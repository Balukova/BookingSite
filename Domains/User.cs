using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : IBase
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
