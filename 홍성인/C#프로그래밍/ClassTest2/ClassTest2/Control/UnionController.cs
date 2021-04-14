using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Control
{
    class UnionController
    {
        CarController carHandle;
        CustController custHandle;
        SellController sellHandle;

        // 3.생성자 오버로딩
        public UnionController(RandData rand)
        {
            carHandle = new CarController(rand);
            custHandle = new CustController(rand);
            sellHandle = new SellController(rand);
        }

        // 2.생성자 만들기
        public UnionController(CarController carHandle, CustController custHandle, SellController sellHandle)
        {
            this.carHandle = carHandle;
            this.custHandle = custHandle;
            this.sellHandle = sellHandle;
        }

        // 1.getter setter 생성
        internal CarController CarHandle { get => carHandle; set => carHandle = value; }
        internal CustController CustHandle { get => custHandle; set => custHandle = value; }
        internal SellController SellHandle { get => sellHandle; set => sellHandle = value; }
    }
}
