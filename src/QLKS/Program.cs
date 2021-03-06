﻿using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    static class Program
    {
        public static NguoiDung CurrentUser { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmDangNhap fLogin = new frmDangNhap();
                if (fLogin.ShowDialog() == DialogResult.OK)
                {
                    CurrentUser = fLogin.CurrentUser;
                    Application.Run(new frmMain());
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Utils.Log.Error(ex);
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
