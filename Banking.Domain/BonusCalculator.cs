namespace Banking.Domain;

public class BonusCalculator
{
    public decimal GetBonusForDepositOn(decimal balance, decimal amountOfDeposit)
    {
        return balance switch
        {
            < 5_000 => 0,
            < 10_000 => amountOfDeposit * .02M,
            _ =>  amountOfDeposit * 0.1M
        };
    }
}