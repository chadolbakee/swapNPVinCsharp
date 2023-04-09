using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapNPV
{
    public class Discount:Interpolation
    {
        public List<double> getDiscountByMaturity()
        {
            List<double> swapRateList = getSwapRateInterpolation();//Interpolation에서 가져옴

            /* by python code
             
            discountList[0] = 1/(1+swapRateInterpolation[0]*swapNumOfDays[0]/365)
            sumProductList[0] = discountList[0]*swapNumOfDays[0]

            for i in range(1, len(sumProductList), 1):

                discountList[i] = (1-swapRateInterpolation[i]*sumProductList[i-1]/365)/(1+swapRateInterpolation[i]*swapNumOfDays[i]/365)
                sumProductList[i] = sumProductList[i-1] + (swapNumOfDays[i]*discountList[i])
             */
            return new List<double>();
        }
    }
}
