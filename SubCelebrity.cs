using System;

namespace DXS_CSHARP_encapsulation
{
    public class SubCelebrity
    {
        //PUBLIC LIVRE DE ACESSO A TODOS
        public string InfoPublica = "Tem conta no Instagram";
        //PROTECTED QUEM TIVER HERANCA DIRETA DESSA CLASSE PODERA ACESSAR
        protected string CorDoOlho = "Tem olhos Castanhos";
        //INTERNAL SÓ PODE SER ACESSADO POR QUEM ESTÁ DENTRO DO MESMO PROJETO [ASSEMBLY]
        internal ulong NumeroCelular = 55119966549875;
        //PROTECTED INTERNAL - QUEM ESTIVER NO MESMO PROJETO OU TIVER HERANÇA DIRETA TERÁ ACESSO
        protected internal string JeitoDeFalar = "Só uso gírias!";
        //PRIVATE PROTECTED - QUEM TIVER HERANÇA DIRETA E DENTRO DO MESMO PROJETO [ASSEMBLY] OU ACESSIVEL DENTRO DA MESMA CLASSE
        private protected string SegredoDeFamilia = "Tem muito ouro guardado debaixo da cama!";
        //PRIVATE OU PADRAO IMPLICITO SE NAO DECLARADO, ACESSIVEL DENTRO DA MESMA CLASSE
        private bool UsaMuitoCorrecaoEmFoto = true;

        public void TudoSobreMim()
        {
            Console.WriteLine("COISAS QUE EU SubCelebrity POSSO REVELAR DE MIM!");
            Console.WriteLine(UsaMuitoCorrecaoEmFoto);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(InfoPublica);
        }
    }
}
