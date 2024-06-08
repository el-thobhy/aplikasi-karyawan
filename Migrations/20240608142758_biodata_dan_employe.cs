using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace aplikasi_karyawan.Migrations
{
    /// <inheritdoc />
    public partial class biodata_dan_employe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biodata",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Dob = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Pob = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MaritalStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biodata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiodataId = table.Column<int>(type: "int", nullable: false),
                    Nip = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Salary = table.Column<double>(type: "float(10)", precision: 10, scale: 0, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Biodata_BiodataId",
                        column: x => x.BiodataId,
                        principalTable: "Biodata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Biodata",
                columns: new[] { "Id", "Address", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Dob", "FirstName", "IsDeleted", "LastName", "MaritalStatus", "ModifiedBy", "ModifiedDate", "Pob" },
                values: new object[,]
                {
                    { 1, "Jl. Raya Baru, Bali", "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6938), null, null, "1991-01-01", "Raya", false, "Indriyani", false, null, null, "Bali" },
                    { 2, "Jl. Berkah Ramadhan, Bandung", "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6943), null, null, "1992-01-02", "Rere", false, "Wulandari", false, null, null, "Bandung" },
                    { 3, "Jl. Mawar Semerbak, Bogor", "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6945), null, null, "1991-03-03", "Bunga", false, "Maria", true, null, null, "Jakarta" },
                    { 4, "Jl. Mawar Harum, Jakarta", "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6947), null, null, "1990-04-10", "Natasha", false, "Wulan", false, null, null, "Jakarta" },
                    { 5, "Jl. Mawar Semerbak, Bogor", "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6949), null, null, "1991-03-03", "Zahra", false, "Aurelia Putri", true, null, null, "Jakarta" },
                    { 6, "Jl. Bunga Melati, Jakarta", "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6951), null, null, "1989-01-12", "Katniss", false, "Everdeen", true, null, null, "Jakarta" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BiodataId", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Nip", "Salary", "Status" },
                values: new object[,]
                {
                    { 1, 1, "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4726), null, null, false, null, null, "NX001", 12000000.0, "Permanen" },
                    { 2, 2, "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4739), null, null, false, null, null, "NX002", 15000000.0, "Kontrak" },
                    { 3, 4, "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4741), null, null, false, null, null, "NX003", 13500000.0, "Permanen" },
                    { 4, 5, "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4743), null, null, false, null, null, "NX004", 12000000.0, "Permanen" },
                    { 5, 6, "admin", new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4744), null, null, false, null, null, "NX005", 17000000.0, "Permanen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BiodataId",
                table: "Employee",
                column: "BiodataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Biodata");
        }
    }
}
