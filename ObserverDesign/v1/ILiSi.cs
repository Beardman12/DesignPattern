using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesign.v1
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
   public interface ILiSi
    {
        public void update(string context);
    }
}
