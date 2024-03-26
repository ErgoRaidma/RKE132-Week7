//total < 10  - 1%
//total >= 10 && 20 < 20 - 5%
//TOTAL >=20 - 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discnout is: {discount}%");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated with {discount}%: {newTotal}");

static double CalculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total <20) 
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double resault = total - (total * discount) / 100;
    return resault;
} 