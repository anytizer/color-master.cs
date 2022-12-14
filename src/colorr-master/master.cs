using System.Diagnostics;
using System.Windows.Forms;

namespace colorrmaster
{
    public partial class Master
    {
        private Button target_active = new();
        //private bool animate = false;
        private readonly Randomizer randomizer = new();
        private readonly Hexculator hexculator = new();
        private readonly Process opener = new();

        public Master()
        {
            InitializeComponent();

            this.Defaults();
            this.SetTooltips(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.backgroundButton.Text = string.Empty;
            this.foregroundButton.Text = string.Empty;
            //this.button6.Text = string.Empty; // Random()

            this.Cursor = Cursors.Hand;

            this.target_active = this.backgroundButton;
            //this.target_inactive = this.foregroundButton;
            this.AdjustEverything();
        }

        private void Defaults()
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

            this.backgroundButton.BackColor = Color.Black;
            this.foregroundButton.BackColor = Color.Black;

            this.numericUpDown1.Increment = 5;
            this.numericUpDown1.Maximum = 30;
            this.numericUpDown1.Minimum = 5; // to start from 5 - 30
            this.numericUpDown1.Value = 30;
            this.numericUpDown1.DecimalPlaces = 0;
            this.numericUpDown1.ThousandsSeparator = false;
            this.numericUpDown1.Hexadecimal = false;
        }

        private void SetTooltips(bool enable = false)
        {
            // based on if the checkbox status
            //this.toolTip1.Enabled = true;

            this.toolTip1.SetToolTip(this.checkBox1, enable ? "Live preview with your selected colors" : null);
            this.toolTip1.SetToolTip(this.button1, enable ? "Red component randomizer" : null);
            this.toolTip1.SetToolTip(this.button2, enable ? "Green component randomizer" : null);
            this.toolTip1.SetToolTip(this.button3, enable ? "Blue component randomizer" : null);
            this.toolTip1.SetToolTip(this.backgroundButton, enable ? "Click to activate Background" : null);
            this.toolTip1.SetToolTip(this.foregroundButton, enable ? "Click to activate Foreground" : null);
            this.toolTip1.SetToolTip(this.label1, enable ? "Click to copy color code" : null);
            this.toolTip1.SetToolTip(this.label2, enable ? "Step down all colors" : null);
            this.toolTip1.SetToolTip(this.label3, enable ? "Step up all colors" : null);
        }

        private void AdjustEverything()
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
            this.target_active.ForeColor = Color.FromArgb(this.foregroundButton.BackColor.ToArgb() ^ 0XFFFFFF);
            this.label1.Text = this.hex_colors();

            // optional if block
            if (this.checkBox1.Checked)
            {
                this.label1.ForeColor = foregroundButton.BackColor;
                this.label1.BackColor = backgroundButton.BackColor;
            }
            else
            {
                this.label1.ForeColor = Color.Black;
                this.label1.BackColor = Color.Transparent;
            }
        }

        private string hex_colors()
        {
            string red = this.hexculator.hex(this.trackBar1.Value);
            string green = this.hexculator.hex(this.trackBar2.Value);
            string blue = this.hexculator.hex(this.trackBar3.Value);

            string hexa = string.Format("#{0}{1}{2}", red, green, blue);
            return hexa;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.label1.Text);
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            this.target_active = this.backgroundButton;
            this.update_trackbars(this.backgroundButton.BackColor);
        }

        private void foregroundButton_Click(object sender, EventArgs e)
        {
            this.target_active = this.foregroundButton;
            this.update_trackbars(this.foregroundButton.BackColor);

            this.target_active.BackColor = this.foregroundButton.BackColor;
        }

        private void update_trackbars(Color color)
        {
            this.trackBar1.Value = color.R;
            this.trackBar2.Value = color.G;
            this.trackBar3.Value = color.B;

            this.AdjustEverything();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.trackBar1.Value = this.randomizer.GetColorComponent();
            this.AdjustEverything();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.trackBar2.Value = this.randomizer.GetColorComponent();
            this.AdjustEverything();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.trackBar3.Value = this.randomizer.GetColorComponent();
            this.AdjustEverything();
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

            this.AdjustEverything();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDown1.Value >= this.numericUpDown1.Maximum) this.numericUpDown1.Value = this.numericUpDown1.Maximum;
            if (this.numericUpDown1.Value <= this.numericUpDown1.Minimum) this.numericUpDown1.Value = this.numericUpDown1.Minimum;
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }

        private string bgcolor()
        {
            string red = this.hexculator.hex(this.backgroundButton.BackColor.R);
            string green = this.hexculator.hex(this.backgroundButton.BackColor.G);
            string blue = this.hexculator.hex(this.backgroundButton.BackColor.B);

            string hexa = string.Format("#{0}{1}{2}", red, green, blue);
            return hexa;
        }

        private void projectSourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.help(Configurations.project_url);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // picks the currently active element: Forground or Background button.
            this.randomize_trackbar();
            this.AdjustEverything();
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
            this.AdjustEverything();
        }

        private void requestAFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.help(Configurations.project_issues_new);
        }

        private void help(string url)
        {
            this.opener.StartInfo.UseShellExecute = true;
            this.opener.StartInfo.FileName = url;

            try
            {
                opener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void randomize_trackbar()
        {
            // randomize colors
            int red = this.randomizer.GetColorComponent();
            int green = this.randomizer.GetColorComponent();
            int blue = this.randomizer.GetColorComponent();

            this.trackBar1.Value = red;
            this.trackBar2.Value = green;
            this.trackBar3.Value = blue;
        }

        private void forgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.target_active = this.foregroundButton;
            this.randomize_trackbar();
            this.AdjustEverything();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.target_active = this.backgroundButton;
            this.randomize_trackbar();
            this.AdjustEverything();
        }

        private void bothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // loops to bring some animated effects
            int frames = animateToolStripMenuItem.Checked ? 10 : 1;
            for (int i = 0; i < frames; ++i)
            {
                this.target_active = this.backgroundButton;
                this.randomize_trackbar();
                this.AdjustEverything();

                this.target_active = this.foregroundButton;
                this.randomize_trackbar();
                this.AdjustEverything();

                this.Refresh(); // without this, UI is static
                Thread.Sleep(50);
            }
        }

        private void animateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animateToolStripMenuItem.Checked = !animateToolStripMenuItem.Checked;
            //this.animate = animateToolStripMenuItem.Checked;
        }

        private void enableToolTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.enableToolTipsToolStripMenuItem.Checked = !enableToolTipsToolStripMenuItem.Checked;
            this.SetTooltips(this.enableToolTipsToolStripMenuItem.Checked);
        }

        private void anytizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "GitHub user handle: @anytizer.";
            string title = "Developer Information";

            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //int delta = this.trackbar1_last_red - trackBar1.Value;
            //this.limit(this.trackBar1, delta);

            //this.trackbar1_last_red = trackBar1.Value;
            //if (this.track_all)
            //{
            //    this.track_others_also(delta);
            //}
            //else
            //{
            //    this.track_single(sender, delta);
            //}

            this.AdjustEverything();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //int delta = this.trackbar3_last_green - trackBar2.Value;
            //this.trackbar3_last_green = trackBar1.Value;
            //if (this.track_all)
            //{
            //    this.track_others_also(delta);
            //}
            //else
            //{
            //    this.track_single(sender, delta);
            //}

            this.AdjustEverything();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            //int delta = this.trackbar2_last_blue - trackBar1.Value;
            //this.trackbar2_last_blue = trackBar1.Value;
            //if (this.track_all)
            //{
            //    this.track_others_also(delta);
            //}
            //else
            //{
            //    this.track_single(sender, delta);
            //}

            this.AdjustEverything();
        }
    }
}