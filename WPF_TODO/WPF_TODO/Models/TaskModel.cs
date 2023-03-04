using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_TODO.Models
{
    internal sealed class TaskModel
    {
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public bool Done { get; set; }
    }
}
