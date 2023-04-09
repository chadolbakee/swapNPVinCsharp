using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapNPV
{
    public class ZeroRate:Discount
    {
        public List<double> getZeroRateByMaturity()
        {
            List<double> swapRateList = getSwapRateInterpolation();//Interpolation에서 가져옴
            /* by python
             swapNumOfDaysAccum = self.getNumOfDaysAccumulate(self.get_CFdays(self.npvDate,20))

            zeroRateList = [0 for i in range(20*4)]

            for i in range(len(zeroRateList)):
                zeroRateList[i] = -math.log(discountList[i])*365 / swapNumOfDaysAccum[i]

            return zeroRateList
             */
            return new List<double>();
        }
    }
}
