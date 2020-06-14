using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    public interface IPersonagens 
    {
        void EncostarNoJogador(Jogador jogador, Timer timer);

        bool EncostouNoJogador();
    }
}
