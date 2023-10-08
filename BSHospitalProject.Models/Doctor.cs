using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Doctor:BaseModel
    {
        public string DoctorName { get; set; }
        public string DoctorDepartmentName { get; set; }
        public string Fields { get; set; }
        public int BranchId { get; set; }
       
        

        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Hospital>? Hospitals { get; set; }
        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
        
    }
}
