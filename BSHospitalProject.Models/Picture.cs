using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Picture:BaseModel
    {
        public string Path { get; set; }
        public string? Alt { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int AppointmentId { get; set; }
        public int BranchId { get; set; }
        public int DoctortId { get; set; }
        public int HospitalId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
