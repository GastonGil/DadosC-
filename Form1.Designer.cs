
namespace DadosC
{
    partial class Dados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cubilete = new System.Windows.Forms.PictureBox();
            this.Dado1 = new System.Windows.Forms.PictureBox();
            this.Dado2 = new System.Windows.Forms.PictureBox();
            this.Dado3 = new System.Windows.Forms.PictureBox();
            this.Dado4 = new System.Windows.Forms.PictureBox();
            this.Dado5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cubilete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado5)).BeginInit();
            this.SuspendLayout();
            // 
            // Cubilete
            // 
            this.Cubilete.BackColor = System.Drawing.Color.Transparent;
            this.Cubilete.Location = new System.Drawing.Point(470, 12);
            this.Cubilete.Name = "Cubilete";
            this.Cubilete.Size = new System.Drawing.Size(307, 273);
            this.Cubilete.TabIndex = 0;
            this.Cubilete.TabStop = false;
            this.Cubilete.Click += new System.EventHandler(this.Cubilete_Click);
            // 
            // Dado1
            // 
            this.Dado1.BackgroundImage = global::DadosC.Properties.Resources.dado6;
            this.Dado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dado1.Location = new System.Drawing.Point(92, 72);
            this.Dado1.Name = "Dado1";
            this.Dado1.Size = new System.Drawing.Size(94, 95);
            this.Dado1.TabIndex = 1;
            this.Dado1.TabStop = false;
            // 
            // Dado2
            // 
            this.Dado2.BackgroundImage = global::DadosC.Properties.Resources.dado6;
            this.Dado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dado2.Location = new System.Drawing.Point(292, 72);
            this.Dado2.Name = "Dado2";
            this.Dado2.Size = new System.Drawing.Size(94, 95);
            this.Dado2.TabIndex = 2;
            this.Dado2.TabStop = false;
            // 
            // Dado3
            // 
            this.Dado3.BackgroundImage = global::DadosC.Properties.Resources.dado6;
            this.Dado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dado3.Location = new System.Drawing.Point(215, 201);
            this.Dado3.Name = "Dado3";
            this.Dado3.Size = new System.Drawing.Size(94, 95);
            this.Dado3.TabIndex = 3;
            this.Dado3.TabStop = false;
            // 
            // Dado4
            // 
            this.Dado4.BackgroundImage = global::DadosC.Properties.Resources.dado6;
            this.Dado4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dado4.Location = new System.Drawing.Point(74, 315);
            this.Dado4.Name = "Dado4";
            this.Dado4.Size = new System.Drawing.Size(94, 95);
            this.Dado4.TabIndex = 4;
            this.Dado4.TabStop = false;
            // 
            // Dado5
            // 
            this.Dado5.BackgroundImage = global::DadosC.Properties.Resources.dado6;
            this.Dado5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dado5.Location = new System.Drawing.Point(326, 315);
            this.Dado5.Name = "Dado5";
            this.Dado5.Size = new System.Drawing.Size(94, 95);
            this.Dado5.TabIndex = 5;
            this.Dado5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dado 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dado 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dado 5";
            // 
            // Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DadosC.Properties.Resources.mesa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dado5);
            this.Controls.Add(this.Dado4);
            this.Controls.Add(this.Dado3);
            this.Controls.Add(this.Dado2);
            this.Controls.Add(this.Dado1);
            this.Controls.Add(this.Cubilete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dados";
            this.Text = "Apretá el Cubilete para tirar los dados";
            ((System.ComponentModel.ISupportInitialize)(this.Cubilete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Cubilete;
        private System.Windows.Forms.PictureBox Dado1;
        private System.Windows.Forms.PictureBox Dado2;
        private System.Windows.Forms.PictureBox Dado3;
        private System.Windows.Forms.PictureBox Dado4;
        private System.Windows.Forms.PictureBox Dado5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

