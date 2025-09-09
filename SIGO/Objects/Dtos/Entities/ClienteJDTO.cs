using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Dtos.Entities
{
    public class ClienteJDTO
    {
        public int Id { get; set; }
        public string Razao { get; set; }
        public string cnpj { get; set; }
    }
}
