using System.ComponentModel.DataAnnotations;

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


        public Todo(long id, string title, bool isUrgent = false, bool isDone=false)
        {
            Id = id;
            Title = title;
            IsUrgent = isUrgent;
            IsDone = isDone;
        }
        public Todo(string title, bool isUrgent = false, bool isDone = false)
        {
            Title = title;
            IsUrgent = isUrgent;
            IsDone = isDone;
        }
    }
}
