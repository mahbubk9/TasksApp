using System.ComponentModel.DataAnnotations;

namespace TasksApp.Models;

public class Tasks
{
   
    public int ID { get; set; }
   
    public string? TaskNames { get; set; }
    public string? Description { get; set; }
    [DataType(DataType.MultilineText)]
    public string? Priotity { get; set; }
    public DateTime? DateCreated { get; set; }

    public DateTime? DeadLIne { get; set; }

}
