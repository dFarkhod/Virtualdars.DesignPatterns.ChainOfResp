namespace Virtualdars.DesignPatterns.ChainOfResp
{
    public interface IMoneyHandler
    {
        void SetNextHandler(IMoneyHandler nextHandler);
        void Handle(int amount);
    }

    public abstract class MoneyHandler : IMoneyHandler
    {
        public IMoneyHandler _moneyHandler;
        public abstract void Handle(int amount);

        public void SetNextHandler(IMoneyHandler nextHandler)
        {
            this._moneyHandler = nextHandler;
        }


    
    }
}
