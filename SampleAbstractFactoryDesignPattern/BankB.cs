using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstractFactoryDesignPattern
{
    /// <summary>  
    /// The 'ConcreteFactory2' class.  
    /// </summary>
    public class BankB : ICreditCardBaseFactory
    {
        private ExchangeCreditCardType _exchangeCreditCardType;
        private RialCreditCardType _rialCreditCardType;

        public BankB(ExchangeCreditCardType exchangeCreditCardType, RialCreditCardType  rialCreditCardType)
        {
            _exchangeCreditCardType = exchangeCreditCardType;
            _rialCreditCardType = rialCreditCardType;
        }

        public IExchangeServicesFactory GetExchangeServices()
        {
            switch (_exchangeCreditCardType)
            {
                case ExchangeCreditCardType.Silver_TYPE:
                    return new ExchangeSilverCardService();
                case ExchangeCreditCardType.Gold_TYPE:
                    return new ExchangeGoldCardService();
                case ExchangeCreditCardType.Platinum_Type:
                    return new ExchangePlatinumCardService();
                default:
                    throw new NotSupportedException("Unknown Exchange CreditCard Type");
            }
        }

        public IRialServicesFactory GetRialServices()
        {
            switch (_rialCreditCardType)
            {
                case RialCreditCardType.Silver_TYPE:
                    return new RialSilverCardService(); 
                case RialCreditCardType.Diamond_Type:
                    return new RialDiamondCardService();
                default:
                    throw new NotSupportedException("Unknown Rial CreditCard Type");
            }
        }

    }
}
