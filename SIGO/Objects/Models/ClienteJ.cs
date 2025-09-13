using SIGO.Objects.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("clientej")]
    public class ClienteJ : Cliente
    {
        [Column("razao")]
        public string Razao { get; set; }

        [Column("cnpj")]
        public string Cnpj { get; set; }

        public ClienteJ() { }

        public ClienteJ(int id, string nome, string email, string senha, DateOnly data, Situacao situacao, string razao, string cnpj)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Data = data;
            Situacao = situacao;
            Razao = razao;
            Cnpj = cnpj;
        }
    }
}
