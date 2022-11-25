using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace colormaster
{
    public partial class master : Form
    {
        private Button target;

        public master()
        {
            InitializeComponent();

            int steps = 1;

            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = 0;
            this.trackBar1.TickFrequency = steps;
            this.trackBar1.LargeChange = steps * 16;
            this.trackBar1.SmallChange = steps * 4;
            this.trackBar1.TickStyle = TickStyle.None;

            this.trackBar2.Maximum = 255;
            this.trackBar2.Minimum = 0;
            this.trackBar2.TickFrequency = steps;
            this.trackBar2.LargeChange = steps * 16;
            this.trackBar2.SmallChange = steps * 4;
            this.trackBar2.TickStyle = TickStyle.None;

            this.trackBar3.Maximum = 255;
            this.trackBar3.Minimum = 0;
            this.trackBar3.TickFrequency = steps;
            this.trackBar3.LargeChange = steps * 16;
            this.trackBar3.SmallChange = steps * 4;
            this.trackBar3.TickStyle = TickStyle.None;

            this.numericUpDown1.Increment = 1;
            this.numericUpDown1.Maximum = 15;
            this.numericUpDown1.Minimum = 0;
            this.numericUpDown1.Value = 10;
            this.numericUpDown1.DecimalPlaces = 0;
            this.numericUpDown1.ThousandsSeparator = false;
            this.numericUpDown1.Hexadecimal = false;

            this.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.target = this.button4;
            this.adjust();
        }

        private void adjust()
        {
            this.button1.BackColor = Color.FromArgb(this.trackBar1.Value, 0, 0);
            this.button2.BackColor = Color.FromArgb(0, this.trackBar2.Value, 0);
            this.button3.BackColor = Color.FromArgb(0, 0, this.trackBar3.Value);

            // inverted colors
            this.button1.ForeColor = Color.FromArgb(this.button1.BackColor.ToArgb() ^ 0XFFFFFF);
            this.button2.ForeColor = Color.FromArgb(this.button2.BackColor.ToArgb() ^ 0XFFFFFF);
            this.button3.ForeColor = Color.FromArgb(this.button3.BackColor.ToArgb() ^ 0XFFFFFF);

            this.button1.Text = this.trackBar1.Value.ToString();
            this.button2.Text = this.trackBar2.Value.ToString();
            this.button3.Text = this.trackBar3.Value.ToString();

            this.target.BackColor = Color.FromArgb(this.trackBar1.Value, this.trackBar2.Value, this.trackBar3.Value);
            this.target.ForeColor = Color.FromArgb(this.button4.BackColor.ToArgb() ^ 0XFFFFFF);
            this.label1.Text = this.hexacolors();
        }

        private string hexvalue(int integer)
        {
            string value = string.Format("{0:X}", integer.ToString("X"));
            if (value.Length == 1) value = "0" + value;

            return value;
        }

        private string hexacolors()
        {
            string hexa = string.Format("#{0}{1}{2}", this.hexvalue(this.trackBar1.Value), this.hexvalue(this.trackBar2.Value), this.hexvalue(this.trackBar3.Value));
            return hexa;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.adjust();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.adjust();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.adjust();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.label1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.target = this.button4;
            this.update_sliders(this.button4.BackColor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.target = this.button5;
            this.update_sliders(this.button5.BackColor);
        }

        private void update_sliders(Color color)
        {
            this.trackBar1.Value = color.R;
            this.trackBar2.Value = color.G;
            this.trackBar3.Value = color.B;

            this.adjust();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.trackBar1.Value = this.get_random_hex();
            this.adjust();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.trackBar2.Value = this.get_random_hex();
            this.adjust();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.trackBar3.Value = this.get_random_hex();
            this.adjust();
        }

        private int get_random_hex()
        {
            int value = new Random().Next(0, 255);
            return value;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.steps(-Convert.ToInt32(numericUpDown1.Value));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.steps(+Convert.ToInt32(numericUpDown1.Value));
        }

        private void steps(int steps)
        {
            int red = this.trackBar1.Value + steps;
            int green = this.trackBar2.Value + steps;
            int blue = this.trackBar3.Value + steps;

            if (red <= this.trackBar1.Minimum) red = this.trackBar1.Minimum;
            if (blue <= this.trackBar2.Minimum) blue = this.trackBar2.Minimum;
            if (green <= this.trackBar3.Minimum) green = this.trackBar3.Minimum;


            if (red >= this.trackBar1.Maximum) red = this.trackBar1.Maximum;
            if (blue >= this.trackBar2.Maximum) blue = this.trackBar2.Maximum;
            if (green >= this.trackBar3.Maximum) green = this.trackBar3.Maximum;

            this.trackBar1.Value = red;
            this.trackBar2.Value = green;
            this.trackBar3.Value = blue;

            this.adjust();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           if(this.numericUpDown1.Value >= 15) this.numericUpDown1.Value = 15;
           if(this.numericUpDown1.Value <= 0) this.numericUpDown1.Value = 0;
        }
    }
}