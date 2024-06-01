using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unitok.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class unitok3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "801136c6-1c83-4fe3-a3f4-0f3a9c39c8e5", "AQAAAAIAAYagAAAAEBdQGmFJn9xYaEYZpIldC41h8TRZU4gAkFaE+V/E2lgxmWF5Qozef0gYSjxi70YcZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b71009c7-bafe-46b6-ae8c-8f866addbd6e", "AQAAAAIAAYagAAAAEGp9n4BUylzCERUnfw26s8fGaAexVTly10QtDg/behcYPRh8QRPeckWbJW1qO/UmxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71ba5729-253e-4e7a-a15f-b083a98ca0f3", "AQAAAAIAAYagAAAAEN5YXXK8HYYNGOXBN3RptgpcwYnNtYjc29hwjonMxJqs9Je4v5eusyhVcZdluni3uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c4c0be6-1006-4c93-bd13-f7988c0a1a22", "AQAAAAIAAYagAAAAEDPp/6hylc291WMLXKCqlrJ8CyZxwX6i9byKaO4wMgKINrGcw+TOhetkCT8I36937Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
