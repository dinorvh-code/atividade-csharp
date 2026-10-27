using System;
class Animal
{
    public string Nome{get;set;}
    public int Idade{get;set;}
    public virtual void EmitirSom()
    {
        Console.WriteLine("Mensagem Genérica");
    }
}

class Cachorro : Animal
{
   static void Main()
    {
        Animal animal1 = new Animal();
        animal1.Nome = "Rex";
        animal1.Idade = 3;
        Console.WriteLine($"Animal: {animal1.Nome}");
        Console.WriteLine($"Idade: {animal1.Idade} anos");
        
    }  
    public override void EmitirSom()
    {
        Console.WriteLine("Som: O cachorro está latindo: Au au!");
    }        
}
class Gato : Animal
{
    static void Main()
    {
        Animal animal2 = new Animal();
        animal2.Nome = "Mimi";
        animal2.Idade = 2;
        Console.WriteLine($"Animal: {animal2.Nome}");
        Console.WriteLine($"Idade: {animal2.Idade} anos");     
    } 
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
};