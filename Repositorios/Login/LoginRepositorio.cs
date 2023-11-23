﻿using Flurl;
using Flurl.Http;
using InventarioMobile.Helpers;
using InventarioMobile.Models.Request;
using InventarioMobile.Models.Response;

namespace InventarioMobile.Repositorios.Login
{
    public class LoginRepositorio : ILoginRepositorio
    {
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var response = await Constants.ApiUrl
                .AppendPathSegment("/users/login")
                .PutJsonAsync(loginRequest);

            if(response.ResponseMessage.IsSuccessStatusCode)
            {
                var content = await response.ResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<LoginResponse>(content);
            }

            return new LoginResponse();
        }
    }
}
