using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Felino : Animal
{
    public override void Pular()
    {
        throw new NotImplementedException();
    }

    public void Urrar()
    {
        Console.WriteLine("Felino Urrando");
    }
}