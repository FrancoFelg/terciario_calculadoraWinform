namespace App1Mensajeria
{
    partial class Home
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
            btnSubmit = new System.Windows.Forms.Button();
            txtIP = new System.Windows.Forms.TextBox();
            txtPuerto = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iPsActualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(670, 57);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(118, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Conectar";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new System.Drawing.Point(12, 57);
            txtIP.Name = "txtIP";
            txtIP.Size = new System.Drawing.Size(425, 23);
            txtIP.TabIndex = 1;
            txtIP.TextChanged += txtIP_TextChanged;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new System.Drawing.Point(443, 58);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new System.Drawing.Size(221, 23);
            txtPuerto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Escribir IP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(443, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Escribir Puerto";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { inicioToolStripMenuItem, iPsActualesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // iPsActualesToolStripMenuItem
            // 
            iPsActualesToolStripMenuItem.Name = "iPsActualesToolStripMenuItem";
            iPsActualesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            iPsActualesToolStripMenuItem.Text = "IPs Actuales";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPuerto);
            Controls.Add(txtIP);
            Controls.Add(btnSubmit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPsActualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}