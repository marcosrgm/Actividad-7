// See https://aka.ms/new-console-template for more information
Console.WriteLine("El programa consiste en adivinar un número del 1 al 15");
Random rnd = new Random();
int Numero = rnd.Next(1,15);
int Intentosrestantes = 2;

Console.WriteLine("Introduzca un número del 1 al 15");
int numerousuario = Convert.ToInt32(Console.ReadLine());

while (Intentosrestantes > 0)
{
    if (numerousuario == Numero)
    {
    Console.WriteLine("Es el número correcto, has ganado");
    }
    else if(Numero < numerousuario)
    {
        Console.WriteLine("El numero que debes encontrar es menor");
    }
    else
    {
        Console.WriteLine("El numero que debes encontrar es mayor");
    }
    Intentosrestantes--;
    if (Intentosrestantes >0)
    {
        Console.WriteLine($"Te quedan {Intentosrestantes} oportunidades para encontrar el numero");
    }
    else
    {
        Console.WriteLine("Has perdido");
    }
    
}
