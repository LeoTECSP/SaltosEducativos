﻿namespace ProyectoISW.Forms
{
    partial class menuProfesor
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
            this.btnActividad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActividad
            // 
            this.btnActividad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividad.Location = new System.Drawing.Point(217, 179);
            this.btnActividad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActividad.Name = "btnActividad";
            this.btnActividad.Size = new System.Drawing.Size(487, 70);
            this.btnActividad.TabIndex = 22;
            this.btnActividad.Text = "Generar Actividad";
            this.btnActividad.UseVisualStyleBackColor = false;
            this.btnActividad.Click += new System.EventHandler(this.btnActividad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 46);
            this.label1.TabIndex = 29;
            this.label1.Text = "Menu de Opciones";
            // 
            // menuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActividad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuProfesor";
            this.Text = "menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuProfesor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActividad;
        private System.Windows.Forms.Label label1;
    }
}