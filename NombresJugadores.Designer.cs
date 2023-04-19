
namespace DadosC
{
    partial class NombresJugadores
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
            this.tIngresarNombres = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tIngresarNombres
            // 
            this.tIngresarNombres.ForeColor = System.Drawing.Color.DimGray;
            this.tIngresarNombres.Location = new System.Drawing.Point(35, 45);
            this.tIngresarNombres.Name = "tIngresarNombres";
            this.tIngresarNombres.Size = new System.Drawing.Size(519, 26);
            this.tIngresarNombres.TabIndex = 1;
            this.tIngresarNombres.TextChanged += new System.EventHandler(this.tIngresarNombres_TextChanged);
            this.tIngresarNombres.Enter += new System.EventHandler(this.tIngresarNombres_Enter);
            // 
            // bConfirmar
            // 
            this.bConfirmar.AutoSize = true;
            this.bConfirmar.Location = new System.Drawing.Point(588, 45);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(88, 30);
            this.bConfirmar.TabIndex = 2;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click_1);
            // 
            // NombresJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 113);
            this.ControlBox = false;
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tIngresarNombres);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NombresJugadores";
            this.Text = "Nombres de Jugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tIngresarNombres;
        private System.Windows.Forms.Button bConfirmar;
    }
}