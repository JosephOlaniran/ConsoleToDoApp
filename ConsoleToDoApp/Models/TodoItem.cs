using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoApp.Models
{
    public class TodoItem
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public TodoItem( string description) {
            Description = description;
            IsCompleted = false;
        }//Constructor


        public override string ToString()
        {
            string status = IsCompleted ? "[Completed]" : "[Pending]"; //if statement to ditacte current status of the item
            return $"{Description} {status}";
        }
    }
}
