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
    [Migration("20230714142803_removeCompanyName")]
    partial class removeCompanyName
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

            modelBuilder.Entity("EnergyCollab.Services.API.Models.ClientSignup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientSignups");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Login", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("countryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("countryId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Vacancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActivationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("AdditionalInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpCategory")
                        .HasColumnType("int");

                    b.Property<string>("EntryRequirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("ScopeofResponsibilities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VacancyAdvertLength")
                        .HasColumnType("int");

                    b.Property<bool>("Visa")
                        .HasColumnType("bit");

                    b.Property<int?>("countryId")
                        .HasColumnType("int");

                    b.Property<int?>("experienceId")
                        .HasColumnType("int");

                    b.Property<int?>("organizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("countryId");

                    b.HasIndex("experienceId");

                    b.HasIndex("organizationId");

                    b.ToTable("Vacancies");
                });

            modelBuilder.Entity("EnergyCollab.Web.Models.SignUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SignUps");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Organization", b =>
                {
                    b.HasOne("EnergyCollab.Services.API.Models.Country", "country")
                        .WithMany("organizations")
                        .HasForeignKey("countryId");

                    b.Navigation("country");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Vacancy", b =>
                {
                    b.HasOne("EnergyCollab.Services.API.Models.Country", "country")
                        .WithMany("vacancies")
                        .HasForeignKey("countryId");

                    b.HasOne("EnergyCollab.Services.API.Models.Experience", "experience")
                        .WithMany("Vacancies")
                        .HasForeignKey("experienceId");

                    b.HasOne("EnergyCollab.Services.API.Models.Organization", "organization")
                        .WithMany("Vacancies")
                        .HasForeignKey("organizationId");

                    b.Navigation("country");

                    b.Navigation("experience");

                    b.Navigation("organization");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Country", b =>
                {
                    b.Navigation("organizations");

                    b.Navigation("vacancies");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Experience", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("EnergyCollab.Services.API.Models.Organization", b =>
                {
                    b.Navigation("Vacancies");
                });
#pragma warning restore 612, 618
        }
    }
}
