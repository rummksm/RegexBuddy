using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexBuddy {
    public partial class Form1 : Form {
        public Form1() {       
            InitializeComponent();
        }
        enum LastColor {
            Yellow,
            Green
        }

        private void btn_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        private void tb_InputText_TextChanged(object sender, EventArgs e) {
            SelectText(tb_InputText);
        }
        private void SelectText(object obj) {
            tb_InputText.SelectionStart = 0;
            tb_InputText.SelectionLength = tb_InputText.Text.Length;
            tb_InputText.SelectionBackColor = Color.White;
            tb_InputText.SelectionStart = tb_InputText.Text.Length;
            tb_InputText.SelectionLength = 0;
            tb_InputText.Focus();
            string inputExpression = @tb_InputRegularExpression.Text;
            string inputText = tb_InputText.Text;
            var regex = new Regex(inputExpression);
            byte lastColor = (byte)LastColor.Green;
            foreach (Match match in regex.Matches(inputText)) {
                if (match.Value != "") {
                    tb_InputText.SelectionStart = match.Index;
                    tb_InputText.SelectionLength = match.Length;
                    if (lastColor == (byte)LastColor.Green) {
                        tb_InputText.SelectionBackColor = Color.Yellow;
                        lastColor = (byte)LastColor.Yellow;
                    }
                    else {
                        tb_InputText.SelectionBackColor = Color.Green;
                        lastColor = (byte)LastColor.Green;
                    }
                }
                tb_InputText.SelectionStart = tb_InputText.Text.Length;
                tb_InputText.SelectionLength = 0;
                tb_InputText.Focus();
            }
            if (obj == tb_InputRegularExpression) {
                tb_InputRegularExpression.SelectionStart = tb_InputRegularExpression.Text.Length;
                tb_InputRegularExpression.SelectionLength = 0;
                tb_InputRegularExpression.Focus();
            }          
        }

        private void tb_InputRegularExpression_TextChanged(object sender, EventArgs e) {
            SelectText(tb_InputRegularExpression);
        }
    }
}
