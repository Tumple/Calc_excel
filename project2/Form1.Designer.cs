namespace project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b_search_nom = new Button();
            b_search_price = new Button();
            b_start = new Button();
            nom_width = new TextBox();
            nom_height = new TextBox();
            nom_formula_nst = new TextBox();
            nom_formula_st = new TextBox();
            price_listnum = new TextBox();
            nom_listnum = new TextBox();
            start_cell = new TextBox();
            width_start = new TextBox();
            width_end = new TextBox();
            height_start = new TextBox();
            height_end = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            openFileDialog1 = new OpenFileDialog();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label12 = new Label();
            label13 = new Label();
            comboBox2 = new ComboBox();
            save = new Button();
            edit = new Button();
            delete = new Button();
            label_nom = new Label();
            label_price = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // b_search_nom
            // 
            b_search_nom.FlatStyle = FlatStyle.Popup;
            b_search_nom.Location = new Point(14, 16);
            b_search_nom.Margin = new Padding(3, 4, 3, 4);
            b_search_nom.Name = "b_search_nom";
            b_search_nom.Size = new Size(129, 31);
            b_search_nom.TabIndex = 0;
            b_search_nom.Text = "Номенклатура";
            b_search_nom.UseVisualStyleBackColor = true;
            b_search_nom.Click += b_search_nom_Click;
            // 
            // b_search_price
            // 
            b_search_price.FlatStyle = FlatStyle.Popup;
            b_search_price.Location = new Point(14, 55);
            b_search_price.Margin = new Padding(3, 4, 3, 4);
            b_search_price.Name = "b_search_price";
            b_search_price.Size = new Size(129, 31);
            b_search_price.TabIndex = 1;
            b_search_price.Text = "Прайс";
            b_search_price.UseVisualStyleBackColor = true;
            b_search_price.Click += b_search_price_Click;
            // 
            // b_start
            // 
            b_start.BackColor = SystemColors.GradientActiveCaption;
            b_start.FlatStyle = FlatStyle.Popup;
            b_start.Location = new Point(914, 21);
            b_start.Margin = new Padding(3, 4, 3, 4);
            b_start.Name = "b_start";
            b_start.Size = new Size(208, 31);
            b_start.TabIndex = 2;
            b_start.Text = "START";
            b_start.UseVisualStyleBackColor = false;
            b_start.Click += b_start_Click;
            // 
            // nom_width
            // 
            nom_width.Location = new Point(454, 8);
            nom_width.Margin = new Padding(3, 4, 3, 4);
            nom_width.Name = "nom_width";
            nom_width.Size = new Size(141, 27);
            nom_width.TabIndex = 3;
            // 
            // nom_height
            // 
            nom_height.Location = new Point(454, 56);
            nom_height.Margin = new Padding(3, 4, 3, 4);
            nom_height.Name = "nom_height";
            nom_height.Size = new Size(141, 27);
            nom_height.TabIndex = 4;
            // 
            // nom_formula_nst
            // 
            nom_formula_nst.Location = new Point(176, 5);
            nom_formula_nst.Margin = new Padding(3, 4, 3, 4);
            nom_formula_nst.Name = "nom_formula_nst";
            nom_formula_nst.Size = new Size(141, 27);
            nom_formula_nst.TabIndex = 5;
            // 
            // nom_formula_st
            // 
            nom_formula_st.Location = new Point(176, 53);
            nom_formula_st.Margin = new Padding(3, 4, 3, 4);
            nom_formula_st.Name = "nom_formula_st";
            nom_formula_st.Size = new Size(141, 27);
            nom_formula_st.TabIndex = 6;
            // 
            // price_listnum
            // 
            price_listnum.Location = new Point(176, 12);
            price_listnum.Margin = new Padding(3, 4, 3, 4);
            price_listnum.Name = "price_listnum";
            price_listnum.Size = new Size(141, 27);
            price_listnum.TabIndex = 7;
            // 
            // nom_listnum
            // 
            nom_listnum.Location = new Point(176, 52);
            nom_listnum.Margin = new Padding(3, 4, 3, 4);
            nom_listnum.Name = "nom_listnum";
            nom_listnum.Size = new Size(141, 27);
            nom_listnum.TabIndex = 8;
            // 
            // start_cell
            // 
            start_cell.Location = new Point(744, 8);
            start_cell.Margin = new Padding(3, 4, 3, 4);
            start_cell.Name = "start_cell";
            start_cell.Size = new Size(141, 27);
            start_cell.TabIndex = 9;
            // 
            // width_start
            // 
            width_start.Location = new Point(454, 9);
            width_start.Margin = new Padding(3, 4, 3, 4);
            width_start.Name = "width_start";
            width_start.Size = new Size(141, 27);
            width_start.TabIndex = 10;
            // 
            // width_end
            // 
            width_end.Location = new Point(454, 52);
            width_end.Margin = new Padding(3, 4, 3, 4);
            width_end.Name = "width_end";
            width_end.Size = new Size(141, 27);
            width_end.TabIndex = 11;
            // 
            // height_start
            // 
            height_start.Location = new Point(744, 9);
            height_start.Margin = new Padding(3, 4, 3, 4);
            height_start.Name = "height_start";
            height_start.Size = new Size(141, 27);
            height_start.TabIndex = 12;
            // 
            // height_end
            // 
            height_end.Location = new Point(744, 52);
            height_end.Margin = new Padding(3, 4, 3, 4);
            height_end.Name = "height_end";
            height_end.Size = new Size(141, 27);
            height_end.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 8);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 14;
            label1.Text = "Ширина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 59);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 15;
            label2.Text = "Высота";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 59);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 16;
            label3.Text = "Формула стандарт";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 11);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 17;
            label4.Text = "Формула не стандарт";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 58);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 18;
            label5.Text = "Лист номенклатуры";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 15);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 19;
            label6.Text = "Лист прайса";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 12);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 20;
            label7.Text = "Нач ширины";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(626, 15);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 21;
            label8.Text = "Нач высоты";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(332, 55);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 22;
            label9.Text = "Конец ширины";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(626, 58);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 23;
            label10.Text = "Конец высоты";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(626, 14);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 24;
            label11.Text = "Заполнение";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(914, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(151, 24);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Режим середины";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(nom_formula_nst);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nom_formula_st);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nom_height);
            panel1.Controls.Add(nom_width);
            panel1.Controls.Add(start_cell);
            panel1.Location = new Point(12, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 102);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(height_end);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(height_start);
            panel2.Controls.Add(price_listnum);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(nom_listnum);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(width_end);
            panel2.Controls.Add(width_start);
            panel2.Location = new Point(12, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 103);
            panel2.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 229);
            label12.Name = "label12";
            label12.Size = new Size(108, 20);
            label12.TabIndex = 31;
            label12.Text = "Номера ячеек";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 100);
            label13.Name = "label13";
            label13.Size = new Size(192, 20);
            label13.TabIndex = 32;
            label13.Text = "Целочисленные значения";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(914, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(208, 23);
            comboBox2.TabIndex = 34;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // save
            // 
            save.FlatStyle = FlatStyle.Popup;
            save.Location = new Point(914, 167);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(208, 31);
            save.TabIndex = 35;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // edit
            // 
            edit.FlatStyle = FlatStyle.Popup;
            edit.Location = new Point(914, 206);
            edit.Margin = new Padding(3, 4, 3, 4);
            edit.Name = "edit";
            edit.Size = new Size(208, 31);
            edit.TabIndex = 36;
            edit.Text = "Изменить";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.FlatStyle = FlatStyle.Popup;
            delete.Location = new Point(914, 245);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(208, 31);
            delete.TabIndex = 37;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.Location = new Point(149, 20);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(0, 20);
            label_nom.TabIndex = 39;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(149, 60);
            label_price.Name = "label_price";
            label_price.Size = new Size(0, 20);
            label_price.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Location = new Point(149, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(759, 70);
            panel3.TabIndex = 41;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(914, 323);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(208, 31);
            button1.TabIndex = 42;
            button1.Text = "Помощь";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 359);
            Controls.Add(button1);
            Controls.Add(label_price);
            Controls.Add(label_nom);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(save);
            Controls.Add(comboBox2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(checkBox1);
            Controls.Add(b_start);
            Controls.Add(b_search_price);
            Controls.Add(b_search_nom);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_search_nom;
        private Button b_search_price;
        private Button b_start;
        private TextBox nom_width;
        private TextBox nom_height;
        private TextBox nom_formula_nst;
        private TextBox nom_formula_st;
        private TextBox price_listnum;
        private TextBox nom_listnum;
        private TextBox start_cell;
        private TextBox width_start;
        private TextBox width_end;
        private TextBox height_start;
        private TextBox height_end;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label12;
        private Label label13;
        private ComboBox comboBox2;
        private Button save;
        private Button edit;
        private Button delete;
        private Label label_nom;
        private Label label_price;
        private Panel panel3;
        private Button button1;
    }
}
