namespace ListaExercicios3
{
    partial class FormVotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVotacao));
            this.btJair = new System.Windows.Forms.Button();
            this.btLula = new System.Windows.Forms.Button();
            this.btCiro = new System.Windows.Forms.Button();
            this.btSimone = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btBranco = new System.Windows.Forms.Button();
            this.btNulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btJair
            // 
            this.btJair.Image = ((System.Drawing.Image)(resources.GetObject("btJair.Image")));
            this.btJair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btJair.Location = new System.Drawing.Point(36, 42);
            this.btJair.Name = "btJair";
            this.btJair.Size = new System.Drawing.Size(80, 67);
            this.btJair.TabIndex = 0;
            this.btJair.UseVisualStyleBackColor = true;
            this.btJair.Click += new System.EventHandler(this.btJair_Click);
            // 
            // btLula
            // 
            this.btLula.Image = ((System.Drawing.Image)(resources.GetObject("btLula.Image")));
            this.btLula.Location = new System.Drawing.Point(143, 42);
            this.btLula.Name = "btLula";
            this.btLula.Size = new System.Drawing.Size(84, 67);
            this.btLula.TabIndex = 1;
            this.btLula.UseVisualStyleBackColor = true;
            this.btLula.Click += new System.EventHandler(this.btLula_Click);
            // 
            // btCiro
            // 
            this.btCiro.Image = global::ListaExercicios3.Properties.Resources.Ciro_Gomes__cropped_;
            this.btCiro.Location = new System.Drawing.Point(261, 42);
            this.btCiro.Name = "btCiro";
            this.btCiro.Size = new System.Drawing.Size(93, 67);
            this.btCiro.TabIndex = 2;
            this.btCiro.UseVisualStyleBackColor = true;
            this.btCiro.Click += new System.EventHandler(this.btCiro_Click);
            // 
            // btSimone
            // 
            this.btSimone.Image = global::ListaExercicios3.Properties.Resources._1EFA1CF4_52CB_4974_8F18_15A60C7B37D6_769x492;
            this.btSimone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSimone.Location = new System.Drawing.Point(387, 42);
            this.btSimone.Name = "btSimone";
            this.btSimone.Size = new System.Drawing.Size(90, 67);
            this.btSimone.TabIndex = 3;
            this.btSimone.UseVisualStyleBackColor = true;
            this.btSimone.Click += new System.EventHandler(this.btSimone_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(244, 369);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(129, 46);
            this.btFinalizar.TabIndex = 4;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btBranco
            // 
            this.btBranco.Location = new System.Drawing.Point(36, 146);
            this.btBranco.Name = "btBranco";
            this.btBranco.Size = new System.Drawing.Size(75, 75);
            this.btBranco.TabIndex = 5;
            this.btBranco.Text = "Branco";
            this.btBranco.UseVisualStyleBackColor = true;
            this.btBranco.Click += new System.EventHandler(this.btBranco_Click);
            // 
            // btNulo
            // 
            this.btNulo.Location = new System.Drawing.Point(36, 247);
            this.btNulo.Name = "btNulo";
            this.btNulo.Size = new System.Drawing.Size(75, 70);
            this.btNulo.TabIndex = 6;
            this.btNulo.Text = "Nulo";
            this.btNulo.UseVisualStyleBackColor = true;
            this.btNulo.Click += new System.EventHandler(this.btNulo_Click);
            // 
            // FormVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.btNulo);
            this.Controls.Add(this.btBranco);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btSimone);
            this.Controls.Add(this.btCiro);
            this.Controls.Add(this.btLula);
            this.Controls.Add(this.btJair);
            this.Name = "FormVotacao";
            this.Text = "FormVotacao";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btJair;
        private Button btLula;
        private Button btCiro;
        private Button btSimone;
        private Button btFinalizar;
        private Button btBranco;
        private Button btNulo;
    }
}