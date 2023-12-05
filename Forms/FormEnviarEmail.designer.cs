namespace email
{
    partial class FormEnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviarEmail));
            this.lbDestinatario = new System.Windows.Forms.Label();
            this.cbDestinatario = new System.Windows.Forms.ComboBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCorpo = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.lbCorpo = new System.Windows.Forms.Label();
            this.lbAssunto = new System.Windows.Forms.Label();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDestinatario
            // 
            this.lbDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDestinatario.AutoSize = true;
            this.lbDestinatario.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinatario.ForeColor = System.Drawing.Color.DimGray;
            this.lbDestinatario.Location = new System.Drawing.Point(31, 29);
            this.lbDestinatario.Name = "lbDestinatario";
            this.lbDestinatario.Size = new System.Drawing.Size(83, 17);
            this.lbDestinatario.TabIndex = 24;
            this.lbDestinatario.Text = "Destinatário*";
            // 
            // cbDestinatario
            // 
            this.cbDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDestinatario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDestinatario.DisplayMember = "email";
            this.cbDestinatario.DropDownHeight = 200;
            this.cbDestinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinatario.Font = new System.Drawing.Font("Yu Gothic UI", 10.5F);
            this.cbDestinatario.FormattingEnabled = true;
            this.cbDestinatario.IntegralHeight = false;
            this.cbDestinatario.Items.AddRange(new object[] {
            "SELECIONE",
            "AROMATIZADOR DE AMBIENTE",
            "ÁGUA DE LENÇÓIS",
            "SABONETE LÍQUIDO"});
            this.cbDestinatario.Location = new System.Drawing.Point(34, 49);
            this.cbDestinatario.Name = "cbDestinatario";
            this.cbDestinatario.Size = new System.Drawing.Size(330, 27);
            this.cbDestinatario.TabIndex = 0;
            this.cbDestinatario.ValueMember = "id";
            this.cbDestinatario.SelectedIndexChanged += new System.EventHandler(this.cbDestinatario_SelectedIndexChanged);
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.DimGray;
            this.lbNome.Location = new System.Drawing.Point(367, 29);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 17);
            this.lbNome.TabIndex = 28;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(370, 49);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(330, 27);
            this.tbNome.TabIndex = 1;
            // 
            // tbCorpo
            // 
            this.tbCorpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorpo.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorpo.Location = new System.Drawing.Point(34, 149);
            this.tbCorpo.MaxLength = 1000;
            this.tbCorpo.Multiline = true;
            this.tbCorpo.Name = "tbCorpo";
            this.tbCorpo.Size = new System.Drawing.Size(666, 309);
            this.tbCorpo.TabIndex = 3;
            // 
            // btEnviar
            // 
            this.btEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEnviar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnviar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.ForeColor = System.Drawing.Color.White;
            this.btEnviar.Location = new System.Drawing.Point(600, 474);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(100, 30);
            this.btEnviar.TabIndex = 5;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = false;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // lbCorpo
            // 
            this.lbCorpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCorpo.AutoSize = true;
            this.lbCorpo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorpo.ForeColor = System.Drawing.Color.DimGray;
            this.lbCorpo.Location = new System.Drawing.Point(31, 129);
            this.lbCorpo.Name = "lbCorpo";
            this.lbCorpo.Size = new System.Drawing.Size(50, 17);
            this.lbCorpo.TabIndex = 31;
            this.lbCorpo.Text = "Corpo*";
            // 
            // lbAssunto
            // 
            this.lbAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAssunto.AutoSize = true;
            this.lbAssunto.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssunto.ForeColor = System.Drawing.Color.DimGray;
            this.lbAssunto.Location = new System.Drawing.Point(31, 79);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(59, 17);
            this.lbAssunto.TabIndex = 33;
            this.lbAssunto.Text = "Assunto*";
            // 
            // tbAssunto
            // 
            this.tbAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAssunto.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAssunto.Location = new System.Drawing.Point(34, 99);
            this.tbAssunto.MaxLength = 100;
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.Size = new System.Drawing.Size(666, 27);
            this.tbAssunto.TabIndex = 2;
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpar.BackColor = System.Drawing.Color.DarkOrange;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(494, 474);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(100, 30);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FormEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 531);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbAssunto);
            this.Controls.Add(this.tbAssunto);
            this.Controls.Add(this.lbCorpo);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.tbCorpo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbDestinatario);
            this.Controls.Add(this.cbDestinatario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 570);
            this.Name = "FormEnviarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de e-mail";
            this.Load += new System.EventHandler(this.FormEnviarEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDestinatario;
        private System.Windows.Forms.ComboBox cbDestinatario;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCorpo;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Label lbCorpo;
        private System.Windows.Forms.Label lbAssunto;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Button btLimpar;
    }
}