using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackStage;
using ClosedXML.Excel;
using System.IO;

namespace MTGRosarioPedidos
{
    public partial class Form1 : Form
    {
        private Parser linkParser = new Parser();
        private ListaCartas lista = new ListaCartas();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Any())
            {

                if (textBox1.Text.Contains("http://www.mtgmintcard.com/mtg/singles"))
                {
                    linkParser.LinkParser(textBox1.Text);
                    Carta card = new Carta();
                    card.nombre = linkParser.NameSelector();
                    card.expansion = linkParser.ExpansionSelector();
                    card.precio = linkParser.PriceSelector();
                    card.cantidad = 1;
                    card.link = textBox1.Text;
                    lista.listaCartas.Add(card);
                    dataGrid.Rows.Add(card.nombre, card.cantidad, card.expansion, card.precio);
                }
                else
                {
                    MessageBox.Show("Link inválido, intente de nuevo.");
                }
                
            }
            else
            {
                MessageBox.Show("El cuadro no puede estar vacío, intente de nuevo.");
            }
                textBox1.Clear();
        }

        private void MTGMintcard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mtgmintcard.com");
        }

        private void MTGRosario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/mtgrosario/");
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Any())
            {
                var file = new SaveFileDialog();
                file.ShowDialog();
                if (file.FileName.Any())
                {
                    var excelRow = 25;
                    var localRow = 0;
                    var workbook = new XLWorkbook("Planilla de Compra.xlsx");
                    var worksheet = workbook.Worksheets.First();

                    var listCards = lista.getList();
                    foreach (var card in listCards)
                    {
                        worksheet.Cell(excelRow, 2).Value = card.nombre;
                        worksheet.Cell(excelRow, 2).Hyperlink = new XLHyperlink(card.link);
                        worksheet.Cell(excelRow, 4).Value = card.expansion;
                        worksheet.Cell(excelRow, 3).Value = dataGrid.Rows[localRow].Cells[1].Value;
                        worksheet.Cell(excelRow, 7).Value = card.precio;
                        excelRow++;
                        localRow++;
                    }
                    worksheet.Cell(22, 3).Value = this.textBox2.Text;

                    workbook.SaveAs(file.FileName + ".xlsx");

                    if (File.Exists(file.FileName + ".xlsx"))
                    {
                        MessageBox.Show("Su archivo se ha creado exitosamente!");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Algo horrible ha pasado y no pudimos crear su archivo.");
                    }
                }
                else
                {
                    MessageBox.Show("No puede dejar el nombre del archivo en blanco, intente de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Complete su nombre y apellido.");
            }


        }

    }
}
