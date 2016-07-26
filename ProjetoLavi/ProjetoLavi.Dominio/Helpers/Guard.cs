using System;

namespace ProjetoLavi.Dominio.Helpers
{
    public static class Guard
    {
        public static void ForValidId(string propName, Guid id)
        {
            ForValidId(id, $"{propName} id inválido!");
        }

        public static void ForValidId(Guid id, string errorMessage)
        {
            if (id == Guid.Empty)
                throw new Exception(errorMessage);
        }

        public static void ForValidId(string propName, int id)
        {
            ForValidId(id, $"{propName} id inválido!");
        }

        public static void ForValidId(int id, string errorMessage)
        {
            if (id <= 0)
                throw new Exception(errorMessage);
        }

        public static void ForNullOrEmptyDefaultMessage(string value, string propName)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception($"{propName} é obrigatório!");
        }

        public static void ForNullOrEmpty(string value, string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception(errorMessage);
        }

        public static void StringLength(string propName, string stringValue, int maximum)
        {
            StringLength(stringValue, maximum, $"{propName} não pode ter mais que {maximum} caracteres");
        }

        public static void StringLength(string stringValue, int maximum, string message)
        {
            var length = stringValue.Length;
            if (length <= maximum) return;

            throw new Exception(message);
        }
        public static void StringLength(string propName, string stringValue, int minimum, int maximum)
        {
            StringLength(stringValue, minimum, maximum, $"{propName} deve ter de {minimum} à {maximum} caracteres!");
        }

        public static void StringLength(string stringValue, int minimum, int maximum, string message)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                stringValue = string.Empty;
            var length = stringValue.Length;
            if (length >= minimum && length <= maximum) return;

            throw new Exception(message);
        }

        public static void AreEqual(string a, string b, string errorMessage)
        {
            if (a != b)
                throw new Exception(errorMessage);
        }

        public static void ListLength(string propName, int qtdItens, int minimo)
        {
            ListLength(qtdItens, minimo, $"{propName} deve ter no mínimo {minimo} item");
        }

        public static void ListLength(int qtdItens, int minimo, string message) 
        {
            if (qtdItens < minimo) 
                throw new Exception(message);
        }

        public static void ValidarNaoNegativo(int numero, string propName)
        {
            if (numero < 0)
                throw new Exception(propName + " não pode ser negativo!");
        }

        public static void ValidarNaoNegativo(double numero, string propName)
        {
            if (numero < 0)
                throw new Exception(propName + " não pode ser negativo!");
        }
    }
}
