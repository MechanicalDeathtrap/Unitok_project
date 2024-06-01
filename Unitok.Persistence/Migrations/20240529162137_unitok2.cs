using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unitok.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class unitok2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "AvatarImageData",
                table: "UserInfos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "BackgroundImageData",
                table: "UserInfos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d20bcc6-fb9f-4b88-acc4-bccacbcf7df4", "AQAAAAIAAYagAAAAEP7O4B3bv9Zr7AutNIy68jfg0U4AVpa/MlVBhmAzJsbQTF8GXKM1HRCZYjcfyTr57A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e3ae0b3-8c37-4ee7-9fec-f3a9645d1fec", "AQAAAAIAAYagAAAAEDLL4XFtM5JNQGehhnZL6GENBkFTZN/ZJ0eNHGxfPr1Bu48Ff3UTUFvn+h3goetzvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "026a68de-f798-43b7-9567-c14ca1cec200", "AQAAAAIAAYagAAAAEC+E/DJJSQg2acG4Sjzzeb1hlutol7xbemt2kkiMr8YfAvppFMgWYF1i2BkcBhbxJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fd71fd4-5a77-4f16-855c-b0c4c217f230", "AQAAAAIAAYagAAAAENWocYCgaeiAQ3wP4o3pTJ5RXtmjmV3V9zFIQnJnj6uEhKnauDxqNFYeDCRJqLzD/Q==" });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarImageData", "BackgroundImageData" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarImageData", "BackgroundImageData" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarImageData", "BackgroundImageData" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarImageData", "BackgroundImageData" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarImageData",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "BackgroundImageData",
                table: "UserInfos");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24ef14d7-62bc-4b27-aeab-fc01f9d5ab3a", "AQAAAAIAAYagAAAAEOUUHElO63tLrWc2LiPJJNDNInkaMpYVnH6CpLc2x2xoCG31FmOt8ubWI9EqwQm2bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "633d5360-d4d5-4c6d-b3a9-43d6dd4801ef", "AQAAAAIAAYagAAAAEM+4UBDsGCIvwTwa2G1F8FrZjvEh6Z+Ap0fOChWLzBMmVuNE9+s3cEqCLJgqQM30nQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0715286-bfc8-4982-aacf-a69c1d89bd3d", "AQAAAAIAAYagAAAAEFxd8qwymxUbCfhcXbWMsweYMc2a98hyNEuSxlEDRXkI4pPJQaZMYSQKPjWgEHlV4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9668e6c6-13a3-49ab-b660-7500cb320300", "AQAAAAIAAYagAAAAEC4dZaGreA/y8Ib6P1Lalf5b7OCuHjcbBoSSyMVXmzPlwXkXbaHxEbS+zRZ5pO+hmA==" });
        }
    }
}
