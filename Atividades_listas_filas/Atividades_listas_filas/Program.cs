using System;
using System.Collections;

public class Program
{
    static List<Endereco> listaEndereco = new List<Endereco>();
    static Queue<Endereco> filaEndereco = new Queue<Endereco>();

    public static void Main(string[] args)
    {
        EnderecoLista();
        EnderecoPilha();

        Exibicao();
    }

    public static void EnderecoLista()
    {
        int qtde;

        Console.WriteLine("Exemplo lista");

        do
        {
            Console.Write("Informe a quantidade de endereços: ");
        } while (!int.TryParse(Console.ReadLine(), out qtde));

        for(int i = 1; i <= qtde; i++)
        {
            Endereco newEndereco = new Endereco();

            Console.WriteLine($"\nEndereço {i}");

            Console.Write("Informe a rua: ");
            newEndereco.Rua = Console.ReadLine();

            Console.Write("Informe o bairro: ");
            newEndereco.Bairro = Console.ReadLine();

            Console.Write("Informe a cidade: ");
            newEndereco.Cidade = Console.ReadLine();

            Console.Write("Informe o estado: ");
            newEndereco.Estado = Console.ReadLine();

            Console.Write("Informe o CEP: ");
            newEndereco.Cep = Console.ReadLine();

            listaEndereco.Add(newEndereco);
        }
    }

    public static void EnderecoPilha()
    {
        int qtde;
        

        Console.WriteLine("\n\nExemplo pilha");

        do
        {
            Console.Write("Informe a quantidade de endereços: ");
        } while (!int.TryParse(Console.ReadLine(), out qtde));

        for (int i = 1; i <= qtde; i++)
        {
            Endereco newEndereco = new Endereco();

            Console.WriteLine($"\nEndereço {i}");

            Console.Write("Informe a rua: ");
            newEndereco.Rua = Console.ReadLine();

            Console.Write("Informe o bairro: ");
            newEndereco.Bairro = Console.ReadLine();

            Console.Write("Informe a cidade: ");
            newEndereco.Cidade = Console.ReadLine();

            Console.Write("Informe o estado: ");
            newEndereco.Estado = Console.ReadLine();

            Console.Write("Informe o CEP: ");
            newEndereco.Cep = Console.ReadLine();

            filaEndereco.Enqueue(newEndereco);
        }
    }

    public static void Exibicao()
    {
        Console.WriteLine("\n\nPercorrendo lista");

        for(int i = 0; i <= listaEndereco.Count - 1; i++)
        {
            Console.WriteLine($"\nExibindo endereço {i + 1}");

            Endereco endereco = listaEndereco[i];

            Console.WriteLine("Rua: " + endereco.Rua);
            Console.WriteLine("Bairro: " + endereco.Bairro);
            Console.WriteLine("Cidade: " + endereco.Cidade);
            Console.WriteLine("Estado: " + endereco.Estado);
            Console.WriteLine("Cep: " + endereco.Cep);
        }

        Console.WriteLine("\n\nPercorrendo fila");

        while (filaEndereco.Count > 0)
        {
            Console.WriteLine($"\nExibindo endereço");

            Endereco endereco = filaEndereco.Dequeue();

            Console.WriteLine("Rua: " + endereco.Rua);
            Console.WriteLine("Bairro: " + endereco.Bairro);
            Console.WriteLine("Cidade: " + endereco.Cidade);
            Console.WriteLine("Estado: " + endereco.Estado);
            Console.WriteLine("Cep: " + endereco.Cep);
        };
        
    }
}