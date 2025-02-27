Console.WriteLine("Shte napravim kalkulator s dve chisla");
Console.WriteLine(" ");
Console.WriteLine("Vuzmojni presmqtaniq");
Console.WriteLine(" ");
Console.WriteLine("1 - Suberi");
Console.WriteLine("2 - Izvadi");
Console.WriteLine("3 - Umnoji");
Console.WriteLine("4 - Razdeli");
Console.WriteLine("5 - Stepenuvane");
Console.WriteLine(" ");

int typed = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Napishi purvoto chislo: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Napishi vtoroto chislo: ");
int number2 = int.Parse(Console.ReadLine());

int suberi = number1 + number2;
int izvadi = number1 - number2;
int umnoji = number1 * number2;
int razdeli = number1 / number2;
double stepen = Math.Pow(number1, number2); // GPT-TO POMOGNA TUKA, PRIZNAVAM SI!

if (typed == 1)
{
    Console.WriteLine("Reshenieto e slednoto: " + number1 + "+" + number2 + "=" + suberi);
    Console.Read();
}
else if (typed == 2)
{
    Console.WriteLine("Reshenieto e slednoto: " + number1 + "-" + number2 + "=" + izvadi);
    Console.Read();
}
else if (typed == 3)
{
    Console.WriteLine("Reshenieto e slednoto: " + number1 + "*" + number2 + "=" + umnoji);
    Console.Read();
}
else if (typed == 4)
{
    Console.WriteLine("Reshenieto e slednoto: " + number1 + "/" + number2 + "=" + razdeli);
    Console.Read();
}
else if (typed == 5)
{
    Console.WriteLine("Reshenieto e slednoto: " + number1 + "^" + number2 + "=" + stepen);
    Console.Read();
}
else
{
    Console.WriteLine("neshto se oburka braaat.");
}