﻿using System.Drawing;
using System.Windows.Forms;

namespace GuildLounge
{
    public partial class GL_HorizontalLine : Control
    {
        public GL_HorizontalLine()
        {
            InitializeComponent();
            Height = 2;
            Width = 75;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawRectangle(new Pen(BackColor), 0, 0, Width, Height);
        }
    }
}
