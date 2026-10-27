class Animal //Classe Principal
{
    public string Nome{get;set;}
    public int Idade{get;set;}
    public Animal(string nome, int idade) //Constructo
    {
        Nome = nome;
        Idade = idade;
    }
    public virtual void EmitirSom() //Método
    {
        Console.WriteLine("Mensagem Genérica");
    }
}

class Cachorro : Animal //Classe Secundária
{
    public Cachorro(string nome, int idade) : base(nome, idade) //Constructo
    {
        
    }
    public override void EmitirSom() //Sobreposição
    {
        Console.WriteLine("Som: O cachorro está latindo: Au au!");
    }        
}
class Gato : Animal //Classe Secundária
{
    public Gato(string nome, int idade) : base(nome, idade) //Constructo
    {
        
    }
    public override void EmitirSom() //Sobreposição
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
}

class Program //Console
{
    static void main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE ANIMAIS ===");
        Cachorro cachorro = new Cachorro("Rex", 3); //Objeto 1
        Gato gato = new Gato("Mimi", 2); //Objeto 2
    }
    cachorro.Apresentar();
    Console.WriteLine();
    gato.Apresentar();
}