namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.turnOn = new System.Windows.Forms.Button();
            this.turnOff = new System.Windows.Forms.Button();
            this.trackLuminosite = new System.Windows.Forms.TrackBar();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackLuminosite)).BeginInit();
            this.SuspendLayout();
            // 
            // turnOn
            // 
            this.turnOn.Location = new System.Drawing.Point(24, 22);
            this.turnOn.Name = "turnOn";
            this.turnOn.Size = new System.Drawing.Size(89, 59);
            this.turnOn.TabIndex = 0;
            this.turnOn.Text = "Allumer";
            this.turnOn.UseVisualStyleBackColor = true;
            this.turnOn.Click += new System.EventHandler(this.turnOn_Click);
            // 
            // turnOff
            // 
            this.turnOff.Location = new System.Drawing.Point(153, 22);
            this.turnOff.Name = "turnOff";
            this.turnOff.Size = new System.Drawing.Size(89, 59);
            this.turnOff.TabIndex = 1;
            this.turnOff.Text = "Eteindre";
            this.turnOff.UseVisualStyleBackColor = true;
            this.turnOff.Click += new System.EventHandler(this.turnOff_Click);
            // 
            // trackLuminosite
            // 
            this.trackLuminosite.LargeChange = 20;
            this.trackLuminosite.Location = new System.Drawing.Point(275, 32);
            this.trackLuminosite.Maximum = 255;
            this.trackLuminosite.Name = "trackLuminosite";
            this.trackLuminosite.Size = new System.Drawing.Size(205, 69);
            this.trackLuminosite.SmallChange = 5;
            this.trackLuminosite.TabIndex = 2;
            this.trackLuminosite.Value = 255;
            this.trackLuminosite.Scroll += new System.EventHandler(this.trackLuminosite_Scroll);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(505, 22);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(89, 59);
            this.button_Apply.TabIndex = 3;
            this.button_Apply.Text = "Appliquer";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Luminosité";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 110);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.trackLuminosite);
            this.Controls.Add(this.turnOff);
            this.Controls.Add(this.turnOn);
            this.Name = "Form1";
            this.Text = "Application personnel - ESP32";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackLuminosite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnOn;
        private System.Windows.Forms.Button turnOff;
        private System.Windows.Forms.TrackBar trackLuminosite;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Label label1;
    }
}

