namespace Pattern5_Adapter
{
    class BetaBank
    {
        public void Otpravitb(string recipient, int money)
        {

        }

    }

    class BetaBankToSingleBank:ISingleBank
    {
        BetaBank betaBank;
        public BetaBankToSingleBank(BetaBank b)
        {
            betaBank = b;
        }

        public void Send(string recipient, int money)
        {
            betaBank.Otpravitb(recipient, money);
        }
    }

}
