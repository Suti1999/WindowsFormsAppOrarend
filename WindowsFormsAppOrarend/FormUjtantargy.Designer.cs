﻿namespace WindowsFormsAppOrarend
{
    partial class FormUjtantargy
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
            this.button_hozzaadas = new System.Windows.Forms.Button();
            this.radioButton_pentek = new System.Windows.Forms.RadioButton();
            this.radioButton_csutortok = new System.Windows.Forms.RadioButton();
            this.radioButton_szerda = new System.Windows.Forms.RadioButton();
            this.radioButton_kedd = new System.Windows.Forms.RadioButton();
            this.radioButton_hetfo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_sorszam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tantargynev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tanarnev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újTantárgyToolStripMenuItem_ujtantargy = new System.Windows.Forms.ToolStripMenuItem();
            this.tantargyTorlesToolStripMenuItem_torles = new System.Windows.Forms.ToolStripMenuItem();
            this.tantargyModositasToolStripMenuItem_modositas = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_hozzaadas
            // 
            this.button_hozzaadas.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hozzaadas.Location = new System.Drawing.Point(123, 224);
            this.button_hozzaadas.Name = "button_hozzaadas";
            this.button_hozzaadas.Size = new System.Drawing.Size(245, 40);
            this.button_hozzaadas.TabIndex = 26;
            this.button_hozzaadas.Text = "Tantárgy hozzáadás";
            this.button_hozzaadas.UseVisualStyleBackColor = true;
            // 
            // radioButton_pentek
            // 
            this.radioButton_pentek.AutoSize = true;
            this.radioButton_pentek.Location = new System.Drawing.Point(374, 168);
            this.radioButton_pentek.Name = "radioButton_pentek";
            this.radioButton_pentek.Size = new System.Drawing.Size(59, 17);
            this.radioButton_pentek.TabIndex = 25;
            this.radioButton_pentek.TabStop = true;
            this.radioButton_pentek.Text = "Péntek";
            this.radioButton_pentek.UseVisualStyleBackColor = true;
            // 
            // radioButton_csutortok
            // 
            this.radioButton_csutortok.AutoSize = true;
            this.radioButton_csutortok.Location = new System.Drawing.Point(298, 168);
            this.radioButton_csutortok.Name = "radioButton_csutortok";
            this.radioButton_csutortok.Size = new System.Drawing.Size(70, 17);
            this.radioButton_csutortok.TabIndex = 24;
            this.radioButton_csutortok.TabStop = true;
            this.radioButton_csutortok.Text = "Csütörtök";
            this.radioButton_csutortok.UseVisualStyleBackColor = true;
            // 
            // radioButton_szerda
            // 
            this.radioButton_szerda.AutoSize = true;
            this.radioButton_szerda.Location = new System.Drawing.Point(234, 168);
            this.radioButton_szerda.Name = "radioButton_szerda";
            this.radioButton_szerda.Size = new System.Drawing.Size(58, 17);
            this.radioButton_szerda.TabIndex = 23;
            this.radioButton_szerda.TabStop = true;
            this.radioButton_szerda.Text = "Szerda";
            this.radioButton_szerda.UseVisualStyleBackColor = true;
            // 
            // radioButton_kedd
            // 
            this.radioButton_kedd.AutoSize = true;
            this.radioButton_kedd.Location = new System.Drawing.Point(178, 168);
            this.radioButton_kedd.Name = "radioButton_kedd";
            this.radioButton_kedd.Size = new System.Drawing.Size(50, 17);
            this.radioButton_kedd.TabIndex = 22;
            this.radioButton_kedd.TabStop = true;
            this.radioButton_kedd.Text = "Kedd";
            this.radioButton_kedd.UseVisualStyleBackColor = true;
            // 
            // radioButton_hetfo
            // 
            this.radioButton_hetfo.AutoSize = true;
            this.radioButton_hetfo.Location = new System.Drawing.Point(123, 168);
            this.radioButton_hetfo.Name = "radioButton_hetfo";
            this.radioButton_hetfo.Size = new System.Drawing.Size(51, 17);
            this.radioButton_hetfo.TabIndex = 21;
            this.radioButton_hetfo.TabStop = true;
            this.radioButton_hetfo.Text = "Hétfő";
            this.radioButton_hetfo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hétnapja:";
            // 
            // numericUpDown_sorszam
            // 
            this.numericUpDown_sorszam.Location = new System.Drawing.Point(163, 134);
            this.numericUpDown_sorszam.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_sorszam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sorszam.Name = "numericUpDown_sorszam";
            this.numericUpDown_sorszam.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown_sorszam.TabIndex = 19;
            this.numericUpDown_sorszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_sorszam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tantárgy sorszám:";
            // 
            // textBox_tantargynev
            // 
            this.textBox_tantargynev.Location = new System.Drawing.Point(149, 96);
            this.textBox_tantargynev.Name = "textBox_tantargynev";
            this.textBox_tantargynev.Size = new System.Drawing.Size(100, 20);
            this.textBox_tantargynev.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tanár neve:";
            // 
            // textBox_tanarnev
            // 
            this.textBox_tanarnev.Location = new System.Drawing.Point(146, 55);
            this.textBox_tanarnev.Name = "textBox_tanarnev";
            this.textBox_tanarnev.Size = new System.Drawing.Size(103, 20);
            this.textBox_tanarnev.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tantárgy neve:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újTantárgyToolStripMenuItem_ujtantargy,
            this.tantargyTorlesToolStripMenuItem_torles,
            this.tantargyModositasToolStripMenuItem_modositas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 27;
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
            // FormUjtantargy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 293);
            this.Controls.Add(this.button_hozzaadas);
            this.Controls.Add(this.radioButton_pentek);
            this.Controls.Add(this.radioButton_csutortok);
            this.Controls.Add(this.radioButton_szerda);
            this.Controls.Add(this.radioButton_kedd);
            this.Controls.Add(this.radioButton_hetfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_sorszam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_tantargynev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_tanarnev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormUjtantargy";
            this.Text = "Újtantárgy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hozzaadas;
        private System.Windows.Forms.RadioButton radioButton_pentek;
        private System.Windows.Forms.RadioButton radioButton_csutortok;
        private System.Windows.Forms.RadioButton radioButton_szerda;
        private System.Windows.Forms.RadioButton radioButton_kedd;
        private System.Windows.Forms.RadioButton radioButton_hetfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_sorszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tantargynev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tanarnev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újTantárgyToolStripMenuItem_ujtantargy;
        private System.Windows.Forms.ToolStripMenuItem tantargyTorlesToolStripMenuItem_torles;
        private System.Windows.Forms.ToolStripMenuItem tantargyModositasToolStripMenuItem_modositas;
    }
}