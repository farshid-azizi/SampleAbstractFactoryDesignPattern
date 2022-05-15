using System.Globalization;

namespace SampleAbstractFactoryDesignPattern
{
    /// <summary>  
    /// The 'ProductA2' class  
    /// </summary>
    public class ExchangeGoldCardService : IExchangeServicesFactory
    {
        protected double CreditLimit;
        public ExchangeGoldCardService()
        {
            SetCreditLimit();
        }
        public void SetCreditLimit()
        {
            // Implement some init logic here...
            CreditLimit = 2500;
            Console.WriteLine("Your card is " + this.GetType().Name + " & your credit limit is " + CreditLimit.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}