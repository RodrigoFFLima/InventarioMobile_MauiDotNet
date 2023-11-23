using Flunt.Validations;
using InventarioMobile.Models.Request;

namespace InventarioMobile.Contracts
{
    public class LoginContract : Contract<LoginRequest>
    {
        public LoginContract(LoginRequest request)
        {
            Requires()
                .IsNotNullOrEmpty(request.Email, "Email", "Email não pode ser vazio")
                .IsEmail(request.Email, "Email", "Email inválido")
                .IsNotNullOrEmpty(request.Senha, "Senha", "Senha não pode ser vazia");
        }
    }
}
