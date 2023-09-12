using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class status_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Status_StatusId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountCoupons_Status_StatusId",
                table: "DiscountCoupons");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Status_StatusId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelMenuProducts_Status_StatusId",
                table: "HotelMenuProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Status_StatusId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Status_StatusId",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Status_StatusId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Status_StatusId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Status_StatusId",
                table: "Restaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusId",
                table: "AspNetUsers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountCoupons_Statuses_StatusId",
                table: "DiscountCoupons",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Statuses_StatusId",
                table: "Emails",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelMenuProducts_Statuses_StatusId",
                table: "HotelMenuProducts",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Statuses_StatusId",
                table: "Hotels",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Statuses_StatusId",
                table: "PhoneNumbers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Statuses_StatusId",
                table: "ProductCategories",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Statuses_StatusId",
                table: "Products",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Statuses_StatusId",
                table: "Restaurants",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountCoupons_Statuses_StatusId",
                table: "DiscountCoupons");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Statuses_StatusId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelMenuProducts_Statuses_StatusId",
                table: "HotelMenuProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Statuses_StatusId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Statuses_StatusId",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Statuses_StatusId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Statuses_StatusId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Statuses_StatusId",
                table: "Restaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Status_StatusId",
                table: "AspNetUsers",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountCoupons_Status_StatusId",
                table: "DiscountCoupons",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Status_StatusId",
                table: "Emails",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelMenuProducts_Status_StatusId",
                table: "HotelMenuProducts",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Status_StatusId",
                table: "Hotels",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Status_StatusId",
                table: "PhoneNumbers",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Status_StatusId",
                table: "ProductCategories",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Status_StatusId",
                table: "Products",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Status_StatusId",
                table: "Restaurants",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");
        }
    }
}
