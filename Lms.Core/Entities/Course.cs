using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lms.Core.Entities
{
    public class Course
    {

        public int id { get; set; }
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public ICollection<Module> Modules { get; set; }
    }
}
