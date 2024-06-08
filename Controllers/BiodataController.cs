using aplikasi_karyawan.DataModel;
using aplikasi_karyawan.Enums;
using aplikasi_karyawan.Repository;
using aplikasi_karyawan.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplikasi_karyawan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiodataController : ControllerBase
    {
        private BiodataRepository _repo;
        public BiodataController(KaryawanDbContext dbContext)
        {
            _repo = new BiodataRepository(dbContext);
        }
        [HttpGet("GetAll")]
        public async Task<IEnumerable<BiodataViewModel>> Get()
        {
            return await _repo.GetAll();
        }

        [HttpGet("Search")]
        public async Task<ResponseResult> Get(int pageNum, int rows, string? search = "", string? orderBy = "", Sorting sort = Sorting.ASCENDING)
        {
            return _repo.Pagination(pageNum, rows, search, orderBy, sort);
        }
    }
}
