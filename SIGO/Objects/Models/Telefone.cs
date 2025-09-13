using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace SIGO.Objects.Models
{
    [Table("telefone")]
    public class Telefone
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("numero")]
        public string Numero {  get; set; }

        [Column("ddd")]
        public int DDD { get; set; }

        [Column("clienteid")]
        public int ClienteId { get; set; }
        public Cliente Clientes { get; set; }

        public Telefone()
        {
            
        }
        public Telefone(int id, string numero, int ddd)
        {
            Id = id;
            Numero = numero;
            DDD = ddd;
        }
    }
}
