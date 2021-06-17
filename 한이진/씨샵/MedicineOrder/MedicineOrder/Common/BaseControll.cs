using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Common
{
    abstract class BaseControll
    {
        protected List<Object> listItme;
        public abstract void addItem(Object item);
        public abstract void viewItem();
        public abstract void dealItem(string item);
        public abstract void updataItem(string[] item);
        public abstract void delAll();
    }
}
