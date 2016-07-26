using System.Globalization;
using System.Linq;

namespace ProjetoLavi.Dominio.Helpers
{
    public static class StringHelper
    {
        public static string RemoverAcentos(string texto)
        {
            if (texto == null) return string.Empty;

            const string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            const string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (var i = 0; i < comAcentos.Length; i++)
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());

            return texto;
        }

        public static string GetNumeros(string texto)
        {
            return string.IsNullOrEmpty(texto) ? "" : new string(texto.Where(char.IsDigit).ToArray());
        }

        /// <summary>
        /// deixa as primeiras letras maiusculas
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string ToTitleCase(string texto)
        {
            return ToTitleCase(texto, false);
        }

        public static string ToTitleCase(string texto, bool manterOqueJaEstiverMaiusculo)
        {
            texto = texto.Trim();

            if (!manterOqueJaEstiverMaiusculo)
                texto = texto.ToLower();

            var textInfo = new CultureInfo("pt-BR", false).TextInfo;
            return textInfo.ToTitleCase(texto);
        }
    }
}
