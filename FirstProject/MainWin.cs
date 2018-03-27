using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class MainWin : Form
    {
        CheckBox multiLineCheckBox = new CheckBox();
        CheckBox verticalScroll = new CheckBox();
        CheckBox horizontalScroll = new CheckBox();
        public event EventHandler CheckedChanged;
        public MainWin()
        {

            InitializeComponent();
            richTextBox.Multiline = false;
            multiLineCheckBox.Text = "MultiLine";
            multiLineCheckBox.Location = new System.Drawing.Point(326, 33);
            multiLineCheckBox.CheckedChanged += new System.EventHandler(CheckBoxCheckedChanged);
            verticalScroll.Text = "Vertical scroll";
            verticalScroll.Location = new System.Drawing.Point(325, 73);
            verticalScroll.CheckedChanged += new System.EventHandler(CheckBoxCheckedChanged);
            horizontalScroll.Text = "Horizontal scroll";
            horizontalScroll.Location = new System.Drawing.Point(327, 107);
            horizontalScroll.CheckedChanged += new System.EventHandler(CheckBoxCheckedChanged);
            Controls.Add(multiLineCheckBox);
            Controls.Add(verticalScroll);
            Controls.Add(horizontalScroll);          
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (multiLineCheckBox.Checked)
                 richTextBox.Multiline = true;
            if (verticalScroll.Checked == true)
                 richTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            else
                richTextBox.ScrollBars = RichTextBoxScrollBars.None;
            if (horizontalScroll.Checked == true)
                 richTextBox.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
        }
    }
}
