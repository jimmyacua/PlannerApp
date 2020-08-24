using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace PlannerAppShared.Models
{
    public class PlanRequest
    {
        [Required]
        [StringLength(100)]
        public string Title { set; get; }

        [StringLength(250)]
        public string Description { get; set; }

        public Stream CoverFile { get; set; }
    }
}
