namespace email
{
    partial class FormLixeira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLixeira));
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.tbRemetente = new System.Windows.Forms.TextBox();
            this.lbLixeira = new System.Windows.Forms.Label();
            this.lbAssunto = new System.Windows.Forms.Label();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.lbCorpo = new System.Windows.Forms.Label();
            this.tbCorpo = new System.Windows.Forms.TextBox();
            this.lbRemetente = new System.Windows.Forms.Label();
            this.lbxEmails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
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
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
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
            this.btFechar.TabIndex = 4;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestaurar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurar.ForeColor = System.Drawing.Color.White;
            this.btRestaurar.Location = new System.Drawing.Point(987, 474);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(100, 30);
            this.btRestaurar.TabIndex = 6;
            this.btRestaurar.Text = "Restaurar";
            this.btRestaurar.UseVisualStyleBackColor = false;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
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
            this.tbRemetente.TabIndex = 1;
            // 
            // lbLixeira
            // 
            this.lbLixeira.AutoSize = true;
            this.lbLixeira.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLixeira.ForeColor = System.Drawing.Color.DimGray;
            this.lbLixeira.Location = new System.Drawing.Point(197, 29);
            this.lbLixeira.Name = "lbLixeira";
            this.lbLixeira.Size = new System.Drawing.Size(45, 17);
            this.lbLixeira.TabIndex = 53;
            this.lbLixeira.Text = "Lixeira";
            // 
            // lbAssunto
            // 
            this.lbAssunto.AutoSize = true;
            this.lbAssunto.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssunto.ForeColor = System.Drawing.Color.DimGray;
            this.lbAssunto.Location = new System.Drawing.Point(418, 79);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(54, 17);
            this.lbAssunto.TabIndex = 52;
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
            this.tbAssunto.TabIndex = 2;
            // 
            // lbCorpo
            // 
            this.lbCorpo.AutoSize = true;
            this.lbCorpo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorpo.ForeColor = System.Drawing.Color.DimGray;
            this.lbCorpo.Location = new System.Drawing.Point(418, 129);
            this.lbCorpo.Name = "lbCorpo";
            this.lbCorpo.Size = new System.Drawing.Size(45, 17);
            this.lbCorpo.TabIndex = 51;
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
            this.tbCorpo.TabIndex = 3;
            // 
            // lbRemetente
            // 
            this.lbRemetente.AutoSize = true;
            this.lbRemetente.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemetente.ForeColor = System.Drawing.Color.DimGray;
            this.lbRemetente.Location = new System.Drawing.Point(418, 29);
            this.lbRemetente.Name = "lbRemetente";
            this.lbRemetente.Size = new System.Drawing.Size(70, 17);
            this.lbRemetente.TabIndex = 50;
            this.lbRemetente.Text = "Remetente";
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
            // FormLixeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 531);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.tbRemetente);
            this.Controls.Add(this.lbLixeira);
            this.Controls.Add(this.lbAssunto);
            this.Controls.Add(this.tbAssunto);
            this.Controls.Add(this.lbCorpo);
            this.Controls.Add(this.tbCorpo);
            this.Controls.Add(this.lbRemetente);
            this.Controls.Add(this.lbxEmails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1140, 570);
            this.Name = "FormLixeira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lixeira";
            this.Load += new System.EventHandler(this.FormLixeira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.TextBox tbRemetente;
        private System.Windows.Forms.Label lbLixeira;
        private System.Windows.Forms.Label lbAssunto;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Label lbCorpo;
        private System.Windows.Forms.TextBox tbCorpo;
        private System.Windows.Forms.Label lbRemetente;
        private System.Windows.Forms.ListBox lbxEmails;
    }
}