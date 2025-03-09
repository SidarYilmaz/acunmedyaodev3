using System;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    // Sanal metot, alt sınıflarda override edilecek
    public virtual double CalculateBonus()
    {
        return 0; // Temel sınıfta bir prim yok
    }
}

public class Manager : Employee
{
    public int TeamSize { get; set; }

    // Manager sınıfında maaşın %20'si kadar bonus hesaplanır
    public override double CalculateBonus()
    {
        return Salary * 0.20; // Yöneticinin maaşının %20'si
    }
}

public class Developer : Employee
{
    public string About { get; set; }

    // Developer sınıfında maaşın %10'u kadar bonus hesaplanır
    public override double CalculateBonus()
    {
        return Salary * 0.10; // Geliştiricinin maaşının %10'u
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager()
        {
            Id = 1,
            Name = "Ali Veli",
            Salary = 5000,
            Department = "IT",
            TeamSize = 10
        };

        Developer developer = new Developer()
        {
            Id = 2,
            Name = "Ayşe Yılmaz",
            Salary = 4000,
            Department = "IT",
            About = "Frontend Developer"
        };

        Console.WriteLine($"{manager.Name} (Manager) Bonus: {manager.CalculateBonus()}");
        Console.WriteLine($"{developer.Name} (Developer) Bonus: {developer.CalculateBonus()}");
    }
}


using System;

public class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    // Sanal metot, alt sınıflarda override edilecek
    public virtual double CalculateInterest()
    {
        return 0; // Temel sınıfta faiz yok
    }
}

public class SavingsAccount : BankAccount
{
    // Vadeli hesapta bakiyenin %5'i kadar faiz hesaplanır
    public override double CalculateInterest()
    {
        return Balance * 0.05; // Vadeli hesap için %5 faiz
    }
}

public class CheckingAccount : BankAccount
{
    // Vadesiz hesapta faiz yok
    public override double CalculateInterest()
    {
        return 0; // Vadesiz hesap için faiz yok
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount()
        {
            AccountHolder = "Ahmet Kaya",
            Balance = 10000
        };

        CheckingAccount checking = new CheckingAccount()
        {
            AccountHolder = "Mehmet Çelik",
            Balance = 5000
        };

        Console.WriteLine($"{savings.AccountHolder} (Savings Account) Interest: {savings.CalculateInterest()}");
        Console.WriteLine($"{checking.AccountHolder} (Checking Account) Interest: {checking.CalculateInterest()}");
    }
}
