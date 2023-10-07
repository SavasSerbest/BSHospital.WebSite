using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Appointment:BaseModel
    {
        public DateTime AppointmentDate { get; set; }
        public int BranchId { get; set; }
        public int DoctorId { get; set; }
        public int HospitalId { get; set; }
        public int PatientId { get; set; }
        public int DeparmentId { get; set; }

        public virtual Branch Branches { get; set; }
        public virtual Doctor Doctors { get; set; }
        public virtual Hospital Hospitals { get; set; }
        public virtual Patient Patients { get; set; }
        public virtual ICollection <Picture> Pictures { get; set; } = new List<Picture>();
        public virtual Department Department { get; set; }


       

    }
}
