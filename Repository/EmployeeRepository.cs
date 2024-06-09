using aplikasi_karyawan.DataModel;
using aplikasi_karyawan.Enums;
using aplikasi_karyawan.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace aplikasi_karyawan.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeViewModel>> GetAll();
        ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort);
    }
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly KaryawanDbContext _context;
        private readonly ResponseResult _result;
        public EmployeeRepository(KaryawanDbContext context)
        {
            _context = context;
            _result = new ResponseResult();
            _context.Database.EnsureCreated();
        }
        public async Task<IEnumerable<EmployeeViewModel>> GetAll()
        {
            return await _context.Set<Employee>().Select(x => new EmployeeViewModel
            {
                Id = x.Id,
                BiodataId = x.BiodataId,
                Biodata = x.Biodata,
                Nip = x.Nip,
                Salary = x.Salary,
                Status = x.Status,
                CreateBy = x.CreateBy,
                CreateDate = x.CreateDate,
            }).ToListAsync();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            try
            {
                var query = _context.Employees
                    .Where(o => o.Biodata.FirstName.Contains(search) && o.IsDeleted == false);

                int count = query.Count();
                if(count > 0)
                {
                    switch (orderBy)
                    {
                        case "FirstName":
                            query = (sort == Sorting.ASCENDING) ? query.OrderBy(o => o.Biodata.FirstName) : query.OrderByDescending(o => o.Biodata.FirstName);
                            break;
                        default:
                            query = (sort == Sorting.ASCENDING) ? query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum - 1) * rows)
                        .Take(rows)
                        .Where(o => o.IsDeleted == false)
                        .Select(x => new EmployeeViewModel
                        {
                            Id = x.Id,
                            BiodataId = x.BiodataId,
                            Biodata = x.Biodata,
                            Nip = x.Nip,
                            Salary = x.Salary,
                            Status = x.Status,
                            CreateBy = x.CreateBy,
                            CreateDate = x.CreateDate,
                        }).ToList();

                    _result.Pages = (int)Math.Ceiling((double)count / rows);
                    if(_result.Pages < pageNum)
                    {
                        return Pagination(1, rows, search, orderBy, sort);
                    }
                }
                else
                {
                    _result.Message = "No Data Found";
                }
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.Message;
            }
            return _result;
        }
    }
}
