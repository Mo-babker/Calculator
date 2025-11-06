using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlTop.Move_Form(Handle);
            txtResultDisplay.SelectionStart = 0;
            historyTextBox.RichTextBox_Settings(pnlText);
            memoryTextBox.RichTextBox_Settings(pnlText);
            historyTextBox.Add_ClearButton(pnlText);
        }
        bool operationStarted=false;
        string firstNum =string.Empty;
        string secondNum=string.Empty;
        string result  =string.Empty;
        string memory = string.Empty;
        Operation Operation { get; set; }
        RichTextBox historyTextBox= new RichTextBox();
        RichTextBox memoryTextBox = new RichTextBox();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
            else WindowState = FormWindowState.Maximized;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(200, 44, 20);
        }

        private void btnMaximize_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(45, 40, 40);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void txtResultDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton23_Click(object sender, EventArgs e)
        {
            txtResultDisplay.Text = "0";
        }

        private void roundedButton26_Click(object sender, EventArgs e)
        {

        }

        private void NumButtons_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "." && txtResultDisplay.Text.Contains(".")) return;
            if (txtResultDisplay.Text == "0") txtResultDisplay.Text = string.Empty;
            if (operationStarted) txtResultDisplay.Text = ((Button)sender).Text;
            else txtResultDisplay.Text += ((Button)sender).Text;
            operationStarted = false;

        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memory=string.Empty;
            btnMemoryClear.Enabled = false;
            btnMRecall.Enabled = false;
            btnShowMemory.Enabled = false;
            memoryTextBox.Clear();
            pnlText.Hide_Panel();
        }

        private void Operations_MouseDown(object sender, MouseEventArgs e)
        {
            firstNum=txtResultDisplay.Text;
            operationStarted = true;
            txtOperationDisplay.Operation_Display(firstNum, Operation); 
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(txtResultDisplay.Text.Length> 0) txtResultDisplay.Text=txtResultDisplay.Text.Substring(0,txtResultDisplay.Text.Length-1);
            if (txtResultDisplay.Text == string.Empty) txtResultDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultDisplay.Text = "0";
            txtOperationDisplay.Text= string.Empty;
            firstNum = string.Empty;
            secondNum = string.Empty;
            result = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(firstNum != string.Empty) 
            {
                secondNum = txtResultDisplay.Text;
                result= Tools.Calculate(Operation,firstNum,secondNum,txtOperationDisplay).ToString();
                txtResultDisplay.Text = result;
                firstNum = result;
                historyTextBox.Show_History(firstNum,secondNum,result,Operation);
            }
            else
            {
                txtResultDisplay.Text = "0";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operation = Operation.Add;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Operation= Operation.Subtract;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operation= Operation.Multiply;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operation= Operation.Divide;
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            Operation= Operation.SQRT;
        }

        private void btnSqure_Click(object sender, EventArgs e)
        {
            Operation = Operation.Square;
        }

        private void btnReciprecal_Click(object sender, EventArgs e)
        {
            Operation=Operation.Reciprocal;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double num= double.Parse(firstNum);
            double percentage= double.Parse(txtResultDisplay.Text);
            secondNum=Tools.Percentage(num,percentage).ToString();

        }

        private void btnNagate_Click(object sender, EventArgs e)
        {
            txtResultDisplay.Text=(-1* double.Parse(txtResultDisplay.Text)).ToString();
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memory=txtResultDisplay.Text;
            btnMemoryClear.Enabled = true;
            btnMemorySave.Enabled = true;
            btnMRecall.Enabled = true;
            btnShowMemory.Enabled = true;
        }
        bool memoryPanelOn = false;
        private void btnShowMemory_Click_1(object sender, EventArgs e)
        {
            if (!memoryPanelOn)
            {
                memoryTextBox.Clear();
                pnlText.Display_panel(memoryTextBox);
                memoryTextBox.Show_Memory(memory);
                memoryPanelOn = true;
            }
            else
            {
                pnlText.Hide_Panel();
                memoryPanelOn = false;
            }

        }

        private void txtResultDisplay_Click(object sender, EventArgs e)
        {
            pnlText.Hide_Panel();
        }

        private void btnMRecall_Click(object sender, EventArgs e)
        {
            txtResultDisplay.Text = memory;
        }
        double memoryTemp = 0;
        bool memorySet = false;
        private void btnMAdd_Click(object sender, EventArgs e)
        {
            memoryTextBox.Clear();
            double mem= double.Parse(memory);
            if(!memorySet)
            {
                memoryTemp = mem;
                memorySet = true;
            }
            double res = mem + memoryTemp;
            memory=res.ToString();
            memoryTextBox.Show_Memory(memory);

        }

        private void btnMSubtract_Click(object sender, EventArgs e)
        {
            double mem = double.Parse(memory);
            if (!memorySet)
            {
                memoryTemp = mem;
                memorySet = true;
            }
            double res = mem - memoryTemp;
            memory = res.ToString();
            memoryTextBox.Show_Memory(memory);

        }
        bool historyPanelOn=false;
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if(!historyPanelOn)
            {
                pnlText.Display_panel(historyTextBox);
                historyPanelOn = true;
            }
            else
            {
                pnlText.Hide_Panel();
                historyPanelOn = false;
            }

        }
    }
}
