using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstThingsFirst.Models
{
    public class TaskItem
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        [Required]
        public bool TaskUrgent { get; set; }
        [Required]
        public bool TaskImportant { get; set; }

        public string GetQuadrant()
        {
            string quadrantName = "";

            if (TaskUrgent && TaskImportant)
            {
                quadrantName = "Quadrant 1";
            }
            else if (!TaskUrgent && TaskImportant)
            {
                quadrantName = "Quadrant 2";
            }
            else if (TaskUrgent && !TaskImportant)
            {
                quadrantName = "Quadrant 3";
            }
            else if (!TaskUrgent && !TaskImportant)
            {
                quadrantName = "Quadrant 4";
            }

            return quadrantName;
        }
    }
}
