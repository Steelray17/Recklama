namespace Recklama
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenOrg = new System.Windows.Forms.Button();
            this.buttonOpenGazeta = new System.Windows.Forms.Button();
            this.buttonOpenRek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenOrg
            // 
            this.buttonOpenOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonOpenOrg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenOrg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenOrg.Location = new System.Drawing.Point(397, 12);
            this.buttonOpenOrg.Name = "buttonOpenOrg";
            this.buttonOpenOrg.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenOrg.TabIndex = 1;
            this.buttonOpenOrg.Text = "Организация";
            this.buttonOpenOrg.UseVisualStyleBackColor = false;
            this.buttonOpenOrg.Click += new System.EventHandler(this.buttonOpenOrg_Click);
            // 
            // buttonOpenGazeta
            // 
            this.buttonOpenGazeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonOpenGazeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenGazeta.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonOpenGazeta.Location = new System.Drawing.Point(397, 66);
            this.buttonOpenGazeta.Name = "buttonOpenGazeta";
            this.buttonOpenGazeta.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenGazeta.TabIndex = 2;
            this.buttonOpenGazeta.Text = "Газета";
            this.buttonOpenGazeta.UseVisualStyleBackColor = false;
            this.buttonOpenGazeta.Click += new System.EventHandler(this.buttonOpenGazeta_Click);
            // 
            // buttonOpenRek
            // 
            this.buttonOpenRek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonOpenRek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenRek.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonOpenRek.Location = new System.Drawing.Point(397, 120);
            this.buttonOpenRek.Name = "buttonOpenRek";
            this.buttonOpenRek.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenRek.TabIndex = 3;
            this.buttonOpenRek.Text = "Реклама";
            this.buttonOpenRek.UseVisualStyleBackColor = false;
            this.buttonOpenRek.Click += new System.EventHandler(this.buttonOpenRek_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(655, 171);
            this.Controls.Add(this.buttonOpenRek);
            this.Controls.Add(this.buttonOpenGazeta);
            this.Controls.Add(this.buttonOpenOrg);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание рекламы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenOrg;
        private System.Windows.Forms.Button buttonOpenGazeta;
        private System.Windows.Forms.Button buttonOpenRek;
    }
}

