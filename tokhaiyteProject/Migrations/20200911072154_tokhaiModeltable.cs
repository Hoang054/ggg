using Microsoft.EntityFrameworkCore.Migrations;

namespace tokhaiyteProject.Migrations
{
    public partial class tokhaiModeltable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tokhaimodels",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    BirthYear = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    VietNam = table.Column<string>(nullable: false),
                    HoChieu = table.Column<int>(nullable: false),
                    tauBay = table.Column<bool>(nullable: false),
                    tauThuyen = table.Column<bool>(nullable: false),
                    oTo = table.Column<bool>(nullable: false),
                    other = table.Column<string>(nullable: true),
                    Sohieu = table.Column<string>(nullable: true),
                    SoGhet = table.Column<int>(nullable: false),
                    startDay = table.Column<int>(nullable: false),
                    startMonth = table.Column<int>(nullable: false),
                    startYear = table.Column<int>(nullable: false),
                    entryDay = table.Column<int>(nullable: false),
                    entryMonth = table.Column<int>(nullable: false),
                    entryYear = table.Column<int>(nullable: false),
                    VietNam_s = table.Column<string>(nullable: true),
                    IdTinhs = table.Column<int>(nullable: false),
                    VietNam_e = table.Column<string>(nullable: true),
                    IdTihhe = table.Column<int>(nullable: false),
                    denquocgia = table.Column<string>(nullable: true),
                    idProvince = table.Column<int>(nullable: false),
                    idDistrict = table.Column<int>(nullable: false),
                    idWard = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Sot = table.Column<bool>(nullable: false),
                    Ho = table.Column<bool>(nullable: false),
                    Khotho = table.Column<bool>(nullable: false),
                    Dauhong = table.Column<bool>(nullable: false),
                    Non = table.Column<bool>(nullable: false),
                    Tieuchay = table.Column<bool>(nullable: false),
                    xuatHuyet = table.Column<bool>(nullable: false),
                    NoiBan = table.Column<bool>(nullable: false),
                    vacxin = table.Column<string>(nullable: true),
                    dongvat = table.Column<bool>(nullable: false),
                    tiepxuc = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tokhaimodels", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tokhaimodels");
        }
    }
}
