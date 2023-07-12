﻿// <auto-generated />
using System;
using EnergyCollab.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
#nullable disable
namespace EnergyCollab.Services.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230704170400_signUp")]
    partial class signUp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
            modelBuilder.Entity("EnergyCollab.Models.CandidateProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");
                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("AddressOne")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("AddressTwo")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("AmountOfPersonnelAvailable")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("AuthorisedToWorkCodeValues")
                        .HasColumnType("nvarchar(max)");
                    b.Property<DateTime?>("AvailableDate")
                        .HasColumnType("datetime2");
                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("CurrentCompanyName")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("CurrentJobTitle")
                        .HasColumnType("nvarchar(max)");
                    b.Property<Guid?>("CvFileId")
                        .HasColumnType("uniqueidentifier");
                    b.Property<string>("DescriptionOfPersonnelAvailable")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("EducationCodeValue")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("EmploymentTypeCodeValues")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("ExperienceDisciplineFirstLevelCodeValue")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("FacebookUrl")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("IndustryExperienceCodeValue")
                        .HasColumnType("nvarchar(max)");
                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");
                    b.Property<bool?>("IsPublic")
                        .HasColumnType("bit");
                    b.Property<DateTime?>("LastCvUpdateDateTime")
                        .HasColumnType("datetime2");
                    b.Property<string>("LinkedinUrl")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("NationalityCodeValue")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("PersonalWebSiteUrl")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("PrimaryContactNumber")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("ProjectBeingDownManned")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("SecondaryContactNumber")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("SummaryOfExperienceCategoryCodeValue")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");
                    b.Property<Guid?>("UserAccountId")
                        .HasColumnType("uniqueidentifier");
                    b.Property<string>("WillingToRelocateCodeValue")
                        .HasColumnType("nvarchar(max)");
                    b.Property<bool?>("WillingToTravel")
                        .HasColumnType("bit");
                    b.HasKey("Id");
                    b.ToTable("CandidateProfiles");
                });
            modelBuilder.Entity("EnergyCollab.Web.Models.SignUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");
                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.HasKey("Id");
                    b.ToTable("SignUps");
                });
#pragma warning restore 612, 618
        }
    }
}
