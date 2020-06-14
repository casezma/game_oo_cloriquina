using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    class AuxilioEmergencial : Personagens, IPersonagens
    {
        private bool encostouJogador = false;
        private int score  = 600;
    
        public AuxilioEmergencial(int posicao) : base() {
            BackColor = System.Drawing.Color.Transparent;
            Image = global::BrasileiroAtacado.Properties.Resources._600pila;
            Location = new System.Drawing.Point(posicao, 0);
            Name = "pictureAuxilioEmergencial";
            Size = new System.Drawing.Size(153, 104);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            TabIndex = 3;
            TabStop = false;
            Top = 0;
        }

        public void EncostarNoJogador(Jogador jogador, Timer timer)
        {   
            Desaparecer();
            AlterarScore(score);
            encostouJogador = true;
        }
        public bool EncostouNoJogador()
        {
            return encostouJogador;
        }



    }
}
