using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infradata.Domain_.DomainVerificatioException;



namespace Infradata.Domain_.Models_Entities
{
    public  class Usuario
    {

        public int Id { get; private set; }
        public  string? Email { get; private set; }
        public string? Name { get; private set;}
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }



        public Usuario(int id,string name,string email)
        {
            UserAuthenticator.When(id<0,"O id não pode ser menor que ZERO.");
            this.Id = id;
            DomainValidation(name, email);
        }



        public Usuario( string name, string email)
        {
            DomainValidation(name, email);
        }



        public void NewPassword(byte[] PasswordHash, byte[] PasswordSalt)
        {
            this.PasswordHash = PasswordHash;
            this.PasswordSalt = PasswordSalt;
        }


        public void DomainValidation(string Email,string Name)
        {
            UserAuthenticator.When(Name.Length > 60, "O nome deve ter no maximo 60 caracteres.");
            UserAuthenticator.When(Name.Length <6, "O nome deve ter no minimo 6 caracteres.");
            UserAuthenticator.When(Email.Length > 80, "O Email deve conter no maximo 80 caracteres.");
            UserAuthenticator.When(Email.Length < 14, "O Email deve conter no minimo 14 caracters.\nPreencha corretamente o Email.");

            this.Email= Email;
            this.Name= Name;
        }

    }
}
