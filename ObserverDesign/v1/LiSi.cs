using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesign.v1
{
    public class LiSi : ILiSi
    {
        public void update(string context)
        {
            Console.WriteLine("李斯:观察到韩非子的活动，开始向老板报告....");
            this.reportToQiShiHuang(context);
            Console.WriteLine("李斯:汇报完毕....");

        }
        private void reportToQiShiHuang(string reportContext)
        {
            Console.WriteLine("李斯:报告老板！韩非子有活动了....");
          
        }
    }
}
