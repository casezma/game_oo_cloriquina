using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    class Cloroquina : Personagens, IPersonagens
    {

        private bool encostouJogador = false;
    
        public Cloroquina(int posicao) : base() {
            BackColor = System.Drawing.Color.Transparent;
            Image = global::BrasileiroAtacado.Properties.Resources.cloroquina;
            Location = new System.Drawing.Point(posicao, 0);
            Name = "pictureBoxCloroquina1";
            Size = new System.Drawing.Size(153, 104);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            TabIndex = 3;
            TabStop = false;
            Top = 0;
        }


        protected override void AlterarVida(Jogador j)
        {
            j.AumentarVida();
        }
   
        public void EncostarNoJogador(Jogador jogador, Timer timer)
        {
            Desaparecer();
            AlterarVida(jogador);
            encostouJogador = true;
          
        }

        public bool EncostouNoJogador()
        {
            return encostouJogador;
        }
    }
}
