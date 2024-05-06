class ForeignPassport
{
    private string passportNumber;
    private string ownerName;
    private DateTime dateOfIssue;

    public ForeignPassport(string passportNumber, string ownerName, DateTime dateOfIssue)
    {
        if (string.IsNullOrWhiteSpace(passportNumber))
        {
            throw new ArgumentException("Passport number cannot be null or empty.");
        }

        if (string.IsNullOrWhiteSpace(ownerName))
        {
            throw new ArgumentException("Owner name cannot be null or empty.");
        }

        if (dateOfIssue > DateTime.Now)
        {
            throw new ArgumentException("Date of issue cannot be in the future.");
        }

        this.passportNumber = passportNumber;
        this.ownerName = ownerName;
        this.dateOfIssue = dateOfIssue;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Passport Number: {passportNumber}");
        Console.WriteLine($"Owner Name: {ownerName}");
        Console.WriteLine($"Date of Issue: {dateOfIssue.ToShortDateString()}");
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            ForeignPassport passport = new ForeignPassport("00123456", "Alexandr Serov", new DateTime(2021, 5, 6));
            passport.DisplayDetails();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}