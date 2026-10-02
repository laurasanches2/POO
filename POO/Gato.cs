namespace poo;

public class Gato : Animal
{
    public Gato(string nome, int Idade) : base(nome, Idade)
    {
        
    }

    public override void FazerBarulho()
    {
       Console.WriteLine($"{Nome} Fez Miau");
    }

    
}