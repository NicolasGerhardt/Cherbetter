using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cherbetter.Models
{
    public class Ticket
    {
        public int TID { get; set; }
        public string Title { get; set; }
        public string TDescription { get; set; }
        public int TStatus { get; set; }
        public string Resolution { get; set; }
    }
}
