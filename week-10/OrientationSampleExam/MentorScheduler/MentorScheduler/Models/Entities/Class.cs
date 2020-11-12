using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentorScheduler.Models.Entities
{
    public class Class
    {
        // entity properties
        [Key]
        public long ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }

        // navigation property
        public List<Mentor> Mentors { get; set; }
    }
}
