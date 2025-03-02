using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_day3.Modals
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

    }
}
