namespace WindowsFormsAppOrarend
{
    partial class FormOrarend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrarend));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újTantárgyToolStripMenuItem_ujtantargy = new System.Windows.Forms.ToolStripMenuItem();
            this.tantargyTorlesToolStripMenuItem_torles = new System.Windows.Forms.ToolStripMenuItem();
            this.tantargyModositasToolStripMenuItem_modositas = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_orarend = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tanarnev = new System.Windows.Forms.TextBox();
            this.button_lekerdezes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tanarszak = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újTantárgyToolStripMenuItem_ujtantargy,
            this.tantargyTorlesToolStripMenuItem_torles,
            this.tantargyModositasToolStripMenuItem_modositas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újTantárgyToolStripMenuItem_ujtantargy
            // 
            this.újTantárgyToolStripMenuItem_ujtantargy.Name = "újTantárgyToolStripMenuItem_ujtantargy";
            this.újTantárgyToolStripMenuItem_ujtantargy.Size = new System.Drawing.Size(74, 20);
            this.újTantárgyToolStripMenuItem_ujtantargy.Text = "Újtantárgy";
            // 
            // tantargyTorlesToolStripMenuItem_torles
            // 
            this.tantargyTorlesToolStripMenuItem_torles.Name = "tantargyTorlesToolStripMenuItem_torles";
            this.tantargyTorlesToolStripMenuItem_torles.Size = new System.Drawing.Size(96, 20);
            this.tantargyTorlesToolStripMenuItem_torles.Text = "Tantárgy törlés";
            // 
            // tantargyModositasToolStripMenuItem_modositas
            // 
            this.tantargyModositasToolStripMenuItem_modositas.Name = "tantargyModositasToolStripMenuItem_modositas";
            this.tantargyModositasToolStripMenuItem_modositas.Size = new System.Drawing.Size(122, 20);
            this.tantargyModositasToolStripMenuItem_modositas.Text = "Tantárgy módosítás";
            // 
            // listBox_orarend
            // 
            this.listBox_orarend.FormattingEnabled = true;
            this.listBox_orarend.Location = new System.Drawing.Point(12, 37);
            this.listBox_orarend.Name = "listBox_orarend";
            this.listBox_orarend.Size = new System.Drawing.Size(167, 225);
            this.listBox_orarend.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tanár neve:";
            // 
            // textBox_tanarnev
            // 
            this.textBox_tanarnev.Location = new System.Drawing.Point(272, 37);
            this.textBox_tanarnev.Name = "textBox_tanarnev";
            this.textBox_tanarnev.Size = new System.Drawing.Size(131, 20);
            this.textBox_tanarnev.TabIndex = 16;
            // 
            // button_lekerdezes
            // 
            this.button_lekerdezes.Location = new System.Drawing.Point(203, 116);
            this.button_lekerdezes.Name = "button_lekerdezes";
            this.button_lekerdezes.Size = new System.Drawing.Size(200, 146);
            this.button_lekerdezes.TabIndex = 17;
            this.button_lekerdezes.Text = "LEKÉRDEZÉS";
            this.button_lekerdezes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tanár szak:";
            // 
            // textBox_tanarszak
            // 
            this.textBox_tanarszak.Location = new System.Drawing.Point(272, 80);
            this.textBox_tanarszak.Name = "textBox_tanarszak";
            this.textBox_tanarszak.Size = new System.Drawing.Size(131, 20);
            this.textBox_tanarszak.TabIndex = 19;
            // 
            // FormOrarend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 288);
            this.Controls.Add(this.textBox_tanarszak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_lekerdezes);
            this.Controls.Add(this.textBox_tanarnev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_orarend);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrarend";
            this.Text = "Órarend";
            this.Load += new System.EventHandler(this.FormOrarend_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újTantárgyToolStripMenuItem_ujtantargy;
        private System.Windows.Forms.ToolStripMenuItem tantargyTorlesToolStripMenuItem_torles;
        private System.Windows.Forms.ToolStripMenuItem tantargyModositasToolStripMenuItem_modositas;
        private System.Windows.Forms.ListBox listBox_orarend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tanarnev;
        private System.Windows.Forms.Button button_lekerdezes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tanarszak;
    }
}