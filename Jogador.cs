using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    public class Jogador : PictureBox
    {
   
        private int Vida = 1;

        public Jogador() : base()  {
            BackColor = System.Drawing.Color.Transparent;
            Image = global::BrasileiroAtacado.Properties.Resources.huehuebr;
            Name = "pictureBoxJogador";
            Size = new System.Drawing.Size(136, 102);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            TabIndex = 0;
            TabStop = false;
        }

        public void DiminuirVida(Timer t) {
            --Vida;
            if (Vida == 0) {
                Morrer(t);
            }
        }

        public void AumentarVida() {
            if(Vida <= 2)
                Vida++;
        }

        public int RetornarValorVida() {
            return this.Vida;
        }


        private void Morrer(Timer t) {
            t.Stop();
            new TelaGameOver().ShowDialog();
        }

        
    }
}
