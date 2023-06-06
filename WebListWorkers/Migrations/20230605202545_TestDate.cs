using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebListWorkers.Migrations
{
    /// <inheritdoc />
    public partial class TestDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(File.ReadAllText("Workers.sql"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
