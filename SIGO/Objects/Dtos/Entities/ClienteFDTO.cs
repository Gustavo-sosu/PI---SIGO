using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Dtos.Entities
{
    public class ClienteFDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateOnly Data { get; set; }
        public int Situacao { get; set; }

        public string Cpf { get; set; }
        public DateOnly DataNasc { get; set; }
        public string Sexo { get; set; }
        public string Obs { get; set; }
    }
}
