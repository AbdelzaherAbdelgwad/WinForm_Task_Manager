using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_day3.Modals
{
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed
    }
    internal class TaskItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; } // Low, Medium, High
        [Column(TypeName = "nvarchar(20)")]
        public TaskStatus Status { get; set; } // Pending, In Progress, Completed
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
