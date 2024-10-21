using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class devDbPublish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("35b43b77-b069-4d7d-adcd-8952f477482c"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("8f9ccabe-f93c-4d62-9c29-863de633f207"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("93a13970-2c69-4424-bf9d-b5219483c0fc"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2f7891b6-c097-4965-925f-6763ea4718ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37fa84d6-870e-4148-9186-8e7366f57417"));

            migrationBuilder.InsertData(
                table: "Packs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Price", "PriceCurrency", "TaxRate", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("58cd724d-0f1f-4db1-835d-427638e4def7"), new DateTime(2024, 10, 21, 21, 1, 1, 515, DateTimeKind.Local).AddTicks(6468), null, "dsa", 45m, 1, 0, "Aile Paketi", null },
                    { new Guid("b7a210fd-be38-4cc5-b7d3-ff023e8f8bba"), new DateTime(2024, 10, 21, 21, 1, 1, 515, DateTimeKind.Local).AddTicks(6471), null, "dsa", 45m, 1, 0, "Deneme Paketi", null },
                    { new Guid("c5927c91-4e69-47bb-98c0-7306f70fd734"), new DateTime(2024, 10, 21, 21, 1, 1, 515, DateTimeKind.Local).AddTicks(6390), null, "dsa", 45m, 1, 0, "Fırsat Paketi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3656321d-6bfa-4f40-ad76-bc1f0249f86e"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dersnet@zurafworks.com", "zurafworks", "Dev Team", new byte[] { 237, 224, 40, 92, 158, 169, 175, 1, 162, 150, 197, 60, 220, 123, 57, 186, 237, 117, 16, 138, 255, 238, 93, 207, 125, 202, 172, 51, 4, 156, 170, 255, 4, 31, 201, 34, 5, 61, 116, 72, 226, 31, 158, 19, 133, 249, 57, 6, 200, 41, 37, 110, 227, 48, 196, 224, 37, 12, 202, 233, 66, 55, 146, 151 }, new byte[] { 24, 170, 162, 239, 58, 91, 136, 245, 36, 239, 191, 206, 253, 224, 114, 144, 0, 224, 213, 7, 217, 4, 240, 112, 129, 63, 222, 141, 37, 27, 102, 234, 199, 62, 38, 229, 177, 165, 151, 10, 221, 113, 96, 17, 138, 197, 121, 55, 222, 224, 40, 211, 72, 3, 29, 240, 63, 20, 205, 65, 126, 90, 107, 237, 199, 37, 194, 7, 130, 158, 1, 173, 247, 108, 250, 213, 166, 253, 17, 30, 51, 37, 54, 21, 198, 132, 134, 69, 119, 96, 57, 32, 57, 172, 66, 63, 92, 246, 207, 136, 206, 143, 13, 235, 135, 223, 96, 185, 98, 88, 230, 1, 170, 82, 216, 185, 3, 66, 209, 1, 126, 253, 167, 164, 232, 48, 145, 54 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("9ce13a2e-6165-4771-beef-b310aae8f980"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3656321d-6bfa-4f40-ad76-bc1f0249f86e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("58cd724d-0f1f-4db1-835d-427638e4def7"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("b7a210fd-be38-4cc5-b7d3-ff023e8f8bba"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("c5927c91-4e69-47bb-98c0-7306f70fd734"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9ce13a2e-6165-4771-beef-b310aae8f980"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3656321d-6bfa-4f40-ad76-bc1f0249f86e"));

            migrationBuilder.InsertData(
                table: "Packs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Price", "PriceCurrency", "TaxRate", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("35b43b77-b069-4d7d-adcd-8952f477482c"), new DateTime(2024, 10, 14, 9, 3, 54, 148, DateTimeKind.Local).AddTicks(3995), null, "dsa", 45m, 1, 0, "Aile Paketi", null },
                    { new Guid("8f9ccabe-f93c-4d62-9c29-863de633f207"), new DateTime(2024, 10, 14, 9, 3, 54, 148, DateTimeKind.Local).AddTicks(3937), null, "dsa", 45m, 1, 0, "Fırsat Paketi", null },
                    { new Guid("93a13970-2c69-4424-bf9d-b5219483c0fc"), new DateTime(2024, 10, 14, 9, 3, 54, 148, DateTimeKind.Local).AddTicks(3998), null, "dsa", 45m, 1, 0, "Deneme Paketi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("37fa84d6-870e-4148-9186-8e7366f57417"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "emrahozyurek33@gmail.com", "Emrah", "Özyürek", new byte[] { 112, 63, 114, 0, 130, 69, 58, 182, 231, 139, 249, 67, 69, 71, 74, 121, 53, 158, 45, 92, 236, 0, 27, 66, 78, 46, 236, 169, 151, 213, 59, 79, 226, 236, 204, 211, 238, 65, 168, 246, 101, 5, 89, 238, 1, 70, 214, 117, 52, 119, 77, 62, 11, 162, 135, 115, 206, 254, 97, 155, 197, 207, 221, 229 }, new byte[] { 189, 170, 19, 64, 216, 190, 97, 127, 48, 61, 197, 148, 240, 231, 226, 245, 169, 193, 131, 116, 52, 162, 139, 5, 180, 208, 73, 137, 248, 232, 22, 63, 235, 116, 5, 178, 68, 188, 222, 109, 101, 124, 160, 238, 132, 94, 168, 151, 151, 30, 80, 162, 255, 164, 124, 212, 155, 58, 233, 129, 231, 239, 76, 173, 24, 166, 217, 201, 250, 125, 247, 134, 58, 227, 226, 73, 238, 188, 139, 107, 172, 137, 70, 156, 24, 189, 201, 9, 234, 118, 116, 118, 7, 44, 11, 227, 119, 33, 234, 40, 135, 99, 110, 65, 181, 210, 249, 138, 139, 9, 186, 252, 99, 195, 247, 186, 73, 198, 97, 195, 201, 17, 41, 252, 147, 109, 42, 180 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("2f7891b6-c097-4965-925f-6763ea4718ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("37fa84d6-870e-4148-9186-8e7366f57417") });
        }
    }
}
