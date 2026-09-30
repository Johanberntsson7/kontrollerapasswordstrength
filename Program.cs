namespace kontrollerapasswordstrength;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a password:");
        string password = Console.ReadLine() ?? string.Empty;
        int passwordStrength = 0;

        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;
        bool hasSpecial = false;

        // Kriterium 1: längd
        if (password.Length >= 8)
        {
            passwordStrength++;
        }

        foreach (char character in password)
        {
            hasUpper |= char.IsUpper(character);
            hasLower |= char.IsLower(character);
            hasDigit |= char.IsDigit(character);
            hasSpecial |= !char.IsLetterOrDigit(character);
        }

        // Kriterium 2-5: ge poäng efter loopen
        if (hasUpper) passwordStrength++;
        if (hasLower) passwordStrength++;
        if (hasDigit) passwordStrength++;
        if (hasSpecial) passwordStrength++;

        // Bedöm styrkan
        Console.WriteLine($"Password strength: {passwordStrength}/5");

        Console.ReadLine();
    }
}    

