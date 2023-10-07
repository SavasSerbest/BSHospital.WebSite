using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Department:BaseModel
    {
        public string Name { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }=new List<Appointment>();
        public virtual ICollection<Branch> Branches { get; set; }=new List<Branch>();
        public virtual ICollection<Doctor> Doctors { get; set; }=new List<Doctor>();
        public virtual ICollection<Hospital> Hospitals { get; set; }=new List<Hospital>();
        public virtual ICollection<Patient> Patients { get; set; }=new List<Patient>();
    }
}
