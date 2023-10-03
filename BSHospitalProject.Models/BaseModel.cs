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
        public string NameSurname { get; set; }
        public string? EmailAddress {  get; set; }
        public string TCKN { get; set;}
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        

    }
}
