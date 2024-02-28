using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_StudentSystem.Migrations
{
    public partial class editi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Course_CoursesCourseId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Student_StudentsStudentId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_Course_CourseId",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_Student_StudentId",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_Course_CourseId",
                table: "Resource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resource",
                table: "Resource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeWork",
                table: "HomeWork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "SudentId",
                table: "HomeWork");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Resource",
                newName: "resources");

            migrationBuilder.RenameTable(
                name: "HomeWork",
                newName: "homeWorks");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "courses");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_CourseId",
                table: "resources",
                newName: "IX_resources_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_HomeWork_StudentId",
                table: "homeWorks",
                newName: "IX_homeWorks_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_HomeWork_CourseId",
                table: "homeWorks",
                newName: "IX_homeWorks_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_resources",
                table: "resources",
                column: "ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_homeWorks",
                table: "homeWorks",
                column: "HomeworkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_courses_CoursesCourseId",
                table: "CourseStudent",
                column: "CoursesCourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_students_StudentsStudentId",
                table: "CourseStudent",
                column: "StudentsStudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_homeWorks_courses_CourseId",
                table: "homeWorks",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_homeWorks_students_StudentId",
                table: "homeWorks",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_resources_courses_CourseId",
                table: "resources",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_courses_CoursesCourseId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_students_StudentsStudentId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_homeWorks_courses_CourseId",
                table: "homeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_homeWorks_students_StudentId",
                table: "homeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_resources_courses_CourseId",
                table: "resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_resources",
                table: "resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_homeWorks",
                table: "homeWorks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "resources",
                newName: "Resource");

            migrationBuilder.RenameTable(
                name: "homeWorks",
                newName: "HomeWork");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_resources_CourseId",
                table: "Resource",
                newName: "IX_Resource_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_homeWorks_StudentId",
                table: "HomeWork",
                newName: "IX_HomeWork_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_homeWorks_CourseId",
                table: "HomeWork",
                newName: "IX_HomeWork_CourseId");

            migrationBuilder.AddColumn<int>(
                name: "SudentId",
                table: "HomeWork",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resource",
                table: "Resource",
                column: "ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeWork",
                table: "HomeWork",
                column: "HomeworkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Course_CoursesCourseId",
                table: "CourseStudent",
                column: "CoursesCourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Student_StudentsStudentId",
                table: "CourseStudent",
                column: "StudentsStudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_Course_CourseId",
                table: "HomeWork",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_Student_StudentId",
                table: "HomeWork",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_Course_CourseId",
                table: "Resource",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
