
namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            string Frase = "O rato roeu a roupa do rei de roma.";

            Console.WriteLine(p.Alterar(Frase));
            Console.ReadKey();
        }

        private string Alterar(string Frase)
        {
            if (Frase.Trim().Length > 0)
            {
                int Total = Frase.Length;
                int Count = 0;
                
                var StringBuilder = new StringBuilder(Frase);


                while (Count < Total)
                {
                    if (StringBuilder[Count] == 'a')
                    {
                        StringBuilder[Count] = '&';
                    }
                    Count++;
                }

                Frase = StringBuilder(Frase);

                return Frase;

            }
            else
            {
                return null;
            }


        }



    }
    
}
