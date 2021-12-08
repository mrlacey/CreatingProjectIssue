using System;
using System.Windows.Forms;

namespace MyProjectWizard
{
    public partial class UserInputForm : Form
    {
        private static string customMessage;
        private TextBox textBox1;
        private Button button1;

        public UserInputForm()
        {
            this.Size = new System.Drawing.Size(400, 400);

            button1 = new Button();
            button1.Location = new System.Drawing.Point(180, 50);
            button1.Size = new System.Drawing.Size(100, 50);
            button1.Text = "Submit";
            button1.Click += button1_Click;
            this.Controls.Add(button1);

            textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(20, 50);
            textBox1.Size = new System.Drawing.Size(140, 40);
            this.Controls.Add(textBox1);
        }
        public static string CustomMessage
        {
            get
            {
                return customMessage;
            }
            set
            {
                customMessage = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            customMessage = textBox1.Text;
            this.Close();
        }
    }
}