namespace GFTEtapaTecnica.Teste04
{
    public class DoarSangue
    {
        public void DoacaoSangue()
        {
            Console.WriteLine("Para saber se você pode doar sangue, digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18 || idade > 67)
            {
                Console.WriteLine("Você não pode doar sangue por causa da sua idade ");
            }
            else if (idade >= 18 && idade <= 670)
            {
                Console.WriteLine("Você pode doar sangue ");
            }

        }
    }
}