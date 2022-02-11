# :book: Exercício de C# :book:
## Exercício 5
## Desenvolva um algoritmo que solicite a entrada de uma frase, após isso, troque todas as letras 'a' por '&', porém, não utilize o método Replace().


```
using System.Text;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            string frase = "O rato roeu a roupa do rei de roma.";

            Console.WriteLine(p.Alterar(frase));
            Console.ReadKey();
        }

        private string Alterar(string frase)
        {
            if (frase.Trim().Length > 0)
            {
                int total = frase.Length;
                int count = 0;
                
                var stringBuilder = new StringBuilder(frase);

                while (count < total)
                {
                    if (stringBuilder[count] == 'a')
                    {
                        stringBuilder[count] = '&';
                    }
                    count++;
                }

                frase = stringBuilder.ToString();

                return frase;

            }
            else
            {
                return null;
            }


        }



    }
    
}

```