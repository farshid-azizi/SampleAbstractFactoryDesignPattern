using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstractFactoryDesignPattern
{
    /// <summary>  
    /// The 'ProductA1' class  
    /// </summary>
    public class ExchangeSilverCardService : IExchangeServicesFactory
    {
        protected double CreditLimit;
        public ExchangeSilverCardService()
        {
            SetCreditLimit();
        }
        public void SetCreditLimit()
        {
            // Implement some init logic here...
            CreditLimit = 1000;
            Console.WriteLine("Your card is " + this.GetType().Name + " & your credit limit is " + CreditLimit.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
