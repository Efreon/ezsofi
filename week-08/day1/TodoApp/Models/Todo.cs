using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace EntityFramework.Model
{
    public class Todo
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public string Description { get; set; }


        public Todo(long id, string title, bool isUrgent = false, bool isDone=false, string description="")
        {
            Id = id;
            Title = title;
            IsUrgent = isUrgent;
            IsDone = isDone;
            Description = description;
        }
        public Todo(string title, bool isUrgent = false, bool isDone = false, string description = "")
        {
            Title = title;
            IsUrgent = isUrgent;
            IsDone = isDone;
            Description = description;
        }
    }
}
