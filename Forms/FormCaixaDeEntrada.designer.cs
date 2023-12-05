namespace email
{
    partial class FormCaixaDeEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixaDeEntrada));
            this.lbxEmails = new System.Windows.Forms.ListBox();
            this.lbAssunto = new System.Windows.Forms.Label();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.lbCorpo = new System.Windows.Forms.Label();
            this.tbCorpo = new System.Windows.Forms.TextBox();
            this.lbRemetente = new System.Windows.Forms.Label();
            this.lbCaixaDeEntrada = new System.Windows.Forms.Label();
            this.tbRemetente = new System.Windows.Forms.TextBox();
            this.btResponder = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.rbLidos = new System.Windows.Forms.RadioButton();
            this.rbNaoLidos = new System.Windows.Forms.RadioButton();
            this.ckLido = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbxEmails
            // 
            this.lbxEmails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxEmails.DisplayMember = "assunto";
            this.lbxEmails.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmails.FormattingEnabled = true;
            this.lbxEmails.ItemHeight = 20;
            this.lbxEmails.Location = new System.Drawing.Point(34, 51);
            this.lbxEmails.Name = "lbxEmails";
            this.lbxEmails.Size = new System.Drawing.Size(370, 404);
            this.lbxEmails.TabIndex = 0;
            this.lbxEmails.ValueMember = "id";
            this.lbxEmails.SelectedIndexChanged += new System.EventHandler(this.lbxEmails_SelectedIndexChanged);
            // 
            // lbAssunto
            // 
            this.lbAssunto.AutoSize = true;
            this.lbAssunto.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssunto.ForeColor = System.Drawing.Color.DimGray;
            this.lbAssunto.Location = new System.Drawing.Point(418, 79);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(54, 17);
            this.lbAssunto.TabIndex = 41;
            this.lbAssunto.Text = "Assunto";
            // 
            // tbAssunto
            // 
            this.tbAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAssunto.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAssunto.Location = new System.Drawing.Point(421, 99);
            this.tbAssunto.MaxLength = 100;
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.ReadOnly = true;
            this.tbAssunto.Size = new System.Drawing.Size(666, 27);
            this.tbAssunto.TabIndex = 4;
            // 
            // lbCorpo
            // 
            this.lbCorpo.AutoSize = true;
            this.lbCorpo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorpo.ForeColor = System.Drawing.Color.DimGray;
            this.lbCorpo.Location = new System.Drawing.Point(418, 129);
            this.lbCorpo.Name = "lbCorpo";
            this.lbCorpo.Size = new System.Drawing.Size(45, 17);
            this.lbCorpo.TabIndex = 40;
            this.lbCorpo.Text = "Corpo";
            // 
            // tbCorpo
            // 
            this.tbCorpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorpo.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorpo.Location = new System.Drawing.Point(421, 149);
            this.tbCorpo.MaxLength = 1000;
            this.tbCorpo.Multiline = true;
            this.tbCorpo.Name = "tbCorpo";
            this.tbCorpo.ReadOnly = true;
            this.tbCorpo.Size = new System.Drawing.Size(666, 309);
            this.tbCorpo.TabIndex = 5;
            // 
            // lbRemetente
            // 
            this.lbRemetente.AutoSize = true;
            this.lbRemetente.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemetente.ForeColor = System.Drawing.Color.DimGray;
            this.lbRemetente.Location = new System.Drawing.Point(418, 29);
            this.lbRemetente.Name = "lbRemetente";
            this.lbRemetente.Size = new System.Drawing.Size(70, 17);
            this.lbRemetente.TabIndex = 38;
            this.lbRemetente.Text = "Remetente";
            // 
            // lbCaixaDeEntrada
            // 
            this.lbCaixaDeEntrada.AutoSize = true;
            this.lbCaixaDeEntrada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaixaDeEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.lbCaixaDeEntrada.Location = new System.Drawing.Point(166, 29);
            this.lbCaixaDeEntrada.Name = "lbCaixaDeEntrada";
            this.lbCaixaDeEntrada.Size = new System.Drawing.Size(107, 17);
            this.lbCaixaDeEntrada.TabIndex = 42;
            this.lbCaixaDeEntrada.Text = "Caixa de entrada";
            // 
            // tbRemetente
            // 
            this.tbRemetente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRemetente.Enabled = false;
            this.tbRemetente.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemetente.Location = new System.Drawing.Point(421, 49);
            this.tbRemetente.MaxLength = 100;
            this.tbRemetente.Name = "tbRemetente";
            this.tbRemetente.ReadOnly = true;
            this.tbRemetente.Size = new System.Drawing.Size(666, 27);
            this.tbRemetente.TabIndex = 3;
            // 
            // btResponder
            // 
            this.btResponder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResponder.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResponder.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResponder.ForeColor = System.Drawing.Color.White;
            this.btResponder.Location = new System.Drawing.Point(987, 474);
            this.btResponder.Name = "btResponder";
            this.btResponder.Size = new System.Drawing.Size(100, 30);
            this.btResponder.TabIndex = 9;
            this.btResponder.Text = "Responder";
            this.btResponder.UseVisualStyleBackColor = false;
            this.btResponder.Click += new System.EventHandler(this.btResponder_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.DarkOrange;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(775, 474);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(100, 30);
            this.btFechar.TabIndex = 7;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Firebrick;
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(881, 474);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 30);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // rbLidos
            // 
            this.rbLidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbLidos.AutoSize = true;
            this.rbLidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLidos.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLidos.Location = new System.Drawing.Point(115, 463);
            this.rbLidos.Name = "rbLidos";
            this.rbLidos.Size = new System.Drawing.Size(53, 19);
            this.rbLidos.TabIndex = 2;
            this.rbLidos.TabStop = true;
            this.rbLidos.Text = "Lidos";
            this.rbLidos.UseVisualStyleBackColor = true;
            this.rbLidos.CheckedChanged += new System.EventHandler(this.rbLidosENaoLidos_CheckedChanged);
            // 
            // rbNaoLidos
            // 
            this.rbNaoLidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNaoLidos.AutoSize = true;
            this.rbNaoLidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNaoLidos.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoLidos.Location = new System.Drawing.Point(34, 463);
            this.rbNaoLidos.Name = "rbNaoLidos";
            this.rbNaoLidos.Size = new System.Drawing.Size(75, 19);
            this.rbNaoLidos.TabIndex = 1;
            this.rbNaoLidos.TabStop = true;
            this.rbNaoLidos.Text = "Não lidos";
            this.rbNaoLidos.UseVisualStyleBackColor = true;
            this.rbNaoLidos.CheckedChanged += new System.EventHandler(this.rbLidosENaoLidos_CheckedChanged);
            // 
            // ckLido
            // 
            this.ckLido.AutoSize = true;
            this.ckLido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckLido.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckLido.Location = new System.Drawing.Point(421, 464);
            this.ckLido.Name = "ckLido";
            this.ckLido.Size = new System.Drawing.Size(134, 19);
            this.ckLido.TabIndex = 6;
            this.ckLido.Text = "Marcar como lido ✓";
            this.ckLido.UseVisualStyleBackColor = true;
            this.ckLido.Click += new System.EventHandler(this.ckLido_Click);
            // 
            // FormCaixaDeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 531);
            this.Controls.Add(this.ckLido);
            this.Controls.Add(this.rbNaoLidos);
            this.Controls.Add(this.rbLidos);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btResponder);
            this.Controls.Add(this.tbRemetente);
            this.Controls.Add(this.lbCaixaDeEntrada);
            this.Controls.Add(this.lbAssunto);
            this.Controls.Add(this.tbAssunto);
            this.Controls.Add(this.lbCorpo);
            this.Controls.Add(this.tbCorpo);
            this.Controls.Add(this.lbRemetente);
            this.Controls.Add(this.lbxEmails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1140, 570);
            this.Name = "FormCaixaDeEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa de Entrada";
            this.Load += new System.EventHandler(this.FormCaixaDeEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEmails;
        private System.Windows.Forms.Label lbAssunto;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Label lbCorpo;
        private System.Windows.Forms.TextBox tbCorpo;
        private System.Windows.Forms.Label lbRemetente;
        private System.Windows.Forms.Label lbCaixaDeEntrada;
        private System.Windows.Forms.TextBox tbRemetente;
        private System.Windows.Forms.Button btResponder;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.RadioButton rbLidos;
        private System.Windows.Forms.RadioButton rbNaoLidos;
        private System.Windows.Forms.CheckBox ckLido;
    }
}