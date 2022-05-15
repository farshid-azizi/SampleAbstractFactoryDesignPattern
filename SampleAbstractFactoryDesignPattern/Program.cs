// See https://aka.ms/new-console-template for more information
using SampleAbstractFactoryDesignPattern;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("************** BankA ***********************");
ICreditCardBaseFactory baseFactory = new BankA();
baseFactory.GetExchangeServices();
baseFactory.GetRialServices();
Console.WriteLine("************** BankB ***********************");
baseFactory = new BankB(ExchangeCreditCardType.Gold_TYPE, RialCreditCardType.Diamond_Type);
baseFactory.GetExchangeServices();
baseFactory.GetRialServices();

Console.ReadKey();
public enum ExchangeCreditCardType
{
    Silver_TYPE,
    Gold_TYPE,
    Platinum_Type
}

public enum RialCreditCardType
{
    Silver_TYPE,
    Diamond_Type

}
