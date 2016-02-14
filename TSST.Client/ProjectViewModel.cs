using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSST.Client
{
    public class ProjectViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public  string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public  ICollection<int> UserIdList { get; set; }
        public ProjectViewModel()
        {
            UserIdList = new List<int>();
        }
    }
}
