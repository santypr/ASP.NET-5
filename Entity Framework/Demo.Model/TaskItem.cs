using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Model
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Título")]
        public string Title { get; set; }
        [Display(Name = "Descripción")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Prioridad")]
        public string Priority { get; set; }
    }
}
