float n1;
float n2;
Console.Write("Primer número: ");
n1 = float.Parse(Console.ReadLine());
Console.Write("Segundo número: ");
n2 = float.Parse(Console.ReadLine());
if (n1 < n2)
{
    Console.WriteLine("El número menor es: " + n1);
}
else
{
    Console.WriteLine("El número menor es: " + n2);
}