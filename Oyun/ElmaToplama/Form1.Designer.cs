namespace ElmaToplama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctElma = new System.Windows.Forms.PictureBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctElma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ElmaToplama.Properties.Resources.running_man_icon_0;
            this.pictureBox1.Location = new System.Drawing.Point(12, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pctElma
            // 
            this.pctElma.BackColor = System.Drawing.Color.Transparent;
            this.pctElma.Image = global::ElmaToplama.Properties.Resources.apple_icon;
            this.pctElma.Location = new System.Drawing.Point(490, 242);
            this.pctElma.Name = "pctElma";
            this.pctElma.Size = new System.Drawing.Size(50, 40);
            this.pctElma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctElma.TabIndex = 2;
            this.pctElma.TabStop = false;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.Black;
            this.lblSure.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSure.Location = new System.Drawing.Point(636, 9);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 31);
            this.lblSure.TabIndex = 3;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.BackColor = System.Drawing.Color.Black;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSayac.Location = new System.Drawing.Point(636, 41);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 31);
            this.lblSayac.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.White;
            this.btnBasla.BackgroundImage = global::ElmaToplama.Properties.Resources._41125_200;
            this.btnBasla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBasla.Location = new System.Drawing.Point(226, 403);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(55, 45);
            this.btnBasla.TabIndex = 5;
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.White;
            this.btnCik.BackgroundImage = global::ElmaToplama.Properties.Resources.close_1_512;
            this.btnCik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCik.Location = new System.Drawing.Point(323, 403);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(55, 46);
            this.btnCik.TabIndex = 6;
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElmaToplama.Properties.Resources.depositphotos_92508558_stock_photo_green_lawn_grass_background_texture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.pctElma);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pick Apple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctElma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctElma;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnCik;
    }
}

