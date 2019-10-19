﻿// <auto-generated />
using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("Likes");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("UserID");

                    b.Property<bool>("isActive");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Entity.Profile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasMaxLength(250);

                    b.Property<int>("BlockCount");

                    b.Property<int>("FollowersCount");

                    b.Property<int>("FollowingCount");

                    b.Property<int>("ProfileUserID");

                    b.Property<bool>("isActive");

                    b.HasKey("ID");

                    b.HasIndex("ProfileUserID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50);

                    b.Property<string>("AvatarURL");

                    b.Property<string>("City")
                        .HasMaxLength(25);

                    b.Property<string>("Country")
                        .HasMaxLength(25);

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<long>("PhoneNumber");

                    b.Property<string>("Sex")
                        .IsRequired();

                    b.Property<string>("State")
                        .HasMaxLength(2);

                    b.Property<string>("UserType")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Zip");

                    b.Property<bool>("isActive");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.Blog", b =>
                {
                    b.HasOne("Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity.Profile", b =>
                {
                    b.HasOne("Entity.User", "ProfileUser")
                        .WithMany()
                        .HasForeignKey("ProfileUserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
