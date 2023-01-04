using System;
class Program
{
    static void Main(string[] args)
    {
        char letra = 'a';
        Console.WriteLine(letra);
        char valor = (char)65;                    
        Console.WriteLine(valor);
        valor = (char)(valor + 1);          
        Console.WriteLine(valor);
    }
}