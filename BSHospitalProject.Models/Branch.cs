using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Branch:BaseModel
    {
        public string BranchName { get; set; }
        public string BranchDepartmentName { get; set; }
        public string DoctorName { get; set; }
        public string? InternalPhoneNum { get; set; }
        public int HospitalId { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
        public virtual Hospital Hospitals { get; set; }
        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}
