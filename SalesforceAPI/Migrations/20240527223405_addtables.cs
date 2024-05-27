using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesforceAPI.Migrations
{
    /// <inheritdoc />
    public partial class addtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientInfos",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentClientId = table.Column<int>(type: "int", nullable: true),
                    ClientCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DBAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveInd = table.Column<byte>(type: "tinyint", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanelSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CredPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Selectable = table.Column<byte>(type: "tinyint", nullable: true),
                    SignatureDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInfos", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientProviderInfos",
                columns: table => new
                {
                    ClientProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ProviderId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProviderInfos", x => x.ClientProviderId);
                });

            migrationBuilder.CreateTable(
                name: "CredentialingContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonRole = table.Column<int>(type: "int", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryContact = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialingContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCertification = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalAffiliations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CategoryofMembership = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalAffiliationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalAffiliationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDateofAffiliation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateofAffiliation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalAffiliations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostGraduateMedicalTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    MedicalTrainingHospitalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTrainingHospitalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTrainingType = table.Column<int>(type: "int", nullable: true),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGraduateMedicalTrainings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLocationLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    ServiceLocations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceLicenseExpirationifapplicabl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceLicenseNumberifapplicable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceLicenseStatusifapplicable = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLocationLicenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    AccountSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityLicenseifapplicable = table.Column<bool>(type: "bit", nullable: false),
                    FacilityLicenseExpirationifapplicab = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacilityLicenseNumberifapplicable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityLicenseStatusifapplicable = table.Column<int>(type: "int", nullable: true),
                    HoursofOperation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccomodationsAccessibility = table.Column<int>(type: "int", nullable: true),
                    AccomodationsAccessibilityOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensedFacility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geocodeAccuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: true),
                    longitude = table.Column<double>(type: "float", nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    AttributesId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAgency = table.Column<bool>(type: "bit", nullable: false),
                    IsSite = table.Column<bool>(type: "bit", nullable: false),
                    IsCMHSP = table.Column<bool>(type: "bit", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountAttributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "AccountAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Accounts_ShippingAddress_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "ShippingAddress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AttributesId",
                table: "Accounts",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ShippingAddressId",
                table: "Accounts",
                column: "ShippingAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ClientInfos");

            migrationBuilder.DropTable(
                name: "ClientProviderInfos");

            migrationBuilder.DropTable(
                name: "CredentialingContacts");

            migrationBuilder.DropTable(
                name: "DirectServices");

            migrationBuilder.DropTable(
                name: "HospitalAffiliations");

            migrationBuilder.DropTable(
                name: "PostGraduateMedicalTrainings");

            migrationBuilder.DropTable(
                name: "ServiceLocationLicenses");

            migrationBuilder.DropTable(
                name: "ServiceLocations");

            migrationBuilder.DropTable(
                name: "AccountAttributes");

            migrationBuilder.DropTable(
                name: "ShippingAddress");
        }
    }
}
