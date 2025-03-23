using System;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        private TextBox txtInput;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Form components
            this.txtInput = new TextBox();
            this.txtResult = new TextBox();
            this.btnAdd = new Button();
            this.btnSubtract = new Button();
            this.btnMultiply = new Button();
            
            // txtInput
            this.txtInput.Location = new System.Drawing.Point(20, 20);
            this.txtInput.Size = new System.Drawing.Size(150, 20);
            this.txtInput.Name = "txtInput";
            
            // txtResult
            this.txtResult.Location = new System.Drawing.Point(20, 50);
            this.txtResult.Size = new System.Drawing.Size(150, 20);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            
            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(20, 90);
            this.btnAdd.Size = new System.Drawing.Size(40, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            
            // btnSubtract
            this.btnSubtract.Location = new System.Drawing.Point(70, 90);
            this.btnSubtract.Size = new System.Drawing.Size(50, 30);
            this.btnSubtract.Text = "Sub";
            this.btnSubtract.Click += new EventHandler(this.btnSubtract_Click);
            
            // btnMultiply
            this.btnMultiply.Location = new System.Drawing.Point(130, 90);
            this.btnMultiply.Size = new System.Drawing.Size(40, 30);
            this.btnMultiply.Text = "Mul";
            this.btnMultiply.Click += new EventHandler(this.btnMultiply_Click);
            
            // Form1
            this.ClientSize = new System.Drawing.Size(190, 140);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Text = "Simple Calculator";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(txtInput.Text);
                txtResult.Text = (num + num).ToString();
            }
            catch
            {
                txtResult.Text = "Invalid input";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(txtInput.Text);
                txtResult.Text = (num - num).ToString();
            }
            catch
            {
                txtResult.Text = "Invalid input";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(txtInput.Text);
                txtResult.Text = (num * num).ToString();
            }
            catch
            {
                txtResult.Text = "Invalid input";
            }
        }
    }
}