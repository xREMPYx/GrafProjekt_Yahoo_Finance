﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model
{
    public class ModelDate : ModelPrintable
    {
        public string Date { get; set; }
        public override void Print(Graphics graphics)
        {
            SizeF size = graphics.MeasureString(Date, ProgramSettings.TextFont);

            graphics.DrawLine(
                new Pen(new SolidBrush(ProgramSettings.BorderLineColor)),
                new Point(X, ProgramSettings.ChartHeight),
                new Point(X, ProgramSettings.ChartHeight + 5));

            graphics.DrawString(
                Date, 
                ProgramSettings.TextFont, 
                new SolidBrush(ProgramSettings.TextColor), 
                new PointF(X - size.Width / 2, ProgramSettings.ChartHeight + 5));
        }
    }
}
