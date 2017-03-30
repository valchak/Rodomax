﻿using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Rodomax
{
    public class Formatacao
    {

        public static void MoedaCampo(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {

                n = txt.Text.Replace(",", "").Replace(".", "");

                if (n.Equals(""))
                {
                    n = "";
                }
                n = n.PadLeft(3, '0');
                if ((n.Length > 3) & n.Substring(0, 1) == "0")
                {
                    n = n.Substring(1, n.Length - 1);
                }
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void SoNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 109)
            {
                e.Handled = true;
            }
        }

        public static double StringToDouble(string txt)
        {
            txt = txt.Replace(".", "").Replace(",", ".");
            return double.Parse(txt) / 100;
        }

        public static string DoubleToString(double valor)
        {
            return String.Format(CultureInfo.InvariantCulture, "{0:0.0,0}", valor);
        }

        public static string IntToString(int valor)
        {
            return String.Format(CultureInfo.InvariantCulture, "{0:0}", valor);
        }

        public static DialogResult MensagemInserir()
        {
            return MessageBox.Show("Deseja realmente salvar esse item?", "Confirmação", MessageBoxButtons.YesNo);
        }

        public static DialogResult MensagemExcluir()
        {
            return MessageBox.Show("Deseja realmente exlcuir esse item?", "Excluir Item", MessageBoxButtons.YesNo);
        }


        public string CriptoSenha(string password)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

    }
}
