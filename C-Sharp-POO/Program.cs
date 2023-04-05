
namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {   

            var pessoaA = new Pessoa(1, "Pedro Rodrigues");
            var pessoaB = new Pessoa(1, "Pedro Rodrigues");

            Console.WriteLine(pessoaA.Equals(pessoaB)); //Falso

        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome= nome;
        }

        public int Id { get; set; }
        public string Nome {get; set; }

        public bool Equals(Pessoa? pessoa)
        {
            return Id == pessoa.Id;
        }
    }

}

