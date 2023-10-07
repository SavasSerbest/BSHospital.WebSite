﻿// <auto-generated />
using System;
using BSHospital.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BSHospital.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231007200225_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppointmentPatient", b =>
                {
                    b.Property<int>("AppointmentsId")
                        .HasColumnType("int");

                    b.Property<int>("PatientsId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentsId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("AppointmentPatient");
                });

            modelBuilder.Entity("BSHospitalProject.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("DeparmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BSHospitalProject.Models.AssistantPanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AssistantPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssistantPanels");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BranchDepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<string>("InternalPhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("BSHospitalProject.Models.ContactForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorDepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fields")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("HaveAppointment")
                        .HasColumnType("bit");

                    b.Property<bool>("HaveSurgery")
                        .HasColumnType("bit");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAllergic")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSick")
                        .HasColumnType("bit");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TakeMedicine")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctortId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("BranchId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("BSHospitalProject.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("BranchDepartment", b =>
                {
                    b.Property<int>("BranchesId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.HasKey("BranchesId", "DepartmentsId");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("BranchDepartment");
                });

            modelBuilder.Entity("BranchPatient", b =>
                {
                    b.Property<int>("BranchesId")
                        .HasColumnType("int");

                    b.Property<int>("PatientsId")
                        .HasColumnType("int");

                    b.HasKey("BranchesId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("BranchPatient");
                });

            modelBuilder.Entity("DepartmentDoctor", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorsId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "DoctorsId");

                    b.HasIndex("DoctorsId");

                    b.ToTable("DepartmentDoctor");
                });

            modelBuilder.Entity("DepartmentHospital", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalsId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "HospitalsId");

                    b.HasIndex("HospitalsId");

                    b.ToTable("DepartmentHospital");
                });

            modelBuilder.Entity("DoctorPatient", b =>
                {
                    b.Property<int>("DoctorsId")
                        .HasColumnType("int");

                    b.Property<int>("PatientsId")
                        .HasColumnType("int");

                    b.HasKey("DoctorsId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("DoctorPatient");
                });

            modelBuilder.Entity("AppointmentPatient", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Appointment", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BSHospitalProject.Models.AppUser", b =>
                {
                    b.HasOne("BSHospitalProject.Models.UserType", "UserTypes")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserTypes");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Appointment", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Branch", "Branches")
                        .WithMany("Appointments")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Department", "Department")
                        .WithMany("Appointments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Doctor", "Doctors")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Hospital", "Hospitals")
                        .WithMany("Appointments")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branches");

                    b.Navigation("Department");

                    b.Navigation("Doctors");

                    b.Navigation("Hospitals");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Branch", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Hospital", "Hospitals")
                        .WithMany("Branches")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospitals");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Doctor", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Branch", "Branch")
                        .WithMany("Doctors")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Hospital", "Hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Patient", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Department", "Department")
                        .WithMany("Patients")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Hospital", "Hospital")
                        .WithMany("Patients")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Picture", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Appointment", "Appointment")
                        .WithMany("Pictures")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Branch", "Branch")
                        .WithMany("Pictures")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Doctor", "Doctor")
                        .WithMany("Pictures")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Hospital", "Hospital")
                        .WithMany("Pictures")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Branch");

                    b.Navigation("Doctor");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("BranchDepartment", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Branch", null)
                        .WithMany()
                        .HasForeignKey("BranchesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BranchPatient", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Branch", null)
                        .WithMany()
                        .HasForeignKey("BranchesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DepartmentDoctor", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DepartmentHospital", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Hospital", null)
                        .WithMany()
                        .HasForeignKey("HospitalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorPatient", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BSHospitalProject.Models.Appointment", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Branch", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Doctors");

                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Department", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Hospital", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Branches");

                    b.Navigation("Doctors");

                    b.Navigation("Patients");

                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}
