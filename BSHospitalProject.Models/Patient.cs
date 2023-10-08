using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Patient : BaseModel
    {
        public string NameSurname { get; set; }
        public string TCKN { get; set; }
        public int Age { get; set; }
        public bool IsSick { get; set; } = false;
        public bool HaveSurgery { get; set; } = false;
<<<<<<< HEAD
        public bool IsAllergic { get; set; } = false;
        public int? DoctorId { get; set; }
        public int? HospitalId { get; set; }
        public int? DepartmentId { get; set; }
        
=======
        public bool IsAllergic { get; set; }=false;
        public bool TakeMedicine { get; set; }=false;
        public bool HaveAppointment { get; set; }=false;
        public double Weight { get; set; }
        public double Height { get; set; }
        public int HospitalId { get; set; }
        public int DepartmentId { get; set; }
>>>>>>> 8fb093aba1f4680ddc32ad4dd51e4a8e203611e5

        public virtual Doctor Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

       
    }
}
