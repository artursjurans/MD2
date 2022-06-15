// 1. uzdevums - Sasveicinasanas konsoles aplikacija

Console.WriteLine("Kā tevi sauc?");
string userInput = Console.ReadLine();
Console.WriteLine("Sveiks, " + userInput);


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();

// 2. uzdevums - int.Parse

Console.WriteLine("Kāds ir tavs vecums?");
int userNumber = int.Parse(Console.ReadLine());
int addedToUserNumber = userNumber + 1;
Console.WriteLine("Nākamgad tev paliks " + addedToUserNumber);

Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();
// 3. uzdevums - Math.Max

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
int fourthNumber = int.Parse(Console.ReadLine());

int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine(maxNumber);

Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();
// 4. uzdevums - Math.Min

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstminNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondminNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdminNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
int fourthminNumber = int.Parse(Console.ReadLine());

int firstMinNumber = Math.Min(firstminNumber, secondminNumber);
int secondMinNumber = Math.Min(thirdminNumber, fourthminNumber);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);

Console.WriteLine(minNumber);

Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();
// 5. uzdevums - %

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstqNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondqNumber = int.Parse(Console.ReadLine());

int qresult = firstqNumber % secondqNumber;
Console.WriteLine(qresult);

Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();
// 6. uzdevums - Odd or Even

Console.WriteLine("Lūdzu, ievadi skaitli");
int wnumber = int.Parse(Console.ReadLine());
bool isEven = wnumber % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();
// 7. uzdevums - Taisnleņķa laukuma aprēķināšana

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstzNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondzNumber = int.Parse(Console.ReadLine());

int area = firstzNumber * secondzNumber;
Console.WriteLine(area);

Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();
// 8. uzdevums - Taisnleņķa trijstura laukuma aprēķināšana

Console.WriteLine("Lūdzu, ievadi trijstūra malas garumu");
int cNumber = int.Parse(Console.ReadLine());

int carea = cNumber * cNumber / 2;
Console.WriteLine(carea);


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine();
// 9. uzdevums - Interpolācija

Console.WriteLine("Lūdzu ievadi savu vārdu: ");
string userName = Console.ReadLine();
Console.WriteLine("Lūdzu ievadi savu vecumu: ");
int userAge = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {userName}, tavs vecums ir {userAge}");
