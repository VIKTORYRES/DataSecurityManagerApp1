namespace DataSecurityManagerApp1
{
<<<<<<< HEAD
    public class PasswordForm : Form
    {
        private TextBox passwordTextBox;
        private Button okButton;
        private Button cancelButton;
        public string Password { get; private set; }
        public PasswordForm()
=======
    public partial class Form1 : Form
    {
        public Form1()
>>>>>>> 52e2f595ab62c58a00db7f16a7ce135a604e908a
        {
            this.Text = "Введите пароль";
            this.Width = 300;
            this.Height = 100;
            CreateControls();
        }
        private void CreateControls()
        {
            passwordTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 20),
                Size = new System.Drawing.Size(260, 20),
                UseSystemPasswordChar = true
            };
            okButton = new Button
            {
                Location = new System.Drawing.Point(10, 50),
                Text = "OK",
                Size = new System.Drawing.Size(75, 25)
            };
            okButton.Click += (sender, e) =>
            {
                Password = passwordTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            };
            cancelButton = new Button
            {
                Location = new System.Drawing.Point(95, 50),
                Text = "Отмена",
                Size = new System.Drawing.Size(75, 25)
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
    public class DataSecurityForm : Form
    {
        private DataSecurityManager dataSecurityManager;
        private Button encryptButton;
        private Button decryptButton;
        public DataSecurityForm()
        {
            this.Text = "Управление безопасностью данных";
            this.Width = 300;
            this.Height = 150;
            CreateControls();
            dataSecurityManager = new DataSecurityManager();
        }
        private void CreateControls()
        {
            encryptButton = new Button
            {
                Location = new System.Drawing.Point(10, 20),
                Text = "Зашифровать файл",
                Size = new System.Drawing.Size(120, 25)
            };
            encryptButton.Click += (sender, e) => dataSecurityManager.EncryptFile();
            decryptButton = new Button
            {
                Location = new System.Drawing.Point(140, 20),
                Text = "Расшифровать файл",
                Size = new System.Drawing.Size(120, 25)
            };
            decryptButton.Click += (sender, e) => dataSecurityManager.DecryptFile();
            this.Controls.Add(encryptButton);
            this.Controls.Add(decryptButton);
        }
       
    }
}
