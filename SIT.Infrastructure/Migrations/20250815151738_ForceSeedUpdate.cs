using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIT.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ForceSeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zSlgnBJRB13cz59h112V5+oPecDM3KyW9+JuEUnlSOwuXb8BLdx2yOdqG36Yydj31tQF36+dm79l1HMo80Ilfg==", "9kcV2HHk5cu0N/7/I9UdNkdXgD7cKAtuOTqVMKD00bxtS0phKZH8B83hSvL9WgVrchkTbXTTDjxW3qSVZ2QkoCZ1bALLVXSVAyG6H/KgSECX9IOrJnS8C7nr8JmZm9iAwfBKcMSDKBOSVEqPE3OJWes007nWmun2Z6+c218QeT4=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Ei0sQQiUfXPg9tT+0na6oVpaOUexR6VRI/tTzEcRn3G2tCVq3rFLBcYTCyAxycgMOBJlquptx2VCkj6vRcv+cQ==", "oFsHxmNggPoJ9GtEq+CCfD2p2jCsp2fBdSOU7UeoEO+M+xk6okTUgTCMYjrKvC7mqaWqLnIaX4dqWrnd5uTDqY8wpGzmr4AEliLRE8MlnJIxrgnVnWDyq0FJ5UWRgrRe9d1/MleeFF3kQOeAVPpoqs/u+mH//Neva7R3gEJm8Zg=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "paste_admin_hash_here", "paste_admin_salt_here" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "paste_user_hash_here", "paste_user_salt_here" });
        }
    }
}
