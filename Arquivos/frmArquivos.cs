using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Arquivos
{
    public partial class frmArquivos : Form
    {
        //Criada classe para gerenciar arquivos
        clsFiles cFiles = new clsFiles();


        public frmArquivos()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {

                fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtLocal.Text = fbd.SelectedPath;
                    CarregarLista(txtLocal.Text);
                }

            }
        }

        private void CarregarLista(string folder)
        {
            var lst = new List<string>();
            lst = cFiles.DevolverArquivosDiretorio(folder);

            foreach (string elem in lst)
            {
                lstArquivos.Items.Add(Path.GetFileName(elem));
            }
        }

        private void lstArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tslTexto.Text =  txtLocal.Text + "\\" + lstArquivos.Text;
                
                //toolstriplabel
                if (tslTexto.Text != "")
                {
                    //Se for para ir para uma linha especifica, deve carregar até a linha + 1
                    if (txtIrPara.Text == "")
                        txtQtdeLinhas.Text = Convert.ToInt32((txtQtdeLinhas.Text != "") ? txtQtdeLinhas.Text : "200").ToString();
                    else
                        txtQtdeLinhas.Text = (Convert.ToInt32(txtIrPara.Text) + 1).ToString();

                    txtTexto.Text = "";

                    CarregarTexto(@tslTexto.Text,
                                  Convert.ToInt32(txtQtdeLinhas.Text == "" ? "0" : txtQtdeLinhas.Text),
                                  Convert.ToInt32(txtIrPara.Text == "" ? "0" : txtIrPara.Text),
                                  txtTexto);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo.\n" + ex.Message.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }
        }

        private void CarregarTexto(string strArquivo, int intQtdeLinhas, int intIrPara, TextBox txtDestino )
        {
            var strMsg="";
            var strTextoArquivo="";
            var intCont = 1;
            var intTamanhoArquivo=0;
            var stReader = cFiles.DevolverStreamReader(strArquivo);

            intTamanhoArquivo = intQtdeLinhas;//cFiles.ContarLinhasTexto(strArquivo);
            
            prbStatus.Minimum = 1;
            prbStatus.Maximum = intQtdeLinhas > intTamanhoArquivo ? intTamanhoArquivo : intQtdeLinhas;

            while (!stReader.EndOfStream)
            {
                strMsg = stReader.ReadLine();

                if (intIrPara != 0)
                {
                    if (intIrPara == intCont)
                    {
                        strTextoArquivo += strMsg + "\r\n";
                        break;
                    }
                }
                else
                    strTextoArquivo += strMsg + System.Environment.NewLine;

                prbStatus.Increment(1);
                intCont += 1;

                if ((intCont > intQtdeLinhas ))
                    break;
            }

            if (intIrPara != 0 && strTextoArquivo == "")
            {
                MessageBox.Show("Linha não encontrada!", "Erro", MessageBoxButtons.OK);
            }

            txtDestino.Text = strTextoArquivo;
        
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lstArquivos_SelectedIndexChanged(sender, e);
        }

        private void frmArquivos_Load(object sender, EventArgs e)
        {
            chkQuebra.Checked = false;
            chkQuebra_CheckedChanged(sender, e);
        }

        private void chkQuebra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQuebra.Checked)
                txtTexto.WordWrap = true;
            else
                txtTexto.WordWrap = false;

        }

    }
}
