using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingApp
{
    public partial class Form1 : Form
    {
    //useless shit i can't get rid of without breaking everything
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        account thisUser;
    //declare global lists
        List<Panel> panelList = new List<Panel>();
        List<account> accountList = new List<account>();
    //on boot
        public Form1()
        {
            InitializeComponent();
            LoginPanel.Visible = true;
            newAccountPanel.Visible = false;
            JoinHousePanel.Visible = false;
            panelList.Add(LoginPanel);
            panelList.Add(newAccountPanel);
            panelList.Add(JoinHousePanel);
        }
        public class account
        {
            private string username = "";
            public string password = "";
            private string type = "";
            public void newAccount (string newUsername, string newPassword, string newType)
            {
                username = newUsername;
                password = newPassword;
                type = newType;
            }
            public string getUsername()
            {
                return username;
            }
            public bool checkPassword (string attempt)
            {
                if (attempt == password)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            public string getType()
            {
                return type;
            }
        }
        public class house
        {
            //house
        }
    //declare functions
        void switchPanel(Panel newPanel)
        {
            foreach (Panel x in panelList)
            {
                x.Visible = false;
            }
            newPanel.Visible = true;
        }
        //on button press
        private void button2_Click(object sender, EventArgs e)
        {
            switchPanel(newAccountPanel);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool login = false;
            foreach (account x in accountList)
            {
                if (usernameInput.Text == x.getUsername() && x.checkPassword(passwordInput.Text))
                {
                    login = true;
                    thisUser = x;
                }
            }
            if (login)
            {
                if (thisUser.getType() == "Resident")
                {
                    switchPanel(JoinHousePanel);
                } else if (thisUser.getType() == "Admin")
                {
                    switchPanel(AdminMainMenuPanel);
                }
                else
                {
                    MessageBox.Show("User Type Error");
                }
            }
            else
            {
                MessageBox.Show("wrong info dipshit");
            }
        }
        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            switchPanel(LoginPanel);
        }
        private void makeAccountButton_Click(object sender, EventArgs e)
        {
            if (newUsernameTextbox.Text != "" && newPasswordTextbox.Text != "" && AccountTypeBox.Text != "")
            {
                account x = new account();
                x.newAccount(newUsernameTextbox.Text, newPasswordTextbox.Text, AccountTypeBox.Text);
                accountList.Add(x);
                switchPanel(LoginPanel);
            } else
            {
                MessageBox.Show("Fill in all the spaces dumbshit");
            }
        }
        private void JoinButton_Click(object sender, EventArgs e)
        {
            //join button
        }

        private void JoinHousePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
//deez nuts