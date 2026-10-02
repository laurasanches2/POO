namespace poo;

public  class Cachorro : Animal

{
    public Cachorro (string nome, int Idade) : base(nome, Idade)
    {
        
    }

    public override void FazerBarulho()
    {
        Console.WriteLine($"{Nome} Fez AUAU");
    }

    
}
