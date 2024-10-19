using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial_commit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("2734a294-9a3f-4f59-ae12-ccc656384f29"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("4280856e-72c9-420e-bcc6-bb2df1d24537"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("fbe63a19-9129-48c1-adea-908fcfb31f47"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("df0d7491-7088-4968-9f39-5e3e75560d7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64d70743-d17c-4441-ade4-6bf9b07eacfe"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("2734a294-9a3f-4f59-ae12-ccc656384f29"), new DateTime(2024, 8, 23, 15, 56, 53, 124, DateTimeKind.Local).AddTicks(1093), null, "dsa", 45m, 1, 0, "Deneme Paketi", null },
                    { new Guid("4280856e-72c9-420e-bcc6-bb2df1d24537"), new DateTime(2024, 8, 23, 15, 56, 53, 124, DateTimeKind.Local).AddTicks(1041), null, "dsa", 45m, 1, 0, "Fırsat Paketi", null },
                    { new Guid("fbe63a19-9129-48c1-adea-908fcfb31f47"), new DateTime(2024, 8, 23, 15, 56, 53, 124, DateTimeKind.Local).AddTicks(1090), null, "dsa", 45m, 1, 0, "Aile Paketi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("64d70743-d17c-4441-ade4-6bf9b07eacfe"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dersnet@zurafworks", "Ahmet", "Çiftçi", new byte[] { 81, 201, 205, 124, 112, 108, 179, 73, 111, 19, 214, 116, 95, 25, 220, 144, 40, 212, 230, 145, 11, 47, 166, 46, 12, 191, 135, 36, 72, 68, 0, 115, 229, 145, 115, 42, 87, 128, 161, 177, 90, 213, 139, 41, 70, 151, 48, 22, 23, 199, 61, 83, 213, 243, 225, 66, 176, 3, 18, 93, 16, 169, 202, 195 }, new byte[] { 10, 241, 25, 26, 98, 135, 179, 132, 237, 49, 114, 145, 29, 69, 195, 85, 125, 208, 107, 13, 96, 92, 76, 106, 248, 220, 22, 122, 133, 220, 185, 12, 154, 224, 220, 74, 42, 118, 243, 91, 78, 230, 200, 17, 193, 25, 5, 243, 31, 214, 209, 222, 188, 174, 211, 248, 140, 110, 55, 186, 108, 21, 47, 173, 188, 83, 123, 170, 143, 21, 66, 220, 161, 134, 84, 156, 188, 194, 186, 227, 151, 195, 203, 16, 3, 59, 144, 37, 177, 110, 179, 84, 14, 207, 120, 151, 41, 159, 161, 83, 47, 37, 34, 53, 29, 195, 218, 120, 142, 227, 151, 219, 120, 129, 50, 23, 113, 105, 124, 248, 73, 184, 38, 41, 170, 155, 60, 145 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("df0d7491-7088-4968-9f39-5e3e75560d7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("64d70743-d17c-4441-ade4-6bf9b07eacfe") });
        }
    }
}
