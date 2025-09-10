using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SIGO.Objects.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("data")]
        public DateOnly Data { get; set; }

        [Column("Situacao")]
        public Situacao Situacao { get; set; }

        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();
        public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();

        public Cliente()
        {
            
        }
        public Cliente(int id, string nome, string email, string senha, DateOnly data, Situacao situacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Data = data;
            Situacao = situacao;
        }
    }
}
