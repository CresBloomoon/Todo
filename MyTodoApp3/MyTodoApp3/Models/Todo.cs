using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodoApp3.Models
{
    public sealed class Todo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
