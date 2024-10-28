﻿namespace AppMobileUrban.Models
{
    public class Fornecedores
    {
        public string Codigo { get; set; } 
        public string RazaoSocial { get; set; } 
        public string NomeFantasia { get; set; } 
        public string CNPJ { get; set; } 
        public string PaisOrigem { get; set; }
        public string Email { get; set; }
        public string EnquadramentoEstadual { get; set; } 
        public string RamoAtividade { get; set; }
        public bool PessoaJuridica { get; set; }
        public bool PessoaFisica { get; set; } 
    }
}
