using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Model
{
    class Seller
    {
        private string name;
        private string tel;
        private string level;
        private string office;

        public Seller(string name, string tel, string level, string office)
        {
            this.name = name;
            this.tel = tel;
            this.level = level;
            this.office = office;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Level { get => level; set => level = value; }
        public string Office { get => office; set => office = value; }

        public override string ToString()
        {
            String info = "직원 이름: " + name + '\n';
            info += "전화: " + tel + '\n';
            info += "직위: " + level + '\n';
            info += "소속: " + office + '\n';
            info += "------------------------";
            return info;
        }
        public void SellerInfo()
        {
            Console.WriteLine("직원 이름: " + name );
            Console.WriteLine("전화: " + tel);
            Console.WriteLine("직위: " + level);
            Console.WriteLine("소속: " + office);
            Console.WriteLine("--------------------");

        }
    }
}
