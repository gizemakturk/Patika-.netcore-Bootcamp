namespace Paycore_Net_Bootcamp_Hafta_1.Models
{
    public class Interest
    {
        public double InterestAmount { get; set; } // vade sonu elindeki toplam para
        public double InterestRate { get; set; } // faiz oranı
        public double TotalBalance  { get; set; } // ana para

        public Interest (double interestAmount, double interestRate, double totalBalance)
        {
            InterestAmount = interestAmount;
            InterestRate = interestRate;
            TotalBalance = totalBalance;
        }
    }
}
