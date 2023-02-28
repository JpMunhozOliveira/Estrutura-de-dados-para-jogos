using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    private static SortedDictionary<string, ArrayList> mapa = new SortedDictionary<string, ArrayList>();

    public static void Main(string[] args)
    {
        //Roda o programa até o usuário fechar
        do
        {
            //Mostra o mapa
            Console.Clear();
            Console.WriteLine("\n------- Mapa -------\n");
            Console.WriteLine("Cidade \t| Vizinhas");

            foreach (KeyValuePair<string, ArrayList> mapa in mapa)
            {
                Console.Write(mapa.Key + "\t|");
                for (int i = 0; i < mapa.Value.Count; i++)
                {
                    Console.Write(mapa.Value[i] + ", ");
                }
                Console.Write("\n");
            }

            String cidadeNome;

            //Pega o nome da cidade
            do
                Console.Write("\n\nInserir cidade: ");      
            while (string.IsNullOrEmpty(cidadeNome = Console.ReadLine()));

            //Testa se a cidade já está cadastrada
            if (mapa.TryGetValue(cidadeNome, out ArrayList jaexiste))
            {
                string addVizinha;
                Console.WriteLine("\n" + cidadeNome + " já está cadastrada");

                do
                    Console.Write("Adicionar vizinhas? (y/n): ");
                while (string.IsNullOrEmpty(addVizinha = Console.ReadLine()));

                if (addVizinha == "y")
                {
                    AdicionarVizinha(cidadeNome, jaexiste);

                    mapa[cidadeNome] = jaexiste;
                }
            }
            //Se ela ainda não existir
            else
            {
                //Cria a nova cidade
                String Novacidade;
                //Cria a lista de vizinhas
                ArrayList listVizinhas = new ArrayList();

                //Coloca o nome dela
                Novacidade = cidadeNome;

                //Adiciona as vizinhas
                AdicionarVizinha(Novacidade, listVizinhas);

                //Adiciona no mapa
                mapa.Add(Novacidade, listVizinhas);
            }

        } while (true);

    }

    public static void AdicionarVizinha(string cidade, ArrayList ListAdd)
    {
        //Ve quantas cidades vizinhas irá ter
        int quant;
        do
            Console.Write("\nAdicionar quantidade vizinhas: ");
        while (!int.TryParse(Console.ReadLine(), out quant));

        //Para cada cidade vizinha fazer esse tratamento
        for (int i = 0; i < quant; i++)
        {
            //Cria a vizinha
            String NovaVizinha;

            //Pega o nome dela
            do
                Console.Write("Nome da cidade: ");
            while (string.IsNullOrEmpty(NovaVizinha = Console.ReadLine()));

            //adiciona ela na lista de vizinhas
            ListAdd.Add(NovaVizinha);

            //Testa se vizinha já existe no mapa
            if (mapa.TryGetValue(NovaVizinha, out ArrayList jaexiste))
            {
                //Se existir adiciona a Nova Cidade como vizinha dela
                jaexiste.Add(cidade);
                //Atualiza a lista
                mapa[NovaVizinha] = jaexiste;
            }

            //Senão existir
            else
            {
                //Cria a vizinha que não existe no mapa e adiciona a Nova Cidade como vizinha
                ArrayList VizinhasDaVizinha = new ArrayList();
                VizinhasDaVizinha.Add(cidade);

                mapa.Add(NovaVizinha, VizinhasDaVizinha);
            }
        }
    }
}