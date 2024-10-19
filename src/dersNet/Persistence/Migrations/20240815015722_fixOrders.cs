using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fixOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7756e5ae-72ca-4099-81a8-54ca7a02aa5f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("05808413-d7e9-4c26-936b-1fc71fdd5842"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("06ed2c92-bf64-4b54-a9db-58eab0eb7682"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0cf0f0ac-3961-46de-8004-5a0adb7ec530"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0d09c27a-dfb4-4147-a816-cda3496b5781"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0d808fcf-0071-4e3f-b964-ddefede7e3d7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0d8f6f6d-8c84-41c5-896f-b4924b13c37e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("12dc0c91-1314-4f7f-ae98-702b15241eed"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1638ccc4-4147-45db-b32c-c794ddf77a96"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("17c5a5ac-e859-4e5b-9bbe-29ca06838a89"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1ae68bf7-a824-4909-9362-80e1c306e048"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1e4446e4-c27e-4751-be99-8d1c7990599f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1e50c7da-8301-443a-9d8e-e77b782c6505"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("20727c16-d102-460a-9df4-c6c2843658f4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("248bf051-f84d-47ee-ab49-00f12a7b8933"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2948e020-aa33-41ab-a5cc-9d1a5a5ca29c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2ae8e78f-50ee-435b-bbeb-80b4cde7c9b1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2d09ef21-cafb-4292-93ed-63458a53d218"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("334234af-557d-46ef-9034-8d8564562328"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("36571a1e-ac7b-4d3f-9912-48b8826a9cff"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("38347a63-6245-4ba9-8751-dc575faf2d11"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("39518ccb-9841-4453-9646-b3b2a4540cb8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("399b58b5-1347-4da4-869e-6a4cb6f61c3e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("399eee32-07b8-463c-8218-9d233e920b66"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("39eb20d1-adb7-4675-972e-65f94ae0171a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3e07735a-d448-4041-b861-69912ab46f8b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3e457ead-19d9-481e-ac24-636a96dec0bf"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3f7f40cd-7072-42b0-9838-540b92284e06"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4a9231a1-c70e-4e4f-abcc-b06d537e19de"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4beacc6c-c462-4486-be3f-c79568545f33"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("502b2494-b92b-4128-88c2-ae2a36f79f87"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("50b3f0d3-ddf4-4992-90c8-605e0519ea1d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("559e4065-aa37-46e3-8320-2e22894d91ba"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5ac71ebb-a8ab-4a2d-91a9-47f3a530b95e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5bf9b901-66df-4c38-81c3-54c77e2bc4b0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5c30d475-3d43-45d8-bd0b-4274657338bc"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("610ceaf1-41ce-4f36-b176-632768d965db"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("612595c7-44f8-4237-aa59-ac044ec919c5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("62fb4861-4a3b-47e8-b531-9edaf63b9329"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("69492844-649c-455d-8516-305903719272"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6c21c559-b21a-4142-a4fc-94d37abe4c6d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6dfb4dc7-e6c7-4c6b-98d4-69bc395fa02c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6e243a4e-8e21-4766-ae19-fa1fa4674d1d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6e2ca6ca-2ea3-4574-aeae-8acf52a2d717"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("71e0b19a-6d7e-428c-8a1d-2183e6de6eaf"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7488623f-230f-48ab-a0b7-1d128df83d14"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("75bae8f1-4f1b-4a72-9c1f-309e1b9b4e33"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("78ffee43-a5bd-42aa-9639-22fbd2f13b5d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("799de9b9-1a84-40ee-9fe7-1dd18715b5d6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7e7cd9ea-26ce-4150-bb82-a9ff50788f5c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("81615dbd-4cea-4910-9872-cb0ab7ffef22"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("82ffa176-e04a-4b8f-9d53-caf81ea84b4d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8605d289-2793-422f-afd7-33d258d67a08"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8c86e214-5773-404c-8265-5afded0b5024"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8d2f9831-bb8e-484b-9ea4-4947b3063d23"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("928b815d-cf97-4240-8cd9-1f8bad834195"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9746069b-8666-4ca4-8176-5c823c48c8a3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9a8006f4-266a-4a69-9c9e-2d228546c1bd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9e0902b7-3c9b-48b9-9d92-3aa47aab9cd3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9f3cf164-7e23-427e-b7d3-1b4f2498fa61"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a1c42876-1ea0-4d5e-a627-b128e2d98a24"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a1ea88d5-2191-47f0-8275-14f941b1bef5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a46723cf-136d-4130-91b5-d5d2306e2ff9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a652b030-53e7-49b2-a1ea-3e53db178cc2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a80ac2cc-424b-4aa0-859f-a6de1590baac"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a86320cd-5831-434c-98ba-ea5dccee0f57"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a8f9aa4d-37ab-4d0e-902c-a4258688a62d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ab07a65c-5347-4fa1-a08d-064ab9101cd8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("acbbf170-0898-4237-9baf-67dd82b82f3e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b075d084-84c3-4784-9f14-397ee1dd7f2e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b596124d-d3b2-4b71-8449-1ea93ce45301"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b71a3b49-6332-436b-8129-cc3f4561356d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b8b01c52-d964-41fb-a16b-2ccf49a2de73"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b8b53844-10ed-4455-9b05-49f941761e60"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b962f259-4b15-442c-a90b-0aed32271205"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bb17ac09-6505-4368-8072-6b10174304c4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bee04171-55eb-4b38-950a-854be7d07f34"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c24537a1-32ea-4230-8120-609e2274691c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c5134748-aba3-4972-af57-e668ef713ffd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c5942acf-5b90-45a1-acf0-086090318329"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c9046194-122a-4826-b586-d1e1aff6e059"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d159f766-00cf-4e84-a2b4-52a0117f8eb0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d2df4118-adc7-4a9d-9b0f-cb3d313f8396"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d9582e10-04d8-4cda-a3b2-6960ce10fe8a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d99b053e-4acd-4aaa-8641-2239da5a1dba"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ded7be7a-208d-4429-8caa-3d24320ad71f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e32c2c6f-8bf7-4abd-9a21-ede78a351c84"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e5f38ee8-290a-4e03-8fe7-e7c4bbfbfa2d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ea3dbf97-55a6-4a94-8fb5-eeaf01cfe119"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ea95a394-5b39-4b78-a2d9-7f5a4c715226"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("eae38c65-3762-464c-8ef3-0c6ed20ce9c6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("eb82d4e3-c866-4666-97b1-89601bcf170e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ec355afb-7786-4017-9dc3-8e39e95506bd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ed8a15eb-701d-4413-8035-d9f903fe0dd4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("edd9d215-5965-474b-acf9-430091724ad4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ef1d1bec-980f-45f7-9d9c-5bce782ad64a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ef54275b-1094-4d05-8aac-76b033db9c7c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f08b326e-e46b-4753-88d8-8830953eb882"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f30a3487-f477-4958-9058-56b2e214d9e9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f70ef628-cf7b-4a55-af8e-417f0d424994"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f8cf1321-9fb8-427b-b6b6-08ed45d66c60"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f9ba402d-6d94-455b-a557-34e0cfdb0c6f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fdbfed7d-9e02-4b51-aaf7-b21879f89c9b"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("3ebc5636-bccd-4c60-92f9-618c4fe06669"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("75367c3e-8175-4290-b67b-51f32b28e348"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("92eee2bf-9088-4939-b01a-8bebbb4f66a7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1665ea22-0662-4055-b4ba-c9def3b4d379"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af7a6a34-4e3e-4ed9-b3ee-eecfeb525fb8"));

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "LessonId", "Name", "PackId", "Quota", "UpdatedDate" },
                values: new object[] { new Guid("eabc4ae8-abba-4a47-af7a-1c10acd358f2"), new DateTime(2024, 8, 15, 4, 57, 20, 144, DateTimeKind.Local).AddTicks(4213), null, new Guid("20bb50c4-c76b-43b8-8789-c938374ca64f"), "Grup Yorum", new Guid("7041e585-d295-44c6-a9b7-178c17035099"), 10, null });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Depth", "Order", "ParentId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("038e0339-bb75-40ed-8ad9-01f7fa84088b"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8576), null, (short)3, 8, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Kimya", null },
                    { new Guid("04f7f19d-633b-4fd1-a8d3-cd6c7865182a"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8455), null, (short)3, 2, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Matematik", null },
                    { new Guid("06bd68ae-9ea4-40c0-96c5-30c62f42ad23"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8630), null, (short)4, 3, new Guid("6f80e241-a12e-4f1b-bdad-fe32005b55af"), "Biyoloji", null },
                    { new Guid("0788b237-6e71-4c58-8778-bfeb6dc155e7"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8420), null, (short)3, 4, new Guid("d1eac796-d5e6-459a-948e-7665c019d598"), "Fen Bilimleri", null },
                    { new Guid("08d8c351-a0df-4e2a-9c3d-add2d449914d"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8413), null, (short)3, 2, new Guid("d1eac796-d5e6-459a-948e-7665c019d598"), "Matematik", null },
                    { new Guid("0c204d61-8765-4277-ac7c-14c787611df8"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8386), null, (short)3, 6, new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("0d6909a1-0e71-489f-905b-2ed261e8dbd8"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8539), null, (short)3, 7, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Fizik", null },
                    { new Guid("0de4a29b-f1c9-4999-84d5-60a2e4f4f586"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8400), null, (short)3, 4, new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"), "Fen Bilimleri", null },
                    { new Guid("12c4dd98-85e5-4c30-821c-b3d6a69017d2"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8618), null, (short)4, 5, new Guid("9ac2b93c-89b2-4d58-b0f6-3b18258512ca"), "Din Kültürü Ve Ahlak Bilgisi", null },
                    { new Guid("15e99b4e-597b-4c8c-9fc9-2c4ec26f9dcd"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8309), null, (short)2, 2, new Guid("3fda3ac0-b282-4435-bf74-2fd2323462c3"), "2. Sınıf", null },
                    { new Guid("1683b3a2-5351-472f-b36e-60ed5cf531b1"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8366), null, (short)1, 1, new Guid("ab46c33b-a16e-47c1-983a-f6eaf8337bfe"), "LGS", null },
                    { new Guid("1bfe3978-e8dd-4597-85da-bb1d3a0975c5"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8551), null, (short)3, 1, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Türk Dili ve Edebiyatı", null },
                    { new Guid("1c2c1996-0f62-451f-a750-cfdbf5dc06df"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8334), null, (short)3, 2, new Guid("dd154df5-0234-4d5d-b51e-8cb2bd05c6cf"), "Matematik", null },
                    { new Guid("1e18b25a-6587-4a97-9087-0362f3e4827c"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8452), null, (short)3, 1, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Türk Dili ve Edebiyatı", null },
                    { new Guid("201909e1-13a6-4849-a8ab-299e3d1a2109"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8380), null, (short)3, 4, new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"), "Fen Bilimleri", null },
                    { new Guid("20bb50c4-c76b-43b8-8789-c938374ca64f"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8445), null, (short)0, 3, null, "Lise", null },
                    { new Guid("283f8007-d7e7-4b75-8546-71cad636a766"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8314), null, (short)3, 2, new Guid("15e99b4e-597b-4c8c-9fc9-2c4ec26f9dcd"), "Matematik", null },
                    { new Guid("291937ee-56aa-4225-86ed-65b0fd9304a6"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8398), null, (short)3, 3, new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"), "Sosyal Bilgiler", null },
                    { new Guid("29f293b1-14cd-4af0-8ed1-052e9b816603"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8593), null, (short)4, 2, new Guid("b42fac2c-488a-49f1-a85d-7888ca8d9c59"), "Fizik", null },
                    { new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8345), null, (short)2, 2, new Guid("6228f98d-ec40-4635-840c-3def2612aafd"), "4. Sınıf", null },
                    { new Guid("2b1f00b6-7004-400a-aef4-15bb8395a663"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8601), null, (short)4, 5, new Guid("b42fac2c-488a-49f1-a85d-7888ca8d9c59"), "Geometri", null },
                    { new Guid("2d962577-bae6-47ef-8767-8f0bf29a4c2a"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8352), null, (short)3, 2, new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"), "Matematik", null },
                    { new Guid("2ddcb429-1f6b-4245-aa52-21fac1b2a2f2"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8425), null, (short)3, 6, new Guid("d1eac796-d5e6-459a-948e-7665c019d598"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("2fad1cc3-49b8-4e6b-ac01-c9be8d223afd"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8533), null, (short)4, 2, new Guid("64a65446-ac58-4028-ba9d-cf835a2a0db2"), "İngilizce", null },
                    { new Guid("3144adef-42a5-408b-89f7-d1a3073806a5"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8434), null, (short)3, 3, new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"), "T.C. İnkılâp Tarihi ve Atatürkçülük", null },
                    { new Guid("34fc5f67-383b-446e-9490-539952a34489"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8417), null, (short)3, 3, new Guid("d1eac796-d5e6-459a-948e-7665c019d598"), "Sosyal Bilgiler", null },
                    { new Guid("356e4c5c-691a-44be-853c-95103a46455b"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8339), null, (short)3, 4, new Guid("dd154df5-0234-4d5d-b51e-8cb2bd05c6cf"), "Fen Bilimleri", null },
                    { new Guid("3c74cc40-94e0-47a6-a270-4af21c02130d"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8317), null, (short)3, 3, new Guid("15e99b4e-597b-4c8c-9fc9-2c4ec26f9dcd"), "Hayat Bilgisi", null },
                    { new Guid("3d3742e6-4db8-43f4-b243-59a5596a7610"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8396), null, (short)3, 2, new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"), "Matematik", null },
                    { new Guid("3ef95911-c85c-432d-9a4c-fc79e2cb3432"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8429), null, (short)3, 1, new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"), "Türkçe", null },
                    { new Guid("3fda3ac0-b282-4435-bf74-2fd2323462c3"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8272), null, (short)1, 1, new Guid("a5f430d8-f015-41b4-9785-462abce6a26f"), "Temel Öğrenim", null },
                    { new Guid("40805ac0-e80e-45aa-86e6-a5fb70f2cf23"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8555), null, (short)3, 3, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Tarih", null },
                    { new Guid("41a4c8bf-1c5d-4de9-b28d-933f30907e83"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8589), null, (short)4, 1, new Guid("b42fac2c-488a-49f1-a85d-7888ca8d9c59"), "Matematik", null },
                    { new Guid("442ff863-be4a-4637-99b9-94a56830e11e"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8608), null, (short)4, 2, new Guid("9ac2b93c-89b2-4d58-b0f6-3b18258512ca"), "Tarih", null },
                    { new Guid("486bc860-7e19-47ec-8c7b-be90ed24090f"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8558), null, (short)3, 4, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Coğrafya", null },
                    { new Guid("48931891-9d36-432a-9736-98bc1b73d5f1"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8403), null, (short)3, 5, new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"), "Yabancı Dil", null },
                    { new Guid("4b1fade3-4755-44f8-b3a5-144f2ff51364"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8553), null, (short)3, 2, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Matematik", null },
                    { new Guid("55abfedc-d890-467f-a233-8cfce49bce90"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8536), null, (short)3, 6, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("566f23bb-5c10-48fe-b211-e3d0555acc01"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8644), null, (short)4, 2, new Guid("9cc3094e-e324-4515-bcc1-99e6bc64b8e7"), "Tarih", null },
                    { new Guid("57868efd-3206-4180-adc6-336dbe441a47"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8311), null, (short)3, 1, new Guid("15e99b4e-597b-4c8c-9fc9-2c4ec26f9dcd"), "Türkçe", null },
                    { new Guid("5a718ff8-c76f-42a5-88de-f0cde5a9d0d5"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8606), null, (short)4, 1, new Guid("9ac2b93c-89b2-4d58-b0f6-3b18258512ca"), "Türk Dili Ve Edebiyatı", null },
                    { new Guid("5a81d372-9ed4-447a-9261-62eeb31f3651"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8336), null, (short)3, 3, new Guid("dd154df5-0234-4d5d-b51e-8cb2bd05c6cf"), "Hayat Bilgisi", null },
                    { new Guid("5b1a013f-9640-4bdd-ad16-192a3eea67d7"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8439), null, (short)3, 4, new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"), "Fen Bilimleri", null },
                    { new Guid("60d540ab-feca-40c4-a02f-9e77f99c43dd"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8611), null, (short)4, 3, new Guid("9ac2b93c-89b2-4d58-b0f6-3b18258512ca"), "Coğrafya", null },
                    { new Guid("621ffedc-008d-4e67-9661-92b424ee83f3"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8652), null, (short)4, 5, new Guid("9cc3094e-e324-4515-bcc1-99e6bc64b8e7"), "Din Kültürü Ve Ahlak Bilgisi", null },
                    { new Guid("62258b7e-4641-4901-a7c7-40952a0d5bc7"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8356), null, (short)3, 4, new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"), "Fen Bilimleri", null },
                    { new Guid("6228f98d-ec40-4635-840c-3def2612aafd"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8323), null, (short)1, 2, new Guid("a5f430d8-f015-41b4-9785-462abce6a26f"), "İleri Öğrenim", null },
                    { new Guid("64a65446-ac58-4028-ba9d-cf835a2a0db2"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8527), null, (short)3, 5, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Yabancı Dil", null },
                    { new Guid("65e8f776-6e2a-401d-a22d-847c798a6b30"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8529), null, (short)4, 1, new Guid("64a65446-ac58-4028-ba9d-cf835a2a0db2"), "Almanca", null },
                    { new Guid("6edfd2e8-3266-4ad3-b502-c137bebb973e"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8410), null, (short)3, 1, new Guid("d1eac796-d5e6-459a-948e-7665c019d598"), "Türkçe", null },
                    { new Guid("6f80e241-a12e-4f1b-bdad-fe32005b55af"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8622), null, (short)3, 1, new Guid("de36a3c4-50c2-4397-a8f3-cc4419cc4b41"), "Sayısal", null },
                    { new Guid("70454864-38f3-47ab-a9b5-2cbd049555ed"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8321), null, (short)3, 4, new Guid("15e99b4e-597b-4c8c-9fc9-2c4ec26f9dcd"), "Yabancı Dil", null },
                    { new Guid("7215bd7f-8051-4b3d-bd1c-99ba886ef9a9"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8560), null, (short)3, 5, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Yabancı Dil", null },
                    { new Guid("75c35a79-b83f-4474-a47c-d90483d5032f"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8422), null, (short)3, 5, new Guid("d1eac796-d5e6-459a-948e-7665c019d598"), "Yabancı Dil", null },
                    { new Guid("7805bb63-ac4d-4763-bf24-f3d4f9c0870d"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8598), null, (short)4, 4, new Guid("b42fac2c-488a-49f1-a85d-7888ca8d9c59"), "Kimya", null },
                    { new Guid("7897c271-2183-4fd9-bb14-7144e89a7791"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8566), null, (short)4, 2, new Guid("7215bd7f-8051-4b3d-bd1c-99ba886ef9a9"), "İngilizce", null },
                    { new Guid("79d2003b-8b08-49c2-90a7-6cfb7c4da14d"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8625), null, (short)4, 1, new Guid("6f80e241-a12e-4f1b-bdad-fe32005b55af"), "Matematik", null },
                    { new Guid("7b00274d-5cc1-46a5-a726-437a63733b70"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8302), null, (short)3, 2, new Guid("906a2c13-dab7-40ee-bbbb-44214339d86c"), "Matematik", null },
                    { new Guid("7cc59221-4572-42e4-90ab-4a91389a2d0c"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8375), null, (short)3, 2, new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"), "Matematik", null },
                    { new Guid("7f506f90-3b36-4e14-9485-381fd3e60c58"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8354), null, (short)3, 3, new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"), "Sosyal Bilgiler", null },
                    { new Guid("860418e1-afdf-4fbe-bddb-cdda7af89e31"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8578), null, (short)3, 9, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Biyoloji", null },
                    { new Guid("861374d7-a152-440e-bccb-a7d2ff5c7c8e"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8342), null, (short)3, 5, new Guid("dd154df5-0234-4d5d-b51e-8cb2bd05c6cf"), "Yabancı Dil", null },
                    { new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8548), null, (short)2, 2, new Guid("918f7058-6abf-43c4-9b83-5613ee8b48ae"), "10. Sınıf", null },
                    { new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8450), null, (short)2, 1, new Guid("918f7058-6abf-43c4-9b83-5613ee8b48ae"), "9. Sınıf", null },
                    { new Guid("8d64b698-39ac-4ea6-a91e-41952d93a933"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8441), null, (short)3, 5, new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"), "Yabancı Dil", null },
                    { new Guid("8de3d0e3-8368-4029-99cd-b173c5f97c2e"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8649), null, (short)4, 4, new Guid("9cc3094e-e324-4515-bcc1-99e6bc64b8e7"), "Felsefe", null },
                    { new Guid("906a2c13-dab7-40ee-bbbb-44214339d86c"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8276), null, (short)2, 1, new Guid("3fda3ac0-b282-4435-bf74-2fd2323462c3"), "1. Sınıf", null },
                    { new Guid("918f7058-6abf-43c4-9b83-5613ee8b48ae"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8447), null, (short)1, 1, new Guid("20bb50c4-c76b-43b8-8789-c938374ca64f"), "TYT", null },
                    { new Guid("94e7c73c-edaf-4be5-9f60-27be95cf47f3"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8564), null, (short)4, 1, new Guid("7215bd7f-8051-4b3d-bd1c-99ba886ef9a9"), "Almanca", null },
                    { new Guid("94ea84a0-d34f-43ee-b5f4-82206ab34d24"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8632), null, (short)4, 4, new Guid("6f80e241-a12e-4f1b-bdad-fe32005b55af"), "Kimya", null },
                    { new Guid("95f76e95-8324-4971-8dae-dbfbd0740c09"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8581), null, (short)1, 2, new Guid("20bb50c4-c76b-43b8-8789-c938374ca64f"), "AYT", null },
                    { new Guid("9ac2b93c-89b2-4d58-b0f6-3b18258512ca"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8603), null, (short)3, 3, new Guid("fd8728cd-6f7a-4606-af45-0999607f1ce6"), "Sözel", null },
                    { new Guid("9cc3094e-e324-4515-bcc1-99e6bc64b8e7"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8639), null, (short)3, 3, new Guid("de36a3c4-50c2-4397-a8f3-cc4419cc4b41"), "Sözel", null },
                    { new Guid("9d7cc4e5-bbac-497b-85ce-1ba92b808bb4"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8444), null, (short)3, 6, new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("9ff85e40-b8ae-4c4e-b2ca-d6aea4609431"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8378), null, (short)3, 3, new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"), "Sosyal Bilgiler", null },
                    { new Guid("a5f430d8-f015-41b4-9785-462abce6a26f"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8265), null, (short)0, 1, null, "İlkokul", null },
                    { new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8427), null, (short)2, 4, new Guid("1683b3a2-5351-472f-b36e-60ed5cf531b1"), "8. Sınıf", null },
                    { new Guid("ab46c33b-a16e-47c1-983a-f6eaf8337bfe"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8364), null, (short)0, 2, null, "Ortaokul", null },
                    { new Guid("aba27986-05e5-46e1-871e-dcfdf8d395ad"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8541), null, (short)3, 8, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Kimya", null },
                    { new Guid("b42fac2c-488a-49f1-a85d-7888ca8d9c59"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8586), null, (short)3, 1, new Guid("fd8728cd-6f7a-4606-af45-0999607f1ce6"), "Sayısal", null },
                    { new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8369), null, (short)2, 1, new Guid("1683b3a2-5351-472f-b36e-60ed5cf531b1"), "5. Sınıf", null },
                    { new Guid("c245d8dd-e49c-41e9-9be8-118e1e972189"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8524), null, (short)3, 4, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Coğrafya", null },
                    { new Guid("c31afdb1-7e65-4721-9228-58bf2efcfc53"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8373), null, (short)3, 1, new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"), "Türkçe", null },
                    { new Guid("c52718eb-0306-4fdf-8662-98716a24d253"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8347), null, (short)3, 1, new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"), "Türkçe", null },
                    { new Guid("c704cba2-9647-4ccb-a7b7-ef960fec21ef"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8518), null, (short)3, 3, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Tarih", null },
                    { new Guid("c72398fc-de83-4298-b012-3aaa4ceeac20"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8615), null, (short)4, 4, new Guid("9ac2b93c-89b2-4d58-b0f6-3b18258512ca"), "Felsefe", null },
                    { new Guid("c770a487-05da-48c8-b759-10e3558a558a"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8432), null, (short)3, 2, new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"), "Matematik", null },
                    { new Guid("c7e518d4-a529-41d9-a82b-4d366c617484"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8383), null, (short)3, 5, new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"), "Yabancı Dil", null },
                    { new Guid("cc01367a-8dda-4b92-b412-3e0a1cf3cd15"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8544), null, (short)3, 9, new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"), "Biyoloji", null },
                    { new Guid("d1eac796-d5e6-459a-948e-7665c019d598"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8407), null, (short)2, 3, new Guid("1683b3a2-5351-472f-b36e-60ed5cf531b1"), "7. Sınıf", null },
                    { new Guid("d2261b94-fe7c-43a8-8a32-9e029439339b"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8571), null, (short)3, 6, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("d5635e32-5f69-479a-97e7-6d92d466d3d3"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8637), null, (short)4, 5, new Guid("6f80e241-a12e-4f1b-bdad-fe32005b55af"), "Geometri", null },
                    { new Guid("d8931f5c-9fe9-4815-b54b-ac602c0e1c16"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8359), null, (short)3, 5, new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"), "Yabancı Dil", null },
                    { new Guid("dae95d09-b1bb-4893-942d-8ed8617ee315"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8306), null, (short)3, 3, new Guid("906a2c13-dab7-40ee-bbbb-44214339d86c"), "Hayat Bilgisi", null },
                    { new Guid("dd154df5-0234-4d5d-b51e-8cb2bd05c6cf"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8329), null, (short)2, 1, new Guid("6228f98d-ec40-4635-840c-3def2612aafd"), "3. Sınıf", null },
                    { new Guid("de36a3c4-50c2-4397-a8f3-cc4419cc4b41"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8620), null, (short)2, 2, new Guid("95f76e95-8324-4971-8dae-dbfbd0740c09"), "12. Sınıf", null },
                    { new Guid("e03fc96a-ebdf-4364-b0f0-db757b80e38f"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8278), null, (short)3, 1, new Guid("906a2c13-dab7-40ee-bbbb-44214339d86c"), "Türkçe", null },
                    { new Guid("e8e6458e-eff7-4dfa-b543-39c4a697333d"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8361), null, (short)3, 6, new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("eca011d0-0543-421f-abbb-509f234a007e"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8642), null, (short)4, 1, new Guid("9cc3094e-e324-4515-bcc1-99e6bc64b8e7"), "Türk Dili Ve Edebiyatı", null },
                    { new Guid("f21b5d5a-bae3-4d84-98f9-ccfe972eb359"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8596), null, (short)4, 3, new Guid("b42fac2c-488a-49f1-a85d-7888ca8d9c59"), "Biyoloji", null },
                    { new Guid("f47af7a4-1e49-4496-8154-ad6e4113e1b2"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8332), null, (short)3, 1, new Guid("dd154df5-0234-4d5d-b51e-8cb2bd05c6cf"), "Türkçe", null },
                    { new Guid("f67c94a9-515b-4b2a-9a10-ed78cfee0116"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8391), null, (short)3, 1, new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"), "Türkçe", null },
                    { new Guid("fa59598b-f90f-44a6-b880-0bf9c0cc6387"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8405), null, (short)3, 6, new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("faca2dad-c713-43f7-8649-895dca6f1ed6"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8647), null, (short)4, 3, new Guid("9cc3094e-e324-4515-bcc1-99e6bc64b8e7"), "Coğrafya", null },
                    { new Guid("fadc1110-ad73-4f80-9612-1ffa63383aa7"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8627), null, (short)4, 2, new Guid("6f80e241-a12e-4f1b-bdad-fe32005b55af"), "Fizik", null },
                    { new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8389), null, (short)2, 2, new Guid("1683b3a2-5351-472f-b36e-60ed5cf531b1"), "6. Sınıf", null },
                    { new Guid("fd8728cd-6f7a-4606-af45-0999607f1ce6"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8583), null, (short)2, 1, new Guid("95f76e95-8324-4971-8dae-dbfbd0740c09"), "11. Sınıf", null },
                    { new Guid("fffb7395-1b39-44a7-9652-ec12beba9f90"), new DateTime(2024, 8, 15, 1, 57, 20, 145, DateTimeKind.Utc).AddTicks(8573), null, (short)3, 7, new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"), "Fizik", null }
                });

            migrationBuilder.InsertData(
                table: "Packs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Price", "PriceCurrency", "TaxRate", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0df77ed0-523d-4c2a-84c1-6afa8825d69e"), new DateTime(2024, 8, 15, 4, 57, 20, 147, DateTimeKind.Local).AddTicks(3334), null, "dsa", 45m, 1, 0, "Deneme Paketi", null },
                    { new Guid("2a004e5d-eacf-4039-a484-f167c26d648f"), new DateTime(2024, 8, 15, 4, 57, 20, 147, DateTimeKind.Local).AddTicks(3324), null, "dsa", 45m, 1, 0, "Aile Paketi", null },
                    { new Guid("7041e585-d295-44c6-a9b7-178c17035099"), new DateTime(2024, 8, 15, 4, 57, 20, 147, DateTimeKind.Local).AddTicks(3304), null, "dsa", 45m, 1, 0, "Fırsat Paketi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("1b1e3e41-2936-4dc7-98d5-f891828c675d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dersnet@zurafworks", "Ahmet", "Çiftçi", new byte[] { 135, 231, 85, 234, 187, 41, 24, 35, 57, 53, 8, 16, 179, 216, 139, 231, 227, 230, 86, 40, 214, 153, 149, 199, 138, 250, 113, 102, 181, 224, 131, 88, 220, 233, 250, 154, 121, 47, 164, 147, 51, 102, 157, 61, 227, 187, 151, 30, 182, 135, 99, 50, 254, 201, 193, 226, 21, 88, 84, 92, 111, 189, 98, 30 }, new byte[] { 192, 64, 50, 97, 162, 131, 93, 48, 47, 219, 117, 53, 63, 28, 221, 36, 28, 235, 143, 91, 128, 108, 108, 81, 241, 170, 221, 211, 134, 247, 66, 156, 77, 87, 191, 249, 185, 215, 239, 235, 82, 214, 96, 10, 175, 233, 49, 64, 168, 153, 239, 10, 90, 63, 177, 244, 235, 176, 162, 181, 136, 251, 170, 201, 9, 45, 100, 46, 129, 171, 163, 216, 84, 134, 212, 135, 101, 112, 227, 63, 80, 67, 145, 101, 37, 32, 83, 73, 170, 49, 251, 31, 57, 81, 91, 40, 134, 18, 129, 139, 143, 194, 57, 213, 67, 85, 154, 4, 91, 117, 106, 192, 119, 97, 230, 236, 137, 216, 238, 185, 14, 243, 113, 230, 161, 5, 3, 249 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("69af0af0-19ad-4f45-be61-82b78cbbfd3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("1b1e3e41-2936-4dc7-98d5-f891828c675d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("eabc4ae8-abba-4a47-af7a-1c10acd358f2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("038e0339-bb75-40ed-8ad9-01f7fa84088b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("04f7f19d-633b-4fd1-a8d3-cd6c7865182a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("06bd68ae-9ea4-40c0-96c5-30c62f42ad23"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0788b237-6e71-4c58-8778-bfeb6dc155e7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("08d8c351-a0df-4e2a-9c3d-add2d449914d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0c204d61-8765-4277-ac7c-14c787611df8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0d6909a1-0e71-489f-905b-2ed261e8dbd8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0de4a29b-f1c9-4999-84d5-60a2e4f4f586"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("12c4dd98-85e5-4c30-821c-b3d6a69017d2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("15e99b4e-597b-4c8c-9fc9-2c4ec26f9dcd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1683b3a2-5351-472f-b36e-60ed5cf531b1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1bfe3978-e8dd-4597-85da-bb1d3a0975c5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1c2c1996-0f62-451f-a750-cfdbf5dc06df"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1e18b25a-6587-4a97-9087-0362f3e4827c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("201909e1-13a6-4849-a8ab-299e3d1a2109"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("20bb50c4-c76b-43b8-8789-c938374ca64f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("283f8007-d7e7-4b75-8546-71cad636a766"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("291937ee-56aa-4225-86ed-65b0fd9304a6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("29f293b1-14cd-4af0-8ed1-052e9b816603"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2a3ec621-e466-4e1b-8afa-3198b158e869"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2b1f00b6-7004-400a-aef4-15bb8395a663"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2d962577-bae6-47ef-8767-8f0bf29a4c2a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2ddcb429-1f6b-4245-aa52-21fac1b2a2f2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2fad1cc3-49b8-4e6b-ac01-c9be8d223afd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3144adef-42a5-408b-89f7-d1a3073806a5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("34fc5f67-383b-446e-9490-539952a34489"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("356e4c5c-691a-44be-853c-95103a46455b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3c74cc40-94e0-47a6-a270-4af21c02130d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3d3742e6-4db8-43f4-b243-59a5596a7610"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3ef95911-c85c-432d-9a4c-fc79e2cb3432"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3fda3ac0-b282-4435-bf74-2fd2323462c3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("40805ac0-e80e-45aa-86e6-a5fb70f2cf23"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("41a4c8bf-1c5d-4de9-b28d-933f30907e83"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("442ff863-be4a-4637-99b9-94a56830e11e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("486bc860-7e19-47ec-8c7b-be90ed24090f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("48931891-9d36-432a-9736-98bc1b73d5f1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4b1fade3-4755-44f8-b3a5-144f2ff51364"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("55abfedc-d890-467f-a233-8cfce49bce90"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("566f23bb-5c10-48fe-b211-e3d0555acc01"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("57868efd-3206-4180-adc6-336dbe441a47"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5a718ff8-c76f-42a5-88de-f0cde5a9d0d5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5a81d372-9ed4-447a-9261-62eeb31f3651"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5b1a013f-9640-4bdd-ad16-192a3eea67d7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("60d540ab-feca-40c4-a02f-9e77f99c43dd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("621ffedc-008d-4e67-9661-92b424ee83f3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("62258b7e-4641-4901-a7c7-40952a0d5bc7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6228f98d-ec40-4635-840c-3def2612aafd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("64a65446-ac58-4028-ba9d-cf835a2a0db2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("65e8f776-6e2a-401d-a22d-847c798a6b30"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6edfd2e8-3266-4ad3-b502-c137bebb973e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6f80e241-a12e-4f1b-bdad-fe32005b55af"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("70454864-38f3-47ab-a9b5-2cbd049555ed"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7215bd7f-8051-4b3d-bd1c-99ba886ef9a9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("75c35a79-b83f-4474-a47c-d90483d5032f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7805bb63-ac4d-4763-bf24-f3d4f9c0870d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7897c271-2183-4fd9-bb14-7144e89a7791"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("79d2003b-8b08-49c2-90a7-6cfb7c4da14d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7b00274d-5cc1-46a5-a726-437a63733b70"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7cc59221-4572-42e4-90ab-4a91389a2d0c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7f506f90-3b36-4e14-9485-381fd3e60c58"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("860418e1-afdf-4fbe-bddb-cdda7af89e31"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("861374d7-a152-440e-bccb-a7d2ff5c7c8e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("88925c54-0bef-4e9e-8e90-ed5a7867849f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8d4245b4-ad5a-4739-9a65-50a4db9ac5f7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8d64b698-39ac-4ea6-a91e-41952d93a933"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8de3d0e3-8368-4029-99cd-b173c5f97c2e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("906a2c13-dab7-40ee-bbbb-44214339d86c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("918f7058-6abf-43c4-9b83-5613ee8b48ae"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("94e7c73c-edaf-4be5-9f60-27be95cf47f3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("94ea84a0-d34f-43ee-b5f4-82206ab34d24"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("95f76e95-8324-4971-8dae-dbfbd0740c09"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9ac2b93c-89b2-4d58-b0f6-3b18258512ca"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9cc3094e-e324-4515-bcc1-99e6bc64b8e7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9d7cc4e5-bbac-497b-85ce-1ba92b808bb4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9ff85e40-b8ae-4c4e-b2ca-d6aea4609431"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a5f430d8-f015-41b4-9785-462abce6a26f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a93cbda6-940e-48c4-9b9a-c2b80f60c542"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ab46c33b-a16e-47c1-983a-f6eaf8337bfe"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("aba27986-05e5-46e1-871e-dcfdf8d395ad"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b42fac2c-488a-49f1-a85d-7888ca8d9c59"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bbaed62e-88b4-404d-8e02-ae46e74ab7d0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c245d8dd-e49c-41e9-9be8-118e1e972189"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c31afdb1-7e65-4721-9228-58bf2efcfc53"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c52718eb-0306-4fdf-8662-98716a24d253"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c704cba2-9647-4ccb-a7b7-ef960fec21ef"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c72398fc-de83-4298-b012-3aaa4ceeac20"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c770a487-05da-48c8-b759-10e3558a558a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c7e518d4-a529-41d9-a82b-4d366c617484"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cc01367a-8dda-4b92-b412-3e0a1cf3cd15"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d1eac796-d5e6-459a-948e-7665c019d598"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d2261b94-fe7c-43a8-8a32-9e029439339b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d5635e32-5f69-479a-97e7-6d92d466d3d3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d8931f5c-9fe9-4815-b54b-ac602c0e1c16"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("dae95d09-b1bb-4893-942d-8ed8617ee315"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("dd154df5-0234-4d5d-b51e-8cb2bd05c6cf"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("de36a3c4-50c2-4397-a8f3-cc4419cc4b41"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e03fc96a-ebdf-4364-b0f0-db757b80e38f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e8e6458e-eff7-4dfa-b543-39c4a697333d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("eca011d0-0543-421f-abbb-509f234a007e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f21b5d5a-bae3-4d84-98f9-ccfe972eb359"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f47af7a4-1e49-4496-8154-ad6e4113e1b2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f67c94a9-515b-4b2a-9a10-ed78cfee0116"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fa59598b-f90f-44a6-b880-0bf9c0cc6387"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("faca2dad-c713-43f7-8649-895dca6f1ed6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fadc1110-ad73-4f80-9612-1ffa63383aa7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("faec20e4-8d56-4826-b052-c3fcc0e9faf6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fd8728cd-6f7a-4606-af45-0999607f1ce6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fffb7395-1b39-44a7-9652-ec12beba9f90"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("0df77ed0-523d-4c2a-84c1-6afa8825d69e"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("2a004e5d-eacf-4039-a484-f167c26d648f"));

            migrationBuilder.DeleteData(
                table: "Packs",
                keyColumn: "Id",
                keyValue: new Guid("7041e585-d295-44c6-a9b7-178c17035099"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("69af0af0-19ad-4f45-be61-82b78cbbfd3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b1e3e41-2936-4dc7-98d5-f891828c675d"));

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "LessonId", "Name", "PackId", "Quota", "UpdatedDate" },
                values: new object[] { new Guid("7756e5ae-72ca-4099-81a8-54ca7a02aa5f"), new DateTime(2024, 8, 14, 0, 25, 22, 269, DateTimeKind.Local).AddTicks(6961), null, new Guid("39518ccb-9841-4453-9646-b3b2a4540cb8"), "Grup Yorum", new Guid("3ebc5636-bccd-4c60-92f9-618c4fe06669"), 10, null });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Depth", "Order", "ParentId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("05808413-d7e9-4c26-936b-1fc71fdd5842"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7822), null, (short)3, 5, new Guid("c24537a1-32ea-4230-8120-609e2274691c"), "Yabancı Dil", null },
                    { new Guid("06ed2c92-bf64-4b54-a9db-58eab0eb7682"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8051), null, (short)4, 1, new Guid("36571a1e-ac7b-4d3f-9912-48b8826a9cff"), "Türk Dili Ve Edebiyatı", null },
                    { new Guid("0cf0f0ac-3961-46de-8004-5a0adb7ec530"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7913), null, (short)3, 3, new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"), "Sosyal Bilgiler", null },
                    { new Guid("0d09c27a-dfb4-4147-a816-cda3496b5781"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8022), null, (short)4, 5, new Guid("69492844-649c-455d-8516-305903719272"), "Geometri", null },
                    { new Guid("0d808fcf-0071-4e3f-b964-ddefede7e3d7"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8018), null, (short)4, 3, new Guid("69492844-649c-455d-8516-305903719272"), "Biyoloji", null },
                    { new Guid("0d8f6f6d-8c84-41c5-896f-b4924b13c37e"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7960), null, (short)3, 8, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Kimya", null },
                    { new Guid("12dc0c91-1314-4f7f-ae98-702b15241eed"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7970), null, (short)3, 3, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Tarih", null },
                    { new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7965), null, (short)2, 2, new Guid("eae38c65-3762-464c-8ef3-0c6ed20ce9c6"), "10. Sınıf", null },
                    { new Guid("1638ccc4-4147-45db-b32c-c794ddf77a96"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7882), null, (short)3, 3, new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"), "Sosyal Bilgiler", null },
                    { new Guid("17c5a5ac-e859-4e5b-9bbe-29ca06838a89"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8048), null, (short)4, 5, new Guid("5c30d475-3d43-45d8-bd0b-4274657338bc"), "Geometri", null },
                    { new Guid("1ae68bf7-a824-4909-9362-80e1c306e048"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7915), null, (short)3, 4, new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"), "Fen Bilimleri", null },
                    { new Guid("1e4446e4-c27e-4751-be99-8d1c7990599f"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7901), null, (short)3, 5, new Guid("4beacc6c-c462-4486-be3f-c79568545f33"), "Yabancı Dil", null },
                    { new Guid("1e50c7da-8301-443a-9d8e-e77b782c6505"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7797), null, (short)3, 3, new Guid("559e4065-aa37-46e3-8320-2e22894d91ba"), "Hayat Bilgisi", null },
                    { new Guid("20727c16-d102-460a-9df4-c6c2843658f4"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7940), null, (short)3, 1, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Türk Dili ve Edebiyatı", null },
                    { new Guid("248bf051-f84d-47ee-ab49-00f12a7b8933"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7827), null, (short)3, 1, new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"), "Türkçe", null },
                    { new Guid("2948e020-aa33-41ab-a5cc-9d1a5a5ca29c"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8027), null, (short)4, 2, new Guid("e5f38ee8-290a-4e03-8fe7-e7c4bbfbfa2d"), "Tarih", null },
                    { new Guid("2ae8e78f-50ee-435b-bbeb-80b4cde7c9b1"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7809), null, (short)1, 2, new Guid("3e457ead-19d9-481e-ac24-636a96dec0bf"), "İlkokul", null },
                    { new Guid("2d09ef21-cafb-4292-93ed-63458a53d218"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7820), null, (short)3, 4, new Guid("c24537a1-32ea-4230-8120-609e2274691c"), "Fen Bilimleri", null },
                    { new Guid("334234af-557d-46ef-9034-8d8564562328"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7980), null, (short)3, 6, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("36571a1e-ac7b-4d3f-9912-48b8826a9cff"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8050), null, (short)3, 3, new Guid("3f7f40cd-7072-42b0-9838-540b92284e06"), "Sözel", null },
                    { new Guid("38347a63-6245-4ba9-8751-dc575faf2d11"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7988), null, (short)1, 2, new Guid("39518ccb-9841-4453-9646-b3b2a4540cb8"), "AYT", null },
                    { new Guid("39518ccb-9841-4453-9646-b3b2a4540cb8"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7935), null, (short)0, 3, null, "Lise", null },
                    { new Guid("399b58b5-1347-4da4-869e-6a4cb6f61c3e"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8032), null, (short)4, 4, new Guid("e5f38ee8-290a-4e03-8fe7-e7c4bbfbfa2d"), "Felsefe", null },
                    { new Guid("399eee32-07b8-463c-8218-9d233e920b66"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7930), null, (short)3, 4, new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"), "Fen Bilimleri", null },
                    { new Guid("39eb20d1-adb7-4675-972e-65f94ae0171a"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7801), null, (short)3, 1, new Guid("4a9231a1-c70e-4e4f-abcc-b06d537e19de"), "Türkçe", null },
                    { new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7920), null, (short)2, 4, new Guid("8d2f9831-bb8e-484b-9ea4-4947b3063d23"), "8. Sınıf", null },
                    { new Guid("3e07735a-d448-4041-b861-69912ab46f8b"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7795), null, (short)3, 2, new Guid("559e4065-aa37-46e3-8320-2e22894d91ba"), "Matematik", null },
                    { new Guid("3e457ead-19d9-481e-ac24-636a96dec0bf"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7771), null, (short)0, 1, null, "İlkokul", null },
                    { new Guid("3f7f40cd-7072-42b0-9838-540b92284e06"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8036), null, (short)2, 1, new Guid("38347a63-6245-4ba9-8751-dc575faf2d11"), "12. Sınıf", null },
                    { new Guid("4a9231a1-c70e-4e4f-abcc-b06d537e19de"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7799), null, (short)2, 2, new Guid("6e2ca6ca-2ea3-4574-aeae-8acf52a2d717"), "2. Sınıf", null },
                    { new Guid("4beacc6c-c462-4486-be3f-c79568545f33"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7891), null, (short)2, 2, new Guid("8d2f9831-bb8e-484b-9ea4-4947b3063d23"), "6. Sınıf", null },
                    { new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7825), null, (short)2, 2, new Guid("2ae8e78f-50ee-435b-bbeb-80b4cde7c9b1"), "4. Sınıf", null },
                    { new Guid("502b2494-b92b-4128-88c2-ae2a36f79f87"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7919), null, (short)3, 6, new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("50b3f0d3-ddf4-4992-90c8-605e0519ea1d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7972), null, (short)3, 4, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Coğrafya", null },
                    { new Guid("559e4065-aa37-46e3-8320-2e22894d91ba"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7779), null, (short)2, 1, new Guid("6e2ca6ca-2ea3-4574-aeae-8acf52a2d717"), "1. Sınıf", null },
                    { new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7875), null, (short)2, 1, new Guid("8d2f9831-bb8e-484b-9ea4-4947b3063d23"), "5. Sınıf", null },
                    { new Guid("5ac71ebb-a8ab-4a2d-91a9-47f3a530b95e"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8045), null, (short)4, 4, new Guid("5c30d475-3d43-45d8-bd0b-4274657338bc"), "Kimya", null },
                    { new Guid("5bf9b901-66df-4c38-81c3-54c77e2bc4b0"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8057), null, (short)4, 4, new Guid("36571a1e-ac7b-4d3f-9912-48b8826a9cff"), "Felsefe", null },
                    { new Guid("5c30d475-3d43-45d8-bd0b-4274657338bc"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8038), null, (short)3, 1, new Guid("3f7f40cd-7072-42b0-9838-540b92284e06"), "Sayısal", null },
                    { new Guid("610ceaf1-41ce-4f36-b176-632768d965db"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7951), null, (short)4, 1, new Guid("a1c42876-1ea0-4d5e-a627-b128e2d98a24"), "Almanca", null },
                    { new Guid("612595c7-44f8-4237-aa59-ac044ec919c5"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7830), null, (short)3, 2, new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"), "Matematik", null },
                    { new Guid("62fb4861-4a3b-47e8-b531-9edaf63b9329"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7922), null, (short)3, 1, new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"), "Türkçe", null },
                    { new Guid("69492844-649c-455d-8516-305903719272"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8011), null, (short)3, 1, new Guid("9746069b-8666-4ca4-8176-5c823c48c8a3"), "Sayısal", null },
                    { new Guid("6c21c559-b21a-4142-a4fc-94d37abe4c6d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8034), null, (short)4, 5, new Guid("e5f38ee8-290a-4e03-8fe7-e7c4bbfbfa2d"), "Din Kültürü Ve Ahlak Bilgisi", null },
                    { new Guid("6dfb4dc7-e6c7-4c6b-98d4-69bc395fa02c"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7961), null, (short)3, 9, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Biyoloji", null },
                    { new Guid("6e243a4e-8e21-4766-ae19-fa1fa4674d1d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7908), null, (short)3, 1, new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"), "Türkçe", null },
                    { new Guid("6e2ca6ca-2ea3-4574-aeae-8acf52a2d717"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7777), null, (short)1, 1, new Guid("3e457ead-19d9-481e-ac24-636a96dec0bf"), "Temel Öğrenim", null },
                    { new Guid("71e0b19a-6d7e-428c-8a1d-2183e6de6eaf"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7815), null, (short)3, 1, new Guid("c24537a1-32ea-4230-8120-609e2274691c"), "Türkçe", null },
                    { new Guid("7488623f-230f-48ab-a0b7-1d128df83d14"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8053), null, (short)4, 2, new Guid("36571a1e-ac7b-4d3f-9912-48b8826a9cff"), "Tarih", null },
                    { new Guid("75bae8f1-4f1b-4a72-9c1f-309e1b9b4e33"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7909), null, (short)3, 2, new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"), "Matematik", null },
                    { new Guid("78ffee43-a5bd-42aa-9639-22fbd2f13b5d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7780), null, (short)3, 1, new Guid("559e4065-aa37-46e3-8320-2e22894d91ba"), "Türkçe", null },
                    { new Guid("799de9b9-1a84-40ee-9fe7-1dd18715b5d6"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7816), null, (short)3, 2, new Guid("c24537a1-32ea-4230-8120-609e2274691c"), "Matematik", null },
                    { new Guid("7e7cd9ea-26ce-4150-bb82-a9ff50788f5c"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8020), null, (short)4, 4, new Guid("69492844-649c-455d-8516-305903719272"), "Kimya", null },
                    { new Guid("81615dbd-4cea-4910-9872-cb0ab7ffef22"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7924), null, (short)3, 2, new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"), "Matematik", null },
                    { new Guid("82ffa176-e04a-4b8f-9d53-caf81ea84b4d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7833), null, (short)3, 3, new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"), "Sosyal Bilgiler", null },
                    { new Guid("8605d289-2793-422f-afd7-33d258d67a08"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7900), null, (short)3, 4, new Guid("4beacc6c-c462-4486-be3f-c79568545f33"), "Fen Bilimleri", null },
                    { new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7939), null, (short)2, 1, new Guid("eae38c65-3762-464c-8ef3-0c6ed20ce9c6"), "9. Sınıf", null },
                    { new Guid("8c86e214-5773-404c-8265-5afded0b5024"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8039), null, (short)4, 1, new Guid("5c30d475-3d43-45d8-bd0b-4274657338bc"), "Matematik", null },
                    { new Guid("8d2f9831-bb8e-484b-9ea4-4947b3063d23"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7873), null, (short)1, 1, new Guid("9f3cf164-7e23-427e-b7d3-1b4f2498fa61"), "LGS", null },
                    { new Guid("928b815d-cf97-4240-8cd9-1f8bad834195"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7835), null, (short)3, 4, new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"), "Fen Bilimleri", null },
                    { new Guid("9746069b-8666-4ca4-8176-5c823c48c8a3"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8009), null, (short)2, 1, new Guid("38347a63-6245-4ba9-8751-dc575faf2d11"), "11. Sınıf", null },
                    { new Guid("9a8006f4-266a-4a69-9c9e-2d228546c1bd"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7974), null, (short)3, 5, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Yabancı Dil", null },
                    { new Guid("9e0902b7-3c9b-48b9-9d92-3aa47aab9cd3"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7942), null, (short)3, 2, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Matematik", null },
                    { new Guid("9f3cf164-7e23-427e-b7d3-1b4f2498fa61"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7872), null, (short)0, 2, null, "Ortaokul", null },
                    { new Guid("a1c42876-1ea0-4d5e-a627-b128e2d98a24"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7949), null, (short)3, 5, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Yabancı Dil", null },
                    { new Guid("a1ea88d5-2191-47f0-8275-14f941b1bef5"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7982), null, (short)3, 7, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Fizik", null },
                    { new Guid("a46723cf-136d-4130-91b5-d5d2306e2ff9"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7931), null, (short)3, 5, new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"), "Yabancı Dil", null },
                    { new Guid("a652b030-53e7-49b2-a1ea-3e53db178cc2"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7947), null, (short)3, 4, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Coğrafya", null },
                    { new Guid("a80ac2cc-424b-4aa0-859f-a6de1590baac"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7966), null, (short)3, 1, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Türk Dili ve Edebiyatı", null },
                    { new Guid("a86320cd-5831-434c-98ba-ea5dccee0f57"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8029), null, (short)4, 3, new Guid("e5f38ee8-290a-4e03-8fe7-e7c4bbfbfa2d"), "Coğrafya", null },
                    { new Guid("a8f9aa4d-37ab-4d0e-902c-a4258688a62d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7898), null, (short)3, 3, new Guid("4beacc6c-c462-4486-be3f-c79568545f33"), "Sosyal Bilgiler", null },
                    { new Guid("ab07a65c-5347-4fa1-a08d-064ab9101cd8"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7884), null, (short)3, 4, new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"), "Fen Bilimleri", null },
                    { new Guid("acbbf170-0898-4237-9baf-67dd82b82f3e"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7893), null, (short)3, 1, new Guid("4beacc6c-c462-4486-be3f-c79568545f33"), "Türkçe", null },
                    { new Guid("b075d084-84c3-4784-9f14-397ee1dd7f2e"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7886), null, (short)3, 5, new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"), "Yabancı Dil", null },
                    { new Guid("b596124d-d3b2-4b71-8449-1ea93ce45301"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7879), null, (short)3, 1, new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"), "Türkçe", null },
                    { new Guid("b71a3b49-6332-436b-8129-cc3f4561356d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7870), null, (short)3, 6, new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("b8b01c52-d964-41fb-a16b-2ccf49a2de73"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7933), null, (short)3, 6, new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("b8b53844-10ed-4455-9b05-49f941761e60"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7803), null, (short)3, 2, new Guid("4a9231a1-c70e-4e4f-abcc-b06d537e19de"), "Matematik", null },
                    { new Guid("b962f259-4b15-442c-a90b-0aed32271205"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8016), null, (short)4, 2, new Guid("69492844-649c-455d-8516-305903719272"), "Fizik", null },
                    { new Guid("bb17ac09-6505-4368-8072-6b10174304c4"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8041), null, (short)4, 2, new Guid("5c30d475-3d43-45d8-bd0b-4274657338bc"), "Fizik", null },
                    { new Guid("bee04171-55eb-4b38-950a-854be7d07f34"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8013), null, (short)4, 1, new Guid("69492844-649c-455d-8516-305903719272"), "Matematik", null },
                    { new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7906), null, (short)2, 3, new Guid("8d2f9831-bb8e-484b-9ea4-4947b3063d23"), "7. Sınıf", null },
                    { new Guid("c24537a1-32ea-4230-8120-609e2274691c"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7813), null, (short)2, 1, new Guid("2ae8e78f-50ee-435b-bbeb-80b4cde7c9b1"), "3. Sınıf", null },
                    { new Guid("c5134748-aba3-4972-af57-e668ef713ffd"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7896), null, (short)3, 2, new Guid("4beacc6c-c462-4486-be3f-c79568545f33"), "Matematik", null },
                    { new Guid("c5942acf-5b90-45a1-acf0-086090318329"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7818), null, (short)3, 3, new Guid("c24537a1-32ea-4230-8120-609e2274691c"), "Hayat Bilgisi", null },
                    { new Guid("c9046194-122a-4826-b586-d1e1aff6e059"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7807), null, (short)3, 4, new Guid("4a9231a1-c70e-4e4f-abcc-b06d537e19de"), "Yabancı Dil", null },
                    { new Guid("d159f766-00cf-4e84-a2b4-52a0117f8eb0"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7944), null, (short)3, 3, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Tarih", null },
                    { new Guid("d2df4118-adc7-4a9d-9b0f-cb3d313f8396"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7968), null, (short)3, 2, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Matematik", null },
                    { new Guid("d9582e10-04d8-4cda-a3b2-6960ce10fe8a"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8026), null, (short)4, 1, new Guid("e5f38ee8-290a-4e03-8fe7-e7c4bbfbfa2d"), "Türk Dili Ve Edebiyatı", null },
                    { new Guid("d99b053e-4acd-4aaa-8641-2239da5a1dba"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7953), null, (short)4, 2, new Guid("a1c42876-1ea0-4d5e-a627-b128e2d98a24"), "İngilizce", null },
                    { new Guid("ded7be7a-208d-4429-8caa-3d24320ad71f"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7889), null, (short)3, 6, new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("e32c2c6f-8bf7-4abd-9a21-ede78a351c84"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7805), null, (short)3, 3, new Guid("4a9231a1-c70e-4e4f-abcc-b06d537e19de"), "Hayat Bilgisi", null },
                    { new Guid("e5f38ee8-290a-4e03-8fe7-e7c4bbfbfa2d"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8024), null, (short)3, 3, new Guid("9746069b-8666-4ca4-8176-5c823c48c8a3"), "Sözel", null },
                    { new Guid("ea3dbf97-55a6-4a94-8fb5-eeaf01cfe119"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7917), null, (short)3, 5, new Guid("c06f0bd8-2610-48da-aa22-3ccd98e66774"), "Yabancı Dil", null },
                    { new Guid("ea95a394-5b39-4b78-a2d9-7f5a4c715226"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7955), null, (short)3, 6, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("eae38c65-3762-464c-8ef3-0c6ed20ce9c6"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7937), null, (short)1, 1, new Guid("39518ccb-9841-4453-9646-b3b2a4540cb8"), "TYT", null },
                    { new Guid("eb82d4e3-c866-4666-97b1-89601bcf170e"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7984), null, (short)3, 8, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Kimya", null },
                    { new Guid("ec355afb-7786-4017-9dc3-8e39e95506bd"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7986), null, (short)3, 9, new Guid("14b64e32-f6f4-4f9c-94da-fdf7fe441cdf"), "Biyoloji", null },
                    { new Guid("ed8a15eb-701d-4413-8035-d9f903fe0dd4"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8043), null, (short)4, 3, new Guid("5c30d475-3d43-45d8-bd0b-4274657338bc"), "Biyoloji", null },
                    { new Guid("edd9d215-5965-474b-acf9-430091724ad4"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8055), null, (short)4, 3, new Guid("36571a1e-ac7b-4d3f-9912-48b8826a9cff"), "Coğrafya", null },
                    { new Guid("ef1d1bec-980f-45f7-9d9c-5bce782ad64a"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7880), null, (short)3, 2, new Guid("5864afce-5632-4217-bf4e-1c67fd7e2bf1"), "Matematik", null },
                    { new Guid("ef54275b-1094-4d05-8aac-76b033db9c7c"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(8058), null, (short)4, 5, new Guid("36571a1e-ac7b-4d3f-9912-48b8826a9cff"), "Din Kültürü Ve Ahlak Bilgisi", null },
                    { new Guid("f08b326e-e46b-4753-88d8-8830953eb882"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7977), null, (short)4, 2, new Guid("9a8006f4-266a-4a69-9c9e-2d228546c1bd"), "İngilizce", null },
                    { new Guid("f30a3487-f477-4958-9058-56b2e214d9e9"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7903), null, (short)3, 6, new Guid("4beacc6c-c462-4486-be3f-c79568545f33"), "Din Kültürü ve Ahlak Bilgisi", null },
                    { new Guid("f70ef628-cf7b-4a55-af8e-417f0d424994"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7975), null, (short)4, 1, new Guid("9a8006f4-266a-4a69-9c9e-2d228546c1bd"), "Almanca", null },
                    { new Guid("f8cf1321-9fb8-427b-b6b6-08ed45d66c60"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7868), null, (short)3, 5, new Guid("4f1173f4-f126-4a1a-a14d-43324bdaaadf"), "Yabancı Dil", null },
                    { new Guid("f9ba402d-6d94-455b-a557-34e0cfdb0c6f"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7958), null, (short)3, 7, new Guid("8adaf0d0-9678-4005-afdf-9f7b1c176008"), "Fizik", null },
                    { new Guid("fdbfed7d-9e02-4b51-aaf7-b21879f89c9b"), new DateTime(2024, 8, 13, 21, 25, 22, 270, DateTimeKind.Utc).AddTicks(7927), null, (short)3, 3, new Guid("3a8ed647-1ef0-480b-81ce-373abe1095eb"), "T.C. İnkılâp Tarihi ve Atatürkçülük", null }
                });

            migrationBuilder.InsertData(
                table: "Packs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Price", "PriceCurrency", "TaxRate", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3ebc5636-bccd-4c60-92f9-618c4fe06669"), new DateTime(2024, 8, 14, 0, 25, 22, 272, DateTimeKind.Local).AddTicks(2519), null, "dsa", 45m, 1, 0, "Fırsat Paketi", null },
                    { new Guid("75367c3e-8175-4290-b67b-51f32b28e348"), new DateTime(2024, 8, 14, 0, 25, 22, 272, DateTimeKind.Local).AddTicks(2533), null, "dsa", 45m, 1, 0, "Aile Paketi", null },
                    { new Guid("92eee2bf-9088-4939-b01a-8bebbb4f66a7"), new DateTime(2024, 8, 14, 0, 25, 22, 272, DateTimeKind.Local).AddTicks(2541), null, "dsa", 45m, 1, 0, "Deneme Paketi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("af7a6a34-4e3e-4ed9-b3ee-eecfeb525fb8"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dersnet@zurafworks", "Ahmet", "Çiftçi", new byte[] { 233, 129, 141, 74, 1, 168, 162, 154, 32, 250, 204, 227, 152, 228, 38, 29, 43, 100, 9, 145, 224, 250, 60, 168, 115, 143, 236, 147, 4, 152, 44, 241, 23, 84, 246, 32, 251, 210, 50, 119, 192, 238, 213, 53, 16, 181, 116, 156, 242, 139, 177, 124, 227, 183, 140, 226, 161, 124, 25, 88, 104, 81, 99, 73 }, new byte[] { 213, 125, 82, 114, 151, 25, 195, 168, 166, 133, 173, 64, 248, 236, 34, 129, 78, 183, 37, 187, 48, 239, 101, 9, 196, 53, 108, 95, 20, 93, 198, 126, 44, 153, 135, 35, 143, 161, 31, 148, 49, 107, 210, 207, 121, 212, 104, 220, 65, 193, 43, 96, 204, 3, 54, 238, 216, 90, 228, 227, 50, 159, 95, 239, 71, 204, 46, 230, 3, 253, 226, 223, 81, 13, 193, 174, 250, 96, 157, 221, 2, 79, 83, 17, 72, 129, 117, 238, 122, 101, 186, 177, 174, 174, 114, 46, 194, 25, 250, 78, 81, 240, 173, 249, 156, 92, 189, 18, 238, 57, 232, 142, 162, 112, 111, 179, 24, 196, 64, 227, 252, 0, 125, 66, 73, 116, 88, 180 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1665ea22-0662-4055-b4ba-c9def3b4d379"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("af7a6a34-4e3e-4ed9-b3ee-eecfeb525fb8") });
        }
    }
}
