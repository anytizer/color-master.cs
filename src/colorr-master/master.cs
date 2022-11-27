using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace colorrmaster
{
    public partial class master : Form
    {
        private Button target_active;
        //private Button target_inactive;

        public master()
        {
            InitializeComponent();

            this.defaults();
            this.set_tooltips();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button4.Text = string.Empty;
            this.button5.Text = string.Empty;
            //this.button6.Text = string.Empty; // Random()
            

            this.Cursor = Cursors.Hand;
            
            this.target_active = this.button4;
            //this.target_inactive = this.button5;
            this.adjust();
        }

        private void defaults()
        {
            int steps = 2;

            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = 0;
            this.trackBar1.TickFrequency = steps;
            this.trackBar1.LargeChange = steps * 16;
            this.trackBar1.SmallChange = steps * 4;
            this.trackBar1.TickStyle = TickStyle.None;
            //this.trackBar1.BackColor = Color.Red;

            this.trackBar2.Maximum = 255;
            this.trackBar2.Minimum = 0;
            this.trackBar2.TickFrequency = steps;
            this.trackBar2.LargeChange = steps * 16;
            this.trackBar2.SmallChange = steps * 4;
            this.trackBar2.TickStyle = TickStyle.None;
            //this.trackBar2.BackColor = Color.Green;

            this.trackBar3.Maximum = 255;
            this.trackBar3.Minimum = 0;
            this.trackBar3.TickFrequency = steps;
            this.trackBar3.LargeChange = steps * 16;
            this.trackBar3.SmallChange = steps * 4;
            this.trackBar3.TickStyle = TickStyle.None;
            //this.trackBar3.BackColor = Color.Blue;

            this.button4.BackColor = Color.Black;
            this.button5.BackColor = Color.Black;

            this.numericUpDown1.Increment = 5;
            this.numericUpDown1.Maximum = 30;
            this.numericUpDown1.Minimum = 5; // to start from 5 - 30
            this.numericUpDown1.Value = 30;
            this.numericUpDown1.DecimalPlaces = 0;
            this.numericUpDown1.ThousandsSeparator = false;
            this.numericUpDown1.Hexadecimal = false;
        }

        private void set_tooltips()
        {
            this.toolTip1.SetToolTip(this.checkBox1, "Live preview with your selected colors");
            this.toolTip1.SetToolTip(this.button1, "Red component randomizer");
            this.toolTip1.SetToolTip(this.button2, "Green component randomizer");
            this.toolTip1.SetToolTip(this.button3, "Blue component randomizer");
            this.toolTip1.SetToolTip(this.button4, "Click to activate Background");
            this.toolTip1.SetToolTip(this.button5, "Click to activate Foreground");
            this.toolTip1.SetToolTip(this.label1, "Click to copy color code");
            this.toolTip1.SetToolTip(this.label2, "Step down all colors");
            this.toolTip1.SetToolTip(this.label3, "Step up all colors");
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

            this.target_active.BackColor = Color.FromArgb(this.trackBar1.Value, this.trackBar2.Value, this.trackBar3.Value);
            this.target_active.ForeColor = Color.FromArgb(this.button4.BackColor.ToArgb() ^ 0XFFFFFF);
            this.label1.Text = this.hex_colors();
            
            // optional
            if(this.checkBox1.Checked)
            {
                this.label1.ForeColor = button5.BackColor;
                this.label1.BackColor = button4.BackColor;
            }
            else
            {
                this.label1.ForeColor = Color.Black;
                this.label1.BackColor = Color.Transparent;
            }
        }

        private string hex(int integer)
        {
            string value = string.Format("{0:X}", integer.ToString("X"));
            if (value.Length == 1) value = "0" + value;

            return value;
        }

        private string hex_colors()
        {
            string hexa = string.Format("#{0}{1}{2}", this.hex(this.trackBar1.Value), this.hex(this.trackBar2.Value), this.hex(this.trackBar3.Value));
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
            this.target_active = this.button4;
            this.update_sliders(this.button4.BackColor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.target_active = this.button5;
            this.update_sliders(this.button5.BackColor);

            this.target_active.BackColor = this.button5.BackColor;
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
            this.trackBar1.Value = this.get_random_color_value();
            this.adjust();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.trackBar2.Value = this.get_random_color_value();
            this.adjust();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.trackBar3.Value = this.get_random_color_value();
            this.adjust();
        }

        private int get_random_color_value()
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
           if(this.numericUpDown1.Value >= this.numericUpDown1.Maximum) this.numericUpDown1.Value = this.numericUpDown1.Maximum;
           if(this.numericUpDown1.Value <= this.numericUpDown1.Minimum) this.numericUpDown1.Value = this.numericUpDown1.Minimum;
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }

        private string bgcolor()
        {
            string hexa = string.Format("#{0}{1}{2}", this.hex(this.button4.BackColor.R), this.hex(this.button4.BackColor.G), this.hex(this.button4.BackColor.B));
            return hexa;
        }

        private void projectSourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.help();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // randomize colors
            int bk_red = this.get_random_color_value();
            int bk_green = this.get_random_color_value();
            int bk_blue = this.get_random_color_value();

            this.trackBar1.Value = bk_red;
            this.trackBar2.Value = bk_green;
            this.trackBar3.Value = bk_blue;

            // inactive one; if background is active, apply to foreground
            //int fc_red= this.get_random_color_value();
            //int fc_green = this.get_random_color_value();
            //int fc_blue = this.get_random_color_value();

            this.adjust();
        }

        private void copyColorCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.label1.Text);
        }

        private void copyFullCSSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Format(".element {{ color: {0}; background-color: {1}; }}", this.label1.Text, this.bgcolor()));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.adjust();
        }

        private void requestAFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.help();
        }

        private void help()
        {
            try
            {
                Process opener = new Process();
                opener.StartInfo.UseShellExecute = true;
                opener.StartInfo.FileName = Configurations.project_url;
                opener.Start();
            }
            catch (Exception ex)
            {
            }
        }

        private void anytizerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}