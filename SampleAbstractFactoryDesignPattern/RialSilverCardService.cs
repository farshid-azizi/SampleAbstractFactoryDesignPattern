using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstractFactoryDesignPattern
{
    /// <summary>  
    /// The 'ProductB1' class  
    /// </summary>
    public class RialSilverCardService : IRialServicesFactory
    {
        protected double CreditLimit;
        public RialSilverCardService()
        {
            SetCreditLimit();
        }
        public void SetCreditLimit()
        {
            // Implement some init logic here...
            CreditLimit = 30000000;
            Console.WriteLine("Your card is " + this.GetType().Name + " & your credit limit is " + CreditLimit.ToString("C", CultureInfo.CreateSpecificCulture("fa-IR")));
          
        }
    }
}
