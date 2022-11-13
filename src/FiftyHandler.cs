namespace Virtualdars.DesignPatterns.ChainOfResp
{
    public class FiftyHandler : MoneyHandler
    {
        public override void Handle(int amount)
        {
            int numberofNotesToBeDispatched = amount / 50;
            if (numberofNotesToBeDispatched > 0)
            {
               Console.WriteLine(numberofNotesToBeDispatched + "-dona 50$ qog'oz pul FiftyHandler tomonidan chiqarildi.");
            }

            int pendingAmountToBeProcessed = amount % 50;
            if (pendingAmountToBeProcessed > 0)
            {
                _moneyHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
