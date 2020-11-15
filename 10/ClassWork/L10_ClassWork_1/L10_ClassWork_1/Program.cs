using System;

namespace L10_ClassWork_1
{
	class CreditCard
	{
		private string _cardNumber;

		public string HolderName { get; set; }
		public string ValidBefore { get; set; }
		public ushort CodeCVC { get; set; }
		public string CardNumber
		{
			get
			{
				return _cardNumber;
			}
			set
			{
				foreach (char ch in value)
				{
					if (!char.IsDigit(ch))
					{
						throw new Exception("Извините так незя!");
					}
				}
				_cardNumber = value;
			}
		}

		public bool IsValid()
		{
			return (CardNumber == null && CardNumber.Length <= 12 && CardNumber.Length >= 26);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			CreditCard creditCard = new CreditCard();
			creditCard.HolderName = "George Verkhovcev";

			creditCard.CardNumber = Console.ReadLine();

			creditCard.ValidBefore = "12/25";
			creditCard.CodeCVC = 143;

			Console.WriteLine(creditCard.CardNumber);

			CreditCard[] creditCards = new CreditCard[2];
			creditCards[0] = creditCard;
		}
	}
}
