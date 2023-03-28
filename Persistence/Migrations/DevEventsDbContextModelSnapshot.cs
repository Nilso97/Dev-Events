﻿// <auto-generated />
using System;
using Dev_Events_App.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dev_Events_App.Persistence.Migrations
{
    [DbContext(typeof(DevEventsDbContext))]
    partial class DevEventsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Dev_Events_App.Entities.DevEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("End_Date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("Start_Date");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DevEvents");
                });

            modelBuilder.Entity("Dev_Events_App.Entities.DevEventSpeaker", b =>
                {
                    b.Property<Guid>("DevEventId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkedInProfile")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TalkDescription")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TalkTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("DevEventId");

                    b.ToTable("DevEventsSpeakers");
                });

            modelBuilder.Entity("Dev_Events_App.Entities.DevEventSpeaker", b =>
                {
                    b.HasOne("Dev_Events_App.Entities.DevEvent", null)
                        .WithMany("Speakers")
                        .HasForeignKey("DevEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dev_Events_App.Entities.DevEvent", b =>
                {
                    b.Navigation("Speakers");
                });
#pragma warning restore 612, 618
        }
    }
}
