using aplikasi_karyawan.DataModel;
using aplikasi_karyawan.Enums;
using aplikasi_karyawan.Repository;
using aplikasi_karyawan.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace aplikasi_karyawan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _repo;
        public EmployeeController(KaryawanDbContext context)
        {
            _repo = new EmployeeRepository(context);
        }

        [HttpGet("GetAll")]
        public Task<IEnumerable<EmployeeViewModel>> GetAll()
        {
            return _repo.GetAll();
        }

        [HttpGet("Search")]
        public ResponseResult Pagination(int pageNum, int rows, string? search = "", string? orderBy = "", Sorting sort = Sorting.ASCENDING)
        {
            return _repo.Pagination(pageNum, rows, search, orderBy, sort);
        }
    }
}
