public class Parte1
{
    public static void Executar()
    {
        Pilha p = new Pilha(5);

        p.empilha(1);
        p.empilha(3);
        p.empilha(5);
        p.empilha(7);

        p.mostra();

        Console.WriteLine(p.desempilha());
        Console.WriteLine(p.consultaTopo());

        p.empilha(8);
        p.empilha(9);      

        p.mostra();

        Console.WriteLine(p.cheia());

        try
        {
            p.empilha(2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

public class Pilha
{
    private int[] item;
    private int topo;

    public Pilha(int maxTam)
    {
        if (maxTam <= 0)
            throw new Exception("Erro: tamanho inválido");

        item = new int[maxTam];
        topo = 0;
    }

    public bool vazia() => topo == 0;
    public bool cheia() => topo == item.Length;
    public int tamanho() => topo;

    public void empilha(int x)
    {
        if (cheia())
            throw new Exception("Erro: pilha cheia");

        item[topo] = x;
        topo++;
    }

    public int desempilha()
    {
        if (vazia())
            throw new Exception("Erro: pilha vazia");

        topo--;
        return item[topo];
    }

    public int consultaTopo()
    {
        if (vazia())
            throw new Exception("Erro: pilha vazia");

        return item[topo - 1];
    }

    public void mostra()
    {
        Console.Write("[");
        for (int i = 0; i < topo; i++)
        {
            Console.Write(item[i]);
            if (i < topo - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}