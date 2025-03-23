using System;
using System.Windows.Forms;

namespace SimpleRegistration
{
    public partial class Form1 : Form
    {
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button btnSubmit;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Form components
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.rbMale = new RadioButton();
            this.rbFemale = new RadioButton();
            this.btnSubmit = new Button();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(100, 20);
            this.txtName.Size = new System.Drawing.Size(150, 20);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 50);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(100, 50);
            this.txtEmail.Size = new System.Drawing.Size(150, 20);

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 80);
            this.lblPhone.Text = "Phone:";

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(100, 80);
            this.txtPhone.Size = new System.Drawing.Size(150, 20);

            // rbMale
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(100, 110);
            this.rbMale.Text = "Male";
            this.rbMale.Checked = true;

            // rbFemale
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(170, 110);
            this.rbFemale.Text = "Female";

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(100, 140);
            this.btnSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(280, 180);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.btnSubmit);
            this.Text = "Registration";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get gender selection
            string gender = rbMale.Checked ? "Male" : "Female";

            // Prepare registration details message
            string details = $"Name: {txtName.Text}\nEmail: {txtEmail.Text}\nPhone: {txtPhone.Text}\nGender: {gender}";

            // Display registration details in a message box
            MessageBox.Show(details, "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}