using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
    private string especie;
    private string raca;
    private string familia;
    private int ano;
    private string origem;

    public string Especie { get => especie; set => especie = value; }
    public string Raca { get => raca; set => raca = value; }
    public string Familia { get => familia; set => familia = value; }
    public int Ano { get => ano; set => ano = value; }
    public string Origem { get => origem; set => origem = value; }

    public void Procriar()
    {
        Console.WriteLine("Animal Procriando");
    }

    public void Comer()
    {
        Console.WriteLine("Animal Comendo");
    }

    public void Dormir()
    {
        Console.WriteLine("Animal Dormindo");
    }

    public void Dormir(int tempo)
    {
        Console.WriteLine("Animal dormindo por: " + tempo + " horas");
    }

    public abstract void Pular();
}

