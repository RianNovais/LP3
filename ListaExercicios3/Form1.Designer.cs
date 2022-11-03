namespace ListaExercicios3
{
    partial class FormMostrarMut
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
            this.textMultiplos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textMultiplos
            // 
            this.textMultiplos.Location = new System.Drawing.Point(26, 38);
            this.textMultiplos.Multiline = true;
            this.textMultiplos.Name = "textMultiplos";
            this.textMultiplos.Size = new System.Drawing.Size(100, 30);
            this.textMultiplos.TabIndex = 0;
            // 
            // FormMostrarMut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.textMultiplos);
            this.Name = "FormMostrarMut";
            this.Text = "Mostrar Multiplos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textMultiplos;
    }
}