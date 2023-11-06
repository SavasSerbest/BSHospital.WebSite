using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class AgentLogin:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }=new List<Patient>();
        public virtual ICollection<Hospital> Hospitals { get; set; }=new List<Hospital>();
        public virtual ICollection<Doctor> Doctors { get; set; }=new List<Doctor>();
        public virtual ICollection<Appointment> Appointments { get; set; }=new List<Appointment>();
        public virtual ICollection<Department> Departments { get; set; }=new List<Department>();
    }
}
