namespace EasyBusPay
{
    partial class FmrHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNovaLinha = new System.Windows.Forms.Button();
            this.btnAbrirRota = new System.Windows.Forms.Button();
            this.btnGerenciarLinhas = new System.Windows.Forms.Button();
            this.dgvLinhasAtivas = new System.Windows.Forms.DataGridView();
            this.lblSubTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasAtivas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // btnNovaLinha
            // 
            this.btnNovaLinha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovaLinha.BackColor = System.Drawing.Color.White;
            this.btnNovaLinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaLinha.Enabled = false;
            this.btnNovaLinha.FlatAppearance.BorderSize = 0;
            this.btnNovaLinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaLinha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaLinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNovaLinha.Location = new System.Drawing.Point(366, 525);
            this.btnNovaLinha.Name = "btnNovaLinha";
            this.btnNovaLinha.Size = new System.Drawing.Size(322, 60);
            this.btnNovaLinha.TabIndex = 1;
            this.btnNovaLinha.Text = "Criar Nova Linha";
            this.btnNovaLinha.UseVisualStyleBackColor = false;
            this.btnNovaLinha.Click += new System.EventHandler(this.BtnNovaLinha_Click);
            // 
            // btnAbrirRota
            // 
            this.btnAbrirRota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbrirRota.BackColor = System.Drawing.Color.White;
            this.btnAbrirRota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirRota.FlatAppearance.BorderSize = 0;
            this.btnAbrirRota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirRota.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirRota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbrirRota.Location = new System.Drawing.Point(24, 525);
            this.btnAbrirRota.Name = "btnAbrirRota";
            this.btnAbrirRota.Size = new System.Drawing.Size(322, 60);
            this.btnAbrirRota.TabIndex = 2;
            this.btnAbrirRota.Text = "Abrir Rota";
            this.btnAbrirRota.UseVisualStyleBackColor = false;
            this.btnAbrirRota.Click += new System.EventHandler(this.BtnAbrirRota_Click);
            // 
            // btnGerenciarLinhas
            // 
            this.btnGerenciarLinhas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerenciarLinhas.BackColor = System.Drawing.Color.White;
            this.btnGerenciarLinhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarLinhas.Enabled = false;
            this.btnGerenciarLinhas.FlatAppearance.BorderSize = 0;
            this.btnGerenciarLinhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarLinhas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarLinhas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGerenciarLinhas.Location = new System.Drawing.Point(710, 525);
            this.btnGerenciarLinhas.Name = "btnGerenciarLinhas";
            this.btnGerenciarLinhas.Size = new System.Drawing.Size(322, 60);
            this.btnGerenciarLinhas.TabIndex = 3;
            this.btnGerenciarLinhas.Text = "Gerenciar Linhas";
            this.btnGerenciarLinhas.UseVisualStyleBackColor = false;
            // 
            // dgvLinhasAtivas
            // 
            this.dgvLinhasAtivas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLinhasAtivas.ColumnHeadersHeight = 50;
            this.dgvLinhasAtivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLinhasAtivas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLinhasAtivas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLinhasAtivas.Location = new System.Drawing.Point(23, 69);
            this.dgvLinhasAtivas.Name = "dgvLinhasAtivas";
            this.dgvLinhasAtivas.RowHeadersWidth = 50;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvLinhasAtivas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLinhasAtivas.Size = new System.Drawing.Size(1008, 428);
            this.dgvLinhasAtivas.TabIndex = 4;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(125, 24);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(228, 25);
            this.lblSubTitle.TabIndex = 5;
            this.lblSubTitle.Text = "- Número de linhas ativas";
            // 
            // FmrHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(89)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1055, 617);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.dgvLinhasAtivas);
            this.Controls.Add(this.btnGerenciarLinhas);
            this.Controls.Add(this.btnAbrirRota);
            this.Controls.Add(this.btnNovaLinha);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1071, 656);
            this.MinimumSize = new System.Drawing.Size(1071, 656);
            this.Name = "FmrHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Bus Pay | Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasAtivas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNovaLinha;
        private System.Windows.Forms.Button btnAbrirRota;
        private System.Windows.Forms.Button btnGerenciarLinhas;
        private System.Windows.Forms.Label lblSubTitle;
        public System.Windows.Forms.DataGridView dgvLinhasAtivas;
    }
}