using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class questionimageFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("a97e0081-877c-44f4-a0d8-83fbde5133e5"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("b098e7d7-3123-4c5a-b0a3-42e6b70c359c"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("bedf38c4-3c1e-4127-8571-10378191a40d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fd33b547-9d80-4552-8eec-a391c2cead8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51af3e2d-cb47-46d6-be8e-24b0d34d357b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("a97e0081-877c-44f4-a0d8-83fbde5133e5"), new DateTime(2024, 8, 23, 15, 9, 37, 491, DateTimeKind.Local).AddTicks(8258), null, "dsa", 45m, 1, 0, "Deneme Paketi", null },
                    { new Guid("b098e7d7-3123-4c5a-b0a3-42e6b70c359c"), new DateTime(2024, 8, 23, 15, 9, 37, 491, DateTimeKind.Local).AddTicks(8254), null, "dsa", 45m, 1, 0, "Aile Paketi", null },
                    { new Guid("bedf38c4-3c1e-4127-8571-10378191a40d"), new DateTime(2024, 8, 23, 15, 9, 37, 491, DateTimeKind.Local).AddTicks(8187), null, "dsa", 45m, 1, 0, "Fırsat Paketi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("51af3e2d-cb47-46d6-be8e-24b0d34d357b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dersnet@zurafworks", "Ahmet", "Çiftçi", new byte[] { 156, 50, 133, 23, 50, 172, 115, 235, 224, 176, 131, 127, 124, 108, 230, 241, 86, 116, 167, 190, 73, 14, 61, 146, 249, 95, 193, 216, 130, 252, 179, 215, 230, 23, 132, 213, 207, 3, 204, 19, 43, 173, 198, 191, 239, 172, 160, 106, 123, 99, 157, 199, 143, 184, 173, 80, 124, 247, 187, 153, 107, 157, 160, 44 }, new byte[] { 117, 201, 141, 0, 114, 65, 77, 202, 151, 28, 109, 199, 8, 96, 50, 10, 163, 170, 14, 99, 28, 39, 142, 50, 159, 70, 62, 177, 15, 2, 129, 202, 232, 163, 182, 159, 210, 244, 112, 12, 145, 190, 90, 139, 126, 168, 223, 93, 34, 240, 185, 174, 250, 140, 209, 197, 40, 224, 168, 50, 138, 188, 211, 50, 95, 132, 19, 4, 55, 233, 201, 125, 69, 238, 177, 44, 107, 188, 76, 44, 205, 61, 24, 165, 90, 186, 74, 191, 253, 121, 104, 216, 191, 61, 53, 210, 161, 149, 109, 169, 208, 121, 102, 49, 160, 61, 70, 233, 155, 39, 16, 47, 19, 119, 153, 255, 223, 141, 166, 218, 17, 105, 55, 227, 89, 81, 166, 28 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("fd33b547-9d80-4552-8eec-a391c2cead8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("51af3e2d-cb47-46d6-be8e-24b0d34d357b") });
        }
    }
}
