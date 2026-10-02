namespace poo;

public class Manuzica : Animal
{
    public Manuzica(string nome, int Idade) : base(nome, Idade)
    {

    }

    public override void FazerBarulho()
    {
        Console.WriteLine($"{Nome} faz Manuuuuuuuu");
    }
    
    }

    

