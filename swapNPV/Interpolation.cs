using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapNPV
{
    public class Interpolation: SwapInitialInfo
    {   
        public List<double> getSwapRateInterpolation()
        {
            //SwapInfo swapInfo = new SwapInfo();
            List<double> swapList = makeSwapRate(SwapRateDic);
            int j = 0;

            for(int i = 0; i < swapList.Count; i++)
            {
                if (swapList[i] == 0)
                {
                    j = 1;
                    while (swapList[i + j] == 0)
                    {
                        j = j + 1;
                        if (swapList[i + j] > 0)
                        {
                            break;
                        }
                    }
                    swapList[i] = swapList[i - 1] + (swapList[i + j] - swapList[i - 1]) / (j + 1);
                }

            }
            return swapList;
        }
    }
}
