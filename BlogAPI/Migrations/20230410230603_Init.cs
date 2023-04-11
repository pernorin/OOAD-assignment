using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleAuthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentType = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ContentTypes_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleAuthorEntityArticleEntity",
                columns: table => new
                {
                    ArticleAuthorsId = table.Column<int>(type: "int", nullable: false),
                    AuthorArticlesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleAuthorEntityArticleEntity", x => new { x.ArticleAuthorsId, x.AuthorArticlesId });
                    table.ForeignKey(
                        name: "FK_ArticleAuthorEntityArticleEntity_ArticleAuthors_ArticleAuthorsId",
                        column: x => x.ArticleAuthorsId,
                        principalTable: "ArticleAuthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleAuthorEntityArticleEntity_Articles_AuthorArticlesId",
                        column: x => x.AuthorArticlesId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleEntityArticleTagEntity",
                columns: table => new
                {
                    ArticleTagsId = table.Column<int>(type: "int", nullable: false),
                    TagArticlesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleEntityArticleTagEntity", x => new { x.ArticleTagsId, x.TagArticlesId });
                    table.ForeignKey(
                        name: "FK_ArticleEntityArticleTagEntity_ArticleTags_ArticleTagsId",
                        column: x => x.ArticleTagsId,
                        principalTable: "ArticleTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleEntityArticleTagEntity_Articles_TagArticlesId",
                        column: x => x.TagArticlesId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleAuthorEntityArticleEntity_AuthorArticlesId",
                table: "ArticleAuthorEntityArticleEntity",
                column: "AuthorArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleEntityArticleTagEntity_TagArticlesId",
                table: "ArticleEntityArticleTagEntity",
                column: "TagArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ContentTypeId",
                table: "Articles",
                column: "ContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTags_Tag",
                table: "ArticleTags",
                column: "Tag",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentTypes_ContentType",
                table: "ContentTypes",
                column: "ContentType",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleAuthorEntityArticleEntity");

            migrationBuilder.DropTable(
                name: "ArticleEntityArticleTagEntity");

            migrationBuilder.DropTable(
                name: "ArticleAuthors");

            migrationBuilder.DropTable(
                name: "ArticleTags");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ContentTypes");
        }
    }
}
