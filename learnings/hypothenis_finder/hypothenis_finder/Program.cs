// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter the value of A: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the value of B: ");
//double b = Convert.ToDouble(Console.ReadLine());

//double c = Math.Sqrt(a * a + b * b);

//Console.WriteLine("The hypotenuse is: " + c);

string fullname;
Console.Write("Enter your full name: ");
fullname= Console.ReadLine();
string username = fullname.Replace(" ", "_").Insert(0,"@");
Console.WriteLine("Your username is: " + username);