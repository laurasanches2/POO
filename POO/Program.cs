namespace poo;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animais =
        [
            new Cachorro("pipoca", 9),

            new Gato("pirulito", 2),

            new Manuzica("manu", 16)
        ];
            foreach (Animal animalAtual in animais)
        {
            {
                animalAtual.Comer();
                animalAtual.FazerBarulho();
            }
        }

    }
}