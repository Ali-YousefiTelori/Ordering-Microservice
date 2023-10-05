using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMicroservices.OrderingMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class FirstInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Orders_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Products_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CreationDateTime",
                table: "Orders",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeletedDateTime",
                table: "Orders",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IsDeleted",
                table: "Orders",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ModificationDateTime",
                table: "Orders",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ParentId",
                table: "Orders",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UniqueIdentity",
                table: "Orders",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreationDateTime",
                table: "Products",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DeletedDateTime",
                table: "Products",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IsDeleted",
                table: "Products",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModificationDateTime",
                table: "Products",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ParentId",
                table: "Products",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UniqueIdentity",
                table: "Products",
                column: "UniqueIdentity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
