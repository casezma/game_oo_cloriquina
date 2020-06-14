using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    public abstract class Personagens : PictureBox
    {
        
        public Personagens() : base() { }


        protected void AlterarScore(int score)
        {
            Configuracoes.Score += score;
        }

        protected virtual void AlterarVida(Jogador j, Timer t)
        {

        }

        protected virtual void AlterarVida(Jogador j)
        {

        }


        protected void Desaparecer() {
            Hide();
        }

    }
}
