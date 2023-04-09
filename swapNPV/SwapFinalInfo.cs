using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapNPV
{
    public class SwapFinalInfo
    {
        SwapInitialInfo swapInitial = new SwapInitialInfo();//거래 정보
        //날짜 변수
        public string cashFlowDate;//cashflow 날짜
        public int numOfDaysToToday;//npv 평가 날짜로부터 cashFlowDate까지의 날짜
        public int numOfDaysToFormerCF;//이전 cf까지의 날짜

        //필요한 커브
        public double swapRateForEachCF;//각 cf별 보간한 금리
        public double discountRateForEachCF;//각 cf 별 할인계수
        public double zeroRateForEachCF;//각 cf 별 무이표금리
        public double forwardRateForEachCF;//각 cf 별 선도금리



        //메소드
        public double getFixedCF()
        {
            double notional = SwapInitialInfo.notionalAmount;
            double price = SwapInitialInfo.fixedRate;
            
            double discount = this.discountRateForEachCF;
            double FixedCF = notional * price*discount;

            return FixedCF;
        }

        public double getFloatingCF()
        {
            double notional = SwapInitialInfo.notionalAmount;
            double price = SwapInitialInfo.fixedRate;
            double FloatingCF = notional * this.forwardRateForEachCF;
            return FloatingCF;
        }
    }
}
