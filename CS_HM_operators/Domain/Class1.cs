using System;

namespace Domain
{
    public class CreditCard
    {
        private string cardNumber;
        private int cvc;
        private DateTime expiryDate;
        private decimal balance;

        public string CardNumber { get { return cardNumber; } }
        public int Cvc { get { return cvc; } }
        public DateTime ExpiryDate { get { return expiryDate; } }
        public decimal Balance { get { return balance; } }

        public CreditCard(string cardNumber, int cvc, DateTime expiryDate, decimal balance)
        {
            this.cardNumber = cardNumber;
            this.cvc = cvc;
            this.expiryDate = expiryDate;
            this.balance = balance;
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card.balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.Cvc == card2.Cvc;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.Cvc != card2.Cvc;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            CreditCard card = (CreditCard)obj;
            return cvc == card.cvc;
        }

        public void DisplayCardInformation()
        {
            Console.WriteLine($"Card Number: {cardNumber}");
            Console.WriteLine($"CVC: {cvc}");
            Console.WriteLine($"Expiry Date: {expiryDate}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}