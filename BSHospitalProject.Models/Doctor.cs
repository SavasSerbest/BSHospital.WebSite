using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Doctor:BaseModel
    {
        public string DocNameSurname { get; set; }
        public int? HospitalId { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }=new List<Appointment>();
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }=new List<Patient>();
        public virtual ICollection<Department> Departments { get; set; }=new List<Department>();


    }
}
