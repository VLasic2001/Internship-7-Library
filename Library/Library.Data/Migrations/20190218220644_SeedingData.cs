using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Luka", "Lukanovic" },
                    { 2, "Filip", "Filipovic" },
                    { 3, "Ivan", "Ivanovic" },
                    { 4, "Stipe", "Stipic" },
                    { 5, "Josip", "Josipovic" },
                    { 6, "Nikola", "Nikolic" },
                    { 7, "Roko", "Rokic" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Name" },
                values: new object[,]
                {
                    { 5, "Firebrand Books" },
                    { 4, "Ballantine Books" },
                    { 3, "Baen Books" },
                    { 2, "HarperCollins" },
                    { 1, "Black Library" },
                    { 7, "Parragon" },
                    { 6, "Hay House" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Class", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 7, "4.a", new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomislav", 0, "Tomicic" },
                    { 5, "3.b", new DateTime(2001, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leon", 0, "Loencevic" },
                    { 3, "3.b", new DateTime(2001, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo", 0, "Leovic" },
                    { 2, "1.c", new DateTime(2003, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", 1, "Anic" },
                    { 1, "3.b", new DateTime(2001, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toni", 0, "Tonicevic" },
                    { 6, "1.c", new DateTime(2003, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivana", 1, "Ivanic" },
                    { 4, "1.c", new DateTime(2003, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dora", 1, "Doric" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Genre", "Name", "NumberOfCopies", "NumberOfPages", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Treasure Island", 10, 143, 1 },
                    { 8, 2, 5, "Dracula", 30, 143, 1 },
                    { 2, 2, 6, "Love Story", 15, 657, 2 },
                    { 3, 3, 0, "Adrenaline", 15, 216, 3 },
                    { 4, 4, 2, "In Cold Blood", 20, 457, 4 },
                    { 7, 3, 7, "Animal Farm", 40, 112, 4 },
                    { 5, 5, 3, "Romeo and Juliet", 40, 480, 5 },
                    { 6, 6, 4, "A Princess Of Mars", 5, 356, 6 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "LoanDate", "ReturnDate", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 2, 2, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 5, 2, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 3, 3, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 4, 3, new DateTime(2019, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 },
                    { 6, 7, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4);
        }
    }
}
