using CustCar0415.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Common
{
    abstract class BaseControll // 추상클래스 정의 (또는 인터페이스로 정의하여 구현)
    {
        protected RandData rand;
        protected List<object> listItem;
        public abstract void insRandData(int count);
        public abstract void itemView();
        public abstract void removeAll();
        public abstract void addItem(object item);
        public abstract void delItem(string item);
        public abstract void updateItem(string[] item);
    }
}
