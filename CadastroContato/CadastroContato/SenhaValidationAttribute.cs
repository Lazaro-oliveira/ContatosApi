using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CadastroContato
{
    public class SenhaValidationAttribute : ValidationAttribute
	{
		public SenhaValidationAttribute() { }

		public override bool IsValid(object value)
		{
			if (value == null || string.IsNullOrEmpty(value.ToString()))
				return false;
			return ValidaSenha(value.ToString());
		}

		private bool ValidaSenha(string senha)
		{
			Regex letraMaiuscula = new Regex(@"[A-Z]");
			bool validadorMaiuscula = letraMaiuscula.IsMatch(senha);

			Regex numero = new Regex(@"[0-9]");
			bool validadornumero = numero.IsMatch(senha);

			Regex caracterSpecial = new Regex(@"[\W]");
			bool validadorSpecial = caracterSpecial.IsMatch(senha);

			if(validadorMaiuscula && validadornumero && validadorSpecial)
            {
				return true;
			}

            else
            {
				return false;
            }
		}

	}
}
