using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Short_Url_Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LongUrls",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LURL = table.Column<string>(nullable: true),
                    SURL = table.Column<string>(nullable: true),
                    CreatorIP = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LongUrls", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShortUrlSettings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    Postfix = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortUrlSettings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UrlLogs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongUrlID = table.Column<int>(nullable: false),
                    BrowserIP = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlLogs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LongUrls");

            migrationBuilder.DropTable(
                name: "ShortUrlSettings");

            migrationBuilder.DropTable(
                name: "UrlLogs");
        }
    }
}
