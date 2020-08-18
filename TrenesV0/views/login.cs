using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrenesV0.controllers;
using TrenesV0.models;
using TrenesV0.views;
using Menu = TrenesV0.views.Menu;

namespace TrenesV0
{
    public partial class Login : Form
    {
        //variable global con el rut del usuario
        public static string SetValueFortxtUsuario = "";
        public Sistema system;
        public Login()
        {
            InitializeComponent();
            system = new Sistema();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLoggin.Enabled = false;
            btnAdminLogin.Enabled = false;
            txtPass.Enabled = false;
        }
        //boton de Iniciar sesion
        private void btnLoggin_Click(object sender, EventArgs e)
        {
            if (SQLiteDataAccess.getUser(txtUsuario.Text)!=null)
            {
                if (system.verificarUser(txtUsuario.Text,txtPass.Text))
                {
                    errorProvider2.SetError(btnLoggin, "");
                    this.Hide();
                    using (Menu menuWindow = new Menu())
                    {
                        menuWindow.hideAdminButton();
                        menuWindow.ShowDialog();
                    }
                }
                else
                {
                    errorProvider2.SetError(btnLoggin, "Error, usuario y/o contraseña incorrecta");
                }

            }
            else
            {
                errorProvider2.SetError(btnLoggin, "Error usuario incorrecto");
            }
           

        }
        //chequeo de password, cambiar a bcrypt cuando se implemente
        private Boolean loggUser(User user)
        {
            return (user.password == txtPass.Text);
        }

        private Boolean loggAdmin(Admin user)
        {
            return (user.password == txtPass.Text);
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            btnControl(txtUsuario);
            if (txtUsuario.Text != string.Empty)
            {
                txtPass.Enabled = true;
            }
            else
            {
                txtPass.Enabled = false;
            }
        }

        private void btnControl(TextBox textBox)
        {
            if(textBox.Text!= string.Empty)
            {
                errorHandler(false, textBox);
            }
            else
            {
                errorHandler(true, textBox);
            }
        }
        //handler de errores
        private void errorHandler(Boolean estado, TextBox textbox)
        {
            if (!estado)
            {
                errorProvider1.SetError(textbox, "");
            }
            else
            {
                errorProvider1.SetError(textbox, "No puede estar vacio.");
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            btnControl(txtPass);
            if (txtPass.Text != string.Empty)
            {
                btnLoggin.Enabled = true;
                btnAdminLogin.Enabled = true;
            }
            else
            {
                btnLoggin.Enabled = false;
                btnAdminLogin.Enabled = false;
            }

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (SQLiteDataAccess.getUser(txtUsuario.Text) != null)
            {
                Admin user = SQLiteDataAccess.getAdmin(txtUsuario.Text);
                if (loggAdmin(user))
                {
                    SetValueFortxtUsuario = txtUsuario.Text;
                    errorProvider2.SetError(btnLoggin, "");
                    this.Hide();
                    using (views.Menu menuWindow = new views.Menu())
                    {
                        menuWindow.ShowDialog();
                    }
                }
                else
                {
                    errorProvider2.SetError(btnAdminLogin, "Error contraseña incorrecta");
                }
            }
            else
            {
                errorProvider2.SetError(btnAdminLogin, "Error usted no es administrador");
            }
        }
    }
    
}
