using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    class Coronavirus : Personagens, IPersonagens
    {
        private bool encostouJogador = false;

        public Coronavirus(int posicao) : base() {
            BackColor = System.Drawing.Color.Transparent;
            Image = global::BrasileiroAtacado.Properties.Resources.coronavirus;
            Location = new System.Drawing.Point(posicao, 0);
            Name = "pictureCoronavirus";
            Size = new System.Drawing.Size(153, 104);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            TabIndex = 3;
            TabStop = false;
            Top = 0;
        }


        protected override void AlterarVida(Jogador jogador,Timer timer)
        {
            jogador.DiminuirVida(timer);
        }
        
        public void EncostarNoJogador(Jogador jogador, Timer timer)
        {
            Desaparecer();
            AlterarVida(jogador, timer);
            encostouJogador = true;
        }

        public bool EncostouNoJogador() {
            return encostouJogador;
        }



    }
}
