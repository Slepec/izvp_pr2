using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr2
{
    public class Residents
    {
        private string name;
        private string address;
        private DateTime birth;

        public Residents(string name, string address, DateTime birth)
        {
            this.Name = name;
            this.Address = address;
            this.Birth = birth;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Birth { get => birth; set => birth = value; }
    }
}
