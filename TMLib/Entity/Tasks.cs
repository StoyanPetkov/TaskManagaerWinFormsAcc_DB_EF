using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMLib.Entities
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int EstimatedTime { get; set; }
        public DateTime Createdon { get; set; }
        public int CreatedBy { get; set; }
        public int Assignedto { get; set; }
        public bool IsFinished { get; set; }
    }
}
