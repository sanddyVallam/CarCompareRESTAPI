using Microsoft.EntityFrameworkCore.Migrations;

namespace CarCampareToolRESTAPI.Migrations
{
    public partial class rriit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModel",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    TCCRating = table.Column<double>(nullable: false),
                    HwMPG = table.Column<int>(nullable: false),
                    BestValue = table.Column<double>(nullable: false),
                    FuelConsumption = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModel", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "CarModel",
                columns: new[] { "id", "BestValue", "Color", "FuelConsumption", "HwMPG", "Make", "Model", "Price", "TCCRating", "Year" },
                values: new object[,]
                {
                    { 1, 0.0, "Green", 0.0, 33, "Honda", "CRV ", 23845, 8.0, 2016 },
                    { 2, 0.0, "Red", 0.0, 32, "Ford ", "Escape ", 23590, 7.7999999999999998, 2017 },
                    { 3, 0.0, "Grey", 0.0, 27, "Hyundai ", "Sante Fe", 24950, 8.0, 2016 },
                    { 4, 0.0, "Red", 0.0, 35, "Mazda ", "CX-5", 21795, 8.0, 2017 },
                    { 5, 0.0, "Blue", 0.0, 32, "Subaru ", "Forester", 22395, 8.4000000000000004, 2016 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModel");
        }
    }
}
