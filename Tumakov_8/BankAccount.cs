using System.Security.Policy;

namespace Tumakov_8
{
    class Bank_Account
    {
        public enum Type_bank_account
        {
            Текущий,
            Сберегательный
        }
        private static uint next_number_account = 1;
        private uint number_account;
        private decimal balance;
        private Type_bank_account bank_account;

        public uint Number_Account
        {
            get { return number_account; }
        }
        public decimal Balance_Account
        {
            get { return balance; }

            set { balance = value; }
        }
        public Type_bank_account Type_Bank_Account
        {
            get { return bank_account; }
            set { bank_account = value; }
        }
        private void Generate_next_number_account()
        {
            next_number_account++;
        }
        public bool Withdraw(uint withdrawn_money)
        {
            if (balance - withdrawn_money > 0)
            {
                balance -= withdrawn_money;
                return true;
            }
            return false;
        }
        public void Put_Money(uint money)
        {
            balance += money;
        }
        public bool Transfer_money(Bank_Account account, decimal money)
        {
            if ((money > 0) && (balance - money > 0))
            {
                account.balance += money;
                balance -= money;
                return true;
            }
            return false;
        }

        public Bank_Account(decimal balance, Type_bank_account bank_account)
        {
            number_account = next_number_account;
            this.balance = balance;
            this.bank_account = bank_account;
            Generate_next_number_account();
        }
    }
}
