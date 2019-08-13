namespace Equacao2grau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe os valores:";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(32, 53);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(40, 20);
            this.txtBoxA.TabIndex = 1;
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(200, 53);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(37, 20);
            this.txtBoxC.TabIndex = 2;
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(115, 53);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(38, 20);
            this.txtBoxB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "c";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(183, 90);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 7;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(26, 150);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(35, 13);
            this.lblDelta.TabIndex = 8;
            this.lblDelta.Text = "Delta:";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(29, 175);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(21, 13);
            this.lblX1.TabIndex = 9;
            this.lblX1.Text = "x1:";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(29, 204);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(21, 13);
            this.lblX2.TabIndex = 10;
            this.lblX2.Text = "x2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxC);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label label5;
    }
}

