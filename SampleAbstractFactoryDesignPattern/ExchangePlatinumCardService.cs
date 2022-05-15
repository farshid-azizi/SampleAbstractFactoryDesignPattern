using System.Globalization;

namespace SampleAbstractFactoryDesignPattern
{
    /// <summary>  
    /// The 'ProductA3' class  
    /// </summary>
    public class ExchangePlatinumCardService : IExchangeServicesFactory
    {
        protected double CreditLimit;
        public ExchangePlatinumCardService()
        {
            SetCreditLimit();
        }
        public void SetCreditLimit()
        {
            // Implement some init logic here...
            CreditLimit = 5000;
            Console.WriteLine("Your card is " + this.GetType().Name + " & your credit limit is " + CreditLimit.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}