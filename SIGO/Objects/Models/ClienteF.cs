using SIGO.Objects.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("clientef")]
    public class ClienteF : Cliente
    {
        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("datanasc")]
        public DateOnly DataNasc { get; set; }

        [Column("sexo")]
        public string Sexo { get; set; }

        [Column("obs")]
        public string Obs { get; set; }

        public ClienteF() { }

        public ClienteF(int id, string nome, string email, string senha, DateOnly data, Situacao situacao,
                        string cpf, DateOnly dataNasc, string sexo, string obs)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Data = data;
            Situacao = situacao;
            Cpf = cpf;
            DataNasc = dataNasc;
            Sexo = sexo;
            Obs = obs;
        }
    }
}
