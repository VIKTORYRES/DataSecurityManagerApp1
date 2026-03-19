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
        public class DataSecurityForm : Form
        {
            public DataSecurityManager dataSecurityManager;
            public Button encryptButton;
            public Button decryptButton;

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
                    Location = new Point(10, 20),
                    Text = "Зашифровать файл",
                    Size = new Size(120, 25)
                };

                encryptButton.Click += (sender, e) => dataSecurityManager.EncryptFile();

                decryptButton = new Button
                {
                    Location = new Point(140, 20),
                    Text = "Расшифровать файл",
                    Size = new Size(120, 25)
                };

                decryptButton.Click += (sender, e) => dataSecurityManager.DecryptFile();

                this.Controls.Add(encryptButton);
                this.Controls.Add(decryptButton);
            }
        }
    }
}
