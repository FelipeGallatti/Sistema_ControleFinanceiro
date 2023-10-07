using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Financeiro
{
    public partial class FormLogin : Form
    {
        NEGOCIOS.NEG_LOGIN_USUARIO ObjNeg_Login = new NEGOCIOS.NEG_LOGIN_USUARIO();
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjNeg_Login.VerificaLogin(txtUsuario.Text, txtSenha.Text))
                {
                    // Crie uma instância do FormPrincipal
                    Form1 formPrincipal = new Form1();

                    // Mostre o FormPrincipal
                    formPrincipal.Show();
                    this.Hide();

                    // Feche o FormLogin

                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
