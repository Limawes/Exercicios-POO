public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public int VelocidadeMaxima { get; set; }
    public int Potencia { get; set; }

    public string Acelerar()
    {
        return "O carro está em movimento";
    }

    public string Freiar()
    {
        return "O carro está parado";
    }
}
