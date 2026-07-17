namespace beginner;

    public static class AdicionaZeros
    {
        public static string adicionaZeros(string texto, int quantidade)
        {
            var tamanhoTexto = quantidade - texto.Length;
            for (int i = 0; i < (tamanhoTexto); i++)
            {
                texto = "0" + texto;
            }

            return texto;
        }
    }
