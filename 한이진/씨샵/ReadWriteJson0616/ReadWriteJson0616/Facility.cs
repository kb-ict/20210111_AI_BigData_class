using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteJson0616
{
    class Facility
    {
        public Facility(string num, string city, string type, string name, string address, string tel, string allpeople, string people)
        {
            this.num = num;
            this.city = city;
            this.type = type;
            this.name = name;
            this.address = address;
            this.tel = tel;
            this.allpeople = allpeople;
            this.people = people;
        }

        public string num { get; set; }
        public string city { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        public string allpeople { get; set; }
        public string people { get; set; }
    }
}
