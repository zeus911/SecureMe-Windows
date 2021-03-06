﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SecureMe
{
    /// <summary>
    /// Interaction logic for PasswdChange.xaml
    /// </summary>
    public partial class PasswdChange : Window
    {
        public PasswdChange()
        {
            InitializeComponent();
        }

        private void SetPasswdBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            SetPasswdBtn.Source = new BitmapImage(new Uri(@"pack://application:,,,/Images/Green_Arrow_Glow.png"));
        }

        private void SetPasswdBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            SetPasswdBtn.Source = new BitmapImage(new Uri(@"pack://application:,,,/Images/Green_Arrow.png"));
        }

        private void SetPasswdBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (SetPasswdBox.Password == "" || SetPasswdBox.Password == " ")
            {
                MessageBox.Show("Please enter a password first!");
            }
            else
            {
                string usr = MainWindow.PasswordChangeUser;
                funclib.AdminEx("net user " + usr + " " + SetPasswdBox.Password);
                MessageBox.Show("Password set!");
                this.Close();
            }
        }

        private void SetPasswdBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (SetPasswdBox.Password == "" || SetPasswdBox.Password == " ")
                {
                    MessageBox.Show("Please enter a password first!");
                }
                else
                {
                    string usr = MainWindow.PasswordChangeUser;
                    funclib.AdminEx("net user " + usr + " " + SetPasswdBox.Password);
                    MessageBox.Show("Password set!");
                    this.Close();
                }
            }
            else
            {
                ;
            }
        }
    }
}
