
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("clientef")]
    public class ClienteF : Cliente
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("datanasc")]
        public DateOnly DataNasc {  get; set; }

        [Column("sexo")]
        public string Sexo { get; set; }

        [Column("obs")]
        public string Obs { get; set; }
    }
}
