﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class QuestionUseAdditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionUse_QCategory_QCategoryID",
                table: "QuestionUse");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionUse_Question_QuestID",
                table: "QuestionUse");

            migrationBuilder.AlterColumn<int>(
                name: "QuestID",
                table: "QuestionUse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QCategoryID",
                table: "QuestionUse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionUse_QCategory_QCategoryID",
                table: "QuestionUse",
                column: "QCategoryID",
                principalTable: "QCategory",
                principalColumn: "QCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionUse_Question_QuestID",
                table: "QuestionUse",
                column: "QuestID",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionUse_QCategory_QCategoryID",
                table: "QuestionUse");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionUse_Question_QuestID",
                table: "QuestionUse");

            migrationBuilder.AlterColumn<int>(
                name: "QuestID",
                table: "QuestionUse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QCategoryID",
                table: "QuestionUse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionUse_QCategory_QCategoryID",
                table: "QuestionUse",
                column: "QCategoryID",
                principalTable: "QCategory",
                principalColumn: "QCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionUse_Question_QuestID",
                table: "QuestionUse",
                column: "QuestID",
                principalTable: "Question",
                principalColumn: "Id");
        }
    }
}
