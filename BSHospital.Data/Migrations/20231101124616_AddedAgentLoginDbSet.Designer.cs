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
    [Migration("20231101124616_AddedAgentLoginDbSet")]
    partial class AddedAgentLoginDbSet
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgentLoginAppointment", b =>
                {
                    b.Property<int>("AgentLoginsId")
                        .HasColumnType("int");

                    b.Property<int>("AppointmentsId")
                        .HasColumnType("int");

                    b.HasKey("AgentLoginsId", "AppointmentsId");

                    b.HasIndex("AppointmentsId");

                    b.ToTable("AgentLoginAppointment");
                });

            modelBuilder.Entity("AgentLoginDepartment", b =>
                {
                    b.Property<int>("AgentLoginsId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.HasKey("AgentLoginsId", "DepartmentsId");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("AgentLoginDepartment");
                });

            modelBuilder.Entity("AgentLoginDoctor", b =>
                {
                    b.Property<int>("AgentLoginsId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorsId")
                        .HasColumnType("int");

                    b.HasKey("AgentLoginsId", "DoctorsId");

                    b.HasIndex("DoctorsId");

                    b.ToTable("AgentLoginDoctor");
                });

            modelBuilder.Entity("AgentLoginHospital", b =>
                {
                    b.Property<int>("AgentLoginsId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalsId")
                        .HasColumnType("int");

                    b.HasKey("AgentLoginsId", "HospitalsId");

                    b.HasIndex("HospitalsId");

                    b.ToTable("AgentLoginHospital");
                });

            modelBuilder.Entity("BSHospitalProject.Models.AgentLogin", b =>
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

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UptadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AgentLogins");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UptadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Department", b =>
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

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UptadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Doctor", b =>
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

                    b.Property<string>("DocNameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UptadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

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

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UptadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<int>("AgentLoginId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UptadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AgentLoginId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("AgentLoginAppointment", b =>
                {
                    b.HasOne("BSHospitalProject.Models.AgentLogin", null)
                        .WithMany()
                        .HasForeignKey("AgentLoginsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Appointment", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AgentLoginDepartment", b =>
                {
                    b.HasOne("BSHospitalProject.Models.AgentLogin", null)
                        .WithMany()
                        .HasForeignKey("AgentLoginsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AgentLoginDoctor", b =>
                {
                    b.HasOne("BSHospitalProject.Models.AgentLogin", null)
                        .WithMany()
                        .HasForeignKey("AgentLoginsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AgentLoginHospital", b =>
                {
                    b.HasOne("BSHospitalProject.Models.AgentLogin", null)
                        .WithMany()
                        .HasForeignKey("AgentLoginsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Hospital", null)
                        .WithMany()
                        .HasForeignKey("HospitalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BSHospitalProject.Models.Appointment", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("BSHospitalProject.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("BSHospitalProject.Models.Hospital", "Hospital")
                        .WithMany("Appointments")
                        .HasForeignKey("HospitalId");

                    b.HasOne("BSHospitalProject.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId");

                    b.Navigation("Department");

                    b.Navigation("Doctor");

                    b.Navigation("Hospital");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Department", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Doctor", null)
                        .WithMany("Departments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("BSHospitalProject.Models.Hospital", null)
                        .WithMany("Departments")
                        .HasForeignKey("HospitalId");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Doctor", b =>
                {
                    b.HasOne("BSHospitalProject.Models.Hospital", "Hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Patient", b =>
                {
                    b.HasOne("BSHospitalProject.Models.AgentLogin", "AgentLogin")
                        .WithMany("Patients")
                        .HasForeignKey("AgentLoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSHospitalProject.Models.Doctor", null)
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId");

                    b.HasOne("BSHospitalProject.Models.Hospital", null)
                        .WithMany("Patients")
                        .HasForeignKey("HospitalId");

                    b.Navigation("AgentLogin");
                });

            modelBuilder.Entity("BSHospitalProject.Models.AgentLogin", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Departments");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Hospital", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Departments");

                    b.Navigation("Doctors");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("BSHospitalProject.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
