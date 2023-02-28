using System;
using System.Collections.Generic;

class Program
{
    public static Dictionary<char, List<Cidade>> mapa = new Dictionary<char, List<Cidade>>();
    public static List<Cidade> listaCidades = new List<Cidade>();

    public static void Main(string[] args)
    {
        do
        {
            //Mostra o mapa
            Console.WriteLine("\n------- Mapa -------\n");
            Console.WriteLine("Chave \t Cidade \t Vizinhas");
            foreach (KeyValuePair<char, List<Cidade>> mapa in mapa)
            {
                Console.Write(mapa.Key + "\t" + mapa.Value[0].Nome + "\t");
                for (int i = 1; i < mapa.Value.Count; i++)
                {
                    Console.Write(mapa.Value[i].Nome + ", ");
                } 
                Console.Write("\n");
            }

            String cidadeNome;

            //Pega o nome da cidade
            do{
                Console.Write("\n\nInserir nova cidade: ");
                cidadeNome = Console.ReadLine();
            } while (string.IsNullOrEmpty(cidadeNome));

            //Testa se a cidade já está cadastrada
            if (mapa.TryGetValue(cidadeNome[0], out List<Cidade> jaexiste))
            {
                string addVizinha;
                Console.WriteLine("\n" + jaexiste[0] + " já está cadastrada");
                do{
                    Console.WriteLine("Adicionar vizinhas? (y/n) ");
                    addVizinha = Console.ReadLine();
                } while (string.IsNullOrEmpty(addVizinha));

                if (addVizinha == "y")
                {
                    AdicionarVizinha(jaexiste[0], jaexiste);

                    mapa[jaexiste[0].Inicial] = jaexiste;
                }
            }
            else
            {
                Cidade cidade = new Cidade();
                List<Cidade> listVizinhas = new List<Cidade>();

                cidade.Nome = cidadeNome;
                cidade.Inicial = cidadeNome[0];

                listVizinhas.Add(cidade);

                AdicionarVizinha(cidade, listVizinhas);

                mapa.Add(cidade.Inicial, listVizinhas);
            }

        } while(true);

    }

    public static void AdicionarVizinha(Cidade cidade, List<Cidade> vizinhas)
    {
        int quant;
        do{
            Console.Write("Quantidade cidades vizinhas: ");
        } while (!int.TryParse(Console.ReadLine(), out quant));

        for (int i = 1; i <= quant; i++)
        {
            Cidade NovaVizinha = new Cidade();
            do
            {
                Console.Write("Nome da cidade: ");
                NovaVizinha.Nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(NovaVizinha.Nome));

            NovaVizinha.Inicial = NovaVizinha.Nome[0];

            vizinhas.Add(NovaVizinha);

            if (mapa.TryGetValue(NovaVizinha.Inicial, out List<Cidade> jaexiste))
            {
                jaexiste.Add(cidade);
                mapa[jaexiste[0].Inicial] = jaexiste;
            }
            else
            {
                List<Cidade> VizinhasDaVizinha = new List<Cidade>();
                VizinhasDaVizinha.Add(NovaVizinha);
                VizinhasDaVizinha.Add(cidade);

                mapa.Add(NovaVizinha.Inicial, VizinhasDaVizinha);
            }    
        }
    }
}