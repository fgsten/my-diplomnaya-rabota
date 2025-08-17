namespace диплом
{
    partial class EditTovar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTovar));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_KuC2 = new System.Windows.Forms.TextBox();
            this.textBox_Tip2 = new System.Windows.Forms.TextBox();
            this.textBox_Name2 = new System.Windows.Forms.TextBox();
            this.comboBox_Pos2 = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klevyy_ZanaDataSet2 = new диплом.Klevyy_ZanaDataSet2();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Roz2 = new System.Windows.Forms.TextBox();
            this.textBox_mar2 = new System.Windows.Forms.TextBox();
            this.textBox_Sum2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.providerTableAdapter = new диплом.Klevyy_ZanaDataSet2TableAdapters.ProviderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klevyy_ZanaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(622, 154);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BackButton.Location = new System.Drawing.Point(13, 285);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(76, 27);
            this.BackButton.TabIndex = 35;
            this.BackButton.Text = "Назад ";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(300, 249);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 36);
            this.SaveButton.TabIndex = 34;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(153, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 67);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавления товара";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(449, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Количество на складе:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(84, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Типы товара:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Наименование товара:";
            // 
            // textBox_KuC2
            // 
            this.textBox_KuC2.Location = new System.Drawing.Point(199, 180);
            this.textBox_KuC2.Multiline = true;
            this.textBox_KuC2.Name = "textBox_KuC2";
            this.textBox_KuC2.Size = new System.Drawing.Size(122, 20);
            this.textBox_KuC2.TabIndex = 40;
            // 
            // textBox_Tip2
            // 
            this.textBox_Tip2.Location = new System.Drawing.Point(199, 154);
            this.textBox_Tip2.Name = "textBox_Tip2";
            this.textBox_Tip2.Size = new System.Drawing.Size(122, 20);
            this.textBox_Tip2.TabIndex = 39;
            // 
            // textBox_Name2
            // 
            this.textBox_Name2.Location = new System.Drawing.Point(199, 128);
            this.textBox_Name2.Name = "textBox_Name2";
            this.textBox_Name2.Size = new System.Drawing.Size(122, 20);
            this.textBox_Name2.TabIndex = 38;
            // 
            // comboBox_Pos2
            // 
            this.comboBox_Pos2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providerBindingSource, "Name", true));
            this.comboBox_Pos2.DataSource = this.providerBindingSource;
            this.comboBox_Pos2.DisplayMember = "Name";
            this.comboBox_Pos2.FormattingEnabled = true;
            this.comboBox_Pos2.Location = new System.Drawing.Point(199, 208);
            this.comboBox_Pos2.Name = "comboBox_Pos2";
            this.comboBox_Pos2.Size = new System.Drawing.Size(122, 21);
            this.comboBox_Pos2.TabIndex = 53;
            this.comboBox_Pos2.ValueMember = "Name";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.klevyy_ZanaDataSet2;
            // 
            // klevyy_ZanaDataSet2
            // 
            this.klevyy_ZanaDataSet2.DataSetName = "Klevyy_ZanaDataSet2";
            this.klevyy_ZanaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(94, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Поставщик:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(332, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Розничная сумма:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(331, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Процент наценки:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(329, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Приходная сумма:";
            // 
            // textBox_Roz2
            // 
            this.textBox_Roz2.Location = new System.Drawing.Point(482, 181);
            this.textBox_Roz2.Multiline = true;
            this.textBox_Roz2.Name = "textBox_Roz2";
            this.textBox_Roz2.Size = new System.Drawing.Size(122, 19);
            this.textBox_Roz2.TabIndex = 47;
            // 
            // textBox_mar2
            // 
            this.textBox_mar2.Location = new System.Drawing.Point(482, 155);
            this.textBox_mar2.Multiline = true;
            this.textBox_mar2.Name = "textBox_mar2";
            this.textBox_mar2.Size = new System.Drawing.Size(122, 20);
            this.textBox_mar2.TabIndex = 46;
            // 
            // textBox_Sum2
            // 
            this.textBox_Sum2.Location = new System.Drawing.Point(482, 129);
            this.textBox_Sum2.Multiline = true;
            this.textBox_Sum2.Name = "textBox_Sum2";
            this.textBox_Sum2.Size = new System.Drawing.Size(122, 20);
            this.textBox_Sum2.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // EditTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(688, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_Pos2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_Roz2);
            this.Controls.Add(this.textBox_mar2);
            this.Controls.Add(this.textBox_Sum2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_KuC2);
            this.Controls.Add(this.textBox_Tip2);
            this.Controls.Add(this.textBox_Name2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(704, 359);
            this.MinimumSize = new System.Drawing.Size(704, 359);
            this.Name = "EditTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.EditTovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klevyy_ZanaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_KuC2;
        private System.Windows.Forms.TextBox textBox_Tip2;
        private System.Windows.Forms.TextBox textBox_Name2;
        private System.Windows.Forms.ComboBox comboBox_Pos2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Roz2;
        private System.Windows.Forms.TextBox textBox_mar2;
        private System.Windows.Forms.TextBox textBox_Sum2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Klevyy_ZanaDataSet2 klevyy_ZanaDataSet2;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private Klevyy_ZanaDataSet2TableAdapters.ProviderTableAdapter providerTableAdapter;
    }
}