using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CustomRoundedButton;

namespace Calculator
{
    public static class Tools
    {
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int Iparam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
        const int WM_NCLBUTTOMDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        public static void Move_Form(this Control control, IntPtr Handle)
        {
            control.MouseMove += new MouseEventHandler(Move);
            void Move(object sender , MouseEventArgs e)
            {
                if(e.Button==MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTOMDOWN, HT_CAPTION, 0);
                }

            }
        }
        static double Add(double firstNum,double secondNum)
        {
            return firstNum + secondNum;
        }
        static double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        static double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
        static double Square(double num)
        {
            return num *num;
        }
        static double SQRT(double num)
        {
            return Math.Sqrt(num) ;
        }
        static double Reciprocal(double num)
        {
            return 1/num;
        }
        public static double Percentage(double num, double percentage)
        {
            return num *percentage/100;
        }
        public static string Get_Symbol(this Operation operation)
        {
            switch (operation)
            {
                case Operation.Add: return "+";
                case Operation.Subtract: return "-";
                case Operation.Multiply: return "×";
                case Operation.Divide: return "÷";
                case Operation.Square: return "^2";
                case Operation.SQRT: return "√";
                case Operation.Reciprocal: return "1/";
                default: return string.Empty;
            }
        }
        public static double Calculate(this Operation operation, string firstNum,string secondNum,TextBox operationDisplay)
        {
            double result = 0;
            double num1=double.Parse(firstNum);
            double num2=double.Parse(secondNum);
            switch (operation)
            {
                case Operation.Add:
                    {
                        result = Add(num1,num2);
                        break;
                    }
                case Operation.Subtract:
                    {
                        result = Subtract(num1, num2);
                        break;
                    }
                case Operation.Multiply:
                    {
                        result = Multiply(num1, num2);
                        break;
                    }
                case Operation.Divide:
                    {
                        result = Divide(num1, num2);
                        break;
                    }
                case Operation.Square:
                    {
                        result = Square(num1);
                        break;
                    }
                case Operation.SQRT:
                    {
                        result = SQRT(num1);
                        break;
                    }
                case Operation.Reciprocal:
                    {
                        result = Reciprocal(num1);
                        break;
                    }
            }
            operationDisplay.Text = Operation_Display_WithResult(firstNum, operation, secondNum, result.ToString());
            return result;
        }
        public static void Operation_Display(this TextBox textBox, string firstNum, Operation operation) 
        {
            string displayText=string.Empty;
            if (operation == Operation.SQRT || operation == Operation.Reciprocal) 
            {
                displayText = $"{operation.Get_Symbol()}{ firstNum}";
            }
            else    
                displayText=$"{firstNum}{operation.Get_Symbol()}";
            textBox.Text = displayText ;
            
        }
        public static string Operation_Display_WithResult(string firstNum, Operation operation,string secondNum, string result) 
        {
            string displayText=string.Empty;
            if (operation == Operation.Square)
                displayText = $"{firstNum} {operation.Get_Symbol()} = {result}";
            else if (operation == Operation.SQRT)
                displayText = $"{operation.Get_Symbol()}{firstNum} = {result}";
            else if (operation == Operation.Reciprocal)
                displayText = $"{operation.Get_Symbol()}({firstNum})= {result}";
            else
                displayText = $"{firstNum} {operation.Get_Symbol()} {secondNum}= {result}";
            return displayText ;
        }
        public static async void Animate_Panel(this Panel pnl)
        {
            int initialHight=pnl.Height;
            int finlHight = 320;
            const int AnimationDuration = 120;
            const int Steps = 12;
            int deltaHight=(finlHight-initialHight) / Steps;
            int interval = AnimationDuration / Steps;
            for (int i = 0; i < Steps; i++) 
            {
                pnl.Height += deltaHight;
                await Task.Delay(interval);
            }
            pnl.Height = finlHight;
        }
        public static void RichTextBox_Settings(this RichTextBox richTextBox, Panel pnl)
        {
            pnl.Controls.Add(richTextBox);
            pnl.BringToFront();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.BackColor = Color.FromArgb(23, 19, 19);
            richTextBox.BorderStyle= BorderStyle.None;
            richTextBox.ReadOnly = true;
        }
        public static void Display_panel(this Panel pnl, RichTextBox textBox)
        {
            pnl.Animate_Panel();
            pnl.BackColor = Color.FromArgb(23, 19, 19);
            foreach (Control control in pnl.Controls.OfType<RichTextBox>())
            {
                control.Hide();
            }
            textBox.Show();
        }
        public static void Hide_Panel(this Panel pnl) 
        {
            pnl.Height=1;
        }
        public static void Show_Memory(this RichTextBox textBox, string memory)
        {
            textBox.Font=new Font("Swgoe UI",28,FontStyle.Bold);
            textBox.ForeColor = Color.WhiteSmoke;
            textBox.Text = memory;
            textBox.SelectionAlignment = HorizontalAlignment.Right;
        }
        public static void Show_History(this RichTextBox textBox, string firstNum,string secondNum,string result, Operation operation)
        {
            textBox.SelectionAlignment= HorizontalAlignment.Right;
            Font font1 = new Font("Swgeo UI", 12);
            Font font2=new Font("Swgeo UI",18 ,FontStyle.Bold);
            textBox.SelectionFont = font1;
            textBox.SelectionColor = Color.Gray;
            string line1=string.Empty;
            if (operation == Operation.Square) line1 = $"{firstNum} {operation.Get_Symbol()} = ";
            else if (operation == Operation.SQRT) line1 = $"{operation.Get_Symbol()}{firstNum} = ";
            else if (operation == Operation.Reciprocal) line1 = $"{operation.Get_Symbol()}({firstNum}) = ";
            else line1 = $"{firstNum} {operation.Get_Symbol()} {secondNum} = ";
            textBox.SelectedText=Environment.NewLine+ line1 + Environment.NewLine;
            textBox.SelectionFont=font2;
            textBox.SelectionColor = Color.White;
            textBox.SelectedText = result + Environment.NewLine;
        }
        public static void Add_ClearButton(this RichTextBox textBox,Panel pnl)
        {
            RoundedButton clearButton=new RoundedButton();
            clearButton.Text = string.Empty;
            clearButton.Image = Calculator.Properties.Resources.clear;
            clearButton.Size= new Size(30,30);
            clearButton.BackColor = Color.FromArgb(23, 19, 19);
            clearButton.BorderRadius = 2;
            clearButton.Click += new EventHandler(ClearButton_Click);
            void ClearButton_Click(object sender, EventArgs e)
            {
                textBox.Clear();
                pnl.Hide_Panel();
            }
            textBox.Controls.Add(clearButton);
            clearButton.Dock = DockStyle.None;

            int lastCharIndex = textBox.TextLength > 0 ? textBox.TextLength - 1 : 0;
            Point lastCharPos = textBox.GetPositionFromCharIndex(lastCharIndex);

            clearButton.Location = new Point(
                Math.Max(0, lastCharPos.X),
                lastCharPos.Y + 25
            );

            clearButton.Show();

        }
    }
    public enum Operation
    {
        Add, Subtract, Multiply, Divide, Square, SQRT, Reciprocal

    }
}