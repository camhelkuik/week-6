using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        private StreamWriter fileWriter;
        private StreamReader fileReader;

        DateTime now = DateTime.Now;
        string name = "Cameron Helkuik";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Student Poll " + name;
            lblDateTime.Text = String.Format("{0:MMM d, yyyy}", now);
            btnResults.Enabled = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string values = inputTextBox.Text;

            var output = new FileStream("C:/Users/CamCam/Desktop/number.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fileWriter = new StreamWriter(output);

            fileWriter.Write(values);

            inputTextBox.Text = "";
            btnResults.Enabled = true;
            fileWriter?.Close();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            FileStream input = new FileStream("C:/Users/CamCam/Desktop/number.txt", FileMode.Open, FileAccess.Read);
            fileReader = new StreamReader(input);

            var inputRecord = fileReader.ReadLine();

            if (inputRecord != null)
            {
                var inputNumber = inputRecord.Split(',').Select(Int32.Parse).ToArray();
                var frequency = new int[11];

                for (var answer = 0; answer < inputNumber.Length; ++answer)
                {
                    ++frequency[inputNumber[answer]];
                }

                displayTextBox.Text = $"{"Rating"}{"Frequency",14}";

                for (var rating = 1; rating < frequency.Length; ++rating)
                {
                    displayTextBox.Text += "\r\n" + $"{rating}{frequency[rating],14}";
                }

            }
            else
            {
                fileReader?.Close();
            }
        }

      
    }
}
