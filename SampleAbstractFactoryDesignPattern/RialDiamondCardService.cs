using System.Globalization;

namespace SampleAbstractFactoryDesignPattern
{
    /// <summary>  
    /// The 'ProductB2' class  
    /// </summary>
    public class RialDiamondCardService : IRialServicesFactory
    {
        protected double CreditLimit;
        public RialDiamondCardService()
        {
            SetCreditLimit();
        }
        public void SetCreditLimit()
        {
            // Implement some init logic here...
            CreditLimit = 200000000;
            Console.WriteLine("Your card is " + this.GetType().Name + " & your credit limit is " + CreditLimit.ToString("C", CultureInfo.CreateSpecificCulture("fa-IR")));
        }
    }
}