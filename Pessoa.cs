
namespace ExerciciosPOO
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cidade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Cidade: {Cidade} ");
        }
    }

}