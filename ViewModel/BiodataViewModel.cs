namespace aplikasi_karyawan.ViewModel
{
    public class BiodataViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Dob { get; set; } = default!;
        public string Pob { get; set; } = default!;
        public string Address { get; set; } = default!;
        public bool MaritalStatus { get; set; } = default!;
    }
}
