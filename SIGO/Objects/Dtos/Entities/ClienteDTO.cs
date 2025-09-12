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
        
        public DateOnly Data { get; set; }
        public int Situacao { get; set; }


    }
}
