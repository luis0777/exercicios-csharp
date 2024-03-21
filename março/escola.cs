using System;

public class Escola
{
    public int Alunos;
    public int Professores;
    public int Sala;
    public string Nome;
    public bool Aberta;

    public Escola(int Alunos, int Professores, int Sala)
    {
        this.Alunos = Alunos;
        this.Sala = Sala;
        this.Nome = Nome;
        this.Alunos = Alunos;
        this.Aberta = true;

    }

    public void estudar( int Alunos, int Sala)
    {
        Console.WriteLine($"Na escola possui um total de {Alunos} alunos dividos em {Sala} salas.");
    }

    public void ensinar(int Alunos, int Professores)
    {
        Console.WriteLine($"Para concluir o plano de ensino dos {Alunos} a conta {Nome} com {Professores} profissionais em Pedagogia.");
    }

    public void abrir()
    {
        if (Aberta)
        {
            Aberta = false;
            Console.WriteLine("A escola foi aberta.");
        }

        else
        {
            Console.WriteLine("A escola esta fechada.");
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Escola Sao_Cristovao = new Escola(450, 15, 5);

        Sao_Cristovao.ensinar(450, 15);
        
        Console.ReadKey();
    }
}
    
