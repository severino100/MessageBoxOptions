using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxOptions
{
    public partial class Form1 : Form
    {
        public string caminhoBotaoComLigacao = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void menuString_Click(object sender, EventArgs e)
        {
            // String
            //Com isto nós pretendemos apaenas mostrar uma message box com uma string
            MessageBox.Show("Ola eu sou uma sting inutil");
            
        }

        private void menuTitulo_Click(object sender, EventArgs e)
        {
            // Titulo
            //Com isto nós pretendemos mostrar uma message box com uma string mas com um titulo
            MessageBox.Show("Ola eu sou uma sting inutil", "Programaçao para meninos");
        }


        //MessageBox.Show(this, " ms ", "caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button3);
        
        
        
        
        
        private void menuButoesOK_Click(object sender, EventArgs e)
        {
            /* Botao OK
                Aqui queremos que a nossa message box contenha um botao ok  */
            DialogResult result = MessageBox.Show("Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.OK);

             switch (result)
             {
                 case DialogResult.Abort:
                     MessageBox.Show("Voce abortou");
                     break;
                 case DialogResult.Cancel:
                     MessageBox.Show("Voce cancelou");
                     break;
                 case DialogResult.Ignore:
                     MessageBox.Show("Voce ignorou");
                     break;
                 case DialogResult.No:
                     MessageBox.Show("NOOOO");
                     break;
                 case DialogResult.None:
                     MessageBox.Show("None");
                     break;
                 case DialogResult.Retry:
                     MessageBox.Show("Retry");
                     break;
                 case DialogResult.Yes:
                     MessageBox.Show("YEEEES FINALYYYYYYYY!!");
                     break;
                 case DialogResult.OK:
                     MessageBox.Show("cLICOU NO OK");
                     break;
             }
        
        }

        private void menuAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            /* Botao Abort Retry e Ignore
                Aqui queremos que a nossa message box contenha 3 butoes com varias ações  */
            DialogResult result = MessageBox.Show("Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.AbortRetryIgnore);

             switch (result)
             {
                 case DialogResult.Abort:
                     MessageBox.Show("Voce abortou");
                     break;
                 case DialogResult.Cancel:
                     MessageBox.Show("Voce cancelou");
                     break;
                 case DialogResult.Ignore:
                     MessageBox.Show("Voce ignorou");
                     break;
                 case DialogResult.No:
                     MessageBox.Show("NOOOO");
                     break;
                 case DialogResult.None:
                     MessageBox.Show("None");
                     break;
                 case DialogResult.Retry:
                     MessageBox.Show("Retry");
                     break;
                 case DialogResult.Yes:
                     MessageBox.Show("YEEEES FINALYYYYYYYY!!");
                     break;
                 case DialogResult.OK:
                     MessageBox.Show("cLICOU NO OK");
                     break;
             }
        }

        private void menuButoesOKCancel_Click(object sender, EventArgs e)
        {
            /* Botao OK e Cancel
                Aqui queremos que a nossa message box contenha 2 butoes com varias ações  */
            DialogResult result = MessageBox.Show("Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.OKCancel);

            switch (result)
            {
                case DialogResult.Abort:
                    MessageBox.Show("Voce abortou");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Voce cancelou");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("Voce ignorou");
                    break;
                case DialogResult.No:
                    MessageBox.Show("NOOOO");
                    break;
                case DialogResult.None:
                    MessageBox.Show("None");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("Retry");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("YEEEES FINALYYYYYYYY!!");
                    break;
                case DialogResult.OK:
                    MessageBox.Show("cLICOU NO OK");
                    break;
            }
        }

        private void menuRetryCancel_Click(object sender, EventArgs e)
        {
            /* Botao Abort Retry e Cancel
                Aqui queremos que a nossa message box contenha 2 butoes com varias ações  */
            DialogResult result = MessageBox.Show("Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.RetryCancel);

            switch (result)
            {
                case DialogResult.Abort:
                    MessageBox.Show("Voce abortou");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Voce cancelou");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("Voce ignorou");
                    break;
                case DialogResult.No:
                    MessageBox.Show("NOOOO");
                    break;
                case DialogResult.None:
                    MessageBox.Show("None");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("Retry");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("YEEEES FINALYYYYYYYY!!");
                    break;
                case DialogResult.OK:
                    MessageBox.Show("cLICOU NO OK");
                    break;
            }
        }

        private void menButoesSimNao_Click(object sender, EventArgs e)
        {
            /* Botao Abort Sim e Nao
                Aqui queremos que a nossa message box contenha 2 butoes com varias ações  */
            DialogResult result = MessageBox.Show("Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Abort:
                    MessageBox.Show("Voce abortou");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Voce cancelou");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("Voce ignorou");
                    break;
                case DialogResult.No:
                    MessageBox.Show("NOOOO");
                    break;
                case DialogResult.None:
                    MessageBox.Show("None");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("Retry");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("YEEEES FINALYYYYYYYY!!");
                    break;
                case DialogResult.OK:
                    MessageBox.Show("cLICOU NO OK");
                    break;
            }
        }

        private void menuButoesSimNaoCancelar_Click(object sender, EventArgs e)
        {
            /* Botao Sim Nao e Cancel
                Aqui queremos que a nossa message box contenha 3 butoes com varias ações  */
            DialogResult result = MessageBox.Show("Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Abort:
                    MessageBox.Show("Voce abortou");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Voce cancelou");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("Voce ignorou");
                    break;
                case DialogResult.No:
                    MessageBox.Show("NOOOO");
                    break;
                case DialogResult.None:
                    MessageBox.Show("None");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("Retry");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("YEEEES FINALYYYYYYYY!!");
                    break;
                case DialogResult.OK:
                    MessageBox.Show("cLICOU NO OK");
                    break;
            }
        }

        private void atalhoEtcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, 
                                    "Ola eu sou uma sting inutil", 
                                    "Programaçao para meninos", 
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button1, 0, 
                                    @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            switch (result)
            {
                case DialogResult.Abort:
                    MessageBox.Show("Voce abortou");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Voce cancelou");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("Voce ignorou");
                    break;
                case DialogResult.No:
                    MessageBox.Show("NOOOO");
                    break;
                case DialogResult.None:
                    MessageBox.Show("None");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("Retry");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("YEEEES FINALYYYYYYYY!!");
                    break;
                case DialogResult.OK:
                    MessageBox.Show("cLICOU NO OK");
                    break;
            }
        }

        private void menuIconsInformacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, 
                            "Ola eu sou uma sting inutil", 
                            "Programaçao para meninos", 
                            MessageBoxButtons.YesNoCancel, 
                            MessageBoxIcon.Information, 
                            MessageBoxDefaultButton.Button1);
        }

        private void menuIconsErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }

        private void menuIconsNenhum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

        }

        private void menuIconsPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        }

        private void menuIconsAviso_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ola eu sou uma sting inutil", "Programaçao para meninos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

        private void menuPosicaoDosObjetos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, 
                "Ola eu sou uma sting inutil", 
                "Programaçao para meninos", 
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button3, 
                System.Windows.Forms.MessageBoxOptions.RtlReading);
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
