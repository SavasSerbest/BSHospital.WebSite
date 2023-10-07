using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Patient:BaseModel
    {
        public string NameSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public string TCKN { get; set; }
        public bool IsSick { get; set; } = false;
        public bool HaveSurgery { get; set; } = false;
        public bool IsAllergic { get; set; }=false;
        public bool TakeMedicine { get; set; }=false;
        public bool HaveAppointment { get; set; }=false;
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AppointmentId { get; set; }
        public int HospitalId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }=new List<Branch>();
        public virtual ICollection<Doctor> Doctors { get; set; }=new List<Doctor>();
        public virtual Hospital Hospital { get; set; }
        public virtual Department Department { get; set; }

    }
}
