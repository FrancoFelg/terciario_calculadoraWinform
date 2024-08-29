namespace Proyecto_FFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            inpNumb1 = new System.Windows.Forms.TextBox();
            inpNumb2 = new System.Windows.Forms.TextBox();
            txtResult = new System.Windows.Forms.Label();
            txtResultNumber = new System.Windows.Forms.Label();
            btnExecute = new System.Windows.Forms.Button();
            radioBtnSuma = new System.Windows.Forms.RadioButton();
            radioBtnResta = new System.Windows.Forms.RadioButton();
            radioBtnMult = new System.Windows.Forms.RadioButton();
            radioBtnDiv = new System.Windows.Forms.RadioButton();
            txtError = new System.Windows.Forms.Label();
            btnBorrar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero2";
            label2.Click += label2_Click;
            // 
            // inpNumb1
            // 
            inpNumb1.Location = new System.Drawing.Point(88, 47);
            inpNumb1.Name = "inpNumb1";
            inpNumb1.Size = new System.Drawing.Size(296, 23);
            inpNumb1.TabIndex = 2;
            inpNumb1.TextChanged += inpNumb1_TextChanged;
            inpNumb1.KeyDown += inpNumb1_KeyDown;
            // 
            // inpNumb2
            // 
            inpNumb2.Location = new System.Drawing.Point(88, 88);
            inpNumb2.Name = "inpNumb2";
            inpNumb2.Size = new System.Drawing.Size(296, 23);
            inpNumb2.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Location = new System.Drawing.Point(16, 132);
            txtResult.Name = "txtResult";
            txtResult.Size = new System.Drawing.Size(65, 15);
            txtResult.TabIndex = 4;
            txtResult.Text = "Resultado: ";
            txtResult.Click += label3_Click;
            // 
            // txtResultNumber
            // 
            txtResultNumber.AutoSize = true;
            txtResultNumber.Location = new System.Drawing.Point(88, 132);
            txtResultNumber.Name = "txtResultNumber";
            txtResultNumber.Size = new System.Drawing.Size(0, 15);
            txtResultNumber.TabIndex = 5;
            txtResultNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExecute
            // 
            btnExecute.Location = new System.Drawing.Point(16, 166);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new System.Drawing.Size(75, 23);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Ejecutar";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // radioBtnSuma
            // 
            radioBtnSuma.AutoSize = true;
            radioBtnSuma.Location = new System.Drawing.Point(25, 16);
            radioBtnSuma.Name = "radioBtnSuma";
            radioBtnSuma.Size = new System.Drawing.Size(59, 19);
            radioBtnSuma.TabIndex = 7;
            radioBtnSuma.TabStop = true;
            radioBtnSuma.Text = "Sumar";
            radioBtnSuma.UseVisualStyleBackColor = true;
            // 
            // radioBtnResta
            // 
            radioBtnResta.AutoSize = true;
            radioBtnResta.Location = new System.Drawing.Point(125, 16);
            radioBtnResta.Name = "radioBtnResta";
            radioBtnResta.Size = new System.Drawing.Size(57, 19);
            radioBtnResta.TabIndex = 8;
            radioBtnResta.TabStop = true;
            radioBtnResta.Text = "Restar";
            radioBtnResta.UseVisualStyleBackColor = true;
            // 
            // radioBtnMult
            // 
            radioBtnMult.AutoSize = true;
            radioBtnMult.Location = new System.Drawing.Point(225, 16);
            radioBtnMult.Name = "radioBtnMult";
            radioBtnMult.Size = new System.Drawing.Size(82, 19);
            radioBtnMult.TabIndex = 9;
            radioBtnMult.TabStop = true;
            radioBtnMult.Text = "Multiplicar";
            radioBtnMult.UseVisualStyleBackColor = true;
            // 
            // radioBtnDiv
            // 
            radioBtnDiv.AutoSize = true;
            radioBtnDiv.Location = new System.Drawing.Point(325, 16);
            radioBtnDiv.Name = "radioBtnDiv";
            radioBtnDiv.Size = new System.Drawing.Size(59, 19);
            radioBtnDiv.TabIndex = 10;
            radioBtnDiv.TabStop = true;
            radioBtnDiv.Text = "Dividir";
            radioBtnDiv.UseVisualStyleBackColor = true;
            // 
            // txtError
            // 
            txtError.AutoSize = true;
            txtError.Location = new System.Drawing.Point(16, 409);
            txtError.Name = "txtError";
            txtError.Size = new System.Drawing.Size(0, 15);
            txtError.TabIndex = 11;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new System.Drawing.Point(97, 166);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(75, 23);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(txtError);
            Controls.Add(radioBtnDiv);
            Controls.Add(radioBtnMult);
            Controls.Add(radioBtnResta);
            Controls.Add(radioBtnSuma);
            Controls.Add(btnExecute);
            Controls.Add(txtResultNumber);
            Controls.Add(txtResult);
            Controls.Add(inpNumb2);
            Controls.Add(inpNumb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpNumb1;
        private System.Windows.Forms.TextBox inpNumb2;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Label txtResultNumber;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RadioButton radioBtnSuma;
        private System.Windows.Forms.RadioButton radioBtnResta;
        private System.Windows.Forms.RadioButton radioBtnMult;
        private System.Windows.Forms.RadioButton radioBtnDiv;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Button btnBorrar;
    }
}
