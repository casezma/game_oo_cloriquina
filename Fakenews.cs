using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    class Fakenews : Personagens, IPersonagens
    {
        private bool encostouJogador = false;
        private int Score = -300;

        public Fakenews(int posicao) : base()
        {
            BackColor = System.Drawing.Color.Transparent;
            Image = global::BrasileiroAtacado.Properties.Resources.fakenews;
            Location = new System.Drawing.Point(posicao, 0);
            Name = "pictureFakeNews";
            Size = new System.Drawing.Size(153, 104);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            TabIndex = 3;
            TabStop = false;
            Top = 0;
        }


        public void EncostarNoJogador(Jogador jogador, Timer t)
        {
            Desaparecer();
            AlterarScore(Score);
            encostouJogador = true;
        }
        public bool EncostouNoJogador()
        {
            return encostouJogador;
        }
    }
}
