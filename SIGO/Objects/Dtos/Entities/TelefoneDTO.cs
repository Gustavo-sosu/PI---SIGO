using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Dtos.Entities
{
    public class TelefoneDTO
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int ClienteId { get; set; }
    }
}
