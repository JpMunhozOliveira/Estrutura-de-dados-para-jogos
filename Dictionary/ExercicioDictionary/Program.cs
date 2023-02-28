using System;
using System.Collections;

class Program
{
    static Dictionary<char, List<Pessoa>> dic = new Dictionary<char, List<Pessoa>>();

    public static void Main(String[] args)
    {
        Cadastro();
        Visualizar();
    }
    public static void Cadastro()
    {
        do
        {
            Console.Write("\nInforme a letra inicial dos nomes: ");
            char letter = Console.ReadLine()[0];
            List<Pessoa> lista = new List<Pessoa>();

            do
            {
                Pessoa newpessoa = new Pessoa();

                Console.WriteLine("\n--- Cadastro de Pessoa ---");

                Console.Write("Nome: ");
                newpessoa.SetNome(Console.ReadLine());

                Console.Write("Telefone: ");
                newpessoa.SetTelefone(Console.ReadLine());

                Console.Write("Endereço: ");
                newpessoa.SetEndereco(Console.ReadLine());

                lista.Add(newpessoa);

                Console.Write("\nContinuar? (y/n) ");

            } while ((Console.ReadLine() == "y"));

            dic.Add(letter, lista);

            Console.Write("\nCriar outra lista de nomes? (y/n) ");
        } while(Console.ReadLine() == "y");
    }
    public static void Visualizar()
    {      
        Console.Write("Informe a chave a ser pesquisada:");
        char letter = Console.ReadLine()[0];


        List<Pessoa> lista = new List<Pessoa>();

        dic.TryGetValue(letter, out lista);

        Console.WriteLine("Chave: " + letter);
        for(int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(i  + " : " + lista[i].GetNome());
        }
        
    }
}