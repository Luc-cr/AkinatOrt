﻿
namespace AkinatOrt
{
    partial class juego
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.Transparent;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnSi.Location = new System.Drawing.Point(137, 601);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(176, 74);
            this.btnSi.TabIndex = 0;
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnNo.Location = new System.Drawing.Point(401, 601);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(168, 74);
            this.btnNo.TabIndex = 1;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.lblPreguntas.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblPreguntas.Location = new System.Drawing.Point(67, 504);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(586, 66);
            this.lblPreguntas.TabIndex = 2;
            this.lblPreguntas.Text = "Su personaje es mujer?";
            this.lblPreguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkinatOrt.Properties.Resources.Pantalla_Juego_Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 719);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPreguntas);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Name = "juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}