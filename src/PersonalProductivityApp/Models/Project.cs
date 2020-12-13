using System;
using System.Collections.Generic;

namespace PersonalProductivityApp.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Task> Tasks { get; set; }

        public Project()
        {
            Tasks = new List<Task>();
        }
    }
}
