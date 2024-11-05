using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leasson7
{
    public partial class Form1 : Form
    {
        private const int escapeD = 30;
        private bool isDragging = false;
        private Point dragOffset;
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += MainForm_MouseMove;
            EB.MouseDown += EB_MouseDown;
            EB.MouseMove += EB_MouseMove;
            EB.MouseUp += EB_MouseUp;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbEscape.Checked)
            {
                EscapeFromMouse(e);
            }
            else if (rbFollow.Checked)
            {
                FollowMouse(e);
            }
        }

        private void EscapeFromMouse(MouseEventArgs e)
        {
            var bCenter = new Point(
                 EB.Left + EB.Width / 2,
                 EB.Top + EB.Height / 2
            );

            var X = bCenter.X - e.X;
            var Y = bCenter.Y - e.Y;
            var d = Math.Sqrt(X * X + Y * Y);

            if (d < escapeD * 2)
            {
                var setX = escapeD * X / d;
                var setY = escapeD * Y / d;

                var newBL = new Point(
                    (int)(EB.Left + setX),
                    (int)(EB.Top + setY)
                );

                if (newBL.X >= 0 && newBL.X + EB.Width <= ClientSize.Width &&
                    newBL.Y >= 0 && newBL.Y + EB.Height <= ClientSize.Height)
                {
                    EB.Location = newBL;
                }
            }
        }
        private void FollowMouse(MouseEventArgs e)
        {
            var newBL1 = new Point(
                e.X - EB.Width / 2,
                e.Y - EB.Height / 2
            );

            if (newBL1.X >= 0 && newBL1.X + EB.Width <= ClientSize.Width &&
                newBL1.Y >= 0 && newBL1.Y + EB.Height <= ClientSize.Height)
            {
                EB.Location = newBL1;
            }
        }
        private void EB_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbDrag.Checked && e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }
        private void EB_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                var newL = new Point(
                    EB.Left + e.X - dragOffset.X,
                    EB.Top + e.Y - dragOffset.Y
                );

                if (newL.X >= 0 && newL.X + EB.Width <= ClientSize.Width &&
                    newL.Y >= 0 && newL.Y + EB.Height <= ClientSize.Height)
                {
                    EB.Location = newL;
                }
            }
        }

        private void EB_MouseUp(object sender, MouseEventArgs e)
        {
            if (rbDrag.Checked && e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void escapeButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
