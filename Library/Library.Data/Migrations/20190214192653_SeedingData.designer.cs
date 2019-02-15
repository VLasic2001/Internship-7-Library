﻿// <auto-generated />
/*using System;
using Library.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190214192653_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Data.Entities.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Luka",
                            LastName = "Lukanovic"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Filip",
                            LastName = "Filipovic"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Roko",
                            LastName = "Rokic"
                        });
                });

            modelBuilder.Entity("Library.Data.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId");

                    b.Property<int>("Genre");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfPages");

                    b.Property<int?>("PublisherId");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Genre = 1,
                            Name = "Treasure Island",
                            NumberOfPages = 143
                        },
                        new
                        {
                            BookId = 2,
                            Genre = 6,
                            Name = "Love Story",
                            NumberOfPages = 657
                        },
                        new
                        {
                            BookId = 3,
                            Genre = 5,
                            Name = "Dracula",
                            NumberOfPages = 143
                        });
                });

            modelBuilder.Entity("Library.Data.Models.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime>("LoanDate");

                    b.Property<DateTime?>("ReturnDate");

                    b.Property<int>("StudentId");

                    b.HasKey("LoanId");

                    b.HasIndex("BookId");

                    b.HasIndex("StudentId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Library.Data.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PublisherId = 1,
                            Name = "Black Library"
                        },
                        new
                        {
                            PublisherId = 2,
                            Name = "HarperCollins"
                        },
                        new
                        {
                            PublisherId = 3,
                            Name = "Parragon"
                        });
                });

            modelBuilder.Entity("Library.Data.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Class = "3.b",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(33),
                            FirstName = "Toni",
                            Gender = 0,
                            LastName = "Tonicevic"
                        },
                        new
                        {
                            StudentId = 2,
                            Class = "1.c",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(333),
                            FirstName = "Ana",
                            Gender = 1,
                            LastName = "Anic"
                        },
                        new
                        {
                            StudentId = 3,
                            Class = "4.a",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(5),
                            FirstName = "Tomislav",
                            Gender = 0,
                            LastName = "Tomicic"
                        });
                });

            modelBuilder.Entity("Library.Data.Models.Book", b =>
                {
                    b.HasOne("Library.Data.Entities.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.HasOne("Library.Data.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId");
                });

            modelBuilder.Entity("Library.Data.Models.Loan", b =>
                {
                    b.HasOne("Library.Data.Models.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Data.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}*/
