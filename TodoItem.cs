using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazorapp
{
    public class TodoItem
    {
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public Boolean IsDone { get; set; } = false;
    }
}
