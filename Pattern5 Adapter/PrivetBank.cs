namespace Pattern5_Adapter
{
    class PrivetBank
    {
        public void भेजनेकेलिए(int केलिए, string भेजने)
        {

        }
    }
    class PrivetBankToSingleBank : ISingleBank
    {
        PrivetBank privetBank;
        public PrivetBankToSingleBank(PrivetBank p)
        {
            privetBank = p;
        }

        public void Send(string recipient, int money)
        {
            privetBank.भेजनेकेलिए(money, recipient);
        }
    }
}
