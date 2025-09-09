using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Dtos.Entities
{
    public class ClienteFDTO
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public DateOnly DataNasc { get; set; }
        public string Sexo { get; set; }
        public string Obs { get; set; }
    }
}
