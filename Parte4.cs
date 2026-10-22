using System;

public class Parte4
{
    public static void Executar()
    {
        int[] v = { 5, 2, 9, 1, 7 };
        
        int[] resultado = bubblePilhas(v, out int comparacoes1);
        
        Console.WriteLine("Vetor original: " + string.Join(", ", v));
        Console.WriteLine("Vetor ordenado: " + string.Join(", ", resultado));
        Console.WriteLine($"Comparações: {comparacoes1}");
        
        Console.WriteLine();

        int[]v2 = {1, 2, 5, 7, 9};
         Console.WriteLine("Vetor original: " + string.Join(", ", v2));
        int[]resultado2 = bubblePilhas(v2, out int comparacoes2);
        Console.WriteLine("Vetor ordenado: " + string.Join(", ", resultado2));
        Console.WriteLine($"Comparações: {comparacoes2}");
    }

    public static int[] bubblePilhas(int[] v, out int comparacoes)
    {
        int n = v.Length;
        comparacoes = 0;

        Pilha entrada = new Pilha(n);
        Pilha aux = new Pilha(n);
        Pilha ordenada = new Pilha(n);

        for (int i = 0; i < n; i++)
        {
            entrada.Empilha(v[i]);
        }

        for (int restantes = n; restantes >= 1; restantes--)
        {
            int carry = entrada.Desempilha();

            for (int i = 1; i < restantes; i++)
            {
                int x = entrada.Desempilha();
                comparacoes++;
                if (carry > x)
                {
                    aux.Empilha(x);
                }
                else
                {
                    aux.Empilha(carry);
                    carry = x;
                }
            }

            ordenada.Empilha(carry);

            Pilha temporaria = entrada;
            entrada = aux;
            aux = temporaria;
        }

        int[] vetorOrdenado = new int[n];
        int indice = 0;
        while (!ordenada.Vazia())
        {
            vetorOrdenado[indice++] = ordenada.Desempilha();
        }

        return vetorOrdenado;
    }
    
    class Pilha
    {
        private int[] item;
        private int topo;

        public Pilha(int maxTam)
        {
            item = new int[maxTam];
            topo = -1;
        }

        public bool Vazia()
        {
            return topo == -1;
        }

        public void Empilha(int valor)
        {
            topo++;
            item[topo] = valor;
        }

        public int Desempilha()
        {
            int valor = item[topo];
            topo--;
            return valor;
        }
    }
}