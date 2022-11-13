namespace Virtualdars.DesignPatterns.ChainOfResp
{
    public class OneHundredHandler : MoneyHandler
    {
        public override void Handle(int amount)
        {
            int numberofNotesToBeDispatched = amount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine(numberofNotesToBeDispatched + "-dona 100$ qog'oz pul OneHundredHandler tomonidan chiqarildi.");
            }
            int pendingAmountToBeProcessed = amount % 100;
            if (pendingAmountToBeProcessed > 0)
            {
                _moneyHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
