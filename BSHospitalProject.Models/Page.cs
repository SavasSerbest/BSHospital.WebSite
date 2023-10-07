using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHospitalProject.Models
{
    public class Page:BaseModel
    {
        public string Content { get; set; }
        public string Slug { get; set; }
        public string? Thumbnail { get; set; }
        public int ViewCount { get; set; }
    }
}
