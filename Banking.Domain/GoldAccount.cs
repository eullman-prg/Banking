
namespace Banking.Domain;

public class GoldAccount : Account
{

    public override void Deposit(decimal amountToDeposit)
    {
        //  base.Deposit(amountToDeposit * 1.10M);
        base._balance += amountToDeposit * 1.10M;
    }
}


//public class PlatinumAccount : Account
//{
//    public override void Deposit(decimal amountToDeposit)
//    {
//        base.Deposit(amountToDeposit * 1.20M);
//    }
//}