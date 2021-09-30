
namespace rectangulo
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
            this.title = new System.Windows.Forms.Label();
            this.labelLadoA = new System.Windows.Forms.Label();
            this.labelLadoB = new System.Windows.Forms.Label();
            this.ladoB = new System.Windows.Forms.TextBox();
            this.ladoA = new System.Windows.Forms.TextBox();
            this.perimetro = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.reiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(47, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(179, 48);
            this.title.TabIndex = 0;
            this.title.Text = "Rectángulo";
            // 
            // labelLadoA
            // 
            this.labelLadoA.AutoSize = true;
            this.labelLadoA.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLadoA.Location = new System.Drawing.Point(47, 127);
            this.labelLadoA.Name = "labelLadoA";
            this.labelLadoA.Size = new System.Drawing.Size(267, 37);
            this.labelLadoA.TabIndex = 1;
            this.labelLadoA.Text = "Ingrese el lado A en cm:";
            // 
            // labelLadoB
            // 
            this.labelLadoB.AutoSize = true;
            this.labelLadoB.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLadoB.Location = new System.Drawing.Point(48, 223);
            this.labelLadoB.Name = "labelLadoB";
            this.labelLadoB.Size = new System.Drawing.Size(266, 37);
            this.labelLadoB.TabIndex = 2;
            this.labelLadoB.Text = "Ingrese el lado B en cm:";
            // 
            // ladoB
            // 
            this.ladoB.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ladoB.Location = new System.Drawing.Point(48, 263);
            this.ladoB.Name = "ladoB";
            this.ladoB.Size = new System.Drawing.Size(266, 31);
            this.ladoB.TabIndex = 3;
            // 
            // ladoA
            // 
            this.ladoA.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ladoA.Location = new System.Drawing.Point(47, 167);
            this.ladoA.Name = "ladoA";
            this.ladoA.Size = new System.Drawing.Size(267, 31);
            this.ladoA.TabIndex = 3;
            // 
            // perimetro
            // 
            this.perimetro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.perimetro.FlatAppearance.BorderSize = 0;
            this.perimetro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perimetro.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.perimetro.Location = new System.Drawing.Point(47, 433);
            this.perimetro.Name = "perimetro";
            this.perimetro.Size = new System.Drawing.Size(266, 31);
            this.perimetro.TabIndex = 4;
            this.perimetro.Text = "CALCULAR EL PERÍMETRO";
            this.perimetro.UseVisualStyleBackColor = false;
            this.perimetro.Click += new System.EventHandler(this.perimetro_Click);
            // 
            // area
            // 
            this.area.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.area.FlatAppearance.BorderSize = 0;
            this.area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.area.ForeColor = System.Drawing.SystemColors.ControlText;
            this.area.Location = new System.Drawing.Point(47, 481);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(266, 31);
            this.area.TabIndex = 4;
            this.area.Text = "CALCULAR ÁREA";
            this.area.UseVisualStyleBackColor = false;
            this.area.Click += new System.EventHandler(this.area_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(381, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(166, 333);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(31, 37);
            this.resultado.TabIndex = 6;
            this.resultado.Text = "0";
            // 
            // reiniciar
            // 
            this.reiniciar.BackColor = System.Drawing.Color.DarkSalmon;
            this.reiniciar.FlatAppearance.BorderSize = 0;
            this.reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reiniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reiniciar.Location = new System.Drawing.Point(48, 527);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(266, 31);
            this.reiniciar.TabIndex = 7;
            this.reiniciar.Text = "REINICIAR";
            this.reiniciar.UseVisualStyleBackColor = false;
            this.reiniciar.Click += new System.EventHandler(this.reiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 602);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.area);
            this.Controls.Add(this.perimetro);
            this.Controls.Add(this.ladoA);
            this.Controls.Add(this.ladoB);
            this.Controls.Add(this.labelLadoB);
            this.Controls.Add(this.labelLadoA);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelLadoA;
        private System.Windows.Forms.Label labelLadoB;
        private System.Windows.Forms.TextBox ladoB;
        private System.Windows.Forms.TextBox ladoA;
        private System.Windows.Forms.Button perimetro;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button reiniciar;
    }
}

