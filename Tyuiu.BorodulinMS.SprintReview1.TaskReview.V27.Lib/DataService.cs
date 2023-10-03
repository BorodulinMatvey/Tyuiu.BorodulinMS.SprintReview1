using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BorodulinMS.SprintReview1.TaskReview.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            var tr = Math.Pow(x, 2);
            var res = Math.Cos(tr);

            var tr2 = Math.Pow(y,2);
            var res2 = Math.Sin(tr2);

            
            var res3 = res + res2;
            var res4 = Math.Sin(y) + 1;

            var res5 = res3 / res4;

            var res6 = x * y - 12;
            var res7 = 15 + Math.Cos(x);

            var res8 = res6 / res7;

            var res9 = res5 - res8;


   
      
            return Math.Round(res9, 3);
         }
    }
}
