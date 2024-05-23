public class Program
{
    static void Main(string[] args)
    {
        List<Account> accounts = new List<Account>
        {
            new SavingsAccount("12345", "1234", 1000),
            new CheckingAccount("67890", "5678", 500),
            new CheckingAccount("4000", "1234", 1500),
            new CheckingAccount("4000", "1234", 1500),
            new CheckingAccount("4000", "1234", 1500),
            new CheckingAccount("4000", "1234", 1500),
        };

        while (true)
        {
            Console.WriteLine("Welcome to the ATM");

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            Account currentAccount = Login(accounts, accountNumber, pin);

            if (currentAccount != null)
            {
                Console.WriteLine($"Logged in as {currentAccount.AccountNumber}");

                bool continueLoop = true;

                while (continueLoop)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter option: ");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter amount to deposit: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            currentAccount.Deposit(depositAmount);
                            break;

                        case 2:
                            Console.Write("Enter amount to withdraw: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            currentAccount.Withdraw(withdrawAmount);
                            break;

                        case 3:
                            Console.WriteLine("Exiting...");
                            continueLoop = false;
                            return;

                        default:
                            Console.WriteLine("Invalid option. Please select a valid option.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid account number or PIN. Please try again.");
            }
        }
    }

    private static Account Login(List<Account> accounts, string accountNumber, string pin)
    {
        Account currentAccount = accounts
            .Where(acc => acc.AccountNumber == accountNumber)
            .Where(acc => acc.ValidatePin(pin) == true)
            .FirstOrDefault();
        
        return currentAccount;
    }
}
