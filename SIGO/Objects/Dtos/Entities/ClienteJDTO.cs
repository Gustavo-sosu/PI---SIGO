using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Dtos.Entities
{
    public class ClienteJDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateOnly Data { get; set; }
        public int Situacao { get; set; }

        public string Razao { get; set; }
        public string Cnpj { get; set; }
    }
}
