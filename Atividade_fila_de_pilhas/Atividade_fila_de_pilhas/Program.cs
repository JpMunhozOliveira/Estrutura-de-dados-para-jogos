using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Exercicio();
    }

    private static void Exercicio()
    {
        int quant;
        Queue<Stack<Livro>> filadePilhas = new Queue<Stack<Livro>> ();

        do
            Console.Write("\nInforme a quantidade de pilhas de livros: ");
        while (!int.TryParse(Console.ReadLine(), out quant));
        
        for (int i = 1; i <= quant; i++)
        {
            Stack<Livro> pilhaLivros = new Stack<Livro>();

            int num;
            do
                Console.Write("\nInforme a quantidade de livros na pilha " + i + ": ");
            while (!int.TryParse(Console.ReadLine(), out num));

            for(int j = 1; j <= num; j++)
            {
                Livro novolivro = new Livro();
                Console.WriteLine("\nLivro: " + j + "/ Pilha: " + i);

                Console.Write("Informe o título:");
                novolivro.SetTitulo(Console.ReadLine());

                Console.Write("Informe o autor:");
                novolivro.SetAutor(Console.ReadLine());

                Console.Write("Informe o ano:");
                novolivro.SetAno(Console.ReadLine());

                Console.Write("Informe a quantidade:");
                novolivro.SetQuantidade(Convert.ToInt32(Console.ReadLine()));

                pilhaLivros.Push(novolivro);
            }

            filadePilhas.Enqueue(pilhaLivros);
        }

        int typenum;
        do
            Console.Write("\n\nDigite 1 para ver todas as pilhas e livros" +
                "\nDigite 1 para ver todas as pilhas e livros" +
                "\nAperte qualquer outro número para sair ");
        while (!int.TryParse(Console.ReadLine(), out typenum));

        if(typenum == 1)
        {
            int quantpilhas = filadePilhas.Count;
            for(int y = 1; y <= quantpilhas; y++) {
                Stack<Livro> pegarPilha = filadePilhas.Dequeue();

                Console.WriteLine("\nPilha: " + y);

                int quantLivros = pegarPilha.Count;
                for(int k = 1; k <= quantLivros; k++) {
                    Livro pegarLivro = pegarPilha.Pop();
                    Console.WriteLine("Titulo: " + pegarLivro.GetTitulo());
                }
            }
        }
    }
}