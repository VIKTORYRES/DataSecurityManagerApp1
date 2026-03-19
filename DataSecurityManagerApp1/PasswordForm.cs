using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurityManagerApp1
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;

    namespace DataSecurityManagerApp1
    {
        public class PasswordForm : Form
        {
            public TextBox passwordTextBox;
            public Button okButton;
            public Button cancelButton;
            public string Password { get; private set; }

            public PasswordForm()
            {
                this.Text = "Введите пароль";
                this.Width = 300;
                this.Height = 150;
                CreateControls();
            }

            private void CreateControls()
            {
                passwordTextBox = new TextBox
                {
                    Location = new Point(10, 20),
                    Size = new Size(260, 20),
                    UseSystemPasswordChar = true
                };

                okButton = new Button
                {
                    Location = new Point(10, 50),
                    Text = "OK",
                    Size = new Size(75, 25)
                };

                okButton.Click += (sender, e) =>
                {
                    Password = passwordTextBox.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                };

                cancelButton = new Button
                {
                    Location = new Point(95, 50),
                    Text = "Отмена",
                    Size = new Size(75, 25)
                };

                cancelButton.Click += (sender, e) =>
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                };

                this.Controls.Add(passwordTextBox);
                this.Controls.Add(okButton);
                this.Controls.Add(cancelButton);
            }
        }
    }
}
