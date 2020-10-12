using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppExamen.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usu_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usu_nombre = table.Column<string>(nullable: true),
                    usu_apellido = table.Column<string>(nullable: true),
                    usu_email = table.Column<string>(nullable: true),
                    cod_rol = table.Column<int>(nullable: false),
                    usu_estado = table.Column<int>(nullable: false),
                    fec_ins = table.Column<DateTime>(nullable: false),
                    fec_upd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usu_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
