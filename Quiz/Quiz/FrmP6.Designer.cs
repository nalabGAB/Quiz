﻿namespace Quiz
{
    partial class FrmP6
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
            this.box = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtnCerto = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.Controls.Add(this.radioButton4);
            this.box.Controls.Add(this.radioButton3);
            this.box.Controls.Add(this.rbtnCerto);
            this.box.Controls.Add(this.radioButton1);
            this.box.Location = new System.Drawing.Point(12, 65);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(696, 377);
            this.box.TabIndex = 18;
            this.box.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(23, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(334, 24);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Uma estrutura de dados em forma de anel  ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(23, 79);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(350, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Um tipo de variável que não pode ser alterada";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtnCerto
            // 
            this.rbtnCerto.AutoSize = true;
            this.rbtnCerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCerto.Location = new System.Drawing.Point(23, 49);
            this.rbtnCerto.Name = "rbtnCerto";
            this.rbtnCerto.Size = new System.Drawing.Size(367, 24);
            this.rbtnCerto.TabIndex = 2;
            this.rbtnCerto.TabStop = true;
            this.rbtnCerto.Text = "Um método para repetir uma série de instruções";
            this.rbtnCerto.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(23, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(320, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Uma função que gera números aleatórios";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Location = new System.Drawing.Point(633, 448);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 17;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "6 - O que é um \"loop\" em programação?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmP6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box);
            this.Controls.Add(this.btnProximo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmP6";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmP6";
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbtnCerto;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label label2;
    }
}