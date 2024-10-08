using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFFMS.API.Migrations
{
    public partial class InitialCreate_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TinhTrang",
                table: "DanhSachHoaDonDichVu",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayLap",
                table: "DanhSachDonNhapHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TinhTrang",
                table: "DanhSachDonNhapHang",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "DanhSachHoaDonDichVu");

            migrationBuilder.DropColumn(
                name: "NgayLap",
                table: "DanhSachDonNhapHang");

            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "DanhSachDonNhapHang");
        }
    }
}
