namespace Virtualdars.DesignPatterns.ChainOfResp
{
    public class FiveHandler : MoneyHandler
    {
        public override void Handle(int amount)
        {
            int numberofNotesToBeDispatched = amount / 5;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine(numberofNotesToBeDispatched + "-dona 5$ qog'oz pul FiveHandler tomonidan chiqarildi.");
            }
            int pendingAmountToBeProcessed = amount % 5;
            if (pendingAmountToBeProcessed > 0)
            {
                _moneyHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
