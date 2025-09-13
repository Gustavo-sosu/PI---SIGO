using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Dtos.Entities
{
    public class ClienteDTO
    {
        private string _email;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email
        {
            get => _email;
            set => _email = value.ToLower();
        }
        public string Senha { get; set; }
        public DateOnly Data { get; set; }
        public string CNPJ_CPF { get; set; }
        public string Obs { get; set; }
        public string Razao { get; set; }
        public int Situacao { get; set; }
        public int Sexo { get; set; }
        public int TipoCliente { get; set; }

        public List<EnderecoDTO> Enderecos { get; set; } = new();
        public List<TelefoneDTO> Telefones { get; set; } = new();


    }
}
