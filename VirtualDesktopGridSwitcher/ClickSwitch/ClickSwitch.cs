﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualDesktopGridSwitcher.ClickSwitch
{
    public partial class ClickSwitch : Form
    {
        private readonly Action<int> switchAction;
        private readonly Color highlightColor;
        private readonly Timer t;

        public ClickSwitch(Action<int> switchAction)
        {
            this.switchAction = i => { switchAction(i); this.Close(); };

            var c = System.Drawing.SystemColors.Highlight;
            this.highlightColor = Color.FromArgb(Math.Min((int)(c.R * 1.3),255), Math.Min((int)(c.G * 1.3), 255), Math.Min((int)(c.B * 1.3),255));

            t = new Timer();
            t.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;
            t.Tick += (o, e) => this.Close();
            t.Start();

            InitializeComponent();
        }

        private void desktop1_Click(object sender, EventArgs e) => switchAction.Invoke(0);
        private void desktop2_Click(object sender, EventArgs e) => switchAction.Invoke(1);
        private void desktop3_Click(object sender, EventArgs e) => switchAction.Invoke(2);
        private void desktop4_Click(object sender, EventArgs e) => switchAction.Invoke(3);
        private void desktop5_Click(object sender, EventArgs e) => switchAction.Invoke(4);
        private void desktop6_Click(object sender, EventArgs e) => switchAction.Invoke(5);
        private void desktop7_Click(object sender, EventArgs e) => switchAction.Invoke(6);
        private void desktop8_Click(object sender, EventArgs e) => switchAction.Invoke(7);
        private void desktop9_Click(object sender, EventArgs e) => switchAction.Invoke(8);

        private void desktop1_MouseEnter(object sender, EventArgs e) => desktop1.BackColor = highlightColor;
        private void desktop1_MouseLeave(object sender, EventArgs e) => desktop1.BackColor = SystemColors.Highlight;
        private void desktop2_MouseEnter(object sender, EventArgs e) => desktop2.BackColor = highlightColor;
        private void desktop2_MouseLeave(object sender, EventArgs e) => desktop2.BackColor = SystemColors.Highlight;
        private void desktop3_MouseEnter(object sender, EventArgs e) => desktop3.BackColor = highlightColor;
        private void desktop3_MouseLeave(object sender, EventArgs e) => desktop3.BackColor = SystemColors.Highlight;
        private void desktop4_MouseEnter(object sender, EventArgs e) => desktop4.BackColor = highlightColor;
        private void desktop4_MouseLeave(object sender, EventArgs e) => desktop4.BackColor = SystemColors.Highlight;
        private void desktop5_MouseEnter(object sender, EventArgs e) => desktop5.BackColor = highlightColor;
        private void desktop5_MouseLeave(object sender, EventArgs e) => desktop5.BackColor = SystemColors.Highlight;
        private void desktop6_MouseEnter(object sender, EventArgs e) => desktop6.BackColor = highlightColor;
        private void desktop6_MouseLeave(object sender, EventArgs e) => desktop6.BackColor = SystemColors.Highlight;
        private void desktop7_MouseEnter(object sender, EventArgs e) => desktop7.BackColor = highlightColor;
        private void desktop7_MouseLeave(object sender, EventArgs e) => desktop7.BackColor = SystemColors.Highlight;
        private void desktop8_MouseEnter(object sender, EventArgs e) => desktop8.BackColor = highlightColor;
        private void desktop8_MouseLeave(object sender, EventArgs e) => desktop8.BackColor = SystemColors.Highlight;
        private void desktop9_MouseEnter(object sender, EventArgs e) => desktop9.BackColor = highlightColor;
        private void desktop9_MouseLeave(object sender, EventArgs e) => desktop9.BackColor = SystemColors.Highlight;

        private void ClickSwitch_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - (this.Width / 2);
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Bounds = new Rectangle(x, y, this.Width, this.Height);
        }

        private void ClickSwitch_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
