using Bogus;
using Bogus.DataSets;

namespace UnoPlayground.Models.Bogus;

public class Finance
{
    public Faker<FinanceModel> Faker { get; init; }

    public Finance()
    {
        Faker = new Faker<FinanceModel>()
            .RuleFor(x => x.Account, f => f.Finance.Account())
            .RuleFor(x => x.AccountName, f => f.Finance.AccountName())
            .RuleFor(x => x.Amount, f => f.Finance.Amount())
            .RuleFor(x => x.TransactionType, f => f.Finance.TransactionType())
            .RuleFor(x => x.Currency, f => f.Finance.Currency())
            .RuleFor(x => x.CreditCardNumber, f => f.Finance.CreditCardNumber())
            .RuleFor(x => x.CreditCardCvv, f => f.Finance.CreditCardCvv())
            .RuleFor(x => x.BitcoinAddress, f => f.Finance.BitcoinAddress())
            .RuleFor(x => x.EthereumAddress, f => f.Finance.EthereumAddress())
            .RuleFor(x => x.RoutingNumber, f => f.Finance.RoutingNumber())
            .RuleFor(x => x.Bic, f => f.Finance.Bic())
            .RuleFor(x => x.Iban, f => f.Finance.Iban());
    }
}

public class FinanceModel
{
    public string Account { get; set; }
    public string AccountName { get; set; }
    public decimal Amount { get; set; }
    public string TransactionType { get; set; }
    public Currency Currency { get; set; }
    public string CreditCardNumber { get; set; }
    public string CreditCardCvv { get; set; }
    public string BitcoinAddress { get; set; }
    public string EthereumAddress { get; set; }
    public string RoutingNumber { get; set; }
    public string Bic { get; set; }
    public string Iban { get; set; }
}
