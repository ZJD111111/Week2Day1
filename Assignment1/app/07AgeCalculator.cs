namespace app1;

class AgeCalculators
{
    public void AgeCalculator()
    {
        Console.Write("Enter your birth date in the format (mm.dd.yyyy): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        TimeSpan age = DateTime.Today - birthDate;
        int ageInDays = (int)age.TotalDays;
        Console.WriteLine("You are {0} days old.", ageInDays);
        int daysToNextAnniversary = 10000 - (ageInDays % 10000);
        DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);
        Console.WriteLine("Your next 10,000-day anniversary will be on: {0:d}", nextAnniversary);
    }
}
