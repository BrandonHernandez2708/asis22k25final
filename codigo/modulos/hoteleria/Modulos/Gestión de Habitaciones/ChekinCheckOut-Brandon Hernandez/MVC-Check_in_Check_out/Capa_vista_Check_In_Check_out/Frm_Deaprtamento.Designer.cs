
namespace Capa_vista_Check_In_Check_out
{
    partial class Frm_Deaprtamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Deaprtamento));
            this.navegador1 = new Capa_Vista_Navegador.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.IPkId_Aplicacion = 0;
            this.navegador1.IPkId_Modulo = 0;
            this.navegador1.Location = new System.Drawing.Point(-7, 0);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.SAlias = null;
            this.navegador1.SEtiquetas = null;
            this.navegador1.Size = new System.Drawing.Size(1573, 601);
            this.navegador1.SNombreTabla = null;
            this.navegador1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(636, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 101);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1279, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 101);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Deaprtamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navegador1);
            this.Name = "Frm_Deaprtamento";
            this.Text = "Frm_Deaprtamento";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}