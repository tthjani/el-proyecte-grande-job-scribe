﻿// <auto-generated />
using System;
using JobScribe_stranger_strings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobScribe_stranger_strings.Migrations
{
    [DbContext(typeof(JobScribeContext))]
    [Migration("20240118232347_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobScribe_stranger_strings.Model.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Applicants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "valaki@valaki.vl",
                            Gender = "Male",
                            Location = "Deb",
                            Name = "Pista",
                            TelephoneNumber = "785656456456",
                            UserName = "pistavok12"
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.CVModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CvModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1932, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Category = "C#",
                            Description = "Én megyek oda",
                            Education = "diploma",
                            Email = "valaki@valaki.vl",
                            IsActive = true,
                            Level = "Senior",
                            Location = "Mucsaröcsöge",
                            Name = "Pista",
                            TelephoneNumber = "8768716273462"
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Founded")
                        .HasColumnType("int");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Description = "In 2014, we started Codecool with the vision that quality coding education can change lives and workplaces for the better.",
                            Founded = 2014,
                            Industry = "Education",
                            Location = "Budapest",
                            Name = "CodeCool"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Polygence is a team of academics and educators united in our passion to make research more widely accessible to all interested students.",
                            Founded = 2019,
                            Industry = "Education",
                            Location = "Budapest",
                            Name = "Polygence"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Ulyssys is one of the leading software development companies in Hungary with a team of 300 professionals. It has a 30-year successful track record in custom software development.",
                            Founded = 1991,
                            Industry = "IT Services and IT Consulting",
                            Location = "Budapest",
                            Name = "Ulyssys Kft."
                        },
                        new
                        {
                            Id = 6,
                            Description = "OPSWAT protects critical infrastructure (CIP). Our goal is to eliminate malware and zero-day attacks.",
                            Founded = 2002,
                            Industry = "Information technology & services",
                            Location = "Veszprém",
                            Name = "OPSWAT"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Born in Stuttgart, made for the world. At Flexopus, we create New Work together with our customers. As a leading workplace management B2B software, we enable the flexible and digital management of office resources in one tool.",
                            Founded = 2020,
                            Industry = "Web tools",
                            Location = "Budapest",
                            Name = "Flexopus"
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.ExperienceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CVModelId = 1,
                            Item = "Voltam már balatonon"
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicantId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobOffers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicantId = 1,
                            Category = "DevOps",
                            CompanyId = 4,
                            Description = "Valami leírás kell",
                            IsActive = true,
                            Level = "junior",
                            Location = "Nyíregyh",
                            Name = "DevOps Engineer",
                            Published = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.LanguageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CVModelId = 1,
                            Item = "English"
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.MustHaveModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobOfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("MustHaves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CVModelId = 1,
                            Item = "Javascript",
                            JobOfferId = 1
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.NiceToHaveModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobOfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("NiceToHaves");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CVModelId = 1,
                            Item = "React",
                            JobOfferId = 1
                        });
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.ExperienceModel", b =>
                {
                    b.HasOne("JobScribe_stranger_strings.Model.CVModel", null)
                        .WithMany("Experience")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.JobOffer", b =>
                {
                    b.HasOne("JobScribe_stranger_strings.Model.Applicant", null)
                        .WithMany("Application")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobScribe_stranger_strings.Model.Company", null)
                        .WithMany("JobOffers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.LanguageModel", b =>
                {
                    b.HasOne("JobScribe_stranger_strings.Model.CVModel", null)
                        .WithMany("Languages")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.MustHaveModel", b =>
                {
                    b.HasOne("JobScribe_stranger_strings.Model.CVModel", null)
                        .WithMany("MustHave")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobScribe_stranger_strings.Model.JobOffer", null)
                        .WithMany("MustHave")
                        .HasForeignKey("JobOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.NiceToHaveModel", b =>
                {
                    b.HasOne("JobScribe_stranger_strings.Model.CVModel", null)
                        .WithMany("NiceToHave")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobScribe_stranger_strings.Model.JobOffer", null)
                        .WithMany("NiceToHave")
                        .HasForeignKey("JobOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.Applicant", b =>
                {
                    b.Navigation("Application");
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.CVModel", b =>
                {
                    b.Navigation("Experience");

                    b.Navigation("Languages");

                    b.Navigation("MustHave");

                    b.Navigation("NiceToHave");
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.Company", b =>
                {
                    b.Navigation("JobOffers");
                });

            modelBuilder.Entity("JobScribe_stranger_strings.Model.JobOffer", b =>
                {
                    b.Navigation("MustHave");

                    b.Navigation("NiceToHave");
                });
#pragma warning restore 612, 618
        }
    }
}
