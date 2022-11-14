// public meaning it can be used elsewhere
public class BankAccount
{
  // public allows variable to be read
  //get and set allow this variable to be read and re-written
  public string accountNumber { get; set; }
  // int is whole number. 
  private decimal balance { get; set; }
  public decimal getBalance()
  {
    return balance;
  }
  //void because function does not return anything
  public void makeDeposit(decimal newDeposit)
  {
    if (newDeposit < 0)
    {
      throw new Exception("Negative deposits are not valid.");
    }
    else
    {
      balance += newDeposit;
    }
  }

  //constructor. Will run when no params given
  public BankAccount()
  {
    accountNumber = "unknown";
    balance = 100.01m;
  }

  public BankAccount(string newAccountNumber)
  {
    accountNumber = newAccountNumber;
    balance = 100.01m;
  }

  //Will run when param is passed
  public BankAccount(decimal startingBalance)
  {
    accountNumber = "unknown";
    if (startingBalance > 10000)
    {
      balance = startingBalance + 2000;
    }
    else
    {
      balance = startingBalance + 100.01m;
    }

  }
}