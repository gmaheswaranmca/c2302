using System;
class BankAccount{
    public string AccountHolderName;
    public string AccountNumber;
    public float balance;
    
    public void doWithDraw(float amount){
        if((balance - amount) < 0){
            Console.WriteLine("You cannot withdraw more than your balance.");
            return;
        }
        if((balance - amount) < 1000){
            Console.WriteLine("Minimum balance will be gone.");
            Console.Write("Are your sure to do?");
            if(Console.Read() != 'Y'){
                return;
            }
        }
        balance = balance - amount;
    }
    
    public void doDeposit(float amount){
        balance = balance + amount;
    }
    
    public BankAccount(string acNum, string acHolderName, float initBal){
        AccountNumber = acNum;
        AccountHolderName = acHolderName;
        balance = initBal;
    }
}
class HelloWorld {
  static void Main() {
    BankAccount mahesh=new BankAccount("100201","Maheswaran",5000);
    mahesh.doDeposit(3000);
    mahesh.doWithDraw(2000);
    Console.WriteLine($"{mahesh.AccountHolderName} of #{mahesh.AccountNumber} has balance {mahesh.balance}");
  }
}
