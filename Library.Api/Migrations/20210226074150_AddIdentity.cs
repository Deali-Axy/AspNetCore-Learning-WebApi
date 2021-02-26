using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Api.Migrations
{
    public partial class AddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6c6bb470-968b-41a9-b25c-a4d7d1ee8f27"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00f75ce6-710a-4320-94a9-2db76f1de87f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0217feab-7ef9-4995-a77f-bcdff0e683c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("034e8dac-c56e-40ed-b780-075f428e4249"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("03a09055-c3b2-4a88-a3ef-dbf2902c49e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04cb583f-7e36-42ae-a4bb-faea5e6fd240"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06a8b03b-7caa-49a4-97eb-83edd7c922c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("07874f6b-45c8-4797-a9f7-c8ad0f7149d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("079488d4-ebcc-41ef-b2d3-e38e2bce9b08"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("086a4ffe-76f8-4db6-90a8-318e55c7197e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0973d369-5a40-4356-8c42-383845739066"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("09d1bf4e-9ac4-4d17-9305-1d44b2ce77ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0a19ddd9-4a14-4f51-813d-0fa5638b72d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b37d903-cf36-4f06-b8a0-f990af2185ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b80c500-8f0c-4edc-b03d-5207cc674a5e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b9b799a-0e5b-4458-850e-bd40232bdc66"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e0eaf83-95a0-4b52-8713-1136339509a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e613e46-dd3f-4808-95fe-5dc63f0b1c20"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e7d5828-2ea5-4827-9b63-93380fff78cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0f931162-b0f9-4cbd-80d4-2b00bd71bb28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("11ed4bad-10a1-468d-a4af-22aa242a6856"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("13895329-f24c-453c-87ec-d5616cabed0b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("13afc1e1-19dc-4da9-ae95-2bb8f86f9d0b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14901266-541e-4c89-bacf-4cae5e565826"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14eff00e-8c7d-4977-ae48-1ee1793ceef9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("15611e90-5908-4aac-ac4c-80d5cc4a01e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1683ae95-48ed-4800-8007-92a3b32444b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17559105-f69f-41fc-b9f5-4ec021de7485"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("183709ae-638d-43bf-9ab7-5278c641b993"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18df23f2-716e-48b9-b4cf-f4e58dba1abb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1911bce3-715f-439d-a814-f8e66b0274dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1a54122c-ca72-41b1-80b4-c20f8c4507d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1a84bec2-3d7d-47c7-9f4f-1bc1cde79fd3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1cbcd4a6-007a-4e0b-be96-7d8aeae94fa9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1ebd9d2e-d3ba-449e-a6c4-714b2e48e6eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1faa8b9f-1e1c-44e7-b701-aeb030b2459e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22279943-7c6f-4e9b-98ec-c07548c4c55a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2290d827-13d2-4925-8657-f52ea26fd90f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24759739-a20d-43e1-9d5e-41d0ece1895f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2693d5a4-33fb-42c4-a399-ac6c7aaa94be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26a612e3-f980-4371-b73c-c4fd8e6d30c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("27b9bc2c-7e3e-4d49-b8a3-d8e936bb92af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b81a089-ff5b-49b6-ad99-a40b0e6b915a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2cafa0ba-8ac0-4b39-89f6-60b2f0c64172"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2dba00b9-3875-47d0-85f8-b33571d59c69"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2eb003f4-15e2-4eef-bc16-dedc7a31edfb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ecaafd9-619c-4433-9ff2-19f8559bac86"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ed5bab5-2d5b-4ca5-872f-502939ec07c4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f2e67d9-44da-48a1-b3da-f569b25230d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31aa7f52-eb55-4474-bb01-ddc6019c0e69"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("33aac393-a27b-4da8-8bd7-ddd126e79c38"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("342704c9-2f77-4f4f-a090-385d1bc5ad03"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("34587b98-71b1-487e-b07e-a94493473a3a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("36091316-2e09-445a-9dea-54abf43c1f81"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("369d7d6d-f76c-4f7d-88d0-0312f77f0e04"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("36d108c7-be9a-4f6f-8263-4f2ad7d3d0f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3824b8b3-b936-43b5-868c-ea37ca042a6a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38744be0-762a-4dc2-b9cc-ca679acdb276"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38b8f6c8-9f88-4d92-82e2-86f3ae05bd5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38dbfdc0-7bd8-4976-938b-2749997905d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3cf8daff-358b-4306-b126-6e22d8a594c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3d67e0ef-6e7d-4b4d-89a1-8642605e1ef0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e2c8aab-e82f-4d7c-82d4-fd5062002f6f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ae8a4c-894c-4a5d-8c45-c1f7fc63e9a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41ff040f-fbc2-4724-8e66-51adfedb5b67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4293d233-a0ec-4dc0-ab20-cf6c8bae2903"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("44f8c913-cfca-4c8e-aa2e-0a7716d97ca0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("45b830ff-29ec-40a2-8052-d4373b6b8a66"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4c023e8e-9a73-4afb-ac50-3e2e19300279"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d031c40-f6e9-4f48-baaa-bc1a62124bcc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4dbe8055-1597-4775-b519-2d31cafdf398"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e05f216-ab77-483e-9323-0fc092f0298a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e69f986-5f6e-4641-87cb-053313573e72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("54c93a59-3729-4e96-aaef-85bdb07ed966"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55aa372c-9e74-46a3-8609-3a84fd96f2ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("563be5ba-ddb2-4e1c-9193-d39b0ca94e94"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("594f8f30-1902-4e43-9bac-746f09c398cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("59d04170-3752-4e91-84f7-817fddbf9575"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5a894aab-7e50-46b1-8bc6-eeb7396cff2c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d114241-f2e5-4cb4-9faa-d65ed2c8f734"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5e8e9699-d961-468a-a816-31e6d0863569"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f142242-cf91-4e47-aff4-0e222fb69e1f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f63a1f2-55bc-4917-b483-2aef29f220b8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f63cae5-616f-4ca9-95c8-be633b0f67ab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("602faf27-ec79-409e-bebd-a3fb657be559"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6085ff29-659b-461f-820e-bab66c6bb03c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6139f979-ff6c-401f-936f-32c335f8eafa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("62ecc5cd-6ec2-4a9b-b0b6-00e0fb1e7f97"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("64890527-5d3d-4778-aeea-b1ea279c0aa4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("65966fce-438f-4ff8-8864-2b299ff4a6c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("65b21c86-e4ae-4570-bbb9-801357a172f4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6689e2ec-4bf9-4074-8679-30424ef4fd2b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("673de257-4703-40c9-a5b2-bdff70b625cc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("687399ff-9ae0-4150-b3f3-9d933c04598f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68c29c10-4c39-4d42-9d94-ce175e7a3f89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("69a90b10-35c1-4f52-8bd7-dcb7c6feb943"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6afb4f36-6275-4b09-9fb9-427b11e1e50f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6bacd4ab-5799-4ed3-ad2f-f60041cab378"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6bbd5a3b-0751-44b7-b737-06ef27eb9fbd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c2a7db6-97b6-4243-bdd4-6dc569a56228"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c45c6f9-58df-4c94-85d1-2117741cac60"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c4733e3-6520-47b2-918f-9c2ce67924ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("712da5b4-285b-48da-8a2c-1badc9562080"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7149f8e7-5cda-4844-83b7-cffc712e4070"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("76515c72-2016-41c3-9e2e-905dd19a16cc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("76d735bd-a274-41b8-b57b-4d27f2a80a62"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("771350bc-b77d-431e-92c6-6b54effb7dd0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("771d5813-dd26-42a4-a443-974ca0df9810"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("789f77ee-70c1-49dc-8769-1a3208555a13"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78ae63ee-5f93-4930-a5c1-c5e26988897d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b920a6e-0d31-49ad-992d-c413fc58389f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7c610d1e-fd9e-4215-aa38-35699cf415ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d94bf8b-282d-4301-895f-2d8c3f18c516"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("835ce1c4-cbf5-44bd-ae75-3e8590bee05f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("84e5f4af-72ee-488d-a0aa-d1d8ca366cf8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("854efcff-54cb-4e28-9b83-ea4211329a8b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85642aa2-8689-4f07-b677-c7981911ad2c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85722b1e-7542-4e9a-8ff0-8266ce9bacbd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86538690-ec6b-4bf2-a04e-b5182c549deb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86b58374-7f37-4ce0-ab1c-d20c7297239d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("89024689-3cdf-4b1e-ad88-7a212e5910ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8c64b058-632c-4053-8a75-0d5a6b380472"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e6185ae-90c3-445b-a709-3d9492bc836f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e62bcb6-21cb-4d92-ae79-95c10a0c6b28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f86cf1b-5dac-4948-aaed-c53f58f4c37d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91d9d587-01f2-4a20-af9c-c842aeb2cae4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("920de295-4234-4abe-b6ce-409a9104fdd7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("93bdedb0-959a-45ee-b5cc-f04d55b81ce9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("93d37447-d9a2-4ac1-ac33-4b82ee36e15b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9512dfb3-fabd-41f1-bfce-3a5447942ac1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9531a813-324d-4d25-9164-9e6dacc46e77"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("95b3c170-f14f-4157-897b-3ec19bb3cb82"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98de0d39-59e6-4536-a601-c04425ac4a7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("99e4b41f-21e6-422b-a60d-cb08fd84e0cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9be3efc1-4d33-4626-9a4e-dfba41bb8bac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f6bd6e0-ca48-48fb-a595-beaf8b9b8a91"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a0e4b774-fa99-4186-a893-2486c52e60ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4d5b85c-c837-4d6f-a34d-df49521caab2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5b40a57-888b-49a8-9eb6-91be50207d1f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7bdd30a-c6dc-4346-999e-0d0cc6899323"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9230bbf-27b1-4e82-8ffb-7c277aa98280"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa2388dd-3f90-4f74-bc3d-59b38a54fa6a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ac952215-1e10-4fab-a939-a8f1140dbef7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ad2d7ca0-8e19-4498-866f-d5f4a3040cf6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ad4fce47-71b0-4c06-881b-df5f123a7f10"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b00099d7-2de9-4321-b1f4-07f05f4ec425"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b0bd1818-25cc-4503-913b-b43a116eced8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b325b074-410c-4815-b3ec-5546091ba285"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b36d5464-4ee7-4437-bad8-9855b622f9a0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b892ebc9-ce18-41dc-970d-a6909e12e608"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb24d58f-137b-433d-ad8b-a7ca7ab0ff5a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb621143-f65c-4761-9eb4-01a4ac999214"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb78dcaa-c3ff-4029-967b-cf9ceeffef89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bc1a3f17-e5e5-4a20-bbae-a96cbac321a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bdb4aa52-4779-4452-b570-0879280e0403"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("be997f8c-30df-4a53-8839-98ae8593491c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bf529b6d-ebb7-4bd8-b112-0716cf9da057"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1d67262-9862-40e8-8c06-8b0ce60d24a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1e2a70e-612d-45e1-ac8b-8f430339fd4c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c2d98324-9399-47d5-9c65-c79bb8b04a63"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c4032d5c-9cf9-4d3e-916a-d198a359afe0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c5609676-5f8c-4978-b7b7-97e4278c4efe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c69c6ebe-f6f9-4dca-b7f3-7593afa151e1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c6dfdb4c-10bf-4d9b-94f4-34cb4dcd333e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ca1ec40b-6c69-493e-890a-058245ebda01"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cee6a424-3e48-48da-b439-a4ac8b693c76"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cfec324e-0fc7-4191-b378-75f077c3aeaa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d2360454-3545-477f-aa0d-f2a1db04851d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d717b00b-36fd-4b2a-a076-f0742d3f6a49"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d74d7c0b-8fe8-458d-856c-ca898e1aabae"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8db2de1-8721-4985-b383-99cc487dff23"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("da86ec40-8518-4ac1-850e-1c73bc28ec1b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc31f21a-4362-4dde-be50-14fc5e2b7641"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc49385b-766d-469c-9c9e-c0a97fc797ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc932189-4eb5-4911-ab67-d77bed45129c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e014c02e-239a-4e9d-b154-72eba7b189d0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e046f420-9738-48c2-9628-2e73f6412957"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e0fa7367-a5a6-4f2c-b440-d4d581ee4083"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e3c08f4c-07e0-4849-8af4-95e4415af77b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e4a03f5f-67e8-41ba-8f14-59b337da4a07"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e85e642e-ad62-4f12-b96f-6b00a850028b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e900c59b-0263-46ce-ab08-f9fb971d20c0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e9dfdae2-8274-45bb-9f1b-776215defce0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e9fc9958-74bd-4d1a-8e94-651b6a30d309"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea623a48-66d4-4fc7-aba5-713f913b60c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ebe02bd1-354c-4575-9238-f966e061f78f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec53604c-81e8-4652-88a0-9e39b88bd6cc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ecf81e80-de88-4f09-8685-1eb9e256ee6f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ed01ce82-1edb-4260-beba-3d50db2a5006"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("edc75a33-e700-4cdd-8e73-61ef1b2d0b27"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eff0d12d-c7f0-40d1-9f7b-2be6845b78c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f269b7c8-bde2-454b-8bab-7f2e5e6167d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f320030d-6067-4102-a0d2-6d81daa7529f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4351e07-750e-4bd6-9191-116c736099e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5e173d9-9260-45d9-be05-0b789f6702f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7314912-6acd-4655-bc30-0ee275293daa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7e5964c-2669-4187-bdfb-afa39855f4a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f9a5f2e3-1418-4227-b80e-0f72cf1e83bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fbc8f147-771a-49d0-a914-8726621a0a28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fdb84b2e-6813-4742-a0ed-38dfac46d438"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ffd29f9f-4598-4c24-b924-33e1d3985558"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0212b86f-b98c-47af-8edb-abc059e3c093"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("02e743e9-a8b2-44ed-ab6b-e08ee620ca1a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("09857bd8-94f9-4f22-88fc-7bcadf73faea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("09993863-7b77-4499-bddc-ce1f3a5ee200"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0add9e3e-8145-4fa4-9b16-059cbef40052"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("16932bc6-4083-4646-8d60-0ecac6a29a38"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1834e14f-7987-47d9-94d4-c44cda205724"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("187038ba-5795-4705-a9e7-add2de31ac95"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("23fce496-3b8c-4521-91f4-1f738b928be5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24c08daa-52d5-4f07-ac73-9ba92cfe4ee1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("28839dc4-58a3-4c24-a7a0-9b0781f48463"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4d85a9e7-b603-4337-bcf0-de71b5f86473"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4eee913f-abcb-4f6c-89d2-56995e42f280"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("523618c9-d2b0-42e5-a51c-8116f86bd6e0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("54a90c07-9a74-45b1-8605-2380c3a863b5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("66910241-9135-468b-9aa2-4030cd5fa589"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6d388830-a3cc-45d2-8016-8ed4ccbbae1b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72845848-5359-404c-b187-be5d964bc71d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("748ba6c1-872f-4c3b-920d-ff85de509683"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("76c729e7-6c99-4a8e-b9c2-e2b4ed6af182"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("79954558-382c-4914-8014-6e8fe546a39b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("81e9697b-3882-4c8b-8b81-f923af34e9ba"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8d08c335-8015-424c-8cb4-d2886bc4d2c9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8d3934e8-0185-4c59-a116-fb0e4334fdf7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8fbe6528-8969-4ae9-855b-3724e60d777d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9c765781-15bd-4bbc-ace8-deecffb33666"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a1bde1d8-dc7a-4fd2-a7e9-0f18bcd2e585"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a35700ad-9775-466a-80e2-7645e9388589"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a3dc2e00-e015-43a5-9cef-00a0988ee396"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("adab38da-ca11-4d57-a9a8-98ffa4e7ded9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("afb2e8fc-d060-401e-b60b-14463ddf42a2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bcb5e4c3-5b0e-45f5-80a4-4dfa132493de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c11e353a-77bd-40e7-abba-3f54d453ed39"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c2a01334-a8c5-4c24-88b9-be8e75bc7db4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c99af5ff-cd36-4e0e-8eb5-d7fcb04fba56"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ce411af8-f7fa-4b3c-bccb-6b660efde51c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cf83ff2b-ff2f-481c-8aa3-aeb79a2ff5e3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fb53852b-8fda-4daf-931f-7a54a6d8389c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fba94512-5eab-4d20-b81a-08b177aca7c4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"), new DateTimeOffset(new DateTime(1988, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author1@deali.cn", "Author 1" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("b8ab45b8-3546-43ca-88a4-1aeae70b7394"), new DateTimeOffset(new DateTime(1958, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author28@deali.cn", "Author 28" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), new DateTimeOffset(new DateTime(2000, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author29@deali.cn", "Author 29" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("ca3a9664-2a45-404b-a5b0-d102137c8d4e"), new DateTimeOffset(new DateTime(2006, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author30@deali.cn", "Author 30" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("e51c1fd5-e202-4317-b006-e3db6905d77e"), new DateTimeOffset(new DateTime(1962, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author31@deali.cn", "Author 31" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("f49231d9-2752-4917-8107-ee96f1ce1571"), new DateTimeOffset(new DateTime(1999, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author32@deali.cn", "Author 32" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("abe987d3-5bab-486f-9799-7ce7568a4c7b"), new DateTimeOffset(new DateTime(1963, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author33@deali.cn", "Author 33" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("5f3e31ef-76cd-49da-9b23-23292ea6a065"), new DateTimeOffset(new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author34@deali.cn", "Author 34" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("0e0a611e-9b0c-4f44-ac27-3f4c3714111e"), new DateTimeOffset(new DateTime(1976, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author35@deali.cn", "Author 35" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("dd647a2f-8429-41bb-b61d-92b220591a61"), new DateTimeOffset(new DateTime(1958, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author36@deali.cn", "Author 36" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("95b7b100-867e-43c7-8a46-af273fede5ff"), new DateTimeOffset(new DateTime(2009, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author37@deali.cn", "Author 37" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("920818ed-a03b-432a-9343-f1eb5d31836c"), new DateTimeOffset(new DateTime(1957, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author38@deali.cn", "Author 38" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("12c337ae-2c6b-4f82-a0a4-6648300bcbc0"), new DateTimeOffset(new DateTime(1960, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author39@deali.cn", "Author 39" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("af99b205-e970-4405-afe7-779cf584dd69"), new DateTimeOffset(new DateTime(1989, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author40@deali.cn", "Author 40" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"), new DateTimeOffset(new DateTime(1997, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author41@deali.cn", "Author 41" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("c2f01b5a-fda9-4f6e-9778-0dca90c8309c"), new DateTimeOffset(new DateTime(1967, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author42@deali.cn", "Author 42" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("a4e67ba5-2bc5-4d5f-bdd9-e048a58cb9b1"), new DateTimeOffset(new DateTime(1974, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author43@deali.cn", "Author 43" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("55d2234d-0e9f-48c9-9012-72f94728e4ab"), new DateTimeOffset(new DateTime(1979, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author44@deali.cn", "Author 44" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"), new DateTimeOffset(new DateTime(1976, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author45@deali.cn", "Author 45" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("98cec19b-0fde-4174-91e7-1c5df9a113e6"), new DateTimeOffset(new DateTime(2001, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author46@deali.cn", "Author 46" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), new DateTimeOffset(new DateTime(2004, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author47@deali.cn", "Author 47" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("69b59b39-b974-48ac-a394-3eb513892e27"), new DateTimeOffset(new DateTime(2008, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author48@deali.cn", "Author 48" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("e8d8d4c9-b05c-457d-afdd-9b5d076854df"), new DateTimeOffset(new DateTime(1952, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author27@deali.cn", "Author 27" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("942caf13-db29-4a17-ad61-56b5fbaf3b1a"), new DateTimeOffset(new DateTime(1978, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author26@deali.cn", "Author 26" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("65e69e0c-8698-4d27-a4ce-ce48f2e39ba3"), new DateTimeOffset(new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author25@deali.cn", "Author 25" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("aac7f072-66ae-4464-af4d-1f04e0681ebf"), new DateTimeOffset(new DateTime(1984, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author24@deali.cn", "Author 24" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("70927fba-52d8-41c4-a256-3a1125e567c2"), new DateTimeOffset(new DateTime(1960, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author2@deali.cn", "Author 2" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("9838cc4a-9c63-4a2c-a02e-f08747497dae"), new DateTimeOffset(new DateTime(1962, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author3@deali.cn", "Author 3" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("6af26fd3-a516-4215-b68c-0aa6235c0f71"), new DateTimeOffset(new DateTime(1952, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author4@deali.cn", "Author 4" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), new DateTimeOffset(new DateTime(1992, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author5@deali.cn", "Author 5" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), new DateTimeOffset(new DateTime(1957, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author6@deali.cn", "Author 6" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("0e89c268-1761-4245-95a0-a8d25653db64"), new DateTimeOffset(new DateTime(1968, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author7@deali.cn", "Author 7" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("be538507-d5f4-4d4d-b129-c1aa3752d1ac"), new DateTimeOffset(new DateTime(1990, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author8@deali.cn", "Author 8" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("5950c737-930b-42a6-8160-20e454438134"), new DateTimeOffset(new DateTime(2002, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author9@deali.cn", "Author 9" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("c41c5a08-5b03-431c-b5a6-0387b2d3de20"), new DateTimeOffset(new DateTime(1954, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author10@deali.cn", "Author 10" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("66b01e7d-726d-441b-a285-5a3008cb2ea2"), new DateTimeOffset(new DateTime(1974, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author11@deali.cn", "Author 11" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("04df928e-1dde-427b-8fc0-0f4e16d3cb0c"), new DateTimeOffset(new DateTime(1964, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author49@deali.cn", "Author 49" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("85698543-5e55-449d-a5a6-470b95697679"), new DateTimeOffset(new DateTime(2008, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author12@deali.cn", "Author 12" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("0b2619be-9ed2-495e-a1fc-ae0e5e9eb6c5"), new DateTimeOffset(new DateTime(1967, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author14@deali.cn", "Author 14" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("832be0a3-3a91-4a50-91a3-264bd3e37fe5"), new DateTimeOffset(new DateTime(1974, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author15@deali.cn", "Author 15" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("7fde27df-0720-4508-a724-225644057296"), new DateTimeOffset(new DateTime(1978, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author16@deali.cn", "Author 16" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("b1063fb4-3460-4605-854c-043d7ccab073"), new DateTimeOffset(new DateTime(1957, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author17@deali.cn", "Author 17" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("6e9cf294-5c68-4a74-b36d-02a25c30f118"), new DateTimeOffset(new DateTime(2003, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author18@deali.cn", "Author 18" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("97788741-ae3d-451e-bed4-645a9edfd224"), new DateTimeOffset(new DateTime(2009, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author19@deali.cn", "Author 19" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("ac6046eb-a770-4359-9f69-4c77eeb88036"), new DateTimeOffset(new DateTime(1994, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author20@deali.cn", "Author 20" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("12e2aa10-dc45-4d53-bfd8-09e1e1d62c36"), new DateTimeOffset(new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author21@deali.cn", "Author 21" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("1da624e4-4cd4-45ef-8fa7-904660c659b6"), new DateTimeOffset(new DateTime(1977, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author22@deali.cn", "Author 22" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), new DateTimeOffset(new DateTime(1964, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author23@deali.cn", "Author 23" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"), new DateTimeOffset(new DateTime(1959, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author13@deali.cn", "Author 13" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("98bbda9f-ca80-4fa6-88ef-663076df5d1f"), new DateTimeOffset(new DateTime(1997, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author50@deali.cn", "Author 50" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("49bef47c-2505-497b-9587-82111d31fb4c"), new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"), "Description of Book 9", 270, "Book 9" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("fb354533-9792-4c83-8761-f025417c4b53"), new Guid("ca3a9664-2a45-404b-a5b0-d102137c8d4e"), "Description of Book 148", 191, "Book 148" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a14461f0-8cd1-4a4a-bb2c-f88b4e61f1de"), new Guid("e51c1fd5-e202-4317-b006-e3db6905d77e"), "Description of Book 25", 679, "Book 25" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("49ba49d5-6ea4-47fd-bdea-4b1510d278b4"), new Guid("f49231d9-2752-4917-8107-ee96f1ce1571"), "Description of Book 48", 514, "Book 48" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b3e9ef41-781b-4f52-a72e-3ded0413d276"), new Guid("f49231d9-2752-4917-8107-ee96f1ce1571"), "Description of Book 100", 835, "Book 100" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("113f6017-e3dd-4e60-acbe-9da4e3be67ba"), new Guid("f49231d9-2752-4917-8107-ee96f1ce1571"), "Description of Book 145", 390, "Book 145" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5e32b1ae-b199-4cb0-8f04-8423ac674ee3"), new Guid("f49231d9-2752-4917-8107-ee96f1ce1571"), "Description of Book 151", 610, "Book 151" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("cbc79001-17c4-4ef6-9cc8-292a052b4213"), new Guid("abe987d3-5bab-486f-9799-7ce7568a4c7b"), "Description of Book 41", 279, "Book 41" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3be63747-4b12-4c50-a31a-54acd7a5312c"), new Guid("abe987d3-5bab-486f-9799-7ce7568a4c7b"), "Description of Book 63", 192, "Book 63" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("605460a2-666e-4a7a-a384-98e79f4d8a5d"), new Guid("abe987d3-5bab-486f-9799-7ce7568a4c7b"), "Description of Book 89", 809, "Book 89" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ea39a6b8-f6c6-4587-b3d9-c218de369182"), new Guid("abe987d3-5bab-486f-9799-7ce7568a4c7b"), "Description of Book 182", 922, "Book 182" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("68788150-1763-4ce0-a440-e0154ff8764c"), new Guid("5f3e31ef-76cd-49da-9b23-23292ea6a065"), "Description of Book 19", 753, "Book 19" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d19996a3-7b7d-4525-86bf-bcced704b8d3"), new Guid("5f3e31ef-76cd-49da-9b23-23292ea6a065"), "Description of Book 36", 722, "Book 36" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("df1fee1d-39c3-4c50-8600-148499870e0f"), new Guid("5f3e31ef-76cd-49da-9b23-23292ea6a065"), "Description of Book 90", 157, "Book 90" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4110efa7-0b57-42f2-a146-ad12284525b7"), new Guid("5f3e31ef-76cd-49da-9b23-23292ea6a065"), "Description of Book 175", 999, "Book 175" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f2310c0e-e9e8-4837-b349-eaebf7bfd67e"), new Guid("0e0a611e-9b0c-4f44-ac27-3f4c3714111e"), "Description of Book 27", 418, "Book 27" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("49ecee3f-f4fd-4717-915d-bf46cb66e864"), new Guid("0e0a611e-9b0c-4f44-ac27-3f4c3714111e"), "Description of Book 176", 676, "Book 176" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("165b23f1-efcc-4f14-bd5e-c955d7b2901f"), new Guid("0e0a611e-9b0c-4f44-ac27-3f4c3714111e"), "Description of Book 193", 644, "Book 193" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ace1f1a6-a07e-4df5-b59d-485e7e32a724"), new Guid("dd647a2f-8429-41bb-b61d-92b220591a61"), "Description of Book 91", 905, "Book 91" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f3bf4214-2085-40d7-bda3-55a6390bfebd"), new Guid("dd647a2f-8429-41bb-b61d-92b220591a61"), "Description of Book 130", 361, "Book 130" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f61c3c1d-b056-4050-97a9-114747da0018"), new Guid("dd647a2f-8429-41bb-b61d-92b220591a61"), "Description of Book 154", 797, "Book 154" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b880e227-d486-43bc-b5be-dba383e4edb2"), new Guid("95b7b100-867e-43c7-8a46-af273fede5ff"), "Description of Book 21", 961, "Book 21" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e39d8c26-76ea-4bd7-a3c8-d5421bdb2980"), new Guid("ca3a9664-2a45-404b-a5b0-d102137c8d4e"), "Description of Book 95", 730, "Book 95" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("cdc12479-1f7d-4d50-97ce-157d68cc2f86"), new Guid("95b7b100-867e-43c7-8a46-af273fede5ff"), "Description of Book 61", 605, "Book 61" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("37c5c835-4d42-4f29-9581-6cf27ba3efc2"), new Guid("ca3a9664-2a45-404b-a5b0-d102137c8d4e"), "Description of Book 49", 262, "Book 49" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ebfb1a36-a9ae-4ac2-a6fc-30ffb68f955f"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 192", 306, "Book 192" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5711bb2d-10fd-45aa-8c68-e2793d7ba7fd"), new Guid("65e69e0c-8698-4d27-a4ce-ce48f2e39ba3"), "Description of Book 29", 140, "Book 29" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("81610093-621f-4d20-b594-9c3f2b04dae2"), new Guid("65e69e0c-8698-4d27-a4ce-ce48f2e39ba3"), "Description of Book 161", 562, "Book 161" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4c45602f-8132-45c1-bf37-58cb202789a6"), new Guid("942caf13-db29-4a17-ad61-56b5fbaf3b1a"), "Description of Book 7", 693, "Book 7" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0fdac72b-fc18-4e94-bc9b-1bd2aa9ee3f6"), new Guid("942caf13-db29-4a17-ad61-56b5fbaf3b1a"), "Description of Book 47", 764, "Book 47" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("309bcce9-bc37-4641-b9c5-77a56008a672"), new Guid("942caf13-db29-4a17-ad61-56b5fbaf3b1a"), "Description of Book 107", 605, "Book 107" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("33d96eb6-dc33-4652-9a4a-33b14f0abd6b"), new Guid("942caf13-db29-4a17-ad61-56b5fbaf3b1a"), "Description of Book 136", 918, "Book 136" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9af32559-4e3a-4255-b5e8-c544fbb66c37"), new Guid("942caf13-db29-4a17-ad61-56b5fbaf3b1a"), "Description of Book 155", 307, "Book 155" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("95061585-932b-46e4-8f51-7f42f6880a5b"), new Guid("e8d8d4c9-b05c-457d-afdd-9b5d076854df"), "Description of Book 14", 544, "Book 14" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3ef76b04-50ac-457d-9180-d3aab4c4d21e"), new Guid("e8d8d4c9-b05c-457d-afdd-9b5d076854df"), "Description of Book 106", 575, "Book 106" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ec2bd8f9-dc90-4abf-9509-d0ab14c21bfa"), new Guid("e8d8d4c9-b05c-457d-afdd-9b5d076854df"), "Description of Book 119", 992, "Book 119" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9cdac809-cb68-4543-8add-97ce1ea556dd"), new Guid("e8d8d4c9-b05c-457d-afdd-9b5d076854df"), "Description of Book 173", 349, "Book 173" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1caac841-0321-450c-bef7-d5cee81e932f"), new Guid("b8ab45b8-3546-43ca-88a4-1aeae70b7394"), "Description of Book 50", 886, "Book 50" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b74bd30d-6077-46c4-9360-c11e3428002d"), new Guid("b8ab45b8-3546-43ca-88a4-1aeae70b7394"), "Description of Book 92", 671, "Book 92" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("318a309b-706a-41a1-90a0-ac3fdf51c2c2"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 26", 838, "Book 26" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("12cc420f-d696-40af-9114-58a013829b20"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 52", 674, "Book 52" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("315f2f10-f86a-4eea-8450-9b521722d7d7"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 68", 608, "Book 68" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e0e31b18-1de3-4c53-a43d-9e1d06344edd"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 69", 196, "Book 69" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3a4e73e0-81bf-45fc-bbf3-2c3e5dffdd1c"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 120", 670, "Book 120" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e78afcbd-4642-4065-b832-06d1f7d0f6e6"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 124", 138, "Book 124" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b3fc4e1c-1bb1-4ef1-b256-5e4a5dfae249"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 137", 586, "Book 137" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a2fbe1e9-73d5-4fb0-9b73-62d52b5df04a"), new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"), "Description of Book 160", 824, "Book 160" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("37c01178-a225-412c-b680-a4cbbab3de98"), new Guid("ca3a9664-2a45-404b-a5b0-d102137c8d4e"), "Description of Book 33", 426, "Book 33" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4186e576-b9a5-4be1-9e8b-0027e01b31cb"), new Guid("aac7f072-66ae-4464-af4d-1f04e0681ebf"), "Description of Book 139", 687, "Book 139" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d00ae3c3-a01e-42d1-a229-48e0cd5dc95d"), new Guid("95b7b100-867e-43c7-8a46-af273fede5ff"), "Description of Book 85", 915, "Book 85" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("62c30d1d-5f3e-4778-a40a-3d1287dfbd36"), new Guid("920818ed-a03b-432a-9343-f1eb5d31836c"), "Description of Book 6", 925, "Book 6" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a1d67f60-7fe9-498b-a141-2c2200e5235f"), new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"), "Description of Book 81", 172, "Book 81" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b96dd4d3-6b8a-4a4f-9db5-a9ab04004427"), new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"), "Description of Book 103", 417, "Book 103" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("734ae02d-76cd-4c24-9659-e6aee440647a"), new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"), "Description of Book 116", 701, "Book 116" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("18e3f568-aabb-4f6d-9e83-112a541cb80c"), new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"), "Description of Book 129", 788, "Book 129" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c2fbe230-138a-4aa1-a0fa-33de0ec48986"), new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"), "Description of Book 132", 343, "Book 132" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("8416f5e3-292d-4478-aae3-62d8a8853239"), new Guid("98cec19b-0fde-4174-91e7-1c5df9a113e6"), "Description of Book 13", 312, "Book 13" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7bc625ff-de21-434d-9326-2bf91e90ab09"), new Guid("98cec19b-0fde-4174-91e7-1c5df9a113e6"), "Description of Book 18", 171, "Book 18" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7e13c471-5e84-43b1-8927-493e11549a6d"), new Guid("98cec19b-0fde-4174-91e7-1c5df9a113e6"), "Description of Book 28", 359, "Book 28" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("705a6c81-a5ac-488e-8d2b-811d1201b3bc"), new Guid("98cec19b-0fde-4174-91e7-1c5df9a113e6"), "Description of Book 134", 251, "Book 134" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c386f59b-6573-41ec-adeb-0d26e034f2e1"), new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), "Description of Book 43", 284, "Book 43" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("33261d6d-53e3-4e82-a561-c132b89c6d4f"), new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), "Description of Book 102", 255, "Book 102" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("41403c66-05d8-422e-802e-e0d78e09ec5e"), new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), "Description of Book 108", 641, "Book 108" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("caebe704-0ef5-4511-9df8-0f3e0d77a5a1"), new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), "Description of Book 127", 112, "Book 127" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("86bca2f8-efbd-4c0a-8392-cf626bd01045"), new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), "Description of Book 147", 313, "Book 147" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3641a61d-2e7d-4386-912f-6f5e7aefd547"), new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), "Description of Book 153", 386, "Book 153" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2e8b7532-e90a-4e39-be7e-e72d4ab3cca3"), new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"), "Description of Book 165", 569, "Book 165" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("276119ec-5bb8-4320-a62f-05a3cb224878"), new Guid("69b59b39-b974-48ac-a394-3eb513892e27"), "Description of Book 67", 720, "Book 67" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b3707c57-b223-4506-9fde-bfcb39b87a93"), new Guid("69b59b39-b974-48ac-a394-3eb513892e27"), "Description of Book 87", 592, "Book 87" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b33588a0-27cc-4dc8-aaa9-b6aa5157ad5e"), new Guid("04df928e-1dde-427b-8fc0-0f4e16d3cb0c"), "Description of Book 123", 800, "Book 123" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("00e117cc-f08b-47b2-96ec-c70856d78968"), new Guid("04df928e-1dde-427b-8fc0-0f4e16d3cb0c"), "Description of Book 131", 963, "Book 131" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("73562932-b2e7-4160-8691-67c90505ad67"), new Guid("04df928e-1dde-427b-8fc0-0f4e16d3cb0c"), "Description of Book 144", 376, "Book 144" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("54d619ef-5d2a-44ca-bb67-9db07c0c3dd8"), new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"), "Description of Book 15", 347, "Book 15" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("902f7cfb-ceee-4e97-9ced-807f986a3b43"), new Guid("95b7b100-867e-43c7-8a46-af273fede5ff"), "Description of Book 121", 626, "Book 121" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("83c422e1-8409-46d4-ba77-8e9572da1ca5"), new Guid("55d2234d-0e9f-48c9-9012-72f94728e4ab"), "Description of Book 191", 561, "Book 191" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d4882482-3f02-4386-952c-4410a6215bbf"), new Guid("55d2234d-0e9f-48c9-9012-72f94728e4ab"), "Description of Book 143", 848, "Book 143" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7258f0d7-9086-4c26-a63e-bdb7ee119ab7"), new Guid("920818ed-a03b-432a-9343-f1eb5d31836c"), "Description of Book 46", 464, "Book 46" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("8a200b57-0ccf-4fa6-89bc-728ba6fc0209"), new Guid("920818ed-a03b-432a-9343-f1eb5d31836c"), "Description of Book 70", 626, "Book 70" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("cdc45ce1-0a60-443b-8e2a-5710b31a4796"), new Guid("920818ed-a03b-432a-9343-f1eb5d31836c"), "Description of Book 75", 207, "Book 75" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b48fb3a5-f326-4a97-8425-6bba80dfeca2"), new Guid("920818ed-a03b-432a-9343-f1eb5d31836c"), "Description of Book 84", 255, "Book 84" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f5c9eca7-bb2e-4155-a3dd-a299028d6653"), new Guid("12c337ae-2c6b-4f82-a0a4-6648300bcbc0"), "Description of Book 51", 449, "Book 51" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bf3d02af-a83a-4a74-afe4-6bf7afc5185f"), new Guid("12c337ae-2c6b-4f82-a0a4-6648300bcbc0"), "Description of Book 138", 559, "Book 138" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("78ced542-4b94-4fb8-a67c-689f0c3d8171"), new Guid("12c337ae-2c6b-4f82-a0a4-6648300bcbc0"), "Description of Book 166", 522, "Book 166" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6a9240f0-a46a-4803-b127-71d8d08e01f1"), new Guid("af99b205-e970-4405-afe7-779cf584dd69"), "Description of Book 12", 146, "Book 12" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d806ca05-526a-4202-9c75-570f76bcae53"), new Guid("af99b205-e970-4405-afe7-779cf584dd69"), "Description of Book 114", 768, "Book 114" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("dc139f1c-990e-473b-a1d6-87463bc35941"), new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"), "Description of Book 2", 601, "Book 2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("aee1ff59-58aa-4f43-b82e-cdf8f4456b60"), new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"), "Description of Book 42", 596, "Book 42" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0bbf1dfe-c0d5-4c24-8596-096a65f5c3f2"), new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"), "Description of Book 62", 433, "Book 62" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ec51e1ae-a148-4709-9158-1ec94e9aaeeb"), new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"), "Description of Book 162", 722, "Book 162" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bb031cb9-d079-4dac-a1aa-390032439fa1"), new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"), "Description of Book 178", 522, "Book 178" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f119bccd-84a9-4639-8f6f-ee0abea484f0"), new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"), "Description of Book 187", 958, "Book 187" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1d70e27d-2c77-4b53-9e87-f6399de489cb"), new Guid("c2f01b5a-fda9-4f6e-9778-0dca90c8309c"), "Description of Book 149", 540, "Book 149" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("56e85eec-8b4e-4524-820a-68e50b1796a6"), new Guid("a4e67ba5-2bc5-4d5f-bdd9-e048a58cb9b1"), "Description of Book 64", 907, "Book 64" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("cf3d550c-e664-4926-bf97-77f5b28f1c4b"), new Guid("a4e67ba5-2bc5-4d5f-bdd9-e048a58cb9b1"), "Description of Book 77", 622, "Book 77" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5b4ae9cc-ef58-45cb-a065-276f378cc8e6"), new Guid("a4e67ba5-2bc5-4d5f-bdd9-e048a58cb9b1"), "Description of Book 135", 569, "Book 135" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("68c5288b-f3a7-4c0d-a9aa-ceaf89e1fc7c"), new Guid("a4e67ba5-2bc5-4d5f-bdd9-e048a58cb9b1"), "Description of Book 197", 196, "Book 197" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("86e8b152-4783-440f-a166-3e34f5d33e0b"), new Guid("55d2234d-0e9f-48c9-9012-72f94728e4ab"), "Description of Book 142", 951, "Book 142" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9f3d08cc-1936-4c02-9f7a-fb7cdaa7f3f7"), new Guid("55d2234d-0e9f-48c9-9012-72f94728e4ab"), "Description of Book 157", 456, "Book 157" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("07c65abc-7903-413e-b44c-d427b7bd0796"), new Guid("aac7f072-66ae-4464-af4d-1f04e0681ebf"), "Description of Book 133", 200, "Book 133" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3d4368c1-4f14-44d3-a6ad-1f18c32dd60e"), new Guid("aac7f072-66ae-4464-af4d-1f04e0681ebf"), "Description of Book 73", 167, "Book 73" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9901833f-169c-4af1-b78e-0864901d67f2"), new Guid("aac7f072-66ae-4464-af4d-1f04e0681ebf"), "Description of Book 38", 842, "Book 38" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9a049ea7-f0eb-470b-8f2b-3dca0213720b"), new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), "Description of Book 198", 924, "Book 198" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("eab09986-abe5-4268-9708-20ab6941f8a0"), new Guid("0e89c268-1761-4245-95a0-a8d25653db64"), "Description of Book 24", 940, "Book 24" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("adf7e493-bc26-47d4-a372-bd987634669f"), new Guid("0e89c268-1761-4245-95a0-a8d25653db64"), "Description of Book 78", 568, "Book 78" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a1ac145a-0c1a-45de-9961-725aa0c24bfe"), new Guid("0e89c268-1761-4245-95a0-a8d25653db64"), "Description of Book 83", 196, "Book 83" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d3e30ff4-a1c9-41d5-99f4-77d9d6568e74"), new Guid("0e89c268-1761-4245-95a0-a8d25653db64"), "Description of Book 97", 502, "Book 97" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e97caac5-9dff-4090-a9b9-20e8920f35fe"), new Guid("0e89c268-1761-4245-95a0-a8d25653db64"), "Description of Book 98", 378, "Book 98" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e1c885ad-de06-4504-ba26-18b97ac810cf"), new Guid("0e89c268-1761-4245-95a0-a8d25653db64"), "Description of Book 186", 497, "Book 186" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d67dc5b8-58b3-4aa1-bc01-ff21f3d93059"), new Guid("be538507-d5f4-4d4d-b129-c1aa3752d1ac"), "Description of Book 31", 852, "Book 31" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c120154b-e053-45f1-960d-3ddfaa80cd43"), new Guid("be538507-d5f4-4d4d-b129-c1aa3752d1ac"), "Description of Book 37", 114, "Book 37" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c4586e99-4680-44e9-a404-ab47109ee88b"), new Guid("be538507-d5f4-4d4d-b129-c1aa3752d1ac"), "Description of Book 57", 817, "Book 57" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2310ecd6-5d9b-448c-8e90-eef94fd6ada0"), new Guid("be538507-d5f4-4d4d-b129-c1aa3752d1ac"), "Description of Book 152", 564, "Book 152" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("58b621bf-4ad9-4155-b286-b12e25c1ce22"), new Guid("be538507-d5f4-4d4d-b129-c1aa3752d1ac"), "Description of Book 169", 297, "Book 169" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9a753a58-4106-4a3d-bbcd-d1c3869977a1"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 32", 651, "Book 32" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("df775b45-e66f-4eb5-a7e9-c553a16f475d"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 44", 314, "Book 44" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d230ebc6-f352-4477-a726-f9ef116e8e7f"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 53", 158, "Book 53" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bf35b137-d262-450e-8b1d-afee79420f62"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 56", 388, "Book 56" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0719e26d-b8f0-4ccb-a2ba-c58eaa32adc4"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 86", 276, "Book 86" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ebd6bfb0-06dd-4d20-847d-ce0deb2fb8b8"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 112", 347, "Book 112" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0de7a8e6-e68c-4aad-a9d8-17486bbd4377"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 122", 687, "Book 122" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("fa5a346a-4911-43b9-9f3d-4c3443cdfe89"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 167", 246, "Book 167" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ab8fe58d-97a1-425d-bbc1-a1da2a42bdd1"), new Guid("5950c737-930b-42a6-8160-20e454438134"), "Description of Book 174", 653, "Book 174" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5a0f67e6-af98-4c7e-85a3-a81970e93876"), new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), "Description of Book 146", 657, "Book 146" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a9434919-7232-4934-9726-af611ddade94"), new Guid("c41c5a08-5b03-431c-b5a6-0387b2d3de20"), "Description of Book 82", 905, "Book 82" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6cd22000-f306-4603-8805-3bcaadd285c9"), new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), "Description of Book 96", 847, "Book 96" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6d8c6bf6-0eb0-42e0-afb3-5fafab54f3df"), new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), "Description of Book 39", 102, "Book 39" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1dc991f3-8ba9-4254-bf06-b4f9c1680a22"), new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"), "Description of Book 76", 464, "Book 76" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f12a38e3-4aba-49aa-ad06-ae4729223a8d"), new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"), "Description of Book 88", 132, "Book 88" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("894cc4dd-b568-45a2-90c3-3b1facf5b993"), new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"), "Description of Book 164", 925, "Book 164" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("eb97b083-153c-4fb1-a845-5cf0320dff3f"), new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"), "Description of Book 179", 748, "Book 179" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("905073de-5b2e-4e6e-a025-c467cd9b6875"), new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"), "Description of Book 188", 403, "Book 188" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6114015b-9854-4394-9071-9c5ee0003195"), new Guid("9838cc4a-9c63-4a2c-a02e-f08747497dae"), "Description of Book 101", 744, "Book 101" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d0af5e2c-ebe2-4d8e-ab6b-9a2ec77afb4e"), new Guid("9838cc4a-9c63-4a2c-a02e-f08747497dae"), "Description of Book 117", 335, "Book 117" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0e27e23a-e1b9-4823-ba92-6ca526efde75"), new Guid("6af26fd3-a516-4215-b68c-0aa6235c0f71"), "Description of Book 17", 716, "Book 17" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c4defc42-e5c6-4ea2-92e1-fa016ef7648a"), new Guid("6af26fd3-a516-4215-b68c-0aa6235c0f71"), "Description of Book 40", 334, "Book 40" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("94ca9009-6d84-4dbd-b56b-1c67d91c4b8d"), new Guid("6af26fd3-a516-4215-b68c-0aa6235c0f71"), "Description of Book 71", 416, "Book 71" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f4b7b9de-2f37-45e5-83c9-3740ef078f06"), new Guid("6af26fd3-a516-4215-b68c-0aa6235c0f71"), "Description of Book 109", 285, "Book 109" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0e313c4f-8d21-4ecd-baea-60eb9d7d784f"), new Guid("6af26fd3-a516-4215-b68c-0aa6235c0f71"), "Description of Book 194", 864, "Book 194" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ef618552-5856-41e9-a9d5-add6e03267c8"), new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), "Description of Book 35", 446, "Book 35" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ee3ad091-2eaf-4db3-a962-a481870a52ee"), new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), "Description of Book 113", 457, "Book 113" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3a1babef-d710-4879-ada8-02afe0407a43"), new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), "Description of Book 156", 156, "Book 156" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("86fd2745-9d4a-4a63-901d-a6f66344bfdb"), new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), "Description of Book 170", 827, "Book 170" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c5ace218-cda5-4013-85b4-8e000c44a4ac"), new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), "Description of Book 183", 442, "Book 183" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("272827f7-255c-4c2f-8c6d-92afb92230aa"), new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), "Description of Book 184", 759, "Book 184" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e655c420-c884-4e80-a37a-9c65657944c2"), new Guid("914f2617-bf88-400e-8344-4308463ff8ea"), "Description of Book 199", 808, "Book 199" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("46ed2ad1-b409-403d-9df0-ad21c749c25a"), new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), "Description of Book 16", 432, "Book 16" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0ae917c4-c364-40fd-a199-b1933e1c5612"), new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), "Description of Book 23", 784, "Book 23" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("35b12a03-5439-4631-a664-7e2f69a6aafe"), new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"), "Description of Book 59", 983, "Book 59" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("424c1a8e-f458-48a3-9b16-c5cb56db5869"), new Guid("c41c5a08-5b03-431c-b5a6-0387b2d3de20"), "Description of Book 105", 568, "Book 105" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2160473d-ec22-4a25-a75c-a4e373c73cda"), new Guid("c41c5a08-5b03-431c-b5a6-0387b2d3de20"), "Description of Book 195", 877, "Book 195" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f061f659-38b2-4d53-a492-5200686d292e"), new Guid("66b01e7d-726d-441b-a285-5a3008cb2ea2"), "Description of Book 11", 769, "Book 11" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("dd19e27b-91bc-4961-af7f-312d8ccf7949"), new Guid("b1063fb4-3460-4605-854c-043d7ccab073"), "Description of Book 4", 661, "Book 4" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d6c78c51-86e5-4b9e-be47-2f36aab3f74b"), new Guid("b1063fb4-3460-4605-854c-043d7ccab073"), "Description of Book 22", 808, "Book 22" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("32a94087-1a64-4b36-b34a-9ebfc0c83eb2"), new Guid("b1063fb4-3460-4605-854c-043d7ccab073"), "Description of Book 104", 637, "Book 104" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("44c467c3-ad98-4505-9d92-6934c98de578"), new Guid("b1063fb4-3460-4605-854c-043d7ccab073"), "Description of Book 163", 854, "Book 163" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d799c227-b252-4f52-9fc1-504bbea0cd4f"), new Guid("6e9cf294-5c68-4a74-b36d-02a25c30f118"), "Description of Book 79", 987, "Book 79" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c780a929-cc69-4236-b1d2-28cd94c7ed72"), new Guid("6e9cf294-5c68-4a74-b36d-02a25c30f118"), "Description of Book 141", 671, "Book 141" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b17886bb-1890-4d0e-8f0e-09d1c77dafc0"), new Guid("6e9cf294-5c68-4a74-b36d-02a25c30f118"), "Description of Book 181", 531, "Book 181" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f60ade86-55a1-4728-8c61-ce0137421dc4"), new Guid("6e9cf294-5c68-4a74-b36d-02a25c30f118"), "Description of Book 190", 512, "Book 190" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("8f8d5705-fe04-4578-bae6-43e854c10e08"), new Guid("ac6046eb-a770-4359-9f69-4c77eeb88036"), "Description of Book 80", 313, "Book 80" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d1768229-fb08-4da6-a9ca-eab4fc8c292f"), new Guid("ac6046eb-a770-4359-9f69-4c77eeb88036"), "Description of Book 111", 767, "Book 111" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("598bcd40-250b-4cee-8902-d1b94825db8c"), new Guid("12e2aa10-dc45-4d53-bfd8-09e1e1d62c36"), "Description of Book 60", 818, "Book 60" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4e65b505-7711-456b-9591-ec5cbc948916"), new Guid("12e2aa10-dc45-4d53-bfd8-09e1e1d62c36"), "Description of Book 185", 751, "Book 185" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("53140263-010e-45e1-9cf9-50fb191cf1c2"), new Guid("1da624e4-4cd4-45ef-8fa7-904660c659b6"), "Description of Book 126", 745, "Book 126" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("341f1cfa-269c-4f5b-a2a4-0d219fa60faf"), new Guid("1da624e4-4cd4-45ef-8fa7-904660c659b6"), "Description of Book 150", 128, "Book 150" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("58edcffb-8e9b-4f04-ae7c-e0874d7ed0a2"), new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), "Description of Book 55", 897, "Book 55" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2dbaaab5-3150-4dc1-bc63-16fb63709c95"), new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), "Description of Book 58", 443, "Book 58" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("dc714dc5-79a4-4bfd-89a2-7fc1c384951e"), new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), "Description of Book 94", 284, "Book 94" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b3a29f7f-4a41-4d51-8ab9-9af616733631"), new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), "Description of Book 125", 721, "Book 125" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("382f9df7-d90a-4516-850b-4112aa9a36bf"), new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), "Description of Book 128", 884, "Book 128" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ed9110ce-a5f1-45e4-8fb7-1a972d7dae6b"), new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), "Description of Book 159", 916, "Book 159" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d1e114e9-bcd6-4b59-a3eb-b136b46f6ad3"), new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"), "Description of Book 200", 868, "Book 200" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("fafa4788-b0dd-4ec8-88f2-65b692990f3c"), new Guid("b1063fb4-3460-4605-854c-043d7ccab073"), "Description of Book 1", 195, "Book 1" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0f7c3efc-04cf-4bc8-8374-07d2e250b52a"), new Guid("7fde27df-0720-4508-a724-225644057296"), "Description of Book 172", 776, "Book 172" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6c4c2db6-8ef4-4347-adcd-920233f0dc66"), new Guid("7fde27df-0720-4508-a724-225644057296"), "Description of Book 110", 531, "Book 110" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7eb649d7-55f8-4bca-a034-d3b8dde06545"), new Guid("7fde27df-0720-4508-a724-225644057296"), "Description of Book 99", 467, "Book 99" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5fe5bda9-c368-4d58-a035-5554d7f05c10"), new Guid("66b01e7d-726d-441b-a285-5a3008cb2ea2"), "Description of Book 34", 705, "Book 34" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("090e2f44-8dbd-4bcc-aa04-40efb41c951a"), new Guid("66b01e7d-726d-441b-a285-5a3008cb2ea2"), "Description of Book 66", 217, "Book 66" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c8b04d99-9353-4330-8aca-5a1c489002b2"), new Guid("66b01e7d-726d-441b-a285-5a3008cb2ea2"), "Description of Book 140", 438, "Book 140" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7782db63-4d97-41a9-9d65-dc8cd22d25c7"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 3", 382, "Book 3" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c5f6d9db-d182-4b0d-bf36-986c533cb4eb"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 10", 699, "Book 10" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3a1fde4a-0f65-4085-b197-4f0a9b7bfd51"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 45", 953, "Book 45" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c27512ad-f52a-40e2-a871-9c185c9b84ee"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 93", 860, "Book 93" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("18ab40f5-9333-44d4-b1f8-1a25f78288c7"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 168", 305, "Book 168" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bccb0704-11c4-4cdc-a1f8-da42456b5b0b"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 171", 213, "Book 171" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f82e510b-8aa3-46dc-9bcd-ba520702cac8"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 177", 840, "Book 177" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bcb6a6a8-1e0e-4dc1-9954-327da5913ef7"), new Guid("98bbda9f-ca80-4fa6-88ef-663076df5d1f"), "Description of Book 5", 656, "Book 5" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("94476030-c45a-4995-8452-c22c1134a613"), new Guid("85698543-5e55-449d-a5a6-470b95697679"), "Description of Book 180", 163, "Book 180" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("645a9ca1-4dc2-42f2-91bf-3d6da4834685"), new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"), "Description of Book 30", 364, "Book 30" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ec9ca7cd-f625-40db-ac06-fbed85eaf3be"), new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"), "Description of Book 115", 744, "Book 115" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d6615fab-a697-4cea-8129-ad5cde92a10e"), new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"), "Description of Book 118", 938, "Book 118" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a22419a8-0126-43b7-bf4e-1e1097636931"), new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"), "Description of Book 158", 378, "Book 158" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9d98382a-ebfc-43f7-8793-6a6219f87f8c"), new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"), "Description of Book 189", 944, "Book 189" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d59fab14-e5db-48c9-802a-5da2198a42a2"), new Guid("0b2619be-9ed2-495e-a1fc-ae0e5e9eb6c5"), "Description of Book 196", 950, "Book 196" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4800df28-2964-4d9d-bd48-6986745c7746"), new Guid("832be0a3-3a91-4a50-91a3-264bd3e37fe5"), "Description of Book 54", 393, "Book 54" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a50cfa0b-f425-4dde-87d8-95480f911603"), new Guid("832be0a3-3a91-4a50-91a3-264bd3e37fe5"), "Description of Book 65", 848, "Book 65" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b30ead74-1618-42bd-9a94-06563429eb69"), new Guid("832be0a3-3a91-4a50-91a3-264bd3e37fe5"), "Description of Book 74", 517, "Book 74" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b4858dcc-41f8-4e92-ad44-ef5937fcc513"), new Guid("7fde27df-0720-4508-a724-225644057296"), "Description of Book 72", 874, "Book 72" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("24d33006-e50e-495a-a782-a30075b1d2e6"), new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"), "Description of Book 20", 387, "Book 20" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2c7359e5-eb4d-457d-9c54-3b4630045334"), new Guid("98bbda9f-ca80-4fa6-88ef-663076df5d1f"), "Description of Book 8", 234, "Book 8" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70927fba-52d8-41c4-a256-3a1125e567c2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("97788741-ae3d-451e-bed4-645a9edfd224"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00e117cc-f08b-47b2-96ec-c70856d78968"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0719e26d-b8f0-4ccb-a2ba-c58eaa32adc4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("07c65abc-7903-413e-b44c-d427b7bd0796"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("090e2f44-8dbd-4bcc-aa04-40efb41c951a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ae917c4-c364-40fd-a199-b1933e1c5612"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0bbf1dfe-c0d5-4c24-8596-096a65f5c3f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0de7a8e6-e68c-4aad-a9d8-17486bbd4377"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e27e23a-e1b9-4823-ba92-6ca526efde75"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e313c4f-8d21-4ecd-baea-60eb9d7d784f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0f7c3efc-04cf-4bc8-8374-07d2e250b52a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0fdac72b-fc18-4e94-bc9b-1bd2aa9ee3f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("113f6017-e3dd-4e60-acbe-9da4e3be67ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12cc420f-d696-40af-9114-58a013829b20"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("165b23f1-efcc-4f14-bd5e-c955d7b2901f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18ab40f5-9333-44d4-b1f8-1a25f78288c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18e3f568-aabb-4f6d-9e83-112a541cb80c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1caac841-0321-450c-bef7-d5cee81e932f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d70e27d-2c77-4b53-9e87-f6399de489cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1dc991f3-8ba9-4254-bf06-b4f9c1680a22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2160473d-ec22-4a25-a75c-a4e373c73cda"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2310ecd6-5d9b-448c-8e90-eef94fd6ada0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24d33006-e50e-495a-a782-a30075b1d2e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("272827f7-255c-4c2f-8c6d-92afb92230aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("276119ec-5bb8-4320-a62f-05a3cb224878"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2c7359e5-eb4d-457d-9c54-3b4630045334"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2dbaaab5-3150-4dc1-bc63-16fb63709c95"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e8b7532-e90a-4e39-be7e-e72d4ab3cca3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("309bcce9-bc37-4641-b9c5-77a56008a672"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("315f2f10-f86a-4eea-8450-9b521722d7d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("318a309b-706a-41a1-90a0-ac3fdf51c2c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("32a94087-1a64-4b36-b34a-9ebfc0c83eb2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("33261d6d-53e3-4e82-a561-c132b89c6d4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("33d96eb6-dc33-4652-9a4a-33b14f0abd6b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("341f1cfa-269c-4f5b-a2a4-0d219fa60faf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("35b12a03-5439-4631-a664-7e2f69a6aafe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3641a61d-2e7d-4386-912f-6f5e7aefd547"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("37c01178-a225-412c-b680-a4cbbab3de98"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("37c5c835-4d42-4f29-9581-6cf27ba3efc2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("382f9df7-d90a-4516-850b-4112aa9a36bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3a1babef-d710-4879-ada8-02afe0407a43"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3a1fde4a-0f65-4085-b197-4f0a9b7bfd51"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3a4e73e0-81bf-45fc-bbf3-2c3e5dffdd1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3be63747-4b12-4c50-a31a-54acd7a5312c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3d4368c1-4f14-44d3-a6ad-1f18c32dd60e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3ef76b04-50ac-457d-9180-d3aab4c4d21e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4110efa7-0b57-42f2-a146-ad12284525b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41403c66-05d8-422e-802e-e0d78e09ec5e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4186e576-b9a5-4be1-9e8b-0027e01b31cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("424c1a8e-f458-48a3-9b16-c5cb56db5869"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("44c467c3-ad98-4505-9d92-6934c98de578"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46ed2ad1-b409-403d-9df0-ad21c749c25a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4800df28-2964-4d9d-bd48-6986745c7746"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49ba49d5-6ea4-47fd-bdea-4b1510d278b4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49bef47c-2505-497b-9587-82111d31fb4c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49ecee3f-f4fd-4717-915d-bf46cb66e864"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4c45602f-8132-45c1-bf37-58cb202789a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e65b505-7711-456b-9591-ec5cbc948916"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53140263-010e-45e1-9cf9-50fb191cf1c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("54d619ef-5d2a-44ca-bb67-9db07c0c3dd8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("56e85eec-8b4e-4524-820a-68e50b1796a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5711bb2d-10fd-45aa-8c68-e2793d7ba7fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58b621bf-4ad9-4155-b286-b12e25c1ce22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58edcffb-8e9b-4f04-ae7c-e0874d7ed0a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("598bcd40-250b-4cee-8902-d1b94825db8c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5a0f67e6-af98-4c7e-85a3-a81970e93876"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b4ae9cc-ef58-45cb-a065-276f378cc8e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5e32b1ae-b199-4cb0-8f04-8423ac674ee3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5fe5bda9-c368-4d58-a035-5554d7f05c10"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("605460a2-666e-4a7a-a384-98e79f4d8a5d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6114015b-9854-4394-9071-9c5ee0003195"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("62c30d1d-5f3e-4778-a40a-3d1287dfbd36"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("645a9ca1-4dc2-42f2-91bf-3d6da4834685"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68788150-1763-4ce0-a440-e0154ff8764c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68c5288b-f3a7-4c0d-a9aa-ceaf89e1fc7c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6a9240f0-a46a-4803-b127-71d8d08e01f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c4c2db6-8ef4-4347-adcd-920233f0dc66"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6cd22000-f306-4603-8805-3bcaadd285c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d8c6bf6-0eb0-42e0-afb3-5fafab54f3df"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("705a6c81-a5ac-488e-8d2b-811d1201b3bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7258f0d7-9086-4c26-a63e-bdb7ee119ab7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("734ae02d-76cd-4c24-9659-e6aee440647a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("73562932-b2e7-4160-8691-67c90505ad67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7782db63-4d97-41a9-9d65-dc8cd22d25c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78ced542-4b94-4fb8-a67c-689f0c3d8171"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7bc625ff-de21-434d-9326-2bf91e90ab09"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e13c471-5e84-43b1-8927-493e11549a6d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7eb649d7-55f8-4bca-a034-d3b8dde06545"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81610093-621f-4d20-b594-9c3f2b04dae2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("83c422e1-8409-46d4-ba77-8e9572da1ca5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8416f5e3-292d-4478-aae3-62d8a8853239"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86bca2f8-efbd-4c0a-8392-cf626bd01045"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86e8b152-4783-440f-a166-3e34f5d33e0b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86fd2745-9d4a-4a63-901d-a6f66344bfdb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("894cc4dd-b568-45a2-90c3-3b1facf5b993"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8a200b57-0ccf-4fa6-89bc-728ba6fc0209"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f8d5705-fe04-4578-bae6-43e854c10e08"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("902f7cfb-ceee-4e97-9ced-807f986a3b43"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("905073de-5b2e-4e6e-a025-c467cd9b6875"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94476030-c45a-4995-8452-c22c1134a613"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94ca9009-6d84-4dbd-b56b-1c67d91c4b8d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("95061585-932b-46e4-8f51-7f42f6880a5b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9901833f-169c-4af1-b78e-0864901d67f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a049ea7-f0eb-470b-8f2b-3dca0213720b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a753a58-4106-4a3d-bbcd-d1c3869977a1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9af32559-4e3a-4255-b5e8-c544fbb66c37"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9cdac809-cb68-4543-8add-97ce1ea556dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9d98382a-ebfc-43f7-8793-6a6219f87f8c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f3d08cc-1936-4c02-9f7a-fb7cdaa7f3f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a14461f0-8cd1-4a4a-bb2c-f88b4e61f1de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1ac145a-0c1a-45de-9961-725aa0c24bfe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1d67f60-7fe9-498b-a141-2c2200e5235f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a22419a8-0126-43b7-bf4e-1e1097636931"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a2fbe1e9-73d5-4fb0-9b73-62d52b5df04a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a50cfa0b-f425-4dde-87d8-95480f911603"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9434919-7232-4934-9726-af611ddade94"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ab8fe58d-97a1-425d-bbc1-a1da2a42bdd1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ace1f1a6-a07e-4df5-b59d-485e7e32a724"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("adf7e493-bc26-47d4-a372-bd987634669f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aee1ff59-58aa-4f43-b82e-cdf8f4456b60"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b17886bb-1890-4d0e-8f0e-09d1c77dafc0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b30ead74-1618-42bd-9a94-06563429eb69"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b33588a0-27cc-4dc8-aaa9-b6aa5157ad5e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3707c57-b223-4506-9fde-bfcb39b87a93"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3a29f7f-4a41-4d51-8ab9-9af616733631"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3e9ef41-781b-4f52-a72e-3ded0413d276"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3fc4e1c-1bb1-4ef1-b256-5e4a5dfae249"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4858dcc-41f8-4e92-ad44-ef5937fcc513"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b48fb3a5-f326-4a97-8425-6bba80dfeca2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b74bd30d-6077-46c4-9360-c11e3428002d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b880e227-d486-43bc-b5be-dba383e4edb2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b96dd4d3-6b8a-4a4f-9db5-a9ab04004427"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb031cb9-d079-4dac-a1aa-390032439fa1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bcb6a6a8-1e0e-4dc1-9954-327da5913ef7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bccb0704-11c4-4cdc-a1f8-da42456b5b0b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bf35b137-d262-450e-8b1d-afee79420f62"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bf3d02af-a83a-4a74-afe4-6bf7afc5185f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c120154b-e053-45f1-960d-3ddfaa80cd43"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c27512ad-f52a-40e2-a871-9c185c9b84ee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c2fbe230-138a-4aa1-a0fa-33de0ec48986"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c386f59b-6573-41ec-adeb-0d26e034f2e1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c4586e99-4680-44e9-a404-ab47109ee88b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c4defc42-e5c6-4ea2-92e1-fa016ef7648a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c5ace218-cda5-4013-85b4-8e000c44a4ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c5f6d9db-d182-4b0d-bf36-986c533cb4eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c780a929-cc69-4236-b1d2-28cd94c7ed72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c8b04d99-9353-4330-8aca-5a1c489002b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("caebe704-0ef5-4511-9df8-0f3e0d77a5a1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbc79001-17c4-4ef6-9cc8-292a052b4213"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cdc12479-1f7d-4d50-97ce-157d68cc2f86"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cdc45ce1-0a60-443b-8e2a-5710b31a4796"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cf3d550c-e664-4926-bf97-77f5b28f1c4b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d00ae3c3-a01e-42d1-a229-48e0cd5dc95d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d0af5e2c-ebe2-4d8e-ab6b-9a2ec77afb4e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1768229-fb08-4da6-a9ca-eab4fc8c292f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d19996a3-7b7d-4525-86bf-bcced704b8d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1e114e9-bcd6-4b59-a3eb-b136b46f6ad3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d230ebc6-f352-4477-a726-f9ef116e8e7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3e30ff4-a1c9-41d5-99f4-77d9d6568e74"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d4882482-3f02-4386-952c-4410a6215bbf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d59fab14-e5db-48c9-802a-5da2198a42a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6615fab-a697-4cea-8129-ad5cde92a10e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d67dc5b8-58b3-4aa1-bc01-ff21f3d93059"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6c78c51-86e5-4b9e-be47-2f36aab3f74b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d799c227-b252-4f52-9fc1-504bbea0cd4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d806ca05-526a-4202-9c75-570f76bcae53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc139f1c-990e-473b-a1d6-87463bc35941"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc714dc5-79a4-4bfd-89a2-7fc1c384951e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dd19e27b-91bc-4961-af7f-312d8ccf7949"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df1fee1d-39c3-4c50-8600-148499870e0f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df775b45-e66f-4eb5-a7e9-c553a16f475d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e0e31b18-1de3-4c53-a43d-9e1d06344edd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e1c885ad-de06-4504-ba26-18b97ac810cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e39d8c26-76ea-4bd7-a3c8-d5421bdb2980"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e655c420-c884-4e80-a37a-9c65657944c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e78afcbd-4642-4065-b832-06d1f7d0f6e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e97caac5-9dff-4090-a9b9-20e8920f35fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea39a6b8-f6c6-4587-b3d9-c218de369182"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eab09986-abe5-4268-9708-20ab6941f8a0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eb97b083-153c-4fb1-a845-5cf0320dff3f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ebd6bfb0-06dd-4d20-847d-ce0deb2fb8b8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ebfb1a36-a9ae-4ac2-a6fc-30ffb68f955f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec2bd8f9-dc90-4abf-9509-d0ab14c21bfa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec51e1ae-a148-4709-9158-1ec94e9aaeeb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec9ca7cd-f625-40db-ac06-fbed85eaf3be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ed9110ce-a5f1-45e4-8fb7-1a972d7dae6b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ee3ad091-2eaf-4db3-a962-a481870a52ee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef618552-5856-41e9-a9d5-add6e03267c8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f061f659-38b2-4d53-a492-5200686d292e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f119bccd-84a9-4639-8f6f-ee0abea484f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f12a38e3-4aba-49aa-ad06-ae4729223a8d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f2310c0e-e9e8-4837-b349-eaebf7bfd67e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f3bf4214-2085-40d7-bda3-55a6390bfebd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4b7b9de-2f37-45e5-83c9-3740ef078f06"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5c9eca7-bb2e-4155-a3dd-a299028d6653"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f60ade86-55a1-4728-8c61-ce0137421dc4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f61c3c1d-b056-4050-97a9-114747da0018"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f82e510b-8aa3-46dc-9bcd-ba520702cac8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa5a346a-4911-43b9-9f3d-4c3443cdfe89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fafa4788-b0dd-4ec8-88f2-65b692990f3c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb354533-9792-4c83-8761-f025417c4b53"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("04df928e-1dde-427b-8fc0-0f4e16d3cb0c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0b2619be-9ed2-495e-a1fc-ae0e5e9eb6c5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0e0a611e-9b0c-4f44-ac27-3f4c3714111e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0e89c268-1761-4245-95a0-a8d25653db64"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("12c337ae-2c6b-4f82-a0a4-6648300bcbc0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("12e2aa10-dc45-4d53-bfd8-09e1e1d62c36"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1da624e4-4cd4-45ef-8fa7-904660c659b6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("358fb857-660b-492a-8cb2-8b90f954ebab"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3c199aef-c98e-4953-9dd0-83d3e70ee043"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("55d2234d-0e9f-48c9-9012-72f94728e4ab"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5950c737-930b-42a6-8160-20e454438134"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5f3e31ef-76cd-49da-9b23-23292ea6a065"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("65e69e0c-8698-4d27-a4ce-ce48f2e39ba3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("66b01e7d-726d-441b-a285-5a3008cb2ea2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("69b59b39-b974-48ac-a394-3eb513892e27"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6af26fd3-a516-4215-b68c-0aa6235c0f71"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6e9cf294-5c68-4a74-b36d-02a25c30f118"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("753ea4f3-6ada-47f5-997a-aceef53e9167"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7fde27df-0720-4508-a724-225644057296"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("832be0a3-3a91-4a50-91a3-264bd3e37fe5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("85698543-5e55-449d-a5a6-470b95697679"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("914f2617-bf88-400e-8344-4308463ff8ea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("920818ed-a03b-432a-9343-f1eb5d31836c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("942caf13-db29-4a17-ad61-56b5fbaf3b1a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("95b7b100-867e-43c7-8a46-af273fede5ff"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9838cc4a-9c63-4a2c-a02e-f08747497dae"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("98bbda9f-ca80-4fa6-88ef-663076df5d1f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("98cec19b-0fde-4174-91e7-1c5df9a113e6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9c2d67dc-d734-465b-951f-7211899db4d4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9fc0b6cd-f3f2-4e99-87f2-ba7c29ac800d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a4e67ba5-2bc5-4d5f-bdd9-e048a58cb9b1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a912487a-9d0e-4fcb-95f4-8b5bcfac4365"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("aac7f072-66ae-4464-af4d-1f04e0681ebf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("abe987d3-5bab-486f-9799-7ce7568a4c7b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac6046eb-a770-4359-9f69-4c77eeb88036"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("af99b205-e970-4405-afe7-779cf584dd69"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b1063fb4-3460-4605-854c-043d7ccab073"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b8ab45b8-3546-43ca-88a4-1aeae70b7394"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("be538507-d5f4-4d4d-b129-c1aa3752d1ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c2f01b5a-fda9-4f6e-9778-0dca90c8309c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c41c5a08-5b03-431c-b5a6-0387b2d3de20"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c6e82e8b-7254-462e-9a40-d0660190e37f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ca3a9664-2a45-404b-a5b0-d102137c8d4e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dd647a2f-8429-41bb-b61d-92b220591a61"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e51c1fd5-e202-4317-b006-e3db6905d77e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8d8d4c9-b05c-457d-afdd-9b5d076854df"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e30678-fb0b-4b1c-bf82-271e47b128e6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f49231d9-2752-4917-8107-ee96f1ce1571"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), new DateTimeOffset(new DateTime(1959, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author1@deali.cn", "Author 1" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("c11e353a-77bd-40e7-abba-3f54d453ed39"), new DateTimeOffset(new DateTime(1998, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author28@deali.cn", "Author 28" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("fb53852b-8fda-4daf-931f-7a54a6d8389c"), new DateTimeOffset(new DateTime(1950, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author29@deali.cn", "Author 29" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("9c765781-15bd-4bbc-ace8-deecffb33666"), new DateTimeOffset(new DateTime(2001, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author30@deali.cn", "Author 30" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("523618c9-d2b0-42e5-a51c-8116f86bd6e0"), new DateTimeOffset(new DateTime(1980, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author31@deali.cn", "Author 31" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("afb2e8fc-d060-401e-b60b-14463ddf42a2"), new DateTimeOffset(new DateTime(1953, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author32@deali.cn", "Author 32" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"), new DateTimeOffset(new DateTime(1963, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author33@deali.cn", "Author 33" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("24c08daa-52d5-4f07-ac73-9ba92cfe4ee1"), new DateTimeOffset(new DateTime(1957, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author34@deali.cn", "Author 34" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("72845848-5359-404c-b187-be5d964bc71d"), new DateTimeOffset(new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author35@deali.cn", "Author 35" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"), new DateTimeOffset(new DateTime(2004, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author36@deali.cn", "Author 36" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("adab38da-ca11-4d57-a9a8-98ffa4e7ded9"), new DateTimeOffset(new DateTime(1958, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author37@deali.cn", "Author 37" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("09857bd8-94f9-4f22-88fc-7bcadf73faea"), new DateTimeOffset(new DateTime(1998, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author38@deali.cn", "Author 38" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), new DateTimeOffset(new DateTime(1978, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author39@deali.cn", "Author 39" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("76c729e7-6c99-4a8e-b9c2-e2b4ed6af182"), new DateTimeOffset(new DateTime(1969, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author40@deali.cn", "Author 40" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"), new DateTimeOffset(new DateTime(1955, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author41@deali.cn", "Author 41" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("cf83ff2b-ff2f-481c-8aa3-aeb79a2ff5e3"), new DateTimeOffset(new DateTime(1976, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author42@deali.cn", "Author 42" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("748ba6c1-872f-4c3b-920d-ff85de509683"), new DateTimeOffset(new DateTime(1990, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author43@deali.cn", "Author 43" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("81e9697b-3882-4c8b-8b81-f923af34e9ba"), new DateTimeOffset(new DateTime(1953, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author44@deali.cn", "Author 44" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("54a90c07-9a74-45b1-8605-2380c3a863b5"), new DateTimeOffset(new DateTime(1977, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author45@deali.cn", "Author 45" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("187038ba-5795-4705-a9e7-add2de31ac95"), new DateTimeOffset(new DateTime(1970, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author46@deali.cn", "Author 46" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("79954558-382c-4914-8014-6e8fe546a39b"), new DateTimeOffset(new DateTime(1976, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author47@deali.cn", "Author 47" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("fba94512-5eab-4d20-b81a-08b177aca7c4"), new DateTimeOffset(new DateTime(1967, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author48@deali.cn", "Author 48" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("02e743e9-a8b2-44ed-ab6b-e08ee620ca1a"), new DateTimeOffset(new DateTime(1952, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author27@deali.cn", "Author 27" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("c99af5ff-cd36-4e0e-8eb5-d7fcb04fba56"), new DateTimeOffset(new DateTime(1956, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author26@deali.cn", "Author 26" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"), new DateTimeOffset(new DateTime(1983, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author25@deali.cn", "Author 25" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("09993863-7b77-4499-bddc-ce1f3a5ee200"), new DateTimeOffset(new DateTime(1990, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author24@deali.cn", "Author 24" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("c2a01334-a8c5-4c24-88b9-be8e75bc7db4"), new DateTimeOffset(new DateTime(2002, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author2@deali.cn", "Author 2" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("8fbe6528-8969-4ae9-855b-3724e60d777d"), new DateTimeOffset(new DateTime(1956, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author3@deali.cn", "Author 3" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("a3dc2e00-e015-43a5-9cef-00a0988ee396"), new DateTimeOffset(new DateTime(1992, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author4@deali.cn", "Author 4" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"), new DateTimeOffset(new DateTime(1969, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author5@deali.cn", "Author 5" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("16932bc6-4083-4646-8d60-0ecac6a29a38"), new DateTimeOffset(new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author6@deali.cn", "Author 6" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("28839dc4-58a3-4c24-a7a0-9b0781f48463"), new DateTimeOffset(new DateTime(1962, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author7@deali.cn", "Author 7" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("66910241-9135-468b-9aa2-4030cd5fa589"), new DateTimeOffset(new DateTime(1975, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author8@deali.cn", "Author 8" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("8d3934e8-0185-4c59-a116-fb0e4334fdf7"), new DateTimeOffset(new DateTime(1960, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author9@deali.cn", "Author 9" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("a35700ad-9775-466a-80e2-7645e9388589"), new DateTimeOffset(new DateTime(1960, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author10@deali.cn", "Author 10" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), new DateTimeOffset(new DateTime(1970, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Beijing", "author11@deali.cn", "Author 11" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"), new DateTimeOffset(new DateTime(1988, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author49@deali.cn", "Author 49" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("bcb5e4c3-5b0e-45f5-80a4-4dfa132493de"), new DateTimeOffset(new DateTime(1964, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author12@deali.cn", "Author 12" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("0add9e3e-8145-4fa4-9b16-059cbef40052"), new DateTimeOffset(new DateTime(2007, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author14@deali.cn", "Author 14" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("4d85a9e7-b603-4337-bcf0-de71b5f86473"), new DateTimeOffset(new DateTime(1979, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author15@deali.cn", "Author 15" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("0212b86f-b98c-47af-8edb-abc059e3c093"), new DateTimeOffset(new DateTime(1974, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author16@deali.cn", "Author 16" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("23fce496-3b8c-4521-91f4-1f738b928be5"), new DateTimeOffset(new DateTime(2007, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author17@deali.cn", "Author 17" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("a1bde1d8-dc7a-4fd2-a7e9-0f18bcd2e585"), new DateTimeOffset(new DateTime(2005, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author18@deali.cn", "Author 18" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("8d08c335-8015-424c-8cb4-d2886bc4d2c9"), new DateTimeOffset(new DateTime(1950, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author19@deali.cn", "Author 19" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), new DateTimeOffset(new DateTime(2005, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author20@deali.cn", "Author 20" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("6c6bb470-968b-41a9-b25c-a4d7d1ee8f27"), new DateTimeOffset(new DateTime(2003, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "ToKyo", "author21@deali.cn", "Author 21" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("ce411af8-f7fa-4b3c-bccb-6b660efde51c"), new DateTimeOffset(new DateTime(1969, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Shanghai", "author22@deali.cn", "Author 22" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("4eee913f-abcb-4f6c-89d2-56995e42f280"), new DateTimeOffset(new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "HongKong", "author23@deali.cn", "Author 23" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("1834e14f-7987-47d9-94d4-c44cda205724"), new DateTimeOffset(new DateTime(1986, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "NewYork", "author13@deali.cn", "Author 13" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("6d388830-a3cc-45d2-8016-8ed4ccbbae1b"), new DateTimeOffset(new DateTime(1954, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London", "author50@deali.cn", "Author 50" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("09d1bf4e-9ac4-4d17-9305-1d44b2ce77ac"), new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), "Description of Book 3", 876, "Book 3" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("aa2388dd-3f90-4f74-bc3d-59b38a54fa6a"), new Guid("24c08daa-52d5-4f07-ac73-9ba92cfe4ee1"), "Description of Book 5", 130, "Book 5" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("65b21c86-e4ae-4570-bbb9-801357a172f4"), new Guid("24c08daa-52d5-4f07-ac73-9ba92cfe4ee1"), "Description of Book 60", 319, "Book 60" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("fbc8f147-771a-49d0-a914-8726621a0a28"), new Guid("24c08daa-52d5-4f07-ac73-9ba92cfe4ee1"), "Description of Book 84", 288, "Book 84" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1a54122c-ca72-41b1-80b4-c20f8c4507d8"), new Guid("24c08daa-52d5-4f07-ac73-9ba92cfe4ee1"), "Description of Book 114", 114, "Book 114" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("04cb583f-7e36-42ae-a4bb-faea5e6fd240"), new Guid("24c08daa-52d5-4f07-ac73-9ba92cfe4ee1"), "Description of Book 145", 618, "Book 145" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("40ae8a4c-894c-4a5d-8c45-c1f7fc63e9a5"), new Guid("72845848-5359-404c-b187-be5d964bc71d"), "Description of Book 25", 919, "Book 25" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("64890527-5d3d-4778-aeea-b1ea279c0aa4"), new Guid("72845848-5359-404c-b187-be5d964bc71d"), "Description of Book 78", 612, "Book 78" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e3c08f4c-07e0-4849-8af4-95e4415af77b"), new Guid("72845848-5359-404c-b187-be5d964bc71d"), "Description of Book 130", 331, "Book 130" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("712da5b4-285b-48da-8a2c-1badc9562080"), new Guid("72845848-5359-404c-b187-be5d964bc71d"), "Description of Book 142", 422, "Book 142" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("54c93a59-3729-4e96-aaef-85bdb07ed966"), new Guid("72845848-5359-404c-b187-be5d964bc71d"), "Description of Book 171", 520, "Book 171" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b325b074-410c-4815-b3ec-5546091ba285"), new Guid("72845848-5359-404c-b187-be5d964bc71d"), "Description of Book 195", 113, "Book 195" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("8e62bcb6-21cb-4d92-ae79-95c10a0c6b28"), new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"), "Description of Book 36", 989, "Book 36" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("89024689-3cdf-4b1e-ad88-7a212e5910ca"), new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"), "Description of Book 37", 913, "Book 37" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("687399ff-9ae0-4150-b3f3-9d933c04598f"), new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"), "Description of Book 64", 696, "Book 64" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("00f75ce6-710a-4320-94a9-2db76f1de87f"), new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"), "Description of Book 96", 681, "Book 96" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6085ff29-659b-461f-820e-bab66c6bb03c"), new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"), "Description of Book 147", 932, "Book 147" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("07874f6b-45c8-4797-a9f7-c8ad0f7149d7"), new Guid("11e5bbde-ce35-4007-b4e8-1b2383487c62"), "Description of Book 176", 820, "Book 176" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("76515c72-2016-41c3-9e2e-905dd19a16cc"), new Guid("adab38da-ca11-4d57-a9a8-98ffa4e7ded9"), "Description of Book 86", 871, "Book 86" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ad4fce47-71b0-4c06-881b-df5f123a7f10"), new Guid("adab38da-ca11-4d57-a9a8-98ffa4e7ded9"), "Description of Book 127", 542, "Book 127" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("95b3c170-f14f-4157-897b-3ec19bb3cb82"), new Guid("adab38da-ca11-4d57-a9a8-98ffa4e7ded9"), "Description of Book 128", 479, "Book 128" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bb78dcaa-c3ff-4029-967b-cf9ceeffef89"), new Guid("adab38da-ca11-4d57-a9a8-98ffa4e7ded9"), "Description of Book 159", 278, "Book 159" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5f142242-cf91-4e47-aff4-0e222fb69e1f"), new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"), "Description of Book 191", 512, "Book 191" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f269b7c8-bde2-454b-8bab-7f2e5e6167d4"), new Guid("09857bd8-94f9-4f22-88fc-7bcadf73faea"), "Description of Book 13", 456, "Book 13" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4e69f986-5f6e-4641-87cb-053313573e72"), new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"), "Description of Book 179", 624, "Book 179" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("38b8f6c8-9f88-4d92-82e2-86f3ae05bd5f"), new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"), "Description of Book 121", 241, "Book 121" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0b80c500-8f0c-4edc-b03d-5207cc674a5e"), new Guid("c99af5ff-cd36-4e0e-8eb5-d7fcb04fba56"), "Description of Book 42", 284, "Book 42" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("034e8dac-c56e-40ed-b780-075f428e4249"), new Guid("02e743e9-a8b2-44ed-ab6b-e08ee620ca1a"), "Description of Book 33", 912, "Book 33" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("41ff040f-fbc2-4724-8e66-51adfedb5b67"), new Guid("02e743e9-a8b2-44ed-ab6b-e08ee620ca1a"), "Description of Book 119", 592, "Book 119" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("18df23f2-716e-48b9-b4cf-f4e58dba1abb"), new Guid("02e743e9-a8b2-44ed-ab6b-e08ee620ca1a"), "Description of Book 149", 358, "Book 149" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("13895329-f24c-453c-87ec-d5616cabed0b"), new Guid("02e743e9-a8b2-44ed-ab6b-e08ee620ca1a"), "Description of Book 174", 304, "Book 174" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("06a8b03b-7caa-49a4-97eb-83edd7c922c1"), new Guid("02e743e9-a8b2-44ed-ab6b-e08ee620ca1a"), "Description of Book 188", 379, "Book 188" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("76d735bd-a274-41b8-b57b-4d27f2a80a62"), new Guid("c11e353a-77bd-40e7-abba-3f54d453ed39"), "Description of Book 6", 111, "Book 6" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("44f8c913-cfca-4c8e-aa2e-0a7716d97ca0"), new Guid("c11e353a-77bd-40e7-abba-3f54d453ed39"), "Description of Book 80", 754, "Book 80" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("fdb84b2e-6813-4742-a0ed-38dfac46d438"), new Guid("fb53852b-8fda-4daf-931f-7a54a6d8389c"), "Description of Book 31", 747, "Book 31" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("69a90b10-35c1-4f52-8bd7-dcb7c6feb943"), new Guid("fb53852b-8fda-4daf-931f-7a54a6d8389c"), "Description of Book 166", 838, "Book 166" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a9230bbf-27b1-4e82-8ffb-7c277aa98280"), new Guid("fb53852b-8fda-4daf-931f-7a54a6d8389c"), "Description of Book 177", 687, "Book 177" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5f63a1f2-55bc-4917-b483-2aef29f220b8"), new Guid("9c765781-15bd-4bbc-ace8-deecffb33666"), "Description of Book 14", 171, "Book 14" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2dba00b9-3875-47d0-85f8-b33571d59c69"), new Guid("9c765781-15bd-4bbc-ace8-deecffb33666"), "Description of Book 24", 282, "Book 24" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9f6bd6e0-ca48-48fb-a595-beaf8b9b8a91"), new Guid("9c765781-15bd-4bbc-ace8-deecffb33666"), "Description of Book 151", 355, "Book 151" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5d114241-f2e5-4cb4-9faa-d65ed2c8f734"), new Guid("523618c9-d2b0-42e5-a51c-8116f86bd6e0"), "Description of Book 63", 339, "Book 63" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("93d37447-d9a2-4ac1-ac33-4b82ee36e15b"), new Guid("523618c9-d2b0-42e5-a51c-8116f86bd6e0"), "Description of Book 110", 609, "Book 110" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("920de295-4234-4abe-b6ce-409a9104fdd7"), new Guid("523618c9-d2b0-42e5-a51c-8116f86bd6e0"), "Description of Book 197", 306, "Book 197" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("93bdedb0-959a-45ee-b5cc-f04d55b81ce9"), new Guid("afb2e8fc-d060-401e-b60b-14463ddf42a2"), "Description of Book 138", 963, "Book 138" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0f931162-b0f9-4cbd-80d4-2b00bd71bb28"), new Guid("afb2e8fc-d060-401e-b60b-14463ddf42a2"), "Description of Book 154", 417, "Book 154" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("dc932189-4eb5-4911-ab67-d77bed45129c"), new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"), "Description of Book 65", 467, "Book 65" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("086a4ffe-76f8-4db6-90a8-318e55c7197e"), new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"), "Description of Book 66", 676, "Book 66" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a5b40a57-888b-49a8-9eb6-91be50207d1f"), new Guid("13e9ca0f-dd11-4f95-932c-b18f3df461bd"), "Description of Book 169", 561, "Book 169" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ca1ec40b-6c69-493e-890a-058245ebda01"), new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"), "Description of Book 185", 976, "Book 185" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("62ecc5cd-6ec2-4a9b-b0b6-00e0fb1e7f97"), new Guid("09857bd8-94f9-4f22-88fc-7bcadf73faea"), "Description of Book 97", 945, "Book 97" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("edc75a33-e700-4cdd-8e73-61ef1b2d0b27"), new Guid("09857bd8-94f9-4f22-88fc-7bcadf73faea"), "Description of Book 186", 797, "Book 186" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4d031c40-f6e9-4f48-baaa-bc1a62124bcc"), new Guid("187038ba-5795-4705-a9e7-add2de31ac95"), "Description of Book 107", 819, "Book 107" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("be997f8c-30df-4a53-8839-98ae8593491c"), new Guid("187038ba-5795-4705-a9e7-add2de31ac95"), "Description of Book 160", 625, "Book 160" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e4a03f5f-67e8-41ba-8f14-59b337da4a07"), new Guid("79954558-382c-4914-8014-6e8fe546a39b"), "Description of Book 1", 385, "Book 1" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3d67e0ef-6e7d-4b4d-89a1-8642605e1ef0"), new Guid("79954558-382c-4914-8014-6e8fe546a39b"), "Description of Book 7", 194, "Book 7" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0217feab-7ef9-4995-a77f-bcdff0e683c7"), new Guid("79954558-382c-4914-8014-6e8fe546a39b"), "Description of Book 58", 693, "Book 58" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bdb4aa52-4779-4452-b570-0879280e0403"), new Guid("79954558-382c-4914-8014-6e8fe546a39b"), "Description of Book 77", 951, "Book 77" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("59d04170-3752-4e91-84f7-817fddbf9575"), new Guid("79954558-382c-4914-8014-6e8fe546a39b"), "Description of Book 81", 901, "Book 81" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("563be5ba-ddb2-4e1c-9193-d39b0ca94e94"), new Guid("79954558-382c-4914-8014-6e8fe546a39b"), "Description of Book 193", 783, "Book 193" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("36d108c7-be9a-4f6f-8263-4f2ad7d3d0f6"), new Guid("fba94512-5eab-4d20-b81a-08b177aca7c4"), "Description of Book 21", 822, "Book 21" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0e7d5828-2ea5-4827-9b63-93380fff78cf"), new Guid("fba94512-5eab-4d20-b81a-08b177aca7c4"), "Description of Book 44", 381, "Book 44" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("dc49385b-766d-469c-9c9e-c0a97fc797ec"), new Guid("fba94512-5eab-4d20-b81a-08b177aca7c4"), "Description of Book 112", 497, "Book 112" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f4351e07-750e-4bd6-9191-116c736099e0"), new Guid("fba94512-5eab-4d20-b81a-08b177aca7c4"), "Description of Book 152", 894, "Book 152" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("dc31f21a-4362-4dde-be50-14fc5e2b7641"), new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"), "Description of Book 99", 915, "Book 99" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0b9b799a-0e5b-4458-850e-bd40232bdc66"), new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"), "Description of Book 118", 150, "Book 118" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1cbcd4a6-007a-4e0b-be96-7d8aeae94fa9"), new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"), "Description of Book 124", 241, "Book 124" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("65966fce-438f-4ff8-8864-2b299ff4a6c2"), new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"), "Description of Book 139", 766, "Book 139" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9531a813-324d-4d25-9164-9e6dacc46e77"), new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"), "Description of Book 150", 485, "Book 150" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c5609676-5f8c-4978-b7b7-97e4278c4efe"), new Guid("3a21c09a-34b0-4bfd-bdcf-fbd9ed33a99b"), "Description of Book 175", 546, "Book 175" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("602faf27-ec79-409e-bebd-a3fb657be559"), new Guid("6d388830-a3cc-45d2-8016-8ed4ccbbae1b"), "Description of Book 90", 265, "Book 90" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("38744be0-762a-4dc2-b9cc-ca679acdb276"), new Guid("6d388830-a3cc-45d2-8016-8ed4ccbbae1b"), "Description of Book 126", 899, "Book 126" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("14eff00e-8c7d-4977-ae48-1ee1793ceef9"), new Guid("6d388830-a3cc-45d2-8016-8ed4ccbbae1b"), "Description of Book 153", 648, "Book 153" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("da86ec40-8518-4ac1-850e-1c73bc28ec1b"), new Guid("54a90c07-9a74-45b1-8605-2380c3a863b5"), "Description of Book 43", 837, "Book 43" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("eff0d12d-c7f0-40d1-9f7b-2be6845b78c9"), new Guid("09857bd8-94f9-4f22-88fc-7bcadf73faea"), "Description of Book 131", 691, "Book 131" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2b81a089-ff5b-49b6-ad99-a40b0e6b915a"), new Guid("54a90c07-9a74-45b1-8605-2380c3a863b5"), "Description of Book 11", 314, "Book 11" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("91d9d587-01f2-4a20-af9c-c842aeb2cae4"), new Guid("81e9697b-3882-4c8b-8b81-f923af34e9ba"), "Description of Book 117", 425, "Book 117" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("cfec324e-0fc7-4191-b378-75f077c3aeaa"), new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), "Description of Book 12", 877, "Book 12" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ad2d7ca0-8e19-4498-866f-d5f4a3040cf6"), new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), "Description of Book 53", 204, "Book 53" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a0e4b774-fa99-4186-a893-2486c52e60ba"), new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), "Description of Book 89", 173, "Book 89" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("45b830ff-29ec-40a2-8052-d4373b6b8a66"), new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), "Description of Book 105", 523, "Book 105" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ebe02bd1-354c-4575-9238-f966e061f78f"), new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), "Description of Book 132", 810, "Book 132" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4dbe8055-1597-4775-b519-2d31cafdf398"), new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), "Description of Book 143", 886, "Book 143" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7d94bf8b-282d-4301-895f-2d8c3f18c516"), new Guid("fc3c616f-225e-4224-9dbf-7ccddf7a8565"), "Description of Book 167", 800, "Book 167" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3cf8daff-358b-4306-b126-6e22d8a594c9"), new Guid("76c729e7-6c99-4a8e-b9c2-e2b4ed6af182"), "Description of Book 17", 418, "Book 17" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c2d98324-9399-47d5-9c65-c79bb8b04a63"), new Guid("76c729e7-6c99-4a8e-b9c2-e2b4ed6af182"), "Description of Book 85", 202, "Book 85" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("31aa7f52-eb55-4474-bb01-ddc6019c0e69"), new Guid("76c729e7-6c99-4a8e-b9c2-e2b4ed6af182"), "Description of Book 196", 711, "Book 196" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6c4733e3-6520-47b2-918f-9c2ce67924ef"), new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"), "Description of Book 30", 514, "Book 30" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("86b58374-7f37-4ce0-ab1c-d20c7297239d"), new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"), "Description of Book 55", 245, "Book 55" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("34587b98-71b1-487e-b07e-a94493473a3a"), new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"), "Description of Book 72", 595, "Book 72" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("13afc1e1-19dc-4da9-ae95-2bb8f86f9d0b"), new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"), "Description of Book 79", 405, "Book 79" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d8db2de1-8721-4985-b383-99cc487dff23"), new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"), "Description of Book 162", 439, "Book 162" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d74d7c0b-8fe8-458d-856c-ca898e1aabae"), new Guid("d7cbb1cb-8862-4a9b-94fc-cbd3344b0bba"), "Description of Book 190", 827, "Book 190" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("22279943-7c6f-4e9b-98ec-c07548c4c55a"), new Guid("cf83ff2b-ff2f-481c-8aa3-aeb79a2ff5e3"), "Description of Book 34", 319, "Book 34" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5a894aab-7e50-46b1-8bc6-eeb7396cff2c"), new Guid("cf83ff2b-ff2f-481c-8aa3-aeb79a2ff5e3"), "Description of Book 75", 914, "Book 75" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("78ae63ee-5f93-4930-a5c1-c5e26988897d"), new Guid("748ba6c1-872f-4c3b-920d-ff85de509683"), "Description of Book 10", 213, "Book 10" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("854efcff-54cb-4e28-9b83-ea4211329a8b"), new Guid("748ba6c1-872f-4c3b-920d-ff85de509683"), "Description of Book 50", 641, "Book 50" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4293d233-a0ec-4dc0-ab20-cf6c8bae2903"), new Guid("748ba6c1-872f-4c3b-920d-ff85de509683"), "Description of Book 137", 190, "Book 137" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0e613e46-dd3f-4808-95fe-5dc63f0b1c20"), new Guid("81e9697b-3882-4c8b-8b81-f923af34e9ba"), "Description of Book 140", 387, "Book 140" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("369d7d6d-f76c-4f7d-88d0-0312f77f0e04"), new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"), "Description of Book 182", 504, "Book 182" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f9a5f2e3-1418-4227-b80e-0f72cf1e83bc"), new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"), "Description of Book 180", 577, "Book 180" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0b37d903-cf36-4f06-b8a0-f990af2185ec"), new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"), "Description of Book 23", 895, "Book 23" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f7e5964c-2669-4187-bdfb-afa39855f4a2"), new Guid("16932bc6-4083-4646-8d60-0ecac6a29a38"), "Description of Book 41", 305, "Book 41" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e85e642e-ad62-4f12-b96f-6b00a850028b"), new Guid("16932bc6-4083-4646-8d60-0ecac6a29a38"), "Description of Book 104", 336, "Book 104" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e9dfdae2-8274-45bb-9f1b-776215defce0"), new Guid("28839dc4-58a3-4c24-a7a0-9b0781f48463"), "Description of Book 109", 606, "Book 109" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("15611e90-5908-4aac-ac4c-80d5cc4a01e8"), new Guid("28839dc4-58a3-4c24-a7a0-9b0781f48463"), "Description of Book 125", 156, "Book 125" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b36d5464-4ee7-4437-bad8-9855b622f9a0"), new Guid("28839dc4-58a3-4c24-a7a0-9b0781f48463"), "Description of Book 155", 157, "Book 155" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9512dfb3-fabd-41f1-bfce-3a5447942ac1"), new Guid("66910241-9135-468b-9aa2-4030cd5fa589"), "Description of Book 32", 639, "Book 32" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("8f86cf1b-5dac-4948-aaed-c53f58f4c37d"), new Guid("66910241-9135-468b-9aa2-4030cd5fa589"), "Description of Book 47", 912, "Book 47" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ffd29f9f-4598-4c24-b924-33e1d3985558"), new Guid("66910241-9135-468b-9aa2-4030cd5fa589"), "Description of Book 62", 624, "Book 62" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("789f77ee-70c1-49dc-8769-1a3208555a13"), new Guid("66910241-9135-468b-9aa2-4030cd5fa589"), "Description of Book 102", 775, "Book 102" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6bacd4ab-5799-4ed3-ad2f-f60041cab378"), new Guid("66910241-9135-468b-9aa2-4030cd5fa589"), "Description of Book 178", 598, "Book 178" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("85642aa2-8689-4f07-b677-c7981911ad2c"), new Guid("8d3934e8-0185-4c59-a116-fb0e4334fdf7"), "Description of Book 122", 573, "Book 122" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2ed5bab5-2d5b-4ca5-872f-502939ec07c4"), new Guid("8d3934e8-0185-4c59-a116-fb0e4334fdf7"), "Description of Book 161", 372, "Book 161" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("17559105-f69f-41fc-b9f5-4ec021de7485"), new Guid("8d3934e8-0185-4c59-a116-fb0e4334fdf7"), "Description of Book 173", 384, "Book 173" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f5e173d9-9260-45d9-be05-0b789f6702f6"), new Guid("8d3934e8-0185-4c59-a116-fb0e4334fdf7"), "Description of Book 194", 239, "Book 194" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2290d827-13d2-4925-8657-f52ea26fd90f"), new Guid("a35700ad-9775-466a-80e2-7645e9388589"), "Description of Book 35", 764, "Book 35" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a7bdd30a-c6dc-4346-999e-0d0cc6899323"), new Guid("a35700ad-9775-466a-80e2-7645e9388589"), "Description of Book 74", 994, "Book 74" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5e8e9699-d961-468a-a816-31e6d0863569"), new Guid("a35700ad-9775-466a-80e2-7645e9388589"), "Description of Book 103", 369, "Book 103" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e9fc9958-74bd-4d1a-8e94-651b6a30d309"), new Guid("a35700ad-9775-466a-80e2-7645e9388589"), "Description of Book 106", 816, "Book 106" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4c023e8e-9a73-4afb-ac50-3e2e19300279"), new Guid("a35700ad-9775-466a-80e2-7645e9388589"), "Description of Book 134", 203, "Book 134" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6139f979-ff6c-401f-936f-32c335f8eafa"), new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), "Description of Book 29", 831, "Book 29" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("835ce1c4-cbf5-44bd-ae75-3e8590bee05f"), new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), "Description of Book 57", 109, "Book 57" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c69c6ebe-f6f9-4dca-b7f3-7593afa151e1"), new Guid("16932bc6-4083-4646-8d60-0ecac6a29a38"), "Description of Book 18", 955, "Book 18" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("27b9bc2c-7e3e-4d49-b8a3-d8e936bb92af"), new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), "Description of Book 111", 647, "Book 111" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("673de257-4703-40c9-a5b2-bdff70b625cc"), new Guid("16932bc6-4083-4646-8d60-0ecac6a29a38"), "Description of Book 4", 688, "Book 4" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f7314912-6acd-4655-bc30-0ee275293daa"), new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"), "Description of Book 116", 611, "Book 116" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("55aa372c-9e74-46a3-8609-3a84fd96f2ba"), new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), "Description of Book 51", 410, "Book 51" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2ecaafd9-619c-4433-9ff2-19f8559bac86"), new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), "Description of Book 52", 877, "Book 52" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6afb4f36-6275-4b09-9fb9-427b11e1e50f"), new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), "Description of Book 54", 519, "Book 54" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bb621143-f65c-4761-9eb4-01a4ac999214"), new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), "Description of Book 73", 156, "Book 73" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("24759739-a20d-43e1-9d5e-41d0ece1895f"), new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), "Description of Book 82", 461, "Book 82" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("85722b1e-7542-4e9a-8ff0-8266ce9bacbd"), new Guid("519c36cd-c84f-48bd-9c64-8d8d920dcbbd"), "Description of Book 129", 997, "Book 129" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1a84bec2-3d7d-47c7-9f4f-1bc1cde79fd3"), new Guid("c2a01334-a8c5-4c24-88b9-be8e75bc7db4"), "Description of Book 69", 408, "Book 69" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6689e2ec-4bf9-4074-8679-30424ef4fd2b"), new Guid("c2a01334-a8c5-4c24-88b9-be8e75bc7db4"), "Description of Book 76", 636, "Book 76" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0a19ddd9-4a14-4f51-813d-0fa5638b72d8"), new Guid("c2a01334-a8c5-4c24-88b9-be8e75bc7db4"), "Description of Book 87", 534, "Book 87" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bc1a3f17-e5e5-4a20-bbae-a96cbac321a4"), new Guid("c2a01334-a8c5-4c24-88b9-be8e75bc7db4"), "Description of Book 165", 919, "Book 165" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("cee6a424-3e48-48da-b439-a4ac8b693c76"), new Guid("c2a01334-a8c5-4c24-88b9-be8e75bc7db4"), "Description of Book 183", 219, "Book 183" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("f320030d-6067-4102-a0d2-6d81daa7529f"), new Guid("8fbe6528-8969-4ae9-855b-3724e60d777d"), "Description of Book 26", 812, "Book 26" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b892ebc9-ce18-41dc-970d-a6909e12e608"), new Guid("8fbe6528-8969-4ae9-855b-3724e60d777d"), "Description of Book 101", 299, "Book 101" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c6dfdb4c-10bf-4d9b-94f4-34cb4dcd333e"), new Guid("8fbe6528-8969-4ae9-855b-3724e60d777d"), "Description of Book 123", 161, "Book 123" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bf529b6d-ebb7-4bd8-b112-0716cf9da057"), new Guid("a3dc2e00-e015-43a5-9cef-00a0988ee396"), "Description of Book 9", 209, "Book 9" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("bb24d58f-137b-433d-ad8b-a7ca7ab0ff5a"), new Guid("a3dc2e00-e015-43a5-9cef-00a0988ee396"), "Description of Book 146", 580, "Book 146" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d717b00b-36fd-4b2a-a076-f0742d3f6a49"), new Guid("a3dc2e00-e015-43a5-9cef-00a0988ee396"), "Description of Book 172", 462, "Book 172" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("5f63cae5-616f-4ca9-95c8-be633b0f67ab"), new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"), "Description of Book 20", 218, "Book 20" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6c45c6f9-58df-4c94-85d1-2117741cac60"), new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"), "Description of Book 27", 138, "Book 27" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6c2a7db6-97b6-4243-bdd4-6dc569a56228"), new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"), "Description of Book 39", 898, "Book 39" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b00099d7-2de9-4321-b1f4-07f05f4ec425"), new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"), "Description of Book 61", 973, "Book 61" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e046f420-9738-48c2-9628-2e73f6412957"), new Guid("df45cacc-b0d6-4466-a31b-c582924dc560"), "Description of Book 157", 713, "Book 157" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("079488d4-ebcc-41ef-b2d3-e38e2bce9b08"), new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), "Description of Book 113", 387, "Book 113" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1683ae95-48ed-4800-8007-92a3b32444b6"), new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), "Description of Book 133", 698, "Book 133" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("8c64b058-632c-4053-8a75-0d5a6b380472"), new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), "Description of Book 141", 150, "Book 141" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("68c29c10-4c39-4d42-9d94-ce175e7a3f89"), new Guid("8d08c335-8015-424c-8cb4-d2886bc4d2c9"), "Description of Book 98", 240, "Book 98" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("183709ae-638d-43bf-9ab7-5278c641b993"), new Guid("8d08c335-8015-424c-8cb4-d2886bc4d2c9"), "Description of Book 158", 226, "Book 158" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("36091316-2e09-445a-9dea-54abf43c1f81"), new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), "Description of Book 2", 906, "Book 2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e900c59b-0263-46ce-ab08-f9fb971d20c0"), new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), "Description of Book 49", 371, "Book 49" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c4032d5c-9cf9-4d3e-916a-d198a359afe0"), new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), "Description of Book 70", 134, "Book 70" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("86538690-ec6b-4bf2-a04e-b5182c549deb"), new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), "Description of Book 91", 978, "Book 91" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("98de0d39-59e6-4536-a601-c04425ac4a7f"), new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), "Description of Book 93", 152, "Book 93" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("38dbfdc0-7bd8-4976-938b-2749997905d6"), new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), "Description of Book 136", 224, "Book 136" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("771d5813-dd26-42a4-a443-974ca0df9810"), new Guid("a96bc5ad-1fe8-4c30-9605-6b3317273baf"), "Description of Book 199", 646, "Book 199" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("342704c9-2f77-4f4f-a090-385d1bc5ad03"), new Guid("ce411af8-f7fa-4b3c-bccb-6b660efde51c"), "Description of Book 59", 769, "Book 59" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("6bbd5a3b-0751-44b7-b737-06ef27eb9fbd"), new Guid("ce411af8-f7fa-4b3c-bccb-6b660efde51c"), "Description of Book 95", 998, "Book 95" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("33aac393-a27b-4da8-8bd7-ddd126e79c38"), new Guid("ce411af8-f7fa-4b3c-bccb-6b660efde51c"), "Description of Book 164", 374, "Book 164" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ac952215-1e10-4fab-a939-a8f1140dbef7"), new Guid("ce411af8-f7fa-4b3c-bccb-6b660efde51c"), "Description of Book 168", 282, "Book 168" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7c610d1e-fd9e-4215-aa38-35699cf415ec"), new Guid("ce411af8-f7fa-4b3c-bccb-6b660efde51c"), "Description of Book 170", 293, "Book 170" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ea623a48-66d4-4fc7-aba5-713f913b60c7"), new Guid("4eee913f-abcb-4f6c-89d2-56995e42f280"), "Description of Book 38", 823, "Book 38" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("99e4b41f-21e6-422b-a60d-cb08fd84e0cb"), new Guid("4eee913f-abcb-4f6c-89d2-56995e42f280"), "Description of Book 184", 610, "Book 184" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("a4d5b85c-c837-4d6f-a34d-df49521caab2"), new Guid("09993863-7b77-4499-bddc-ce1f3a5ee200"), "Description of Book 68", 235, "Book 68" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4e05f216-ab77-483e-9323-0fc092f0298a"), new Guid("09993863-7b77-4499-bddc-ce1f3a5ee200"), "Description of Book 88", 492, "Book 88" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("d2360454-3545-477f-aa0d-f2a1db04851d"), new Guid("09993863-7b77-4499-bddc-ce1f3a5ee200"), "Description of Book 94", 678, "Book 94" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("03a09055-c3b2-4a88-a3ef-dbf2902c49e0"), new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"), "Description of Book 16", 129, "Book 16" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2693d5a4-33fb-42c4-a399-ac6c7aaa94be"), new Guid("8d4c3083-64fd-46ff-93f5-9f1245f8cd7b"), "Description of Book 19", 964, "Book 19" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c1d67262-9862-40e8-8c06-8b0ce60d24a5"), new Guid("8d08c335-8015-424c-8cb4-d2886bc4d2c9"), "Description of Book 46", 264, "Book 46" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1faa8b9f-1e1c-44e7-b701-aeb030b2459e"), new Guid("a1bde1d8-dc7a-4fd2-a7e9-0f18bcd2e585"), "Description of Book 198", 611, "Book 198" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2cafa0ba-8ac0-4b39-89f6-60b2f0c64172"), new Guid("a1bde1d8-dc7a-4fd2-a7e9-0f18bcd2e585"), "Description of Book 148", 137, "Book 148" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ecf81e80-de88-4f09-8685-1eb9e256ee6f"), new Guid("a1bde1d8-dc7a-4fd2-a7e9-0f18bcd2e585"), "Description of Book 115", 419, "Book 115" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3824b8b3-b936-43b5-868c-ea37ca042a6a"), new Guid("64667e97-d60e-46ff-9ec5-157443e45b99"), "Description of Book 200", 780, "Book 200" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7b920a6e-0d31-49ad-992d-c413fc58389f"), new Guid("bcb5e4c3-5b0e-45f5-80a4-4dfa132493de"), "Description of Book 22", 787, "Book 22" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("594f8f30-1902-4e43-9bac-746f09c398cb"), new Guid("bcb5e4c3-5b0e-45f5-80a4-4dfa132493de"), "Description of Book 181", 967, "Book 181" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("14901266-541e-4c89-bacf-4cae5e565826"), new Guid("1834e14f-7987-47d9-94d4-c44cda205724"), "Description of Book 67", 966, "Book 67" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c1e2a70e-612d-45e1-ac8b-8f430339fd4c"), new Guid("1834e14f-7987-47d9-94d4-c44cda205724"), "Description of Book 100", 300, "Book 100" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1911bce3-715f-439d-a814-f8e66b0274dc"), new Guid("1834e14f-7987-47d9-94d4-c44cda205724"), "Description of Book 192", 964, "Book 192" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ec53604c-81e8-4652-88a0-9e39b88bd6cc"), new Guid("0add9e3e-8145-4fa4-9b16-059cbef40052"), "Description of Book 28", 570, "Book 28" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0973d369-5a40-4356-8c42-383845739066"), new Guid("0add9e3e-8145-4fa4-9b16-059cbef40052"), "Description of Book 83", 298, "Book 83" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("ed01ce82-1edb-4260-beba-3d50db2a5006"), new Guid("0add9e3e-8145-4fa4-9b16-059cbef40052"), "Description of Book 120", 597, "Book 120" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("771350bc-b77d-431e-92c6-6b54effb7dd0"), new Guid("0add9e3e-8145-4fa4-9b16-059cbef40052"), "Description of Book 187", 260, "Book 187" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("3e2c8aab-e82f-4d7c-82d4-fd5062002f6f"), new Guid("6d388830-a3cc-45d2-8016-8ed4ccbbae1b"), "Description of Book 156", 727, "Book 156" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("7149f8e7-5cda-4844-83b7-cffc712e4070"), new Guid("4d85a9e7-b603-4337-bcf0-de71b5f86473"), "Description of Book 15", 122, "Book 15" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b0bd1818-25cc-4503-913b-b43a116eced8"), new Guid("4d85a9e7-b603-4337-bcf0-de71b5f86473"), "Description of Book 48", 678, "Book 48" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("1ebd9d2e-d3ba-449e-a6c4-714b2e48e6eb"), new Guid("4d85a9e7-b603-4337-bcf0-de71b5f86473"), "Description of Book 144", 564, "Book 144" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("26a612e3-f980-4371-b73c-c4fd8e6d30c6"), new Guid("4d85a9e7-b603-4337-bcf0-de71b5f86473"), "Description of Book 189", 145, "Book 189" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2f2e67d9-44da-48a1-b3da-f569b25230d2"), new Guid("0212b86f-b98c-47af-8edb-abc059e3c093"), "Description of Book 56", 598, "Book 56" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e0fa7367-a5a6-4f2c-b440-d4d581ee4083"), new Guid("0212b86f-b98c-47af-8edb-abc059e3c093"), "Description of Book 92", 318, "Book 92" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9be3efc1-4d33-4626-9a4e-dfba41bb8bac"), new Guid("0212b86f-b98c-47af-8edb-abc059e3c093"), "Description of Book 108", 210, "Book 108" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0e0eaf83-95a0-4b52-8713-1136339509a2"), new Guid("0212b86f-b98c-47af-8edb-abc059e3c093"), "Description of Book 135", 554, "Book 135" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("e014c02e-239a-4e9d-b154-72eba7b189d0"), new Guid("23fce496-3b8c-4521-91f4-1f738b928be5"), "Description of Book 71", 217, "Book 71" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("84e5f4af-72ee-488d-a0aa-d1d8ca366cf8"), new Guid("a1bde1d8-dc7a-4fd2-a7e9-0f18bcd2e585"), "Description of Book 8", 170, "Book 8" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("11ed4bad-10a1-468d-a4af-22aa242a6856"), new Guid("a1bde1d8-dc7a-4fd2-a7e9-0f18bcd2e585"), "Description of Book 40", 970, "Book 40" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("2eb003f4-15e2-4eef-bc16-dedc7a31edfb"), new Guid("4d85a9e7-b603-4337-bcf0-de71b5f86473"), "Description of Book 45", 877, "Book 45" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("8e6185ae-90c3-445b-a709-3d9492bc836f"), new Guid("6d388830-a3cc-45d2-8016-8ed4ccbbae1b"), "Description of Book 163", 214, "Book 163" });
        }
    }
}
