using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanArchDemo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 28, 8, 17, 40, 784, DateTimeKind.Utc).AddTicks(4375), "Ducimus nobis maxime in ipsum ducimus veritatis dolorem.", "https://picsum.photos/640/480/?image=329", "Lakin Inc Villa", 8, 2615.2129645656337, 691, new DateTime(2023, 4, 14, 8, 17, 40, 784, DateTimeKind.Utc).AddTicks(4375) },
                    { 2, new DateTime(2024, 7, 8, 19, 20, 37, 48, DateTimeKind.Utc).AddTicks(5532), "Ut quas sit reiciendis fugit cum.", "https://picsum.photos/640/480/?image=543", "Cummerata LLC Villa", 1, 1400.308354681328, 1893, new DateTime(2024, 7, 24, 19, 20, 37, 48, DateTimeKind.Utc).AddTicks(5532) },
                    { 3, new DateTime(2023, 11, 11, 23, 41, 34, 121, DateTimeKind.Utc).AddTicks(2185), "Qui non voluptatem iusto.", "https://picsum.photos/640/480/?image=432", "Padberg, Balistreri and Batz Villa", 2, 3044.2899776326053, 1196, new DateTime(2023, 12, 6, 23, 41, 34, 121, DateTimeKind.Utc).AddTicks(2185) },
                    { 4, new DateTime(2023, 6, 3, 22, 40, 45, 627, DateTimeKind.Utc).AddTicks(5534), "Facilis deleniti libero excepturi modi enim.", "https://picsum.photos/640/480/?image=340", "Cummerata LLC Villa", 3, 1107.1005729634032, 1682, new DateTime(2023, 6, 12, 22, 40, 45, 627, DateTimeKind.Utc).AddTicks(5534) },
                    { 5, new DateTime(2022, 11, 27, 2, 6, 47, 196, DateTimeKind.Utc).AddTicks(4996), "Nostrum architecto adipisci et.", "https://picsum.photos/640/480/?image=688", "Murphy, Frami and Mayer Villa", 3, 1394.2574872886944, 1536, new DateTime(2022, 12, 3, 2, 6, 47, 196, DateTimeKind.Utc).AddTicks(4996) },
                    { 6, new DateTime(2023, 3, 8, 12, 15, 16, 780, DateTimeKind.Utc).AddTicks(8825), "Accusantium in consequatur ut sed.", "https://picsum.photos/640/480/?image=595", "Tremblay, Bednar and Bruen Villa", 9, 3024.4695072059035, 2964, new DateTime(2023, 3, 27, 12, 15, 16, 780, DateTimeKind.Utc).AddTicks(8825) },
                    { 7, new DateTime(2022, 12, 22, 3, 37, 57, 560, DateTimeKind.Utc).AddTicks(5186), "Eum id assumenda necessitatibus necessitatibus cum.", "https://picsum.photos/640/480/?image=694", "Kovacek Inc Villa", 1, 505.56398634883669, 4965, new DateTime(2022, 12, 30, 3, 37, 57, 560, DateTimeKind.Utc).AddTicks(5186) },
                    { 8, new DateTime(2023, 2, 13, 18, 25, 4, 257, DateTimeKind.Utc).AddTicks(8010), "Quia accusamus deleniti deleniti voluptatum officia.", "https://picsum.photos/640/480/?image=558", "Marquardt - Lind Villa", 4, 2970.8013763647423, 1861, new DateTime(2023, 2, 23, 18, 25, 4, 257, DateTimeKind.Utc).AddTicks(8010) },
                    { 9, new DateTime(2023, 3, 6, 23, 11, 37, 65, DateTimeKind.Utc).AddTicks(8657), "Exercitationem voluptate ex quo.", "https://picsum.photos/640/480/?image=957", "Hirthe - Metz Villa", 7, 3770.0430866792803, 703, new DateTime(2023, 3, 18, 23, 11, 37, 65, DateTimeKind.Utc).AddTicks(8657) },
                    { 10, new DateTime(2024, 10, 4, 14, 8, 7, 267, DateTimeKind.Utc).AddTicks(9792), "Magni non sunt vitae.", "https://picsum.photos/640/480/?image=1082", "Heidenreich, Fay and Senger Villa", 10, 951.048688663809, 2255, new DateTime(2024, 10, 22, 14, 8, 7, 267, DateTimeKind.Utc).AddTicks(9792) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
