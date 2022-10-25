namespace SãoJudas1.Forms
{
    partial class TelaSys
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
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concatenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.concatenarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.novoToolStripMenuItem.Text = "Abrir";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // concatenarToolStripMenuItem
            // 
            this.concatenarToolStripMenuItem.Name = "concatenarToolStripMenuItem";
            this.concatenarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.concatenarToolStripMenuItem.Text = "Concatenar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.departamentoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logísticaToolStripMenuItem,
            this.tecnologiaToolStripMenuItem});
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // logísticaToolStripMenuItem
            // 
            this.logísticaToolStripMenuItem.Name = "logísticaToolStripMenuItem";
            this.logísticaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logísticaToolStripMenuItem.Text = "Logística";
            this.logísticaToolStripMenuItem.Click += new System.EventHandler(this.logísticaToolStripMenuItem_Click);
            // 
            // tecnologiaToolStripMenuItem
            // 
            this.tecnologiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroUsuárioToolStripMenuItem});
            this.tecnologiaToolStripMenuItem.Name = "tecnologiaToolStripMenuItem";
            this.tecnologiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tecnologiaToolStripMenuItem.Text = "Tecnologia";
            // 
            // cadastroUsuárioToolStripMenuItem
            // 
            this.cadastroUsuárioToolStripMenuItem.Name = "cadastroUsuárioToolStripMenuItem";
            this.cadastroUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroUsuárioToolStripMenuItem.Text = "Cadastro Usuário";
            this.cadastroUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroUsuárioToolStripMenuItem_Click);
            // 
            // TelaSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "TelaSys";
            this.Text = "São Judas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concatenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuárioToolStripMenuItem;
    }
}