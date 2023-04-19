
namespace DadosC
{
    partial class CantidadJugadores
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
            this.tIngresarCantidad = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tIngresarCantidad
            // 
            this.tIngresarCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.tIngresarCantidad.Location = new System.Drawing.Point(48, 48);
            this.tIngresarCantidad.Name = "tIngresarCantidad";
            this.tIngresarCantidad.Size = new System.Drawing.Size(519, 26);
            this.tIngresarCantidad.TabIndex = 0;
            this.tIngresarCantidad.Text = "Ingrese la cantidad de Jugadores";
            this.tIngresarCantidad.TextChanged += new System.EventHandler(this.tIngresarCantidad_TextChanged);
            this.tIngresarCantidad.Enter += new System.EventHandler(this.tIngresarCantidad_Enter);
            this.tIngresarCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tIngresarCantidad_KeyPress);
            // 
            // bConfirmar
            // 
            this.bConfirmar.AutoSize = true;
            this.bConfirmar.Location = new System.Drawing.Point(613, 48);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(88, 30);
            this.bConfirmar.TabIndex = 1;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // CantidadJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 113);
            this.ControlBox = false;
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tIngresarCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CantidadJugadores";
            this.Text = "Cantidad de Jugadores";
            this.Load += new System.EventHandler(this.CantidadJugadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tIngresarCantidad;
        private System.Windows.Forms.Button bConfirmar;
    }
}