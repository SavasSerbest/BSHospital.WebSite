using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Hospital:BaseModel
    {
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string HospitalName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
        public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}
