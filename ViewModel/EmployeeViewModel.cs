using aplikasi_karyawan.DataModel;

namespace aplikasi_karyawan.ViewModel
{
    public class EmployeeViewModel: BaseProperties
    {
        public int Id { get; set; }
        public int BiodataId { get; set; }
        public string? Nip { get; set; } = default!;
        public string? Status { get; set; } = default!;
        public double Salary { get; set; } = default!;
        public virtual Biodata? Biodata { get; set; }
    }
}
