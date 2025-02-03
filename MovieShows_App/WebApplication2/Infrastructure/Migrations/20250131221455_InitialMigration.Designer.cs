﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20250131221455_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationCore.Entities.Casts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProfilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("TmdbUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Casts");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackdropUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<decimal?>("Budget")
                        .HasColumnType("Decimal(18,4)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Datetime");

                    b.Property<string>("ImdbUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("OriginalLanguage")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("Decimal(5,2)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("Datetime");

                    b.Property<decimal?>("Revenue")
                        .HasColumnType("Decimal(18,4)");

                    b.Property<int?>("RunTime")
                        .HasColumnType("Int");

                    b.Property<string>("Tagline")
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("varchar(MAX)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Datetime");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieCasts", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CastId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MovieId", "CastId");

                    b.HasIndex("CastId");

                    b.ToTable("MovieCasts");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieGenres", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Trailers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("TrailerUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(2084)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("CastsMovie", b =>
                {
                    b.Property<int>("CastsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("CastsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CastsMovie");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieCasts", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Casts", "Cast")
                        .WithMany()
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cast");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieGenres", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Trailers", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Movie", "Movies")
                        .WithMany("Trailers")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("CastsMovie", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Casts", null)
                        .WithMany()
                        .HasForeignKey("CastsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.Movie", b =>
                {
                    b.Navigation("Trailers");
                });
#pragma warning restore 612, 618
        }
    }
}
