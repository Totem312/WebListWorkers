using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebListWorkers.Migrations
{
    /// <inheritdoc />
    public partial class Datainsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(File.ReadAllText("Worker.sql"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
