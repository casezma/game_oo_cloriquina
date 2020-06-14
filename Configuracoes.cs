using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiroAtacado
{
    public static class Configuracoes
    {

        public static int Score { get;  set; }
        public static int Dificuldade { get; private set; }

        public static int MultiplicadorDeVelocidade() {

            for (int i = 1; i <= 10; i++) {

                if (i - 1 == Score/600) { 
                    Dificuldade = Score/600 + 1;
                    return Dificuldade;
                }
            }
            return 10;
        
        }

    }
}
