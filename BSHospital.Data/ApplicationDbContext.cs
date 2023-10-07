using BSHospitalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospital.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }


        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<AssistantPanel> AssistantPanels { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<ContactForm> ContactForms { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

    }
}
