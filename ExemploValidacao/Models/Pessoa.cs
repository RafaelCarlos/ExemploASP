using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength (50, MinimumLength= 5, ErrorMessage="A observação deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage="Preencha a Observação")]
        public string Observacao { get; set; }

        [Range(18, 50, ErrorMessage= "Idade deve ser entre 18 e 50 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Insira um email válido")]
        public string Email { get; set; }

        [RegularExpression (@"[a-zA-Z]{5,15}", ErrorMessage="O nome deve apenas letras")]
        [Required(ErrorMessage="O login deve ser informado")]
        public string Login { get; set; }

        [Required(ErrorMessage="A senha deve ser informada")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage="Senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}