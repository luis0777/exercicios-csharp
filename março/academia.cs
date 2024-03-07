// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Academia 
{
    private int Supino;
    private int Esteira;
    private int Halter;
    private bool Aberta;
    private int Professor;
    
    
    public Academia(int Supino, int Esteira, int Halter, int Professor)
    {
        this.Supino = Supino;
        this.Esteira = Esteira;
        this.Halter = Halter;
        this.Professor = Professor;
        this.Aberta = true;
    }
        public void Abrir()
        {
            if(Aberta)
            {
                Aberta = false;
                Console.WriteLine("A academia foi aberta");
                
                string Resposta;
                Console.WriteLine("Gostaria de fechar a academia? SIM ou NAO");
               Resposta = Console.ReadLine();
               
               //Tolower Retorna uma cópia dessa cadeia de caracteres convertida em minúsculas.
               switch(Resposta.ToLower())
               {
                case "sim":
                    Console.WriteLine("A academia foi fechada, ate amanha!");
                        break;
                case "nao":
                    Console.WriteLine("OK! A academia continua aberta");
                         break;   
                default:
                    Console.WriteLine("Opcao invalida");
                    break;       
               }
            }
            else
            {
                Console.WriteLine("A academia já está aberta");
            }
        }
        
        public void Fechar()
        {
            if(!Aberta)
            {
                Aberta =  true;
                Console.WriteLine("A academia foi fechada. Bom descanso");
            }
            else
            {
                Console.WriteLine("A academia ja foi fechada.");
            }
        }
        public void Correr()
        {
            Console.WriteLine("Na academia  eu corro");
        }
        
        public void Treinar()
        {
            Console.WriteLine("Na academia eu treino muito");
        }
        
        public int getSupino
        {
            get => Supino;
            set => Supino = value;
        }
        
        public int getEsteira
        {
            get => Esteira;
            set => Esteira = value;
        }
        
        public int getHalter
        {
            get => Halter;
            set => Halter = value;
        }
        
        public int getProfessor
        {
            get => Professor;
            set => Professor = value;
        }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Academia estacaoX = new Academia(7, 8, 9, 3);
     
        Console.WriteLine($"Peso do supino {estacaoX.getSupino}\nPeso do halter {estacaoX.getHalter}\nQuantidade de esteira {estacaoX.getEsteira}\nNa academia tem {estacaoX.getProfessor} Professores");
        
        Academia Skin = new Academia(5, 8, 14, 8);
        
        if(Skin.getProfessor > estacaoX.getProfessor)
        {
            Console.WriteLine("\nA academia skin e melhor que a estacao X pois tem mais professores");
        }
        else
        {
            Console.WriteLine("A academia estacao X é melhor que a skin pois tem mais professores");
        }
    }
        
}
