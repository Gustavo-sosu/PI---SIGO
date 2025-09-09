using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("clientej")]
    public class ClienteJ : Cliente
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("razao")]
        public string Razao { get; set; }

        [Column("cnpj")]
        public string cnpj { get; set; }


    }
}
