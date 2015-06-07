using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMLib.Entities
{
    public class TimeSpent
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int Taskid { get; set; }
        public int LogTime { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinished { get; set; }
    }
}
