using OOOPrintedFamily.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOPrintedFamily
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = ColorTranslator.FromHtml("#34C6CD");
            tableLayoutPanelBottom.BackColor = ColorTranslator.FromHtml("#34C6CD");
            tableLayoutPanel1.BackColor = Color.White;
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы вошли как гость", "Авторизация");
            Helper.roleID = 4;
            this.Hide();
            new View.Catalog(this).ShowDialog();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAutorisation_Click(object sender, EventArgs e)
        {
            var name = Helper.DBContext.User.Where(x => x.UserLogin == textBoxLogin.Text && x.UserPassword == textBoxPassword.Text).FirstOrDefault();
            if (name != null)
            {

                MessageBox.Show($"Вы вошли под: {name.UserSurname} {name.UserName} {name.UserPatronymic} \n\nВаша роль: {name.Role.RoleName}", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Helper.roleID = name.RoleId;
                Helper.fullName = name.UserSurname + " " + name.UserName + " " + name.UserPatronymic;
                this.Hide();
                new Catalog(this).ShowDialog();

            }
            else
            {
                MessageBox.Show("Данные введены не верно", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы дейтвительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
             
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
