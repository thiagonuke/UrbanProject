﻿namespace UrbanFarming.Domain.Classes
{
    public class Login
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Administrador { get; set; }
    }
}
