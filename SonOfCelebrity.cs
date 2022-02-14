using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_encapsulation
{
    //HERANÇA DIRETA DE SubCelebrity
    public class SonOfCelebrity: SubCelebrity
    {
        public new void TudoSobreMim()
        {
            Console.WriteLine("COISAS QUE EU SonOfCelebrity POSSO REVELAR DE MINHA MÃE SubCelebrity!");
            //ATRIBUTO PRIVADO NÃO PODE SER ACESSADO NEM PELA HERANÇA DIRETA
            //Console.WriteLine(UsaMuitoCorrecaoEmFoto);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(InfoPublica);
        }
    }
}
