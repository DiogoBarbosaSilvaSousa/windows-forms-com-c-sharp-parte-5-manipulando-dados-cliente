using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        /// <summary>
        /// Incicializo os parâmetros que serão usados.
        /// </summary>
        /// <param name="nomeArquivoImagem">Nome do arquivo</param>
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem_UC.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if(CDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = CDb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();
            if(FDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = FDb.Font;
            }
        }
    }
}
