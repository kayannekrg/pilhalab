using System;


public class Parte3{

     static string Inverte(string s)
    {
        char[]pilha = new char[s.Length];
        int topo = -1;

        foreach(char c in s)
        {
            pilha[++topo] = c;
        }
        string resultado = "";
        while(topo>=0){
            resultado += pilha[topo--];
        }
        return resultado;
    }
    public static void Executar()
    {
        Console.WriteLine("Digite um texto:");
        string texto = Console.ReadLine()!;
        Console.WriteLine("Texto invertido: "+ Inverte(texto));
    }
}
