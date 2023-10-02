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
        public string DepartmentName { get; set; }
        public string DoctorName { get; set; }
        public string InternalPhoneNum { get; set; }
        public int HospitalNo { get; set; }
    }
}
