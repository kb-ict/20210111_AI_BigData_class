using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteJson0616
{
    public class Hospital
    {
        public Hospital(int num, string openDate, string totalRoom, string address, string name, string type, string tel)
        {
            this.num = num;
            this.openDate = openDate;
            this.totalRoom = totalRoom;
            this.address = address;
            this.name = name;
            this.type = type;
            this.tel = tel;
        }

        public int num { get; set; }
        public string openDate { get; set; }
        public string totalRoom { get; set; }
        public string address { get; set; }
        public string  name { get; set; }
        public string type { get; set; }
        public string tel { get; set; }


    }
}
