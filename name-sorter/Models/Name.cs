using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Models
{
    public class Name
    {
        public Name()
        {
        }
        public Name(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}


