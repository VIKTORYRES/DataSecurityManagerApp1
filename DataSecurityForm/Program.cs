namespace DataSecurityForm
{
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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataSecurityForm());
        }
    }
}