using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstractFactoryDesignPattern
{
    /// <summary>  
    /// The 'ConcreteFactory1' class.  
    /// </summary>
    public class BankA : ICreditCardBaseFactory
    {
        public IExchangeServicesFactory GetExchangeServices()
        {
            return new ExchangeSilverCardService();
        }

        public IRialServicesFactory GetRialServices()
        {
            return new RialSilverCardService();
        }
    }
}
