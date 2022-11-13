namespace Virtualdars.DesignPatterns.ChainOfResp
{
    // Client
    public class ATM
    {
        private OneHundredHandler oneHunderHandler = new();
        private FiftyHandler fiftyHandler = new();
        private TwentyHandler twentyHandler = new();
        private TenHandler tenHandler = new();
        private FiveHandler fiveHandler = new();
       

        public ATM()
        {
            // Handler'lar ketma-ketligini sozlaymiz:
            oneHunderHandler.SetNextHandler(fiftyHandler);
            fiftyHandler.SetNextHandler(twentyHandler);
            twentyHandler.SetNextHandler(tenHandler);
            tenHandler.SetNextHandler(fiveHandler);
        }
        public void Withdraw(int amount)
        {
            // eng birinchi handler'ning Handle metodini chaqiramiz:
            oneHunderHandler.Handle(amount);
        }
    }
}
