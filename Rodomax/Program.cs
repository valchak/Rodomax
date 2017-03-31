using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using UI;
using Repositorio;

namespace Rodomax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frmUsuario());

            
            LoginForm telaLogin = new LoginForm();


            if (telaLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Principal());
            }
            

        }
    }
}
