using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ProvaEdesoft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProvaEdesoft.Operacao;

namespace ProvaEdesoft
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            crud c = new crud();
            c.AcaoOperacao(Operacao.Acao.edit, txtNomeDono.Text, txtNomeCao.Text, txtRacaCao.Text);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            crud c = new crud();
            c.AcaoOperacao(Operacao.Acao.del, txtNomeDono.Text, txtNomeCao.Text, txtRacaCao.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            crud c = new crud();
            c.AcaoOperacao(Operacao.Acao.add, txtNomeDono.Text, txtNomeCao.Text, txtRacaCao.Text);
            clearFields();
            MessageBox.Show("Registros salvos com sucesso");
        }
        public void clearFields()
        {
            txtNomeDono.Clear();
            txtNomeCao.Clear();
            txtRacaCao.Clear();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void txtNomeDono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarRelatório_Click(object sender, EventArgs e)
        {
            string diretorio= "";
            try
            {
                //Define as propriedades do controle FolderBrowserDialog
                fbdDestino.Description = "Selecione uma pasta de destino:";
                this.fbdDestino.ShowNewFolderButton = true;
                //Exibe a caixa de diálogo
                this.fbdDestino.RootFolder = System.Environment.SpecialFolder.MyComputer;
                if (fbdDestino.ShowDialog() == DialogResult.OK)
                {
                    //Exibe a pasta selecionada
                    diretorio = fbdDestino.SelectedPath;
                    diretorio = diretorio + @"\";
                }
                SolicitaGeracaoRelatorio(txtInformeRacaCao.Text, diretorio);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void SolicitaGeracaoRelatorio(string racaCao, string diretorio)
        {
            crud c = null;
            List<ModelDonoCao> relatorioDonoCao = null;
            ModelDonoCao mDC = null;
            try
            {
                lblDiretorioDestino.Text = diretorio + "RelatorioDonoCao.xlsx";
                c = new crud();
                relatorioDonoCao = c.Relatorio(racaCao);
                mDC = new ModelDonoCao();
                if (relatorioDonoCao == null)
                {
                    MessageBox.Show("Não existe essa raça.","Atenção!");
                }
                else
                {
                    txtInformeRacaCao.Clear();
                    // Preencher planilha excel/csv

                    ////var folderPath = @"E:\APLICAÇÕES E CURSOS\PROVA EDESOFT\ProvaEdesoft";
                    ////if (!Directory.Exists(folderPath))
                    ////    Directory.CreateDirectory(folderPath);
                    ////var filePath = $"{folderPath}\\YourFileName.xlsx";
                    ////Console.WriteLine($"Exported Successfully to {filePath}");
                    ///
                    using (var workbook = new XLWorkbook())
                    {
                        //Formatação da planilha
                        var worksheet = workbook.Worksheets.Add("RelacionamentoDono&Cao");
                        var currentRow = 1;
                        worksheet.Cell(currentRow, 1).Value = "Nome do Dono";
                        worksheet.Cell(currentRow, 2).Value = "Nome do Cão";
                        worksheet.Cell(currentRow, 3).Value = "Raça do Cão";

                        //Preenchimento da planilha
                        foreach (var m in relatorioDonoCao)
                        {
                            currentRow++;
                            worksheet.Cell(currentRow, 1).Value = m.NomeDono; ;
                            worksheet.Cell(currentRow, 2).Value = m.NomeCao;
                            worksheet.Cell(currentRow, 3).Value = m.RacaCao;
                        }


                        //Salva a planilha
                        using (var stream = new MemoryStream())
                        {
                            workbook.SaveAs(stream);
                            var content = stream.ToArray();
                            //workbook.SaveAs(@"E:\APLICAÇÕES E CURSOS\PROVA EDESOFT\ProvaEdesoft\RelatorioDonoCao.xlsx");
                            workbook.SaveAs(@diretorio + "RelatorioDonoCao.xlsx");
                        }
                        MessageBox.Show("Relatório gerado no diretório informado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SolicitaGeracaoRelatorio: " + ex.Message);                
            }
        }
    }
}
