using System.ComponentModel.DataAnnotations;

namespace TaskManagement_BE.Model
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(250)]
        public string Description { get; set; } = string.Empty; 


        public DateTime DueDate { get; set; }

        
        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedIP { get; set; } = string.Empty;
        public string UpdatedIP { get; set; } = string.Empty;
        public string MachineName { get; set; } = string.Empty;
    }
}
