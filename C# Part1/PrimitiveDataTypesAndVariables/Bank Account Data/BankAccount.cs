//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types
//and descriptive names.
using System;


namespace Bank_Account_Data
{
    class BankAccount
    {
        private int balance;
        private string bankName;
        private int iBAN;
        private Person holder;
        private Card firstCard;
        private Card sCard;
        private Card tCard;
        public int Balance { get; private set; }
        public string BankName { get; private set; }
        public int IBAN { get; private set; }
        public Person Holder { get; private set; }       
        public Card FirstCard
        {
            get { return this.firstCard; }
            set { firstCard = value; }
             
        }
        
        
        public BankAccount(Person holder, Card fCard, int iBAN, string bankName, int balance)
        {
            this.Holder = holder;
            this.FirstCard = fCard;
            this.IBAN = iBAN;
            this.BankName = bankName;
            this.Balance = balance;
        }
        static void Main()
        {
            Person theHolder = new Person("Stoqn", "Georgiev", "Markov");
            Card fCard = new Card("debit",400032);
            BankAccount myBankAccount = new BankAccount(theHolder, fCard, 676889899, "AlfaBank", 34638);
            string cardType = myBankAccount.firstCard.Type;
            Console.WriteLine(cardType);
        }
    }


}
