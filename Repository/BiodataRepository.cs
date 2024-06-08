using aplikasi_karyawan.DataModel;
using aplikasi_karyawan.Enums;
using aplikasi_karyawan.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace aplikasi_karyawan.Repository
{
    public interface IBiodataRepository
    {
        Task<IEnumerable<BiodataViewModel>> GetAll();

    }
    public class BiodataRepository : IBiodataRepository
    {
        protected readonly KaryawanDbContext _context;
        private ResponseResult _result = new ResponseResult();
        public BiodataRepository(KaryawanDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public async Task<IEnumerable<BiodataViewModel>> GetAll()
        {
            return await _context.Set<Biodata>().Select(o => new BiodataViewModel
            {
                Id = o.Id,
                FirstName = o.FirstName,
                LastName = o.LastName,
                Address = o.Address,
                Dob = o.Dob,
                MaritalStatus = o.MaritalStatus,
                Pob = o.Pob
            }).ToListAsync();
        }

        public ResponseResult Pagination(int pageNum, int rows, string search, string orderBy, Sorting sort)
        {
            try
            {
                var query = _context.Biodatas
                    .Where(o => o.FirstName.Contains(search) && o.IsDeleted == false);
                int count = query.Count();
                if (count > 0)
                {
                    switch (orderBy)
                    {
                        case "FirstName":
                            query = (sort == Sorting.ASCENDING)?query.OrderBy(o => o.FirstName):query.OrderByDescending(o => o.FirstName);
                            break;
                        default:
                            query = (sort == Sorting.ASCENDING)?query.OrderBy(o => o.Id) : query.OrderByDescending(o => o.Id);
                            break;
                    }

                    _result.Data = query.Skip((pageNum-1) *rows)
                        .Take(rows)
                        .Where(o=>o.IsDeleted== false)
                        .Select(o=>new BiodataViewModel
                        {
                            Id = o.Id,
                            FirstName = o.FirstName,
                            LastName = o.LastName,
                            Address = o.Address,
                            Dob = o.Dob,
                            MaritalStatus = o.MaritalStatus,
                            Pob = o.Pob
                        }).ToList();

                    _result.Pages = (int)Math.Ceiling((decimal)count / rows);
                    if(_result.Pages < pageNum)
                    {
                        return Pagination(1, rows, search, orderBy, sort);
                    }
                }
                else
                {
                    _result.Message = "No Record Found";
                }
            }
            catch (Exception ex)
            {
                _result.Success = false;
                _result.Message = ex.Message;
            }
            return _result;
        }
    }
}
