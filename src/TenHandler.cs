namespace Virtualdars.DesignPatterns.ChainOfResp
{
    public class TenHandler : MoneyHandler
    {
        public override void Handle(int amount)
        {
            int numberofNotesToBeDispatched = amount / 10;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine(numberofNotesToBeDispatched + "-dona 10$ qog'oz pul TenHandler tomonidan chiqarildi.");
            }
            int pendingAmountToBeProcessed = amount % 10;
            if (pendingAmountToBeProcessed > 0)
            {
                _moneyHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
