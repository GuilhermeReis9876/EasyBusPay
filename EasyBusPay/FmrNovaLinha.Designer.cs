namespace EasyBusPay
{
    partial class FmrNovaLinha
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
            this.txtNumLinha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPontoInicio = new System.Windows.Forms.TextBox();
            this.txtPontoFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Nova Linha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número da Linha (4 dígitos)";
            // 
            // txtNumLinha
            // 
            this.txtNumLinha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumLinha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNumLinha.Location = new System.Drawing.Point(18, 114);
            this.txtNumLinha.MaxLength = 4;
            this.txtNumLinha.Name = "txtNumLinha";
            this.txtNumLinha.Size = new System.Drawing.Size(201, 29);
            this.txtNumLinha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ponto Início";
            // 
            // txtPontoInicio
            // 
            this.txtPontoInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPontoInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontoInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPontoInicio.Location = new System.Drawing.Point(18, 188);
            this.txtPontoInicio.MaxLength = 60;
            this.txtPontoInicio.Name = "txtPontoInicio";
            this.txtPontoInicio.Size = new System.Drawing.Size(404, 29);
            this.txtPontoInicio.TabIndex = 4;
            // 
            // txtPontoFinal
            // 
            this.txtPontoFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPontoFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontoFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPontoFinal.Location = new System.Drawing.Point(18, 264);
            this.txtPontoFinal.MaxLength = 60;
            this.txtPontoFinal.Name = "txtPontoFinal";
            this.txtPontoFinal.Size = new System.Drawing.Size(404, 29);
            this.txtPontoFinal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ponto Final";
            // 
            // FmrNovaLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(89)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(450, 591);
            this.Controls.Add(this.txtPontoFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPontoInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumLinha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(466, 630);
            this.MinimumSize = new System.Drawing.Size(466, 630);
            this.Name = "FmrNovaLinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Nova Linha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumLinha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPontoInicio;
        private System.Windows.Forms.TextBox txtPontoFinal;
        private System.Windows.Forms.Label label4;
    }
}