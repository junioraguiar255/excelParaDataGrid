using ExcelDataReader;
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

namespace TesteExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DataTableCollection tablesC;

        private void Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tablesC = result.Tables;
                            cboMuda.Items.Clear();

                            foreach (DataTable table in tablesC)
                            {
                                //cboMuda.Items.Add(table.TableName);
                                DataTable teste1 = table.Copy();
                                tabela.DataSource = teste1;
                                

                            }
                            //cboMuda.Items[0] = ofd.FileName;
                            
                            //DataTable teste = tablesC[cboMuda.Items[0].ToString()];
                            //tabela.DataSource = teste1;
                            //tablesC.;
                        }
                        
                        
                    }
                }
            }
        }

        private void CboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = tablesC[cboMuda.SelectedItem.ToString()];
           // cboMuda.Items[0] = txtPath.Text;
            //tabela.DataSource = dt;
           
            
        }
    }
}
