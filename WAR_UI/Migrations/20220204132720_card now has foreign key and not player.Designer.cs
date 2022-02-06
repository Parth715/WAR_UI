﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WAR_UI;

#nullable disable

namespace WAR_UI.Migrations
{
    [DbContext(typeof(WARDbContext))]
    [Migration("20220204132720_card now has foreign key and not player")]
    partial class cardnowhasforeignkeyandnotplayer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WAR_UI.Cards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cardnumber")
                        .HasColumnType("int");

                    b.Property<string>("Face")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Playerid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Playerid")
                        .IsUnique();

                    b.ToTable("Cards", (string)null);
                });

            modelBuilder.Entity("WAR_UI.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outcome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players", (string)null);
                });

            modelBuilder.Entity("WAR_UI.Cards", b =>
                {
                    b.HasOne("WAR_UI.Player", null)
                        .WithOne("Card")
                        .HasForeignKey("WAR_UI.Cards", "Playerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WAR_UI.Player", b =>
                {
                    b.Navigation("Card")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
