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
        public bool IsAllergic { get; set; } = false;
        public int? DoctorId { get; set; }
        public int? HospitalId { get; set; }
        public int? DepartmentId { get; set; }
        

        public virtual Doctor Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

       
    }
}
