
namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.Btn_ModificaLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            this.lbl_Titulo.Click += new System.EventHandler(this.lbl_Titulo_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Sair.Location = new System.Drawing.Point(278, 147);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(150, 23);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Fechar a aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(34, 107);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(393, 20);
            this.Txt_ConteudoLabel.TabIndex = 2;
            this.Txt_ConteudoLabel.TextChanged += new System.EventHandler(this.Txt_ConteudoLabel_TextChanged);
            // 
            // Btn_ModificaLabel
            // 
            this.Btn_ModificaLabel.Location = new System.Drawing.Point(34, 66);
            this.Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            this.Btn_ModificaLabel.Size = new System.Drawing.Size(172, 23);
            this.Btn_ModificaLabel.TabIndex = 3;
            this.Btn_ModificaLabel.Text = "Modifica Texto do Label";
            this.Btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificaLabel.Click += new System.EventHandler(this.Btn_ModificaLabel_Click);
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 182);
            this.Controls.Add(this.Btn_ModificaLabel);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Frm_HelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
        private System.Windows.Forms.Button Btn_ModificaLabel;
    }
}

