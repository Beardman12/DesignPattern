using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesign.v1
{
    /// <summary>
    /// 具体的被观察者
    /// </summary>
    public class HanFeiZi : IHanFeiZi
    {
        private bool isHavingBreakfast = false;
        private bool isHaveFun = false;
        public void HaveBreakfast()
        {
            Console.WriteLine("韩非子：开始吃饭了.....");
            this.isHavingBreakfast = true;
        }

        public void HaveFun()
        {
            Console.WriteLine("韩非子：出来玩啊.....");
            this.isHaveFun = true;
        }
        public bool IsHavingBreakfast()
        {
            return this.isHavingBreakfast;
        }

        public void SetHavingBreakfast(bool isHavingBreakfast)
        {
            this.isHavingBreakfast = isHavingBreakfast;
        }
        public bool IsHavingFun()
        {
            return this.isHaveFun;
        }

        public void SetHavingFun(bool isHavingFun)
        {
            this.isHaveFun = isHavingFun;
        }

    }
}
