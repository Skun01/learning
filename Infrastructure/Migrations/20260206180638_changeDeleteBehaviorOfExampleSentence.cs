using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeDeleteBehaviorOfExampleSentence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExampleSentences_GrammarCards_GrammarCardId",
                table: "ExampleSentences");

            migrationBuilder.DropForeignKey(
                name: "FK_ExampleSentences_VocabularyCards_VocabularyCardId",
                table: "ExampleSentences");

            migrationBuilder.AddForeignKey(
                name: "FK_ExampleSentences_GrammarCards_GrammarCardId",
                table: "ExampleSentences",
                column: "GrammarCardId",
                principalTable: "GrammarCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExampleSentences_VocabularyCards_VocabularyCardId",
                table: "ExampleSentences",
                column: "VocabularyCardId",
                principalTable: "VocabularyCards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExampleSentences_GrammarCards_GrammarCardId",
                table: "ExampleSentences");

            migrationBuilder.DropForeignKey(
                name: "FK_ExampleSentences_VocabularyCards_VocabularyCardId",
                table: "ExampleSentences");

            migrationBuilder.AddForeignKey(
                name: "FK_ExampleSentences_GrammarCards_GrammarCardId",
                table: "ExampleSentences",
                column: "GrammarCardId",
                principalTable: "GrammarCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExampleSentences_VocabularyCards_VocabularyCardId",
                table: "ExampleSentences",
                column: "VocabularyCardId",
                principalTable: "VocabularyCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
