namespace Recklama
{
    partial class FormRecklama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecklama));
            this.comboBoxGaz = new System.Windows.Forms.ComboBox();
            this.comboBoxOrg = new System.Windows.Forms.ComboBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelOrg = new System.Windows.Forms.Label();
            this.labelGaz = new System.Windows.Forms.Label();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.listViewGazeta = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGaz
            // 
            this.comboBoxGaz.Font = new System.Drawing.Font("Calibri", 11F);
            this.comboBoxGaz.FormattingEnabled = true;
            this.comboBoxGaz.Location = new System.Drawing.Point(15, 80);
            this.comboBoxGaz.Name = "comboBoxGaz";
            this.comboBoxGaz.Size = new System.Drawing.Size(185, 26);
            this.comboBoxGaz.TabIndex = 0;
            // 
            // comboBoxOrg
            // 
            this.comboBoxOrg.Font = new System.Drawing.Font("Calibri", 11F);
            this.comboBoxOrg.FormattingEnabled = true;
            this.comboBoxOrg.Location = new System.Drawing.Point(15, 30);
            this.comboBoxOrg.Name = "comboBoxOrg";
            this.comboBoxOrg.Size = new System.Drawing.Size(185, 26);
            this.comboBoxOrg.TabIndex = 1;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelNumber.Location = new System.Drawing.Point(252, 9);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(96, 18);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер газеты";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelVolume.Location = new System.Drawing.Point(252, 59);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(113, 18);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Объём рекламы";
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelOrg.Location = new System.Drawing.Point(12, 9);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(90, 18);
            this.labelOrg.TabIndex = 4;
            this.labelOrg.Text = "Организация";
            // 
            // labelGaz
            // 
            this.labelGaz.AutoSize = true;
            this.labelGaz.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelGaz.Location = new System.Drawing.Point(12, 59);
            this.labelGaz.Name = "labelGaz";
            this.labelGaz.Size = new System.Drawing.Size(47, 18);
            this.labelGaz.TabIndex = 5;
            this.labelGaz.Text = "Газета";
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxVolume.Location = new System.Drawing.Point(255, 80);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(185, 25);
            this.textBoxVolume.TabIndex = 7;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxNumber.Location = new System.Drawing.Point(255, 31);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(185, 25);
            this.textBoxNumber.TabIndex = 8;
            // 
            // listViewGazeta
            // 
            this.listViewGazeta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.listViewGazeta.Font = new System.Drawing.Font("Calibri", 12F);
            this.listViewGazeta.FullRowSelect = true;
            this.listViewGazeta.GridLines = true;
            this.listViewGazeta.HideSelection = false;
            this.listViewGazeta.Location = new System.Drawing.Point(15, 123);
            this.listViewGazeta.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.listViewGazeta.Name = "listViewGazeta";
            this.listViewGazeta.Size = new System.Drawing.Size(587, 189);
            this.listViewGazeta.TabIndex = 13;
            this.listViewGazeta.UseCompatibleStateImageBehavior = false;
            this.listViewGazeta.View = System.Windows.Forms.View.Details;
            this.listViewGazeta.SelectedIndexChanged += new System.EventHandler(this.listViewGazeta_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Название организации";
            this.columnHeader10.Width = 127;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Название газеты";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер газеты";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Объём рекламы";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена рекламы";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonDel.Location = new System.Drawing.Point(485, 314);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(117, 36);
            this.buttonDel.TabIndex = 31;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(361, 314);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(238, 314);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormRecklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(605, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewGazeta);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.labelGaz);
            this.Controls.Add(this.labelOrg);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.comboBoxOrg);
            this.Controls.Add(this.comboBoxGaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRecklama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реклама";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGaz;
        private System.Windows.Forms.ComboBox comboBoxOrg;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.Label labelGaz;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ListView listViewGazeta;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}