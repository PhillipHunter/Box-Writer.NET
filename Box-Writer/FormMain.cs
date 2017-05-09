using System;
using System.Windows.Forms;

namespace Box_Writer
{
    public partial class FormMain : Form
    {
        BoxWriter _BoxWriter;
        Random _Random = new Random();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBoxify_Click(object sender, EventArgs e)
        {
            _BoxWriter = new BoxWriter(txtWord.Text, txtLabel.Text);

            int spacing;
            if (Int32.TryParse(txtSpacing.Text, out spacing))
            {
                _BoxWriter.SetSpacing(spacing);
            }

            int offset;
            if (Int32.TryParse(txtOffset.Text, out offset))
            {
                _BoxWriter.SetSpacing(offset);
            }

            _BoxWriter.Boxify();

            rtxtBox.Text = _BoxWriter.ToString();

            int i = _Random.Next(4);
            if (i == 0)
                lblText.Text = "Boxes are the future.";
            else if (i == 1)
                lblText.Text = "Why are you even using this?";
            else if (i == 2)
                lblText.Text = "ayy lmao";
            else if (i == 3)
                lblText.Text = txtWord.Text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtBox.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtWord.Text = txtLabel.Text = txtSpacing.Text = txtOffset.Text = rtxtBox.Text 
                = String.Empty;            
        }
    }
}
