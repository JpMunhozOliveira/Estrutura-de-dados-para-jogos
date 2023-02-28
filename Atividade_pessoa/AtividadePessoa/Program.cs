using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Exercicio1();
    }

    public static void Exercicio1()
    {
        Empregado meuEmpregado = new Empregado();

        Console.WriteLine("Nome: ");
        meuEmpregado.SetNome(Console.ReadLine());
        Console.WriteLine("Telefone: ");
        meuEmpregado.SetTelefone(Console.ReadLine());
        Console.WriteLine("Endereço: ");
        meuEmpregado.SetEndereco(Console.ReadLine());
        Console.WriteLine("Codigo Setor: ");
        meuEmpregado.SetCodigoSetor(Convert.ToInt16(Console.ReadLine()));
        Console.WriteLine("Salario Base: ");
        meuEmpregado.SetSalarioBase(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Imposto: ");
        meuEmpregado.SetImposto(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Salario liquido: " + meuEmpregado.calcularSalario());
    }
}