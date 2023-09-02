﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TopLearn.DataLeyer.Migrations
{
    public partial class ResaveCourseComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseComment_Courses_CourseId",
                table: "CourseComment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseComment_Users_UserId",
                table: "CourseComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseComment",
                table: "CourseComment");

            migrationBuilder.RenameTable(
                name: "CourseComment",
                newName: "CourseComments");

            migrationBuilder.RenameIndex(
                name: "IX_CourseComment_UserId",
                table: "CourseComments",
                newName: "IX_CourseComments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseComment_CourseId",
                table: "CourseComments",
                newName: "IX_CourseComments_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseComments",
                table: "CourseComments",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseComments_Courses_CourseId",
                table: "CourseComments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseComments_Users_UserId",
                table: "CourseComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseComments_Courses_CourseId",
                table: "CourseComments");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseComments_Users_UserId",
                table: "CourseComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseComments",
                table: "CourseComments");

            migrationBuilder.RenameTable(
                name: "CourseComments",
                newName: "CourseComment");

            migrationBuilder.RenameIndex(
                name: "IX_CourseComments_UserId",
                table: "CourseComment",
                newName: "IX_CourseComment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseComments_CourseId",
                table: "CourseComment",
                newName: "IX_CourseComment_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseComment",
                table: "CourseComment",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseComment_Courses_CourseId",
                table: "CourseComment",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseComment_Users_UserId",
                table: "CourseComment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
