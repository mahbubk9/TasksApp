using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TasksApp.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Task Table")]
        public string Task{ get; set; }
        public string Description { get; set; }
        [DataType(DataType.MultilineText)]
        public string Priotity { get; set; }
        public DateTime? DateCreated { get; set; }

        public DateTime? DeadLIne { get; set; }
    }
}
