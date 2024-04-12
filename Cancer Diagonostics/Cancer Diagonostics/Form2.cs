using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cancer_Diagonostics
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            breastCancerToolStripMenuItem.Click += toolStripMenuItem1_Click;
            lungCancerToolStripMenuItem.Click += toolStripMenuItem2_Click;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //the magical button
        {
            if (Check() == true)
                Diagonostics();
            else;

        }

        public bool Check() //check for wrong inputs in the datasample before inputing to the model 
        {
            if(@comboBox1.Text == "Male" || @comboBox1.Text == "Female") 
            { 
                try
                {
                    float.Parse(textBox1.Text);
                    yesno(comboBox1.Text);
                    yesno(comboBox2.Text);
                    yesno(comboBox3.Text);
                    yesno(comboBox4.Text);
                    yesno(comboBox5.Text);
                    yesno(comboBox6.Text);
                    yesno(comboBox7.Text);
                    yesno(comboBox8.Text);
                    yesno(comboBox9.Text);
                    yesno(comboBox10.Text);
                    yesno(comboBox11.Text);
                    yesno(comboBox12.Text);
                    yesno(comboBox13.Text);
                    yesno(comboBox14.Text);                  
                }
                catch (Exception e)
                {
                    label16.Text = e.Message;
                    return false;
                }
            return true;
            }
            else { return false; }

        }
        public int Diagonostics() 
        {
            var sampleData = new CancerDiagonosticsMLModel2.ModelInput()
            {
                GENDER = @comboBox1.Text, //@"M",
                AGE = float.Parse(textBox1.Text),//74F,
                SMOKING = yesno(comboBox2.Text), //2F, 
                YELLOW_FINGERS = yesno(comboBox3.Text), //1F,
                ANXIETY = yesno(comboBox4.Text), //1F,
                PEER_PRESSURE = yesno(comboBox5.Text), //1F,
                CHRONIC_DISEASE = yesno(comboBox6.Text), //2F,
                FATIGUE = yesno(comboBox7.Text), //2F,
                ALLERGY = yesno(comboBox8.Text), //2F,
                WHEEZING = yesno(comboBox9.Text), //1F,
                ALCOHOL_CONSUMING = yesno(comboBox10.Text), //1F,
                COUGHING = yesno(comboBox11.Text), //1F,
                SHORTNESS_OF_BREATH = yesno(comboBox12.Text), //2F,
                SWALLOWING_DIFFICULTY = yesno(comboBox13.Text), //2F,
                CHEST_PAIN = yesno(comboBox14.Text), //2F,
            };

            var result = CancerDiagonosticsMLModel2.Predict(sampleData);

            var predictionResult = CancerDiagonosticsMLModel2.Predict(sampleData);

            // Check the structure of the returned object and adjust accordingly

            if (predictionResult.PredictedLabel.ToString() == "True")    //true for cancer , false for not cancer        
                label16.Text = "Positive for Lung cancer" + " " + ConvertToPercentage(predictionResult.Probability.ToString());        
            else if(predictionResult.PredictedLabel.ToString() == "False")           
                label16.Text = "Negative for Lung cancer" + " " + ConvertToPercentage(predictionResult.Probability.ToString());            
            else           
                label16.Text = "Unsure for Lung cancer" + " " + ConvertToPercentage(predictionResult.Probability.ToString());            
            

            return 0; 
        }
        public float yesno(string answer)
        {
            if (answer == "Yes")
                return 2F;
            else if(answer == "No")
                return 1F;
            
            return 0; //in this rare case 0 is fail
            
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

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
