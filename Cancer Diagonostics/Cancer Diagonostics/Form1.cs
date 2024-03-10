using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cancer_Diagonostics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire up event handlers
            breastCancerToolStripMenuItem.Click += toolStripMenuItem1_Click;
            lungCancerToolStripMenuItem.Click += toolStripMenuItem2_Click;            
        }

        private void button1_Click(object sender, EventArgs e) // the magical button
        {
            if (CheckInput() == true)
                Diagonostics();
            else;

        }
        public int Diagonostics()
        {
            //Load sample data
            var sampleData = new CancerDiagonosticsMLModel1.ModelInput()
            {
                Radius_mean = float.Parse(textBox1.Text), //20.57F,
                Texture_mean = float.Parse(textBox2.Text),//17.77F,
                Perimeter_mean = float.Parse(textBox3.Text),//132.9F,
                Area_mean = float.Parse(textBox4.Text),//1326F,
                Smoothness_mean = float.Parse(textBox5.Text),//0.08474F,
                Compactness_mean = float.Parse(textBox6.Text),//0.07864F,
                Concavity_mean = float.Parse(textBox7.Text),//0.0869F,
                Concave_points_mean = float.Parse(textBox8.Text),//0.07017F,
                Symmetry_mean = float.Parse(textBox9.Text),//0.1812F,
                Fractal_dimension_mean = float.Parse(textBox10.Text),//0.05667F,
                Radius_se = float.Parse(textBox11.Text),//0.5435F,
                Texture_se = float.Parse(textBox12.Text),//0.7339F,
                Perimeter_se = float.Parse(textBox13.Text),//3.398F,
                Area_se = float.Parse(textBox14.Text),//74.08F,
                Smoothness_se = float.Parse(textBox15.Text),//0.005225F,
                Compactness_se = float.Parse(textBox16.Text),//0.01308F,
                Concavity_se = float.Parse(textBox17.Text),//0.0186F,
                Concave_points_se = float.Parse(textBox18.Text),//0.0134F,
                Symmetry_se = float.Parse(textBox19.Text),//0.01389F,
                Fractal_dimension_se = float.Parse(textBox20.Text),//0.003532F,
                Radius_worst = float.Parse(textBox21.Text),//24.99F,
                Texture_worst = float.Parse(textBox22.Text),//23.41F,
                Perimeter_worst = float.Parse(textBox23.Text),//158.8F,
                Area_worst = float.Parse(textBox24.Text),//1956F,
                Smoothness_worst = float.Parse(textBox25.Text),//0.1238F,
                Compactness_worst = float.Parse(textBox26.Text),//0.1866F,
                Concavity_worst = float.Parse(textBox27.Text),//0.2416F,
                Concave_points_worst = float.Parse(textBox28.Text),//0.186F,
                Symmetry_worst = float.Parse(textBox29.Text),//0.275F,
                Fractal_dimension_worst = float.Parse(textBox30.Text),//0.08902F,
            };

            //Load model and predict output
            string Output;
            Output = "";
            var result = CancerDiagonosticsMLModel1.PredictAllLabels(sampleData);
            foreach (var score in result)
            {
                Output += score.Key + " " + ConvertToPercentage(score.Value.ToString()) + "\r";
            }

            label1.Text = Output;

            return 0;
        }
        public bool CheckInput() //I don't want letter in my math, I have a bias against algebra
        {
            try
            {
                float.Parse(textBox1.Text);
                float.Parse(textBox2.Text);
                float.Parse(textBox3.Text);
                float.Parse(textBox4.Text);
                float.Parse(textBox5.Text);
                float.Parse(textBox6.Text);
                float.Parse(textBox7.Text);
                float.Parse(textBox8.Text);
                float.Parse(textBox9.Text);
                float.Parse(textBox10.Text);                   
                float.Parse(textBox11.Text);
                float.Parse(textBox12.Text);
                float.Parse(textBox13.Text);
                float.Parse(textBox14.Text);
                float.Parse(textBox15.Text);
                float.Parse(textBox16.Text);
                float.Parse(textBox17.Text);
                float.Parse(textBox18.Text);
                float.Parse(textBox19.Text);
                float.Parse(textBox20.Text);
                float.Parse(textBox21.Text);
                float.Parse(textBox22.Text);
                float.Parse(textBox23.Text);
                float.Parse(textBox24.Text);
                float.Parse(textBox25.Text);
                float.Parse(textBox26.Text);
                float.Parse(textBox27.Text);
                float.Parse(textBox28.Text);
                float.Parse(textBox29.Text);
                float.Parse(textBox30.Text);

            }
            catch(Exception e) 
            {
                label1.Text = e.Message;
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e) // label1 Display the results
        {
            Clipboard.SetText(label1.Text); // just useful to have
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Open Form1 when the first menu item is clicked
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Open Form2 when the second menu item is clicked
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label3_Click(object sender, EventArgs e) //ignore
        {

        }

        private void label2_Click(object sender, EventArgs e) //made by me, credit were due :)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Clear Button
        {
            label1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox16.Text = string.Empty;
            textBox17.Text = string.Empty;
            textBox18.Text = string.Empty;
            textBox19.Text = string.Empty;
            textBox20.Text = string.Empty;
            textBox21.Text = string.Empty;
            textBox22.Text = string.Empty;
            textBox23.Text = string.Empty;
            textBox24.Text = string.Empty;
            textBox25.Text = string.Empty;
            textBox26.Text = string.Empty;
            textBox27.Text = string.Empty;
            textBox28.Text = string.Empty;
            textBox29.Text = string.Empty;
            textBox30.Text = string.Empty;


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
        public int ClipboardtoInput() // all in one , it return a int just for in case for incorrect input // a life savier for anyone using this form
        {
            string clipboard = "";
            if (Clipboard.ContainsText())                         
                clipboard = Clipboard.GetText();// Get the text from the clipboard           
            else           
                return 1;
            
            string[] data = System.Text.RegularExpressions.Regex.Split(clipboard, @"\s+");
            //a
            textBox1.Text = data[0];           
            textBox2.Text = data[1];
            textBox3.Text = data[2];
            textBox4.Text = data[3];
            textBox5.Text = data[4];
            textBox6.Text = data[5];
            textBox7.Text = data[6];
            textBox8.Text = data[7];
            textBox9.Text = data[8];
            textBox10.Text = data[9];
            textBox11.Text = data[10];
            textBox12.Text = data[11];
            textBox13.Text = data[12];
            textBox14.Text = data[13];
            textBox15.Text = data[14];                
            textBox16.Text = data[15];
            textBox17.Text = data[16];
            textBox18.Text = data[17];
            textBox19.Text = data[18];               
            textBox20.Text = data[19];
            textBox21.Text = data[20];
            textBox22.Text = data[21];
            textBox23.Text = data[22];
            textBox24.Text = data[23];
            textBox25.Text = data[24];
            textBox26.Text = data[25];
            textBox27.Text = data[26];
            textBox28.Text = data[27];
            textBox29.Text = data[28];
            textBox30.Text = data[29];    
            return 0;
        }

        private void button3_Click(object sender, EventArgs e) //paste from clipboard
        {
            try 
            { 
            ClipboardtoInput();
            }catch
            {

            }
        }
        static string ConvertToPercentage(string valueString)
        {
            // Try parsing the input string to a double
            if (double.TryParse(valueString, out double value))
            {
                // Ensure the parsed value is within the valid range [0, 1]
                value = Math.Max(0, Math.Min(1, value));

                // Convert to percentage string without rounding
                string percentageString = (value * 100).ToString("0.#############################") + "%";

                return percentageString;
            }
            else
            {
                return "Invalid input. Please provide a valid decimal number between 0 and 1.";
            }
        }
    }
}
