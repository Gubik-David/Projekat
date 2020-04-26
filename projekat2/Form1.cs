using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projekat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadHeader();
            LoadComboBox();
            LoadColorComboBox();
            comboBox2.Hide();
            label2.Hide();
            comboBox3.Hide();
            label3.Hide();
        }
        private void LoadHeader()
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.AutoResizeColumns();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Name = "Proizvodjac";
            dataGridView1.Columns[1].Name = "Model";
            dataGridView1.Columns[2].Name = "CPU";
            dataGridView1.Columns[3].Name = "RAM";
            dataGridView1.Columns[4].Name = "GPU";
            dataGridView1.Columns[5].Name = "Memorija";
            dataGridView1.Columns[6].Name = "Velicina Ekrana";
            dataGridView1.Columns[7].Name = "Boja";
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }
        private void LoadComboBox()
        {
            comboBox1.Items.Add("Huawei");
            comboBox1.Items.Add("LG");
            comboBox1.Items.Add("Samsung");
        }
        private void LoadColorComboBox()
        {
            comboBox3.Items.Add("White");
            comboBox3.Items.Add("Black");
            comboBox3.Items.Add("Gray");
            comboBox3.Items.Add("Gold");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Huawei")
            {
                comboBox2.Items.Clear();
                comboBox2.Show();
                label2.Show();
                comboBox2.Items.Add(Huawei.ModelToString("P40"));
                comboBox2.Items.Add(Huawei.ModelToString("MateXs"));
                comboBox2.Items.Add(Huawei.ModelToString("Y7p"));
                comboBox2.Items.Add(Huawei.ModelToString("Enjoy10"));
            }
            else if (comboBox1.Text == "LG")
            {
                comboBox2.Items.Clear();
                comboBox2.Show();
                label2.Show();
                comboBox2.Items.Add(LG.ModelToString("Q51"));
                comboBox2.Items.Add(LG.ModelToString("W10Alpha"));
                comboBox2.Items.Add(LG.ModelToString("K61"));
                comboBox2.Items.Add(LG.ModelToString("G8XThinQ"));
            }
            else if (comboBox1.Text == "Samsung")
            {
                comboBox2.Items.Clear();
                comboBox2.Show();
                label2.Show();
                comboBox2.Items.Add(Samsung.ModelToString("S20"));
                comboBox2.Items.Add(Samsung.ModelToString("A71"));
                comboBox2.Items.Add(Samsung.ModelToString("M31"));
                comboBox2.Items.Add(Samsung.ModelToString("Note10"));
            }
            else comboBox2.Hide();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Show();
            label3.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex >= 0)
            {
                if (comboBox1.Text == "Huawei")
                {
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            KreirajHuawei("P40");
                            break;
                        case 1:
                            KreirajHuawei("MateXs");
                            break;
                        case 2:
                            KreirajHuawei("Y7p");
                            break;
                        case 3:
                            KreirajHuawei("Enjoy10");
                            break;
                    }
                }
                else if (comboBox1.Text == "LG")
                {
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            KreirajLG("Q51");
                            break;
                        case 1:
                            KreirajLG("W10Alpha");
                            break;
                        case 2:
                            KreirajLG("K61");
                            break;
                        case 3:
                            KreirajLG("G8XThinQ");
                            break;
                    }
                }
                else if (comboBox1.Text == "Samsung")
                {
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            KreirajSamsung("S20");
                            break;
                        case 1:
                            KreirajSamsung("A71");
                            break;
                        case 2:
                            KreirajSamsung("M31");
                            break;
                        case 3:
                            KreirajSamsung("Note10");
                            break;
                    }
                }
            }
        }
        private void KreirajHuawei(string model)
        {
            Enum.TryParse(model, out Huawei.ModelTelefona Model);
            Huawei huawei = new Huawei(Model, comboBox3.Text);
            int n = dataGridView1.Rows.Add();
            Dictionary<string, string> dict = huawei.Tabela();
            dataGridView1.Rows[n].Cells[0].Value = huawei.Proizvodjac();
            dataGridView1.Rows[n].Cells[1].Value = Huawei.ModelToString(model);
            dataGridView1.Rows[n].Cells[2].Value = dict.ElementAt(0).Value;
            dataGridView1.Rows[n].Cells[3].Value = dict.ElementAt(1).Value;
            dataGridView1.Rows[n].Cells[4].Value = dict.ElementAt(2).Value;
            dataGridView1.Rows[n].Cells[5].Value = dict.ElementAt(3).Value;
            dataGridView1.Rows[n].Cells[6].Value = dict.ElementAt(4).Value;
            dataGridView1.Rows[n].Cells[7].Style.BackColor = Color.FromName(dict.ElementAt(5).Value);
        }
        private void KreirajLG(string model)
        {
            Enum.TryParse(model, out LG.ModelTelefona Model);
            LG lg = new LG(Model, comboBox3.Text);
            int n = dataGridView1.Rows.Add();
            Dictionary<string, string> dict = lg.Tabela();
            dataGridView1.Rows[n].Cells[0].Value = lg.Proizvodjac();
            dataGridView1.Rows[n].Cells[1].Value = LG.ModelToString(model);
            dataGridView1.Rows[n].Cells[2].Value = dict.ElementAt(0).Value;
            dataGridView1.Rows[n].Cells[3].Value = dict.ElementAt(1).Value;
            dataGridView1.Rows[n].Cells[4].Value = dict.ElementAt(2).Value;
            dataGridView1.Rows[n].Cells[5].Value = dict.ElementAt(3).Value;
            dataGridView1.Rows[n].Cells[6].Value = dict.ElementAt(4).Value;
            dataGridView1.Rows[n].Cells[7].Style.BackColor = Color.FromName(dict.ElementAt(5).Value);
        }
        private void KreirajSamsung(string model)
        {
            Enum.TryParse(model, out Samsung.ModelTelefona Model);
            Samsung samsung = new Samsung(Model, comboBox3.Text);
            int n = dataGridView1.Rows.Add();
            Dictionary<string, string> dict = samsung.Tabela();
            dataGridView1.Rows[n].Cells[0].Value = samsung.Proizvodjac();
            dataGridView1.Rows[n].Cells[1].Value = Samsung.ModelToString(model);
            dataGridView1.Rows[n].Cells[2].Value = dict.ElementAt(0).Value;
            dataGridView1.Rows[n].Cells[3].Value = dict.ElementAt(1).Value;
            dataGridView1.Rows[n].Cells[4].Value = dict.ElementAt(2).Value;
            dataGridView1.Rows[n].Cells[5].Value = dict.ElementAt(3).Value;
            dataGridView1.Rows[n].Cells[6].Value = dict.ElementAt(4).Value;
            dataGridView1.Rows[n].Cells[7].Style.BackColor = Color.FromName(dict.ElementAt(5).Value);
        }
    }
}