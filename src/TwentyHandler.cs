namespace Virtualdars.DesignPatterns.ChainOfResp
{
    public class TwentyHandler : MoneyHandler
    {
        public override void Handle(int amount)
        {
            int numberofNotesToBeDispatched = amount / 20;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine(numberofNotesToBeDispatched + "-dona 20$ qog'oz pul TwentyHandler tomonidan chiqarildi.");
            }
            int pendingAmountToBeProcessed = amount % 20;
            if (pendingAmountToBeProcessed > 0)
            {
                _moneyHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
