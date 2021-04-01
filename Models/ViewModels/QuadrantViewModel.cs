using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstThingsFirst.Models.ViewModels
{
    public class QuadrantViewModel
    {
        public IEnumerable<TaskItem> Quadrant1 { get; set; }
        public IEnumerable<TaskItem> Quadrant2 { get; set; }
        public IEnumerable<TaskItem> Quadrant3 { get; set; }
        public IEnumerable<TaskItem> Quadrant4 { get; set; }
    }
}
