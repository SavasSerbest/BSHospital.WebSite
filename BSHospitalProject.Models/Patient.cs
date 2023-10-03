using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Patient:BaseModel
    {
        public bool IsSick { get; set; }
        public bool HaveSurgery { get; set; }
        public bool IsAllergic { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
    }
}
