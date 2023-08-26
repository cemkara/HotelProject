using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig_CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "EventType",
                columns: table => new
                {
                    EventTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.EventTypeId);
                });

            migrationBuilder.CreateTable(
                name: "NotificationLogType",
                columns: table => new
                {
                    NotificationLogTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationLogType", x => x.NotificationLogTypeId);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    OrderStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingId);
                });

            migrationBuilder.CreateTable(
                name: "ReportDuration",
                columns: table => new
                {
                    ReportDurationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDuration", x => x.ReportDurationId);
                });

            migrationBuilder.CreateTable(
                name: "ReportType",
                columns: table => new
                {
                    ReportTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportType", x => x.ReportTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantType",
                columns: table => new
                {
                    RestaurantTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantType", x => x.RestaurantTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "TransferStatus",
                columns: table => new
                {
                    TransferStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferStatus", x => x.TransferStatusId);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodId");
                });

            migrationBuilder.CreateTable(
                name: "DiscountCoupons",
                columns: table => new
                {
                    DiscountCouponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCoupons", x => x.DiscountCouponId);
                    table.ForeignKey(
                        name: "FK_DiscountCoupons_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_Emails_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    UserTypeId = table.Column<int>(type: "int", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                    table.ForeignKey(
                        name: "FK_Users_UserType_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserType",
                        principalColumn: "UserTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergenWarning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId");
                    table.ForeignKey(
                        name: "FK_Products_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "UserEmails",
                columns: table => new
                {
                    UserEmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    EmailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmails", x => x.UserEmailId);
                    table.ForeignKey(
                        name: "FK_UserEmails_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "EmailId");
                    table.ForeignKey(
                        name: "FK_UserEmails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserPhoneNumbers",
                columns: table => new
                {
                    UserPhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhoneNumbers", x => x.UserPhoneNumberId);
                    table.ForeignKey(
                        name: "FK_UserPhoneNumbers_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "PhoneNumberId");
                    table.ForeignKey(
                        name: "FK_UserPhoneNumbers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId");
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotels_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "FK_Hotels_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    MinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxDeliveryTime = table.Column<int>(type: "int", nullable: false),
                    RestaurantTypeId = table.Column<int>(type: "int", nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                    table.ForeignKey(
                        name: "FK_Restaurants_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "FK_Restaurants_RestaurantType_RestaurantTypeId",
                        column: x => x.RestaurantTypeId,
                        principalTable: "RestaurantType",
                        principalColumn: "RestaurantTypeId");
                    table.ForeignKey(
                        name: "FK_Restaurants_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "HotelCommissions",
                columns: table => new
                {
                    HotelCommissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelCommissions", x => x.HotelCommissionId);
                    table.ForeignKey(
                        name: "FK_HotelCommissions_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "HotelEmails",
                columns: table => new
                {
                    HotelEmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    EmailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelEmails", x => x.HotelEmailId);
                    table.ForeignKey(
                        name: "FK_HotelEmails_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "EmailId");
                    table.ForeignKey(
                        name: "FK_HotelEmails_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "HotelMenus",
                columns: table => new
                {
                    HotelMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelMenus", x => x.HotelMenuId);
                    table.ForeignKey(
                        name: "FK_HotelMenus_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "HotelPhoneNumbers",
                columns: table => new
                {
                    HotelPhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelPhoneNumbers", x => x.HotelPhoneNumberId);
                    table.ForeignKey(
                        name: "FK_HotelPhoneNumbers_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_HotelPhoneNumbers_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "PhoneNumberId");
                });

            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    HotelRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => x.HotelRoomId);
                    table.ForeignKey(
                        name: "FK_HotelRooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "HotelUser",
                columns: table => new
                {
                    HotelsHotelId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelUser", x => new { x.HotelsHotelId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_HotelUser_Hotels_HotelsHotelId",
                        column: x => x.HotelsHotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventLogs",
                columns: table => new
                {
                    EventLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTypeId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLogs", x => x.EventLogID);
                    table.ForeignKey(
                        name: "FK_EventLogs_EventType_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventType",
                        principalColumn: "EventTypeId");
                    table.ForeignKey(
                        name: "FK_EventLogs_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_EventLogs_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                    table.ForeignKey(
                        name: "FK_EventLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "HotelRestaurants",
                columns: table => new
                {
                    HotelRestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRestaurants", x => x.HotelRestaurantId);
                    table.ForeignKey(
                        name: "FK_HotelRestaurants_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_HotelRestaurants_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                });

            migrationBuilder.CreateTable(
                name: "NotificationLogs",
                columns: table => new
                {
                    NotificationLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationLogTypeId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationLogs", x => x.NotificationLogID);
                    table.ForeignKey(
                        name: "FK_NotificationLogs_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_NotificationLogs_NotificationLogType_NotificationLogTypeId",
                        column: x => x.NotificationLogTypeId,
                        principalTable: "NotificationLogType",
                        principalColumn: "NotificationLogTypeId");
                    table.ForeignKey(
                        name: "FK_NotificationLogs_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                    table.ForeignKey(
                        name: "FK_NotificationLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantCommissions",
                columns: table => new
                {
                    RestaurantCommissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantCommissions", x => x.RestaurantCommissionId);
                    table.ForeignKey(
                        name: "FK_RestaurantCommissions_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantEmails",
                columns: table => new
                {
                    RestaurantEmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelRestaurantId = table.Column<int>(type: "int", nullable: true),
                    EmailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantEmails", x => x.RestaurantEmailId);
                    table.ForeignKey(
                        name: "FK_RestaurantEmails_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "EmailId");
                    table.ForeignKey(
                        name: "FK_RestaurantEmails_Restaurants_HotelRestaurantId",
                        column: x => x.HotelRestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantPhoneNumbers",
                columns: table => new
                {
                    RestaurantPhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelRestaurantId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantPhoneNumbers", x => x.RestaurantPhoneNumberId);
                    table.ForeignKey(
                        name: "FK_RestaurantPhoneNumbers_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "PhoneNumberId");
                    table.ForeignKey(
                        name: "FK_RestaurantPhoneNumbers_Restaurants_HotelRestaurantId",
                        column: x => x.HotelRestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantProducts",
                columns: table => new
                {
                    RestaurantProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantProducts", x => x.RestaurantProductId);
                    table.ForeignKey(
                        name: "FK_RestaurantProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_RestaurantProducts_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantUser",
                columns: table => new
                {
                    RestaurantsRestaurantId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantUser", x => new { x.RestaurantsRestaurantId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_RestaurantUser_Restaurants_RestaurantsRestaurantId",
                        column: x => x.RestaurantsRestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelMenuProducts",
                columns: table => new
                {
                    HotelMenuProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelMenuId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelMenuProducts", x => x.HotelMenuProductId);
                    table.ForeignKey(
                        name: "FK_HotelMenuProducts_HotelMenus_HotelMenuId",
                        column: x => x.HotelMenuId,
                        principalTable: "HotelMenus",
                        principalColumn: "HotelMenuId");
                    table.ForeignKey(
                        name: "FK_HotelMenuProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_HotelMenuProducts_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelRoomId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    OrderTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    CouponDiscountCouponId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_DiscountCoupons_CouponDiscountCouponId",
                        column: x => x.CouponDiscountCouponId,
                        principalTable: "DiscountCoupons",
                        principalColumn: "DiscountCouponId");
                    table.ForeignKey(
                        name: "FK_Orders_HotelRooms_HotelRoomId",
                        column: x => x.HotelRoomId,
                        principalTable: "HotelRooms",
                        principalColumn: "HotelRoomId");
                    table.ForeignKey(
                        name: "FK_Orders_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "OrderStatusId");
                    table.ForeignKey(
                        name: "FK_Orders_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodId");
                    table.ForeignKey(
                        name: "FK_Orders_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    TransferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    HotelRoomId = table.Column<int>(type: "int", nullable: true),
                    TransferCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransferPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TransferTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusTransferStatusId = table.Column<int>(type: "int", nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.TransferId);
                    table.ForeignKey(
                        name: "FK_Transfers_HotelRooms_HotelRoomId",
                        column: x => x.HotelRoomId,
                        principalTable: "HotelRooms",
                        principalColumn: "HotelRoomId");
                    table.ForeignKey(
                        name: "FK_Transfers_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_Transfers_TransferStatus_StatusTransferStatusId",
                        column: x => x.StatusTransferStatusId,
                        principalTable: "TransferStatus",
                        principalColumn: "TransferStatusId");
                });

            migrationBuilder.CreateTable(
                name: "AdminCommissionEarnings",
                columns: table => new
                {
                    AdminCommissionEarningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EarnedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCommissionEarnings", x => x.AdminCommissionEarningId);
                    table.ForeignKey(
                        name: "FK_AdminCommissionEarnings_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "DriverAssignments",
                columns: table => new
                {
                    DriverAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    DeliveryUserUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverAssignments", x => x.DriverAssignmentId);
                    table.ForeignKey(
                        name: "FK_DriverAssignments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_DriverAssignments_Users_DeliveryUserUserId",
                        column: x => x.DeliveryUserUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "HotelCommissionEarnings",
                columns: table => new
                {
                    HotelCommissionEarningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EarnedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelCommissionEarnings", x => x.HotelCommissionEarningId);
                    table.ForeignKey(
                        name: "FK_HotelCommissionEarnings_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_HotelCommissionEarnings_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "OrderStatusHistories",
                columns: table => new
                {
                    OrderStatusHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    OrderStatusId = table.Column<int>(type: "int", nullable: true),
                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatusHistories", x => x.OrderStatusHistoryId);
                    table.ForeignKey(
                        name: "FK_OrderStatusHistories_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "OrderStatusId");
                    table.ForeignKey(
                        name: "FK_OrderStatusHistories_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatingId = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_Reviews_Rating_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Rating",
                        principalColumn: "RatingId");
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportTypeId = table.Column<int>(type: "int", nullable: true),
                    ReportDurationId = table.Column<int>(type: "int", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    TransferId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    HotelMenuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Reports_HotelMenus_HotelMenuId",
                        column: x => x.HotelMenuId,
                        principalTable: "HotelMenus",
                        principalColumn: "HotelMenuId");
                    table.ForeignKey(
                        name: "FK_Reports_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                    table.ForeignKey(
                        name: "FK_Reports_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_Reports_ReportDuration_ReportDurationId",
                        column: x => x.ReportDurationId,
                        principalTable: "ReportDuration",
                        principalColumn: "ReportDurationId");
                    table.ForeignKey(
                        name: "FK_Reports_ReportType_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportType",
                        principalColumn: "ReportTypeId");
                    table.ForeignKey(
                        name: "FK_Reports_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                    table.ForeignKey(
                        name: "FK_Reports_Transfers_TransferId",
                        column: x => x.TransferId,
                        principalTable: "Transfers",
                        principalColumn: "TransferId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCommissionEarnings_OrderId",
                table: "AdminCommissionEarnings",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCoupons_StatusId",
                table: "DiscountCoupons",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverAssignments_DeliveryUserUserId",
                table: "DriverAssignments",
                column: "DeliveryUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverAssignments_OrderId",
                table: "DriverAssignments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_StatusId",
                table: "Emails",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLogs_EventTypeId",
                table: "EventLogs",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLogs_HotelId",
                table: "EventLogs",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLogs_RestaurantId",
                table: "EventLogs",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLogs_UserId",
                table: "EventLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelCommissionEarnings_HotelId",
                table: "HotelCommissionEarnings",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelCommissionEarnings_OrderId",
                table: "HotelCommissionEarnings",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelCommissions_HotelId",
                table: "HotelCommissions",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelEmails_EmailId",
                table: "HotelEmails",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelEmails_HotelId",
                table: "HotelEmails",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelMenuProducts_HotelMenuId",
                table: "HotelMenuProducts",
                column: "HotelMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelMenuProducts_ProductId",
                table: "HotelMenuProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelMenuProducts_StatusId",
                table: "HotelMenuProducts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelMenus_HotelId",
                table: "HotelMenus",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelPhoneNumbers_HotelId",
                table: "HotelPhoneNumbers",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelPhoneNumbers_PhoneNumberId",
                table: "HotelPhoneNumbers",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRestaurants_HotelId",
                table: "HotelRestaurants",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRestaurants_RestaurantId",
                table: "HotelRestaurants",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_HotelId",
                table: "HotelRooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_AddressId",
                table: "Hotels",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_StatusId",
                table: "Hotels",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelUser_UsersUserId",
                table: "HotelUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationLogs_HotelId",
                table: "NotificationLogs",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationLogs_NotificationLogTypeId",
                table: "NotificationLogs",
                column: "NotificationLogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationLogs_RestaurantId",
                table: "NotificationLogs",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationLogs_UserId",
                table: "NotificationLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponDiscountCouponId",
                table: "Orders",
                column: "CouponDiscountCouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_HotelId",
                table: "Orders",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_HotelRoomId",
                table: "Orders",
                column: "HotelRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatusHistories_OrderId",
                table: "OrderStatusHistories",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatusHistories_OrderStatusId",
                table: "OrderStatusHistories",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_StatusId",
                table: "PhoneNumbers",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_StatusId",
                table: "ProductCategories",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StatusId",
                table: "Products",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_HotelId",
                table: "Reports",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_HotelMenuId",
                table: "Reports",
                column: "HotelMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ProductId",
                table: "Reports",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportDurationId",
                table: "Reports",
                column: "ReportDurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportTypeId",
                table: "Reports",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_RestaurantId",
                table: "Reports",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_TransferId",
                table: "Reports",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCommissions_RestaurantId",
                table: "RestaurantCommissions",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantEmails_EmailId",
                table: "RestaurantEmails",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantEmails_HotelRestaurantId",
                table: "RestaurantEmails",
                column: "HotelRestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantPhoneNumbers_HotelRestaurantId",
                table: "RestaurantPhoneNumbers",
                column: "HotelRestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantPhoneNumbers_PhoneNumberId",
                table: "RestaurantPhoneNumbers",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantProducts_ProductId",
                table: "RestaurantProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantProducts_RestaurantId",
                table: "RestaurantProducts",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantTypeId",
                table: "Restaurants",
                column: "RestaurantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_StatusId",
                table: "Restaurants",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantUser_UsersUserId",
                table: "RestaurantUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OrderId",
                table: "Reviews",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RatingId",
                table: "Reviews",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_HotelId",
                table: "Transfers",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_HotelRoomId",
                table: "Transfers",
                column: "HotelRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_StatusTransferStatusId",
                table: "Transfers",
                column: "StatusTransferStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmails_EmailId",
                table: "UserEmails",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmails_UserId",
                table: "UserEmails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhoneNumbers_PhoneNumberId",
                table: "UserPhoneNumbers",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhoneNumbers_UserId",
                table: "UserPhoneNumbers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusId",
                table: "Users",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminCommissionEarnings");

            migrationBuilder.DropTable(
                name: "DriverAssignments");

            migrationBuilder.DropTable(
                name: "EventLogs");

            migrationBuilder.DropTable(
                name: "HotelCommissionEarnings");

            migrationBuilder.DropTable(
                name: "HotelCommissions");

            migrationBuilder.DropTable(
                name: "HotelEmails");

            migrationBuilder.DropTable(
                name: "HotelMenuProducts");

            migrationBuilder.DropTable(
                name: "HotelPhoneNumbers");

            migrationBuilder.DropTable(
                name: "HotelRestaurants");

            migrationBuilder.DropTable(
                name: "HotelUser");

            migrationBuilder.DropTable(
                name: "NotificationLogs");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderStatusHistories");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "RestaurantCommissions");

            migrationBuilder.DropTable(
                name: "RestaurantEmails");

            migrationBuilder.DropTable(
                name: "RestaurantPhoneNumbers");

            migrationBuilder.DropTable(
                name: "RestaurantProducts");

            migrationBuilder.DropTable(
                name: "RestaurantUser");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "UserEmails");

            migrationBuilder.DropTable(
                name: "UserPhoneNumbers");

            migrationBuilder.DropTable(
                name: "EventType");

            migrationBuilder.DropTable(
                name: "NotificationLogType");

            migrationBuilder.DropTable(
                name: "HotelMenus");

            migrationBuilder.DropTable(
                name: "ReportDuration");

            migrationBuilder.DropTable(
                name: "ReportType");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TransferStatus");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "RestaurantType");

            migrationBuilder.DropTable(
                name: "DiscountCoupons");

            migrationBuilder.DropTable(
                name: "HotelRooms");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
