namespace MessageBoxOptions
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuString = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitulo = new System.Windows.Forms.ToolStripMenuItem();
            this.butoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButoesOK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbortRetryIgnore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButoesOKCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRetryCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.menButoesSimNao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButoesSimNaoCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.iconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIconsInformacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIconsErro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIconsNenhum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIconsPergunta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIconsAviso = new System.Windows.Forms.ToolStripMenuItem();
            this.atalhoEtcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPosicaoDosObjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuString,
            this.menuTitulo,
            this.butoesToolStripMenuItem,
            this.iconsToolStripMenuItem,
            this.menuPosicaoDosObjetos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuString
            // 
            this.menuString.Name = "menuString";
            this.menuString.Size = new System.Drawing.Size(50, 20);
            this.menuString.Text = "String";
            this.menuString.Click += new System.EventHandler(this.menuString_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Size = new System.Drawing.Size(53, 20);
            this.menuTitulo.Text = "Titulo ";
            this.menuTitulo.Click += new System.EventHandler(this.menuTitulo_Click);
            // 
            // butoesToolStripMenuItem
            // 
            this.butoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButoesOK,
            this.menuAbortRetryIgnore,
            this.menuButoesOKCancel,
            this.menuRetryCancel,
            this.menButoesSimNao,
            this.menuButoesSimNaoCancelar,
            this.atalhoEtcToolStripMenuItem});
            this.butoesToolStripMenuItem.Name = "butoesToolStripMenuItem";
            this.butoesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.butoesToolStripMenuItem.Text = "Butoes";
            // 
            // menuButoesOK
            // 
            this.menuButoesOK.Name = "menuButoesOK";
            this.menuButoesOK.Size = new System.Drawing.Size(180, 22);
            this.menuButoesOK.Text = "OK";
            this.menuButoesOK.Click += new System.EventHandler(this.menuButoesOK_Click);
            // 
            // menuAbortRetryIgnore
            // 
            this.menuAbortRetryIgnore.Name = "menuAbortRetryIgnore";
            this.menuAbortRetryIgnore.Size = new System.Drawing.Size(180, 22);
            this.menuAbortRetryIgnore.Text = "AbortRetryIgnore";
            this.menuAbortRetryIgnore.Click += new System.EventHandler(this.menuAbortRetryIgnore_Click);
            // 
            // menuButoesOKCancel
            // 
            this.menuButoesOKCancel.Name = "menuButoesOKCancel";
            this.menuButoesOKCancel.Size = new System.Drawing.Size(180, 22);
            this.menuButoesOKCancel.Text = "OK e Cancel";
            this.menuButoesOKCancel.Click += new System.EventHandler(this.menuButoesOKCancel_Click);
            // 
            // menuRetryCancel
            // 
            this.menuRetryCancel.Name = "menuRetryCancel";
            this.menuRetryCancel.Size = new System.Drawing.Size(180, 22);
            this.menuRetryCancel.Text = "RetryCancel";
            this.menuRetryCancel.Click += new System.EventHandler(this.menuRetryCancel_Click);
            // 
            // menButoesSimNao
            // 
            this.menButoesSimNao.Name = "menButoesSimNao";
            this.menButoesSimNao.Size = new System.Drawing.Size(180, 22);
            this.menButoesSimNao.Text = "Sim e Nao";
            this.menButoesSimNao.Click += new System.EventHandler(this.menButoesSimNao_Click);
            // 
            // menuButoesSimNaoCancelar
            // 
            this.menuButoesSimNaoCancelar.Name = "menuButoesSimNaoCancelar";
            this.menuButoesSimNaoCancelar.Size = new System.Drawing.Size(180, 22);
            this.menuButoesSimNaoCancelar.Text = "Sim, Nao e Cancelar";
            this.menuButoesSimNaoCancelar.Click += new System.EventHandler(this.menuButoesSimNaoCancelar_Click);
            // 
            // iconsToolStripMenuItem
            // 
            this.iconsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIconsInformacao,
            this.menuIconsErro,
            this.menuIconsNenhum,
            this.menuIconsPergunta,
            this.menuIconsAviso});
            this.iconsToolStripMenuItem.Name = "iconsToolStripMenuItem";
            this.iconsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.iconsToolStripMenuItem.Text = "Icons";
            // 
            // menuIconsInformacao
            // 
            this.menuIconsInformacao.Name = "menuIconsInformacao";
            this.menuIconsInformacao.Size = new System.Drawing.Size(152, 22);
            this.menuIconsInformacao.Text = "Informaçao";
            this.menuIconsInformacao.Click += new System.EventHandler(this.menuIconsInformacao_Click);
            // 
            // menuIconsErro
            // 
            this.menuIconsErro.Name = "menuIconsErro";
            this.menuIconsErro.Size = new System.Drawing.Size(152, 22);
            this.menuIconsErro.Text = "Erro";
            this.menuIconsErro.Click += new System.EventHandler(this.menuIconsErro_Click);
            // 
            // menuIconsNenhum
            // 
            this.menuIconsNenhum.Name = "menuIconsNenhum";
            this.menuIconsNenhum.Size = new System.Drawing.Size(152, 22);
            this.menuIconsNenhum.Text = "Nenhum";
            this.menuIconsNenhum.Click += new System.EventHandler(this.menuIconsNenhum_Click);
            // 
            // menuIconsPergunta
            // 
            this.menuIconsPergunta.Name = "menuIconsPergunta";
            this.menuIconsPergunta.Size = new System.Drawing.Size(152, 22);
            this.menuIconsPergunta.Text = "Pergunta";
            this.menuIconsPergunta.Click += new System.EventHandler(this.menuIconsPergunta_Click);
            // 
            // menuIconsAviso
            // 
            this.menuIconsAviso.Name = "menuIconsAviso";
            this.menuIconsAviso.Size = new System.Drawing.Size(152, 22);
            this.menuIconsAviso.Text = "Aviso";
            this.menuIconsAviso.Click += new System.EventHandler(this.menuIconsAviso_Click);
            // 
            // atalhoEtcToolStripMenuItem
            // 
            this.atalhoEtcToolStripMenuItem.Name = "atalhoEtcToolStripMenuItem";
            this.atalhoEtcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atalhoEtcToolStripMenuItem.Text = "Atalho etc";
            this.atalhoEtcToolStripMenuItem.Click += new System.EventHandler(this.atalhoEtcToolStripMenuItem_Click);
            // 
            // menuPosicaoDosObjetos
            // 
            this.menuPosicaoDosObjetos.Name = "menuPosicaoDosObjetos";
            this.menuPosicaoDosObjetos.Size = new System.Drawing.Size(126, 20);
            this.menuPosicaoDosObjetos.Text = "Posicao dos Objetos";
            this.menuPosicaoDosObjetos.Click += new System.EventHandler(this.menuPosicaoDosObjetos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Opçoes na MessageBox.Show";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuString;
        private System.Windows.Forms.ToolStripMenuItem menuTitulo;
        private System.Windows.Forms.ToolStripMenuItem butoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuButoesOK;
        private System.Windows.Forms.ToolStripMenuItem menuAbortRetryIgnore;
        private System.Windows.Forms.ToolStripMenuItem menuButoesOKCancel;
        private System.Windows.Forms.ToolStripMenuItem menuRetryCancel;
        private System.Windows.Forms.ToolStripMenuItem menButoesSimNao;
        private System.Windows.Forms.ToolStripMenuItem menuButoesSimNaoCancelar;
        private System.Windows.Forms.ToolStripMenuItem iconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuIconsInformacao;
        private System.Windows.Forms.ToolStripMenuItem menuIconsErro;
        private System.Windows.Forms.ToolStripMenuItem menuIconsNenhum;
        private System.Windows.Forms.ToolStripMenuItem menuIconsPergunta;
        private System.Windows.Forms.ToolStripMenuItem menuIconsAviso;
        private System.Windows.Forms.ToolStripMenuItem atalhoEtcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPosicaoDosObjetos;
    }
}

