namespace BrasileiroAtacado
{
    partial class TelaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.opcaoPequeno = new System.Windows.Forms.RadioButton();
            this.opcaoMedio = new System.Windows.Forms.RadioButton();
            this.opcaoGrande = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opcaoPequeno
            // 
            this.opcaoPequeno.AutoSize = true;
            this.opcaoPequeno.Location = new System.Drawing.Point(302, 288);
            this.opcaoPequeno.Name = "opcaoPequeno";
            this.opcaoPequeno.Size = new System.Drawing.Size(86, 21);
            this.opcaoPequeno.TabIndex = 0;
            this.opcaoPequeno.TabStop = true;
            this.opcaoPequeno.Text = "Pequeno";
            this.opcaoPequeno.UseVisualStyleBackColor = true;
            // 
            // opcaoMedio
            // 
            this.opcaoMedio.AutoSize = true;
            this.opcaoMedio.Location = new System.Drawing.Point(302, 332);
            this.opcaoMedio.Name = "opcaoMedio";
            this.opcaoMedio.Size = new System.Drawing.Size(67, 21);
            this.opcaoMedio.TabIndex = 1;
            this.opcaoMedio.TabStop = true;
            this.opcaoMedio.Text = "Medio";
            this.opcaoMedio.UseVisualStyleBackColor = true;
            // 
            // opcaoGrande
            // 
            this.opcaoGrande.AutoSize = true;
            this.opcaoGrande.Location = new System.Drawing.Point(302, 378);
            this.opcaoGrande.Name = "opcaoGrande";
            this.opcaoGrande.Size = new System.Drawing.Size(77, 21);
            this.opcaoGrande.TabIndex = 2;
            this.opcaoGrande.TabStop = true;
            this.opcaoGrande.Text = "Grande";
            this.opcaoGrande.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(302, 425);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(125, 23);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Em busca da Cloroquina";
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.opcaoGrande);
            this.Controls.Add(this.opcaoMedio);
            this.Controls.Add(this.opcaoPequeno);
            this.Name = "TelaInicio";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton opcaoPequeno;
        private System.Windows.Forms.RadioButton opcaoMedio;
        private System.Windows.Forms.RadioButton opcaoGrande;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label label1;
    }
}