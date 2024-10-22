using System;

class calculator
{
    static void Main(string[] args)
    {
        double balance = 0;
        int pin = 0;

        Console.Write("Enter initial amount: ");
        balance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter PIN number: ");
        pin = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("\n**** SELECT TRANSACTION ****");
            Console.WriteLine("[A] Deposit");
            Console.WriteLine("[B] Withdraw");
            Console.WriteLine("[C] Inquire");
            Console.WriteLine("[D] Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine().ToUpper();

            if (ValidatePin(pin))
            {
                switch (choice)
                {
                    case "A":
                        Deposit(ref balance);
                        break;
                    case "B":
                        Withdraw(ref balance);
                        break;
                    case "C":
                        Inquire(balance);
                        break;
                    case "D":
                        Exit();
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect PIN, try again.");
            }
        }
    }

    static bool ValidatePin(int correctPin)
    {
        Console.Write("\nEnter PIN number: ");
        int inputPin = Convert.ToInt32(Console.ReadLine());
        return inputPin == correctPin;
    }

    static void Deposit(ref double balance)
    {
        Console.Write("Enter amount to deposit: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        balance += amount;
        Console.WriteLine($"You have successfully deposited an amount of {amount}");
    }

    static void Withdraw(ref double balance)
    {
        Console.Write("Enter amount to withdraw: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount > balance)
        {
            Console.WriteLine("Withdrawal Denied!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"You have successfully withdrawn {amount}");
        }
    }

    static void Inquire(double balance)
    {
        Console.WriteLine($"Your current balance is {balance}");
    }

    static void Exit()
    {
        Console.WriteLine("Thank you for using our service, Come back again!");
    }
}