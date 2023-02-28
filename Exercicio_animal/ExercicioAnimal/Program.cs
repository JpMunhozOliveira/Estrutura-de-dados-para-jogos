using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Tigre meutigre = new Tigre();

        Leao meuleao = new Leao();

        Lobo meulobo = new Lobo();

        Hiena minhahiena = new Hiena();

        meutigre.Familia = Console.ReadLine();

        meutigre.Comer();
        
        Console.WriteLine("Familia: ");
        Console.WriteLine(meutigre.Familia);
        meutigre.Dormir(2);
    }
    
}