

class TemperatureConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Valige teisendusviis:");
        Console.WriteLine("1. Fahrenheit -> Celsius");
        Console.WriteLine("2. Celsius -> Fahrenheit");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Sisestage temperatuur Fahrenheitides: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"Temperatuur Celsius kraadides on: {celsius}°C");
                break;
            case 2:
                Console.Write("Sisestage temperatuur Celsius kraadides: ");
                double celsiusInput = Convert.ToDouble(Console.ReadLine());
                double fahrenheitOutput = CelsiusToFahrenheit(celsiusInput);
                Console.WriteLine($"Temperatuur Fahrenheitides on: {fahrenheitOutput}°F");
                break;
            default:
                Console.WriteLine("Vigane valik. Palun valige 1 või 2.");
                break;
        }
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
