using poo;

namespace POO.Testes;

[TestClass]
[DoNotParallelize]
public sealed class AnimalTestes
{
    private StringWriter _consoleOutput;
    private TextWriter _originalOutput;

    [TestInitialize]
    public void Setup()
    {
        _consoleOutput = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_consoleOutput);

    }

    [TestCleanup]
    public void Cleanup()
    {
        Console.SetOut(_originalOutput);
        _consoleOutput.Dispose();
    }

    [TestMethod]
    public void DeveRetornaObjetoCachorro_QuandoNomeEIdadeEstaoCorretos()
    {
        string nomeEsperado = "Pipoca";
        int idadeEsperado = 9;

        var animal = new Cachorro(nomeEsperado, idadeEsperado);

        Assert.AreEqual(nomeEsperado, animal.Nome);
        Assert.AreEqual(idadeEsperado, animal.Idade);
    }

    [TestMethod]
    public void QuandoInvocadoComer_DeveEscreverMensagemPadraoNoConsole()
    {
        //arrenge
        string nome = "lady";
        var animal = new Manuzica(nome, 5);
        string mensagemEsperada = ($" {nome} está comendo!{Environment.NewLine}");

        //act
        animal.Comer();

        //assert
        Assert.AreEqual(mensagemEsperada, _consoleOutput.ToString());

    }

    [TestMethod]
    public void QuandoInvocadoFazerBarulho_DaInstanciaCachorro_DeveFazerAuAu()
    {
        string nome = "pipoca";
        var animal = new Cachorro(nome, 9);
        string mensagemEsperada = ($"{nome} Fez AUAU{Environment.NewLine}");
        animal.FazerBarulho();

        Assert.AreEqual(mensagemEsperada, _consoleOutput.ToString());
    }

    [TestMethod]
    public void QuandoInvocadoFazerBarulho_DaInstanciaManuzica_DeveFazerManuuuuuuuu()
    {
        string nome = "manu";
        var animal = new Manuzica(nome, 16);
        string mensagemEsperada = ($"{nome} faz Manuuuuuuuu{Environment.NewLine}");
        animal.FazerBarulho();

        Assert.AreEqual(mensagemEsperada, _consoleOutput.ToString());

    }

    [TestMethod]
    public void QuandoInvocadoFazerBarulho_DaInstanciaGato_DeveFazerMiau()
    {
        string nome = "pirulito";
        var animal = new Gato(nome, 2);
        string mensagemEsperada = ($"{nome} Fez Miau{Environment.NewLine}");
        animal.FazerBarulho();

        Assert.AreEqual(mensagemEsperada, _consoleOutput.ToString());
    }


    [TestMethod]
    public void
        QuandoInstanciaComNomeVazio_Sempre_DeveLacarArgumentException()
    {
        //Arrange
        string nomeAnimal = "";
        //Act ->Assert
        var excecao = Assert.ThrowsExactly<ArgumentException>(() => new Cachorro(nomeAnimal,12));
        Assert.Contains("O nome não pode estar vazio ou nulo!", excecao.Message);
    }

    [TestMethod]
    public void
        QuandoInstanciaComNomeNulo_Sempre_DeveLacarArgumentException()
    {
        string nomeAnimal = null;
    var excecao = Assert.ThrowsExactly<ArgumentException>(() => new Cachorro(nomeAnimal,12));
    Assert.Contains("O nome não pode estar vazio ou nulo!", excecao.Message);
        
    }

    [TestMethod]
    public void
        QuandoInstanciaComIdadeNegativa_Sempre_DeveLacarArgumentOutORangeException()
    {
        int idade = -10 ;
        var excecao = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Cachorro("lady",idade));
        Assert.Contains("A idade não pode ser negativa!", excecao.Message);
    }
} 









    
        
    
    
    
    
    
        
