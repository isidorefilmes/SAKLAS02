using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

/* 
 * Este formulário não tem nenhuma borda clássica window. 
 * Consequentemente, os botões foram inseridos como imagens interativas.
 */

namespace SAKLAS02
{
    public partial class Form1 : Form
    {
        #region Definindo nomes para botoes Max, Min, Norm
        //=============================================
        string pasta_images = "";

        Image img_close_normal;
        Image img_close_high;
        Image img_mini_normal;
        Image img_mini_high;
        Image img_maxi_normal;
        Image img_maxi_high;
        Image img_norm_normal;
        Image img_norm_high;

        //=============================================
        #endregion

        public Form1()
        {

        #region Iniciando componentes dos Botoes Max, Min, Norm
            //=============================================
            InitializeComponent();
            pasta_images = Application.StartupPath + @"\images\";

            img_close_normal = Image.FromFile(pasta_images + "clos02.png");
            img_close_high = Image.FromFile(pasta_images + "clos02a.png");

            img_mini_normal = Image.FromFile(pasta_images + "min02.png");
            img_mini_high = Image.FromFile(pasta_images + "min02a.png");

            img_maxi_normal = Image.FromFile(pasta_images + "max02.png");
            img_maxi_high = Image.FromFile(pasta_images + "max02a.png");

            img_norm_normal = Image.FromFile(pasta_images + "nor02.png");
            img_norm_high = Image.FromFile(pasta_images + "nor02a.png");

            //=============================================
            #endregion

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            #region Definindo Imagebox Normal
            //=============================================
            btnclos.BackgroundImage = img_close_normal;
            btnmin.BackgroundImage = img_mini_normal;
            btnmax.BackgroundImage = img_maxi_normal;
            btnnor.BackgroundImage = img_norm_normal;
            //=============================================
            #endregion

        }

        #region PROPRIEDADES DOS BOTOES MAX, MIN, NORM
        //=============================================

        private void btnclos_MouseEnter(object sender, EventArgs e)
        {
            btnclos.BackgroundImage = img_close_high;
        }

        private void btnclos_MouseLeave(object sender, EventArgs e)
        {
            btnclos.BackgroundImage = img_close_normal;
        }

        private void btnclos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_MouseEnter(object sender, EventArgs e)
        {
            btnmin.BackgroundImage = img_mini_high;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmin_MouseLeave(object sender, EventArgs e)
        {
            btnmin.BackgroundImage = img_mini_normal;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmax.Visible = false;
            btnnor.Visible = true;
        }

        private void btnnor_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnnor.Visible = false;
            btnmax.Visible = true;
        }

        private void btnmax_MouseEnter(object sender, EventArgs e)
        {
            btnmax.BackgroundImage = img_maxi_high;
        }

        private void btnmax_MouseLeave(object sender, EventArgs e)
        {
            btnmax.BackgroundImage = img_maxi_normal;
        }

        private void btnnor_MouseEnter(object sender, EventArgs e)
        {
            btnnor.BackgroundImage = img_norm_high;
        }

        private void btnnor_MouseLeave(object sender, EventArgs e)
        {
            btnnor.BackgroundImage = img_norm_normal;
        }

        //=============================================
        #endregion

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void splash_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
