﻿using Flunt.Validations;
using InventarioMobile.Models.Request;

namespace InventarioMobile.Contracts
{
    public class SignupContract : Contract<SignupRequest>
    {
        public SignupContract(SignupRequest signupRequest)
        {
            Requires().IsEmail(signupRequest.Email, nameof(signupRequest.Email), "Email inválido").IsNotNullOrEmpty(signupRequest.Email, nameof(signupRequest.Email), "Email não pode ser vazio");
            Requires().IsNotNullOrEmpty(signupRequest.Senha, nameof(signupRequest.Senha), "Senha não pode ser vazia");
            Requires().IsNotNullOrEmpty(signupRequest.Nome, nameof(signupRequest.Nome), "Nome não pode ser vazio");
        }
    }
}
