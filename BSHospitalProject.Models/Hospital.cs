using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Hospital : BaseModel
    {
        public string HospitalName { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }=new List<Appointment>();
        public virtual ICollection<Doctor> Doctors { get; set; }=new List<Doctor>();
        public virtual ICollection<Patient> Patients { get; set; }=new List<Patient>();
        public virtual ICollection<Department> Departments { get; set; }=new List<Department>();
        public virtual ICollection<AgentLogin> AgentLogins { get; set; }=new List<AgentLogin>();
    }
}
