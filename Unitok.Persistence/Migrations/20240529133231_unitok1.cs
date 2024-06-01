using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unitok.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class unitok1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "NftCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "NftCards",
                type: "varbinary(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageData",
                value: null);

            migrationBuilder.UpdateData(
                table: "NftCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageData",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "NftCards");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "NftCards",
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
                values: new object[] { "938c68bc-3b57-4bf3-9fb4-8020624d1da8", "AQAAAAIAAYagAAAAELJLW3CSx1yxpuvvG9zuJCa5quF1cLVOO/wkQpaUusTmb2JNLR8uYORWRi7YvZNovQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21aa19d2-7017-47fe-8157-5fed89adb349", "AQAAAAIAAYagAAAAEGSWv57E6mhZKhLgTLdIeGh032uRjAO+uJf8PTbxmcbD1h4DhyL7daTDaHPfyXdg/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad63f72c-4917-4060-bd75-603471de7a26", "AQAAAAIAAYagAAAAEMLRcrKFlu91K9rkxGJoDDYquUWBVN2NBduC9lbkezBcc1199v/zOT72FsKBOHDdzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16fea979-b776-4859-bd51-393ebe23b4ec", "AQAAAAIAAYagAAAAEE+a2igrayd94WevI/0VPLEufEz4LpV2W+auMbTg6b85y/fB6kivrNM5phuVZGnNig==" });
        }
    }
}
