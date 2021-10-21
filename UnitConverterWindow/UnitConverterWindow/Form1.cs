using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverterWindow
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";  // NOTE(bora): Status label

            PopulateComboboxes();

        }

        private void PopulateComboboxes()
        {

            foreach(ComboBox it in new List<ComboBox>(){ comboBox1, comboBox2 })
            {
                it.Items.Add(new ComboboxItem("mm", "Millimeters"));
                it.Items.Add(new ComboboxItem("cm", "Centimeters"));
                it.Items.Add(new ComboboxItem("m", "Meters"));
                it.Items.Add(new ComboboxItem("km", "Kilometers"));
                it.Items.Add(new ComboboxItem("in", "Inches"));
                it.Items.Add(new ComboboxItem("ft", "Feet"));
                it.Items.Add(new ComboboxItem("mi", "Miles"));

                it.SelectedIndex = 2;  // NOTE(bora): Meters
            }
        }

        private void Calculate()
        {
            try
            {
                // NOTE(bora): If it only contains whitespace, don't do anything.
                if(textBox1.Text.Trim() != "")
                {


                    double value = double.Parse(textBox1.Text);

                    label2.Text = "";

                    if(comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                    {
                        // NOTE(bora): Both units are selected

                        string unit1 = ((ComboboxItem)comboBox1.SelectedItem).tableKey;
                        string unit2 = ((ComboboxItem)comboBox2.SelectedItem).tableKey;

                        textBox2.Text = Convert.DoConversiton(unit1, unit2, value).ToString();
                    }
                }
            }
            catch(FormatException)
            {
                label2.Text = "Please only enter numbers.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // NOTE(bora): Combobox selections trigger calculations so store values first.
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            int tempSelection = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = tempSelection;

            textBox1.Text = value2;
            textBox2.Text = value1;

            Calculate();
        }
    }

    public class ComboboxItem
    {
        public readonly string tableKey;
        string displayName;

        public ComboboxItem(string tableKey, string displayName)
        {
            this.tableKey = tableKey;
            this.displayName = displayName;
        }

        override public string ToString()
        {
            return displayName;
        }
    }
}
