BankAccount account = new BankAccount(10001);

try
{
  account.makeDeposit(-100);
}
catch (Exception ex)
{
  Console.WriteLine(ex.Message);
}

Console.WriteLine($" Your account balance is: {account.getBalance()}");