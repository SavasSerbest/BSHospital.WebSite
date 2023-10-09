using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Appointment:BaseModel
    {
        public DateTime AppointmentDate { get; set; }= DateTime.Now;
        public int? DoctorId { get; set; }
        public int? HospitalId { get; set; }
        public int? PatientId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Department Department { get; set; }
    }
}
