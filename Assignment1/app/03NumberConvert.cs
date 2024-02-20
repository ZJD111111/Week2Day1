namespace app1;

class NumberConverter
{
    public void NumberConvert()
    {
        Console.Write("Enter the number of centuries: ");
        int centuries = int.Parse(Console.ReadLine());
        const int yearsPerCentury = 100;
        const int daysPerYear = 365;
        const int hoursPerDay = 24;
        const int minutesPerHour = 60;
        const int secondsPerMinute = 60;
        const long millisecondsPerSecond = 1000;
        const long microsecondsPerMillisecond = 1000;
        const long nanosecondsPerMicrosecond = 1000;
        long years = (long)centuries * yearsPerCentury;
        long days = years * daysPerYear;
        long hours = days * hoursPerDay;
        long minutes = hours * minutesPerHour;
        long seconds = minutes * secondsPerMinute;
        long milliseconds = seconds * millisecondsPerSecond;
        long microseconds = milliseconds * microsecondsPerMillisecond;
        long nanoseconds = microseconds * nanosecondsPerMicrosecond;
        Console.WriteLine("{0} Centuries = {1} Years = {2} Days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
        centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
    }
}
