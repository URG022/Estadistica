namespace Estadistica
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(240, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Probabilidad Binomial";
            // 
            // txtN
            // 
            this.txtN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(650, 120);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(126, 31);
            this.txtN.TabIndex = 1;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(340, 363);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(311, 38);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Probabilidad";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtK
            // 
            this.txtK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK.Location = new System.Drawing.Point(650, 192);
            this.txtK.Multiline = true;
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(126, 31);
            this.txtK.TabIndex = 2;
            this.txtK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de éxitos deseados (k)";
            // 
            // txtP
            // 
            this.txtP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(650, 265);
            this.txtP.Multiline = true;
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(126, 31);
            this.txtP.TabIndex = 3;
            this.txtP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Probabilidad de éxito en un solo ensayo (p)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de ensayos (n)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 473);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cálculo de probabilidad Binomial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtK;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

