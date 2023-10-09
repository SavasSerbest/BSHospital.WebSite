using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class BaseModel
    {
       public int Id { get; set; }
        public string Address { get; set; }
        public string City {  get; set; }
        public string Phone { get; set; }
        public bool IsCanceled { get; set; }=false;
        public DateTime UptadedDate { get; set; }=DateTime.Now;
        
    }
}
