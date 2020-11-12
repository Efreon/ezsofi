using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentorScheduler.Models.Entities
{
    public class GfaClass
    {
        // entity properties
        [Key]
        public long ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }

        // navigation property
        public List<Mentor> Mentors { get; set; }
        public GfaClass(string  className)
        {
            ClassName = className; 
        }
        public GfaClass()
        {
            Mentors = new List<Mentor>();
        }
    }
}
