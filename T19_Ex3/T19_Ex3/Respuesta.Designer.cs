
namespace T19_Ex3
{
    partial class Respuesta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Operativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label2.Location = new System.Drawing.Point(64, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especialidad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label3.Location = new System.Drawing.Point(64, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas Dedicadas: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 120);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nueva Encuesta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Respuesta";
            this.Text = "Respuesta";
            this.Load += new System.EventHandler(this.Respuesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}