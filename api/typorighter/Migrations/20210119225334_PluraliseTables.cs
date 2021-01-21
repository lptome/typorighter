using Microsoft.EntityFrameworkCore.Migrations;

namespace typorighter.Migrations
{
    public partial class PluraliseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostCategories_BlogPost_BlogPostID",
                table: "BlogPostCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostCategories_Category_CategoryID",
                table: "BlogPostCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "BlogPost",
                newName: "BlogPosts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostCategories_BlogPosts_BlogPostID",
                table: "BlogPostCategories",
                column: "BlogPostID",
                principalTable: "BlogPosts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostCategories_Categories_CategoryID",
                table: "BlogPostCategories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostCategories_BlogPosts_BlogPostID",
                table: "BlogPostCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostCategories_Categories_CategoryID",
                table: "BlogPostCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "BlogPosts",
                newName: "BlogPost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostCategories_BlogPost_BlogPostID",
                table: "BlogPostCategories",
                column: "BlogPostID",
                principalTable: "BlogPost",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostCategories_Category_CategoryID",
                table: "BlogPostCategories",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
