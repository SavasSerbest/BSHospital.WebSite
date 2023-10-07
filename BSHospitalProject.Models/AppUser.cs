using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    [Table("Users")]
    public class AppUser : BaseModel
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int  UserTypeId { get; set; }

        public virtual UserType UserTypes { get; set; }
    }
}
