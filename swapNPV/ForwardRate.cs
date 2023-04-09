using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapNPV
{
    public class ForwardRate:ZeroRate
    {
        public List<double> getForwardRateByMaturity()
        {
            List<double> swapRateList = getSwapRateInterpolation();//Interpolation에서 가져옴
            /* by python
             forwardRateList[0] = self.swapRateForTenor['CD']

            for i in range(1, len(forwardRateList), 1):
                forwardRateList[i] = ((discountList[i-1]/discountList[i])-1) * (365/swapNumOfDays[i])
             */
            return new List<double>();
        }
    }
}
