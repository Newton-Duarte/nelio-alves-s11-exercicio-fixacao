try
{
  System.Console.WriteLine("Enter account data");
  System.Console.Write("Number: ");
  var number = int.Parse(Console.ReadLine());

  System.Console.Write("Holder: ");
  var holder = Console.ReadLine();

  System.Console.Write("Initial Balance: ");
  var initialBalance = double.Parse(Console.ReadLine());

  System.Console.Write("Withdraw limit: ");
  var withdrawLimit = double.Parse(Console.ReadLine());

  var account = new Account(number, holder, initialBalance, withdrawLimit);

  System.Console.Write("Enter amount for withdraw: ");
  var withdrawAmount = double.Parse(Console.ReadLine());

  account.Withdraw(withdrawAmount);

  System.Console.Write($"New balance: {account.Balance:F2}");
}
catch (DomainException e)
{
  System.Console.WriteLine(e.Message);
}