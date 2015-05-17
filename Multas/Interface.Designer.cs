namespace Multas
{
    partial class aplicacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aplicacao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.placaEnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.velocidadeEnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listaRadares = new System.Windows.Forms.ComboBox();
            this.botaoMultar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // placaEnt
            // 
            this.placaEnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.placaEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaEnt.Location = new System.Drawing.Point(233, 318);
            this.placaEnt.Name = "placaEnt";
            this.placaEnt.Size = new System.Drawing.Size(100, 26);
            this.placaEnt.TabIndex = 1;
            this.placaEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informações do Veículo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informações do Radar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velocidadeEnt
            // 
            this.velocidadeEnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.velocidadeEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocidadeEnt.Location = new System.Drawing.Point(507, 318);
            this.velocidadeEnt.Name = "velocidadeEnt";
            this.velocidadeEnt.Size = new System.Drawing.Size(100, 26);
            this.velocidadeEnt.TabIndex = 4;
            this.velocidadeEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F);
            this.label3.Location = new System.Drawing.Point(143, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 16F);
            this.label4.Location = new System.Drawing.Point(357, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Velocidade:";
            // 
            // listaRadares
            // 
            this.listaRadares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listaRadares.FormattingEnabled = true;
            this.listaRadares.Location = new System.Drawing.Point(156, 425);
            this.listaRadares.Name = "listaRadares";
            this.listaRadares.Size = new System.Drawing.Size(484, 24);
            this.listaRadares.TabIndex = 7;
            // 
            // botaoMultar
            // 
            this.botaoMultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoMultar.Location = new System.Drawing.Point(301, 465);
            this.botaoMultar.Name = "botaoMultar";
            this.botaoMultar.Size = new System.Drawing.Size(172, 42);
            this.botaoMultar.TabIndex = 8;
            this.botaoMultar.Text = "Multar Veículo";
            this.botaoMultar.UseVisualStyleBackColor = true;
            this.botaoMultar.Click += new System.EventHandler(this.botaoMultar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 16F);
            this.label6.Location = new System.Drawing.Point(613, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Km/h";
            // 
            // aplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botaoMultar);
            this.Controls.Add(this.listaRadares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.velocidadeEnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placaEnt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "aplicacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Multas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox placaEnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox velocidadeEnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listaRadares;
        private System.Windows.Forms.Button botaoMultar;
        private System.Windows.Forms.Label label6;
    }
}

