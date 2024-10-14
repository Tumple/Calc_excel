using OfficeOpenXml;
using System;
using System.Runtime.CompilerServices;
using System.Data;
using System.Data.OleDb;
using static System.Data.Common.DbConnection;
using System.Data.Common;
using Microsoft.Data.Sqlite;

namespace project2
{

    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbCommand command = new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Tumple\Documents\Calc_Excel\Pres1.accdb;Persist Security Info=False;";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            update_list();
        }
        public void update_list()
        {
            comboBox2.Items.Clear();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from [Option]";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["name_pres"].ToString());
            }
            connection.Close();

        }
        public int CharToInt(char c)
        {
            if (char.IsUpper(c))
            {
                return (int)c - 64;
            }
            return c;
        }
        private void b_start_Click(object sender, EventArgs e)
        {
            Class1.file_nom = label_nom.Text;
            Class1.file_price = label_price.Text;
            Class1.width_end_i = int.Parse(width_end.Text);
            Class1.height_end_i = int.Parse(height_end.Text);
            string new_start_cell = start_cell.Text;
            new_start_cell = new_start_cell.ToUpper();
            int index = CharToInt(new_start_cell[0]);
            int index2 = Convert.ToInt32(new_start_cell.Replace(new_start_cell[0], ' '));
            int index2_for = index2;
            using (ExcelPackage excelPackage_nom = new ExcelPackage(Class1.file_nom))
            {
                ExcelWorksheet workSheet_nom = excelPackage_nom.Workbook.Worksheets[Convert.ToInt32(nom_listnum.Text) - 1];
                using (ExcelPackage excelPackage_price = new ExcelPackage(Class1.file_price))
                {

                    ExcelWorksheet workSheet_price = excelPackage_price.Workbook.Worksheets[Convert.ToInt32(price_listnum.Text) - 1];
                    if (checkBox1.Checked == false)
                    {
                        for (int width = int.Parse(width_start.Text); width <= Class1.width_end_i; width += 5)
                        {
                            for (int height = int.Parse(height_start.Text); height <= Class1.height_end_i; height += 5)
                            {
                                //nom
                                workSheet_nom.Cells[nom_width.Text.ToUpper()].Value = width;
                                workSheet_nom.Cells[nom_height.Text.ToUpper()].Value = height;
                                if (nom_formula_st.Text != "")
                                {
                                    workSheet_nom.Cells[nom_formula_st.Text.ToUpper()].Calculate();
                                }

                                workSheet_nom.Cells[nom_formula_nst.Text.ToUpper()].Calculate();

                                //price
                                if (workSheet_price.Cells[index2, index].Style.Border.Bottom.Style.ToString() == "Thick")
                                {
                                    if (workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF99CC00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FFFFFF00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF92D050"
                                        )
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_st.Text.ToUpper()].Value);
                                    }
                                    else
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_nst.Text.ToUpper()].Value);
                                    }
                                    Class1.height_end_i = height;
                                }
                                else
                                {
                                    if (workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF99CC00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FFFFFF00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF92D050"
                                        )
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_st.Text.ToUpper()].Value);
                                    }
                                    else
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_nst.Text.ToUpper()].Value);
                                    }
                                }
                                index2 += 1;
                            }

                            index2 = index2_for;
                            index += 1;
                        }
                    }
                    else
                    {
                        for (int width = int.Parse(width_start.Text); width >= Class1.width_end_i; width -= 5)
                        {
                            for (int height = int.Parse(height_start.Text); height >= Class1.height_end_i; height -= 5)
                            {
                                //nom
                                workSheet_nom.Cells[nom_width.Text.ToUpper()].Value = width;
                                workSheet_nom.Cells[nom_height.Text.ToUpper()].Value = height;
                                if (nom_formula_st.Text != "")
                                {
                                    workSheet_nom.Cells[nom_formula_st.Text.ToUpper()].Calculate();

                                }

                                workSheet_nom.Cells[nom_formula_nst.Text.ToUpper()].Calculate();

                                //price
                                if (workSheet_price.Cells[index2, index].Style.Border.Top.Style.ToString() == "Thick")
                                {
                                    if (workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF99CC00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FFFFFF00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF92D050"
                                        )
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_st.Text.ToUpper()].Value);
                                    }
                                    else
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_nst.Text.ToUpper()].Value);
                                    }
                                    Class1.height_end_i = height;
                                }
                                else
                                {
                                    if (workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF99CC00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FFFFFF00" ||
                                        workSheet_price.Cells[index2, index].Style.Fill.BackgroundColor.LookupColor() == "#FF92D050"
                                        )
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_st.Text.ToUpper()].Value);
                                    }
                                    else
                                    {
                                        workSheet_price.Cells[index2, index].Value = Convert.ToInt32(workSheet_nom.Cells[nom_formula_nst.Text.ToUpper()].Value);
                                    }
                                }
                                index2 -= 1;
                            }

                            index2 = index2_for;
                            index -= 1;
                        }
                    }


                    excelPackage_price.Save();
                    MessageBox.Show("Работа выполнена");
                }

            }
        }

        private void b_search_nom_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel Files|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Class1.file_nom = openFileDialog1.FileName;
            }
            label_nom.Text = (Class1.file_nom);
        }

        private void b_search_price_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel Files|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Class1.file_price = openFileDialog1.FileName;
            }
            label_price.Text = (Class1.file_price);
        }


        private void save_Click(object sender, EventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Введите название пресета", "Ввод названия пресета");
            connection.Open();
            command.Connection = connection;
            command.CommandText =
                "insert into [Option] (name_pres, nom, price, l_price, l_nom, w_start, w_end, h_start, h_end, formula_st, formula_nst, weight, height, start_cell, checkbox) " +
                "values ('" + userInput + "','" + label_nom.Text + "', '" + label_price.Text + "', '" + price_listnum.Text + "','" + nom_listnum.Text + "','" + width_start.Text + "'," +
                "'" + width_end.Text + "','" + height_start.Text + "','" + height_end.Text + "', '" + nom_formula_st.Text + "','" + nom_formula_nst.Text + "','" + nom_width.Text + "'," +
                "'" + nom_height.Text + "','" + start_cell.Text + "','" + checkBox1.Checked.ToString() + "')";
            command.ExecuteNonQuery();


            connection.Close();
            update_list();
            MessageBox.Show($"Создан пресет {userInput}");
        }
        private void edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText =
                "update [Option] set  nom = '" + label_nom.Text + "' , price = '" + label_price.Text + "' , l_price = '" + price_listnum.Text + "' , l_nom = '" + nom_listnum.Text + "' " +
                ", w_start = '" + width_start.Text + "' , w_end = '" + width_end.Text + "' , h_start = '" + height_start.Text + "' , h_end = '" + height_end.Text + "' , formula_st = '" + nom_formula_st.Text + "' " +
                ", formula_nst = '" + nom_formula_nst.Text + "' , weight = '" + nom_width.Text + "' , height = '" + nom_height.Text + "' , start_cell = '" + start_cell.Text + "' , checkbox = '" + checkBox1.Checked.ToString() + "' " +
                $"where [name_pres] = '{comboBox2.SelectedItem.ToString()}'";

            command.ExecuteNonQuery();
            connection.Close();
            update_list();
            MessageBox.Show("Изменения внесены в пресет");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.SelectedItem.ToString());
            connection.Open();
            command.Connection = connection;
            command.CommandText = $"delete * from [Option] where [name_pres] = '{comboBox2.SelectedItem.ToString()}'";
            command.ExecuteNonQuery();
            connection.Close();
            update_list();
            MessageBox.Show("Изменения внесены в пресет");
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;

            command.CommandText = $"select * from [Option] where [name_pres] = '{comboBox2.SelectedItem.ToString()}'";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                label_nom.Text = reader["nom"].ToString();
                label_price.Text = reader["price"].ToString();
                price_listnum.Text = reader["l_price"].ToString();
                nom_listnum.Text = reader["l_nom"].ToString();
                width_start.Text = reader["w_start"].ToString();
                width_end.Text = reader["w_end"].ToString();
                height_start.Text = reader["h_start"].ToString();
                height_end.Text = reader["h_end"].ToString();
                nom_formula_st.Text = reader["formula_st"].ToString();
                nom_formula_nst.Text = reader["formula_nst"].ToString();
                nom_width.Text = reader["weight"].ToString();
                nom_height.Text = reader["height"].ToString();
                start_cell.Text = reader["start_cell"].ToString();
                if (reader["checkbox"].ToString() == "True") { checkBox1.Checked = true; }
                else if (reader["checkbox"].ToString() == "False") { checkBox1.Checked = false; }
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
