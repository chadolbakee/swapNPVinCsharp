using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapNPV
{
    public class SwapInitialInfo
    {
        public readonly static double notionalAmount = 10000000000;
        private readonly static string contractDate = "2022-09-28";
        public readonly static double fixedRate = 3.885;
        public readonly static double tenor = 10;
        private readonly static double direction = -1;

        //makeSwapRate 에서 나오는 list도 static으로 저장하고 싶음

        public readonly Dictionary<string, Double> SwapRateDic=new Dictionary<string, Double>();

        public void GetSwapRate(string path)
        {   
            List<double> swapRateList = new List<double>();
            string[] lines=File.ReadAllLines(path);
            foreach(string line in lines)
            {   
                string[] items=line.Split(',');
                SwapRateDic.Add(items[0], Double.Parse(items[1]));
            }
        }

        public List<double> makeSwapRate(Dictionary<string,Double> SwapRateDic)
        {
            List<double> swapList = new List<double>();

            swapList[0] = SwapRateDic["CD"];
            swapList[1] = SwapRateDic["6M"];
            swapList[2] = SwapRateDic["9M"];
            swapList[3] = SwapRateDic["1Y"];
            swapList[5] = SwapRateDic["18M"];
            swapList[7] = SwapRateDic["2Y"];
            swapList[11] = SwapRateDic["3Y"];
            swapList[15] = SwapRateDic["4Y"];
            swapList[19] = SwapRateDic["5Y"];
            swapList[23] = SwapRateDic["6Y"];
            swapList[27] = SwapRateDic["7Y"];
            swapList[31] = SwapRateDic["8Y"];
            swapList[35] = SwapRateDic["9Y"];
            swapList[39] = SwapRateDic["10Y"];
            swapList[47] = SwapRateDic["12Y"];
            swapList[59] = SwapRateDic["15Y"];
            swapList[79] = SwapRateDic["20Y"];


            return swapList;
        }
        
    }
}
