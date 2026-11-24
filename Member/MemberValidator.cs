using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{
    internal class MemberValidator
    {
        public static bool ValidateEmail(string emilIngresado)
        {
            if (string.IsNullOrWhiteSpace(emilIngresado))
            {
                return true;
            }

            if (!emilIngresado.Contains("@"))
            {
                return false;
            }

            else if (emilIngresado.Contains(" "))
            {
                return false;
            }

            int contador = 0;
            char letra;
            for (int i = 0; i < emilIngresado.Length; i++)
            {
                letra = emilIngresado[i];
                if (letra == '@')
                {
                    contador++;
                }
                if (contador > 1)
                {
                    return false;
                }
            }


            int indiceDelante = emilIngresado.IndexOf("@");
            int indiceDetras = emilIngresado.LastIndexOf("@");

            if (indiceDelante == 0 || indiceDetras == emilIngresado.Length - 1)
            {
                return false;
            }

            string dominio = emilIngresado.Split('@')[1];

            int indicePunto = dominio.IndexOf('.');
            if (indicePunto <= 0 || indicePunto >= dominio.Length - 1)
            {
                return false;
            }

            if (dominio.Contains(".."))
            {
                return false;
            }
            indicePunto = dominio.LastIndexOf('.');
            if (indicePunto == dominio.Length - 1)
            {
                return false;
            }

            return true;

        }
        public static bool ValidateRut(string rutIngresado)
        {
            if (string.IsNullOrWhiteSpace(rutIngresado))
            {
                return false;
            }

            string rutcorregido = rutIngresado.Trim().Replace(".", "").Replace(" ", "").Replace("-", "").ToUpper();

            if (rutcorregido.Length < 2)
            {
                return false;
            }

            string dv = rutcorregido[rutcorregido.Length - 1].ToString();
            string cuerpo = rutcorregido.Substring(0, rutcorregido.Length - 1);

            for (int i = 0; i < cuerpo.Length; i++)
            {
                if (!char.IsDigit(cuerpo[i]))
                {
                    return false;
                }
            }

            if (!int.TryParse(cuerpo, out int rutNumero))
            {
                return false;
            }
            
            if (rutNumero <= 0)
            {
                return false;
            }

            int suma = 0;
            int multiplicador = 2;

            for (int i = cuerpo.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(cuerpo[i].ToString());
                suma += digito * multiplicador;
                multiplicador++;
                if (multiplicador > 7)
                {
                    multiplicador = 2;
                }
            }

            int resto = suma % 11;
            int resultado = 11 - resto;
            string dvEsperado;
            if (resultado == 11)
            {
                dvEsperado = "0";
            }
            else if (resultado == 10)
            {
                dvEsperado = "K";
            }
            else
            {
                dvEsperado = resultado.ToString();
            }

            return dv == dvEsperado;
        }

        public static bool ValidatePhone(string telefonoIngresado)
        {

            if (string.IsNullOrWhiteSpace(telefonoIngresado))
            {
                return false;
            }

            string telefonoCorregido;

            if (telefonoIngresado.Trim().StartsWith("+56"))
            {
                telefonoCorregido = telefonoIngresado.Trim().Replace("+", "").Replace(" ", "");
            }
            else if (telefonoIngresado.Trim().StartsWith("9"))
            {
                telefonoCorregido = telefonoIngresado.Trim().Replace("+", "").Replace(" ", "");
            }
            else
            {
                return false;
            }

            for (int i = 0; i < telefonoCorregido.Length; i++)
            {
                if (!char.IsDigit(telefonoCorregido[i]))
                {
                    return false;
                }
            }

            if (telefonoCorregido.Length > 11
                || telefonoCorregido.Length < 9
                || telefonoCorregido.Length == 10)
            {
                return false;
            }

            char primerNumero = '0';

            if (telefonoCorregido.Length == 9)
            {
                primerNumero = telefonoCorregido[0];
            }
            else if (telefonoCorregido.Length == 11)
            {
                primerNumero = telefonoCorregido[2];
            }

            if (primerNumero == '9')
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
