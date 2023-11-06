﻿using BSHospitalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospital.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
              
        }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
               
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<AgentLogin> AgentLogins { get; set; }
    }
}
