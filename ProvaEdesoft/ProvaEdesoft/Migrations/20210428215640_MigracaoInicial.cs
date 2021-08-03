using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProvaEdesoft.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCao",
                columns: table => new
                {
                    IdCao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    Raca = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCao", x => x.IdCao);
                });

            migrationBuilder.CreateTable(
                name: "tblDono",
                columns: table => new
                {
                    IdDono = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDono", x => x.IdDono);
                });

            migrationBuilder.CreateTable(
                name: "tblDono_Cao",
                columns: table => new
                {
                    IdCao = table.Column<int>(nullable: false),
                    IdDono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDono_Cao", x => new { x.IdCao, x.IdDono });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCao");

            migrationBuilder.DropTable(
                name: "tblDono");

            migrationBuilder.DropTable(
                name: "tblDono_Cao");
        }
    }
}
