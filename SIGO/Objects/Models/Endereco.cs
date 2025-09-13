using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("endereco")]
    public class Endereco
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("numero")]
        public int Numero { get; set; }

        [Column("rua")]
        public string Rua { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("cep")]
        public int Cep { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        [Column("clienteid")]
        public int ClienteId { get; set; }
        public Cliente Clientes { get; set; } = null!;

        public Endereco() { }
        public Endereco(int id ,int numero, string rua, string cidade, int cep, string bairro, string estado)
        {
            Id = id;
            Numero = numero;
            Rua = rua;
            Cidade = cidade;
            Cep = cep;
            Bairro = bairro;
            Estado = estado;
        }
    }
}
