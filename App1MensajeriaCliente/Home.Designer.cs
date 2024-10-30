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
            panel1 = new System.Windows.Forms.Panel();
            txtUsernameNew = new System.Windows.Forms.TextBox();
            txtIpNew = new System.Windows.Forms.TextBox();
            txtPortNew = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnNew = new System.Windows.Forms.Button();
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
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(12, 347);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(776, 91);
            panel1.TabIndex = 6;
            // 
            // txtUsernameNew
            // 
            txtUsernameNew.Location = new System.Drawing.Point(12, 177);
            txtUsernameNew.Name = "txtUsernameNew";
            txtUsernameNew.Size = new System.Drawing.Size(425, 23);
            txtUsernameNew.TabIndex = 7;
            // 
            // txtIpNew
            // 
            txtIpNew.Location = new System.Drawing.Point(12, 228);
            txtIpNew.Name = "txtIpNew";
            txtIpNew.Size = new System.Drawing.Size(305, 23);
            txtIpNew.TabIndex = 8;
            // 
            // txtPortNew
            // 
            txtPortNew.Location = new System.Drawing.Point(323, 228);
            txtPortNew.Name = "txtPortNew";
            txtPortNew.Size = new System.Drawing.Size(114, 23);
            txtPortNew.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre de usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 210);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(20, 15);
            label4.TabIndex = 11;
            label4.Text = "IP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(323, 210);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 12;
            label5.Text = "Puerto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 134);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 15);
            label6.TabIndex = 13;
            label6.Text = "Añadir amigo:";
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(362, 269);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(75, 23);
            btnNew.TabIndex = 14;
            btnNew.Text = "Guardar";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnNew);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPortNew);
            Controls.Add(txtIpNew);
            Controls.Add(txtUsernameNew);
            Controls.Add(panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsernameNew;
        private System.Windows.Forms.TextBox txtIpNew;
        private System.Windows.Forms.TextBox txtPortNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
    }
}