using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_encapsulation
{
    public class FriendOfSubCelebrity
    {
        public readonly SubCelebrity amiga = new SubCelebrity();

        public void TudoSobreMim()
        {
            Console.WriteLine("COISAS QUE EU FriendOfSubCelebrity POSSO REVELAR DA SubCelebrity!");
            //ATRIBUTO PRIVADO NÃO PODE SER ACESSADO NEM PELA HERANÇA DIRETA
            //Console.WriteLine(UsaMuitoCorrecaoEmFoto);
            //PRIVATE PROTECTED - SOMENTE PODE SER ACESSADO POR HERANÇA DIRETA E DENTRO DO MESMO PROJETO
            //Console.WriteLine(amiga.SegredoDeFamilia);
            Console.WriteLine(amiga.JeitoDeFalar);
            Console.WriteLine(amiga.NumeroCelular);
            //PROTECTED SOMENTE PODE SER ACESSADO POR HERANÇA DIRETA
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.InfoPublica);
        }
    }
}
