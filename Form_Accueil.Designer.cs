using System.Windows.Forms;

namespace LightControlWifi
{
    partial class Form_Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Accueil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageOn = new System.Windows.Forms.PictureBox();
            this.imageOff = new System.Windows.Forms.PictureBox();
            this.bAllume = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.track_puissanceEclairage = new System.Windows.Forms.TrackBar();
            this.bEteindre = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bAppliquer = new System.Windows.Forms.Button();
            this.comboBox_projecteurs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_puissanceEclairage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(518, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // imageOn
            // 
            this.imageOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageOn.BackgroundImage")));
            this.imageOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageOn.Location = new System.Drawing.Point(218, 210);
            this.imageOn.Margin = new System.Windows.Forms.Padding(2);
            this.imageOn.Name = "imageOn";
            this.imageOn.Size = new System.Drawing.Size(62, 55);
            this.imageOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOn.TabIndex = 20;
            this.imageOn.TabStop = false;
            // 
            // imageOff
            // 
            this.imageOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageOff.BackgroundImage")));
            this.imageOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageOff.Location = new System.Drawing.Point(37, 210);
            this.imageOff.Margin = new System.Windows.Forms.Padding(2);
            this.imageOff.Name = "imageOff";
            this.imageOff.Size = new System.Drawing.Size(60, 52);
            this.imageOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOff.TabIndex = 19;
            this.imageOff.TabStop = false;
            // 
            // bAllume
            // 
            this.bAllume.BackColor = System.Drawing.Color.White;
            this.bAllume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAllume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAllume.FlatAppearance.BorderSize = 3;
            this.bAllume.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bAllume.Location = new System.Drawing.Point(359, 156);
            this.bAllume.Margin = new System.Windows.Forms.Padding(2);
            this.bAllume.Name = "bAllume";
            this.bAllume.Size = new System.Drawing.Size(227, 62);
            this.bAllume.TabIndex = 18;
            this.bAllume.Text = "Allumer         ";
            this.bAllume.UseVisualStyleBackColor = false;
            this.bAllume.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "Projecteurs par Wifi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Puissance éclairage";
            // 
            // track_puissanceEclairage
            // 
            this.track_puissanceEclairage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.track_puissanceEclairage.Location = new System.Drawing.Point(101, 220);
            this.track_puissanceEclairage.Margin = new System.Windows.Forms.Padding(2);
            this.track_puissanceEclairage.Maximum = 255;
            this.track_puissanceEclairage.Name = "track_puissanceEclairage";
            this.track_puissanceEclairage.Size = new System.Drawing.Size(113, 45);
            this.track_puissanceEclairage.TabIndex = 15;
            this.track_puissanceEclairage.Scroll += new System.EventHandler(this.track_puissanceEclairage_Scroll);
            // 
            // bEteindre
            // 
            this.bEteindre.BackColor = System.Drawing.Color.Gray;
            this.bEteindre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEteindre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEteindre.FlatAppearance.BorderSize = 3;
            this.bEteindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bEteindre.Location = new System.Drawing.Point(359, 237);
            this.bEteindre.Margin = new System.Windows.Forms.Padding(2);
            this.bEteindre.Name = "bEteindre";
            this.bEteindre.Size = new System.Drawing.Size(227, 62);
            this.bEteindre.TabIndex = 22;
            this.bEteindre.Text = "Eteindre         ";
            this.bEteindre.UseVisualStyleBackColor = false;
            this.bEteindre.Click += new System.EventHandler(this.bEteindre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(527, 247);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // bAppliquer
            // 
            this.bAppliquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAppliquer.Location = new System.Drawing.Point(111, 270);
            this.bAppliquer.Name = "bAppliquer";
            this.bAppliquer.Size = new System.Drawing.Size(103, 29);
            this.bAppliquer.TabIndex = 24;
            this.bAppliquer.Text = "Appliquer";
            this.bAppliquer.UseVisualStyleBackColor = true;
            this.bAppliquer.Click += new System.EventHandler(this.bAppliquer_Click);
            // 
            // comboBox_projecteurs
            // 
            this.comboBox_projecteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboBox_projecteurs.FormattingEnabled = true;
            this.comboBox_projecteurs.Location = new System.Drawing.Point(200, 93);
            this.comboBox_projecteurs.Name = "comboBox_projecteurs";
            this.comboBox_projecteurs.Size = new System.Drawing.Size(246, 33);
            this.comboBox_projecteurs.TabIndex = 25;
            this.comboBox_projecteurs.SelectedIndexChanged += new System.EventHandler(this.comboBox_projecteurs_SelectedIndexChanged);
            // 
            // Form_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(625, 342);
            this.Controls.Add(this.comboBox_projecteurs);
            this.Controls.Add(this.bAppliquer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bEteindre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageOn);
            this.Controls.Add(this.imageOff);
            this.Controls.Add(this.bAllume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_puissanceEclairage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application de pilotage - Carte ESP32 (WIFI)";
            this.Load += new System.EventHandler(this.Form_Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_puissanceEclairage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox imageOn;
        private PictureBox imageOff;
        private Button bAllume;
        private Label label2;
        private Label label1;
        private TrackBar track_puissanceEclairage;
        private Button bEteindre;
        private PictureBox pictureBox2;
        private Button bAppliquer;
        private ComboBox comboBox_projecteurs;
    }
}