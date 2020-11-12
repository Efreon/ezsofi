using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorScheduler.Models.Entities
{
    public class Mentor
    {
        // entity properties
        [Key]
        public long MentorId { get; set; }
        [Required]
        public string MentorName { get; set; }

        //navigation properties
        public GfaClass Class { get; set; }
        public long ClassId { get; set; }
        public Mentor()
        {

        }
    }
}
