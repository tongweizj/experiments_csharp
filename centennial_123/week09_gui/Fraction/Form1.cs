using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;

namespace Fraction
{
    public partial class Form1 : Form
    {
        public string operation { get; set;}
        public Form1()
        {
            InitializeComponent();
       
            tbFTop.KeyPress += new KeyPressEventHandler(keypressed);
            tbFDown.KeyPress += new KeyPressEventHandler(keypressed);
            tbSTop.KeyPress += new KeyPressEventHandler(keypressed);
            tbSDown.KeyPress += new KeyPressEventHandler(keypressed);

            rdoAdd.CheckedChanged += RadioButton_CheckedChanged;
            rdoDiv.CheckedChanged += RadioButton_CheckedChanged;
            rdoMul.CheckedChanged += RadioButton_CheckedChanged;
            rdoSub.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
 

        }
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    e.Handled = true;
            //}

            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;

        }
        // 事件处理方法
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 将 sender 强制转换为 RadioButton
            if (sender is System.Windows.Forms.RadioButton selectedRadioButton && selectedRadioButton.Checked)
            {
                // 输出选中的 RadioButton 的名称
                operation = selectedRadioButton.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
     
            DoCalculation();
        }
        private void DoCalculation()
        {
            // 3. 获得数学法则
            // Check of the raiser of the event is a checked Checkbox.
            // Of course we also need to to cast it first.
  
            switch (operation)
            {
                case null:
                    (tbRTop.Text, tbRDown.Text) = new Fraction(tbFTop.Text, tbFDown.Text) + new Fraction(tbSTop.Text, tbSDown.Text);
                    break;
                case "+" :
                    (tbRTop.Text, tbRDown.Text) = new Fraction(tbFTop.Text, tbFDown.Text) + new Fraction(tbSTop.Text, tbSDown.Text);
                    break;
                case "-":
                    (tbRTop.Text, tbRDown.Text) = new Fraction(tbFTop.Text, tbFDown.Text) - new Fraction(tbSTop.Text, tbSDown.Text);
                    break;
                case "*":
                    (tbRTop.Text, tbRDown.Text) = new Fraction(tbFTop.Text, tbFDown.Text) * new Fraction(tbSTop.Text, tbSDown.Text);
                    break;
                case "/":
                    (tbRTop.Text, tbRDown.Text) = new Fraction(tbFTop.Text, tbFDown.Text) / new Fraction(tbSTop.Text, tbSDown.Text);
                    break;
            }

        }
    }

   
    /**
     * Fraction class supplies the underlying logic to 
     * drive this application. A better design might be
     * to have this in a separate file or as a library.
     */
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }
        /**
         * This constructor takes two optional int
         * arguments and assigns them to the 
         * appropriate properties
         */
        public Fraction(int top = 0, int bottom = 1)
            => (Top, Bottom) = (top, bottom);
        /**
         * Add another constructor that takes two optional string
         * arguments and assigns them to the appropriate
         * properties (of course after conversion).
         */
        public Fraction(string top, string bottom)
          => (Top, Bottom) = (int.Parse(top), int.Parse(bottom));
        public static Fraction operator +(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);

        public static Fraction operator -(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);

        /**
         * Add two more methods that overloads the arithmetic 
         * operators multiply and divide arithmetic.
         */
        public static Fraction operator *(Fraction lhs, Fraction rhs)
           => new Fraction(lhs.Top * rhs.Top, lhs.Bottom * rhs.Bottom);

        public static Fraction operator /(Fraction lhs, Fraction rhs)
           => new Fraction(lhs.Top * rhs.Bottom, lhs.Bottom * rhs.Top);
        public override string ToString()
            => $"[{Top}, {Bottom}]";
        /**
         * This Deconstructor allows you to get both properties
         * with a single statement.
         */
        public void Deconstruct(out string top, out string bottom)
            => (top, bottom) = ($"{Top}", $"{Bottom}");
    }





}
