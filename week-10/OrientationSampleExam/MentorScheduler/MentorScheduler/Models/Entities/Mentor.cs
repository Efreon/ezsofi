using System.ComponentModel.DataAnnotations;

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
        public Mentor(string mentorName, GfaClass gfaClass)
        {
            MentorName = mentorName;
            Class = gfaClass; 
        }
        public Mentor()
        {

        }
    }
}
