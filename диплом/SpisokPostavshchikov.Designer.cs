namespace диплом
{
    partial class SpisokPostavshchikov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpisokPostavshchikov));
            this.dataGridView_Postavshc = new System.Windows.Forms.DataGridView();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klevyy_Provider = new диплом.Klevyy_Provider();
            this.providerTableAdapter = new диплом.Klevyy_ProviderTableAdapters.ProviderTableAdapter();
            this.textBox_poisk = new System.Windows.Forms.TextBox();
            this.find_Iabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.GroupBoxControlPanel = new System.Windows.Forms.GroupBox();
            this.DelButton_P = new System.Windows.Forms.Button();
            this.SaveButton_P = new System.Windows.Forms.Button();
            this.EditButton_P = new System.Windows.Forms.Button();
            this.AddButton_P = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdatepictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрграммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tlsUserStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Postavshc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klevyy_Provider)).BeginInit();
            this.GroupBoxControlPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatepictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Postavshc
            // 
            this.dataGridView_Postavshc.AllowUserToAddRows = false;
            this.dataGridView_Postavshc.AllowUserToDeleteRows = false;
            this.dataGridView_Postavshc.AllowUserToResizeColumns = false;
            this.dataGridView_Postavshc.AllowUserToResizeRows = false;
            this.dataGridView_Postavshc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Postavshc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Postavshc.Location = new System.Drawing.Point(12, 92);
            this.dataGridView_Postavshc.Name = "dataGridView_Postavshc";
            this.dataGridView_Postavshc.Size = new System.Drawing.Size(829, 185);
            this.dataGridView_Postavshc.TabIndex = 0;
            this.dataGridView_Postavshc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Postavshc_CellClick);
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.klevyy_Provider;
            // 
            // klevyy_Provider
            // 
            this.klevyy_Provider.DataSetName = "Klevyy_Provider";
            this.klevyy_Provider.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_poisk
            // 
            this.textBox_poisk.Location = new System.Drawing.Point(74, 63);
            this.textBox_poisk.Name = "textBox_poisk";
            this.textBox_poisk.Size = new System.Drawing.Size(263, 20);
            this.textBox_poisk.TabIndex = 2;
            this.textBox_poisk.TextChanged += new System.EventHandler(this.textBox_poisk_TextChanged);
            // 
            // find_Iabel
            // 
            this.find_Iabel.AutoSize = true;
            this.find_Iabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.find_Iabel.Location = new System.Drawing.Point(71, 42);
            this.find_Iabel.Name = "find_Iabel";
            this.find_Iabel.Size = new System.Drawing.Size(357, 18);
            this.find_Iabel.TabIndex = 10;
            this.find_Iabel.Text = "Найти поставщика  по наименование организации";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BackButton.Location = new System.Drawing.Point(18, 505);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(76, 27);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Назад ";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // GroupBoxControlPanel
            // 
            this.GroupBoxControlPanel.Controls.Add(this.DelButton_P);
            this.GroupBoxControlPanel.Controls.Add(this.SaveButton_P);
            this.GroupBoxControlPanel.Controls.Add(this.EditButton_P);
            this.GroupBoxControlPanel.Controls.Add(this.AddButton_P);
            this.GroupBoxControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxControlPanel.Location = new System.Drawing.Point(12, 295);
            this.GroupBoxControlPanel.Name = "GroupBoxControlPanel";
            this.GroupBoxControlPanel.Size = new System.Drawing.Size(336, 204);
            this.GroupBoxControlPanel.TabIndex = 19;
            this.GroupBoxControlPanel.TabStop = false;
            this.GroupBoxControlPanel.Text = "Панель управления поставщиков ";
            // 
            // DelButton_P
            // 
            this.DelButton_P.BackColor = System.Drawing.Color.Red;
            this.DelButton_P.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DelButton_P.Location = new System.Drawing.Point(6, 114);
            this.DelButton_P.Name = "DelButton_P";
            this.DelButton_P.Size = new System.Drawing.Size(300, 37);
            this.DelButton_P.TabIndex = 3;
            this.DelButton_P.Text = "Удалить поставщика";
            this.DelButton_P.UseVisualStyleBackColor = false;
            this.DelButton_P.Click += new System.EventHandler(this.DelButton_P_Click);
            // 
            // SaveButton_P
            // 
            this.SaveButton_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveButton_P.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton_P.Location = new System.Drawing.Point(6, 157);
            this.SaveButton_P.Name = "SaveButton_P";
            this.SaveButton_P.Size = new System.Drawing.Size(300, 37);
            this.SaveButton_P.TabIndex = 2;
            this.SaveButton_P.Text = "Сохранить ";
            this.SaveButton_P.UseVisualStyleBackColor = false;
            this.SaveButton_P.Click += new System.EventHandler(this.SaveButton_P_Click);
            // 
            // EditButton_P
            // 
            this.EditButton_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditButton_P.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditButton_P.Location = new System.Drawing.Point(6, 71);
            this.EditButton_P.Name = "EditButton_P";
            this.EditButton_P.Size = new System.Drawing.Size(300, 37);
            this.EditButton_P.TabIndex = 1;
            this.EditButton_P.Text = "Изменить поставщика";
            this.EditButton_P.UseVisualStyleBackColor = false;
            this.EditButton_P.Click += new System.EventHandler(this.EditButton_P_Click);
            // 
            // AddButton_P
            // 
            this.AddButton_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddButton_P.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton_P.Location = new System.Drawing.Point(6, 30);
            this.AddButton_P.Name = "AddButton_P";
            this.AddButton_P.Size = new System.Drawing.Size(300, 37);
            this.AddButton_P.TabIndex = 0;
            this.AddButton_P.Text = "Добавить поставщика ";
            this.AddButton_P.UseVisualStyleBackColor = false;
            this.AddButton_P.Click += new System.EventHandler(this.AddButton_P_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_Number);
            this.groupBox2.Controls.Add(this.textBox_City);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Controls.Add(this.textBox_id);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(376, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 194);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запись поставщика:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Город:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование организации:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(314, 141);
            this.textBox_Number.Multiline = true;
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(151, 29);
            this.textBox_Number.TabIndex = 3;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(314, 106);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(151, 29);
            this.textBox_City.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(314, 66);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(151, 29);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(314, 28);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(151, 29);
            this.textBox_id.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // UpdatepictureBox
            // 
            this.UpdatepictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdatepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UpdatepictureBox.Image")));
            this.UpdatepictureBox.Location = new System.Drawing.Point(492, 40);
            this.UpdatepictureBox.Name = "UpdatepictureBox";
            this.UpdatepictureBox.Size = new System.Drawing.Size(53, 46);
            this.UpdatepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdatepictureBox.TabIndex = 22;
            this.UpdatepictureBox.TabStop = false;
            this.UpdatepictureBox.Click += new System.EventHandler(this.UpdatepictureBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрграммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрграммеToolStripMenuItem
            // 
            this.оПрграммеToolStripMenuItem.Name = "оПрграммеToolStripMenuItem";
            this.оПрграммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрграммеToolStripMenuItem.Text = "О программе";
            this.оПрграммеToolStripMenuItem.Click += new System.EventHandler(this.оПрграммеToolStripMenuItem_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(434, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.ClearpictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(774, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // tlsUserStatus
            // 
            this.tlsUserStatus.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tlsUserStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlsUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlsUserStatus.Location = new System.Drawing.Point(623, 1);
            this.tlsUserStatus.Multiline = true;
            this.tlsUserStatus.Name = "tlsUserStatus";
            this.tlsUserStatus.Size = new System.Drawing.Size(216, 23);
            this.tlsUserStatus.TabIndex = 26;
            this.tlsUserStatus.Text = "User";
            this.tlsUserStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SpisokPostavshchikov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(852, 537);
            this.Controls.Add(this.tlsUserStatus);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.UpdatepictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBoxControlPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.find_Iabel);
            this.Controls.Add(this.textBox_poisk);
            this.Controls.Add(this.dataGridView_Postavshc);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(868, 576);
            this.MinimumSize = new System.Drawing.Size(868, 576);
            this.Name = "SpisokPostavshchikov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список поставщиков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorProvider_FormClosing);
            this.Load += new System.EventHandler(this.EditorProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Postavshc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klevyy_Provider)).EndInit();
            this.GroupBoxControlPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatepictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Postavshc;
        private Klevyy_Provider klevyy_Provider;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private Klevyy_ProviderTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.TextBox textBox_poisk;
        private System.Windows.Forms.Label find_Iabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox GroupBoxControlPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DelButton_P;
        private System.Windows.Forms.Button SaveButton_P;
        private System.Windows.Forms.Button EditButton_P;
        private System.Windows.Forms.Button AddButton_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox UpdatepictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tlsUserStatus;
        private System.Windows.Forms.ToolStripMenuItem оПрграммеToolStripMenuItem;
    }
}