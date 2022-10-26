namespace SãoJudas1
{
    partial class LoginTela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LembrarUser = new System.Windows.Forms.CheckBox();
            this.botaologin = new System.Windows.Forms.Button();
            this.botaosair = new System.Windows.Forms.Button();
            this.usuariologin = new System.Windows.Forms.TextBox();
            this.senhalogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LembrarUser
            // 
            this.LembrarUser.AutoSize = true;
            this.LembrarUser.Location = new System.Drawing.Point(59, 83);
            this.LembrarUser.Name = "LembrarUser";
            this.LembrarUser.Size = new System.Drawing.Size(103, 17);
            this.LembrarUser.TabIndex = 0;
            this.LembrarUser.Text = "Lembrar Usuário";
            this.LembrarUser.UseVisualStyleBackColor = true;
            // 
            // botaologin
            // 
            this.botaologin.Location = new System.Drawing.Point(246, 229);
            this.botaologin.Name = "botaologin";
            this.botaologin.Size = new System.Drawing.Size(75, 23);
            this.botaologin.TabIndex = 1;
            this.botaologin.Text = "Entrar";
            this.botaologin.UseVisualStyleBackColor = true;
            this.botaologin.Click += new System.EventHandler(this.botaologin_Click);
            // 
            // botaosair
            // 
            this.botaosair.Location = new System.Drawing.Point(59, 229);
            this.botaosair.Name = "botaosair";
            this.botaosair.Size = new System.Drawing.Size(75, 23);
            this.botaosair.TabIndex = 2;
            this.botaosair.Text = "Cancelar";
            this.botaosair.UseVisualStyleBackColor = true;
            this.botaosair.Click += new System.EventHandler(this.botaosair_Click);
            // 
            // usuariologin
            // 
            this.usuariologin.Location = new System.Drawing.Point(59, 57);
            this.usuariologin.Name = "usuariologin";
            this.usuariologin.Size = new System.Drawing.Size(262, 20);
            this.usuariologin.TabIndex = 3;
            // 
            // senhalogin
            // 
            this.senhalogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.senhalogin.Location = new System.Drawing.Point(59, 142);
            this.senhalogin.Name = "senhalogin";
            this.senhalogin.PasswordChar = '*';
            this.senhalogin.Size = new System.Drawing.Size(262, 20);
            this.senhalogin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // LoginTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(382, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhalogin);
            this.Controls.Add(this.usuariologin);
            this.Controls.Add(this.botaosair);
            this.Controls.Add(this.botaologin);
            this.Controls.Add(this.LembrarUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo São Judas";
            this.Load += new System.EventHandler(this.LoginTela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LembrarUser;
        private System.Windows.Forms.Button botaologin;
        private System.Windows.Forms.Button botaosair;
        private System.Windows.Forms.TextBox usuariologin;
        private System.Windows.Forms.TextBox senhalogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

