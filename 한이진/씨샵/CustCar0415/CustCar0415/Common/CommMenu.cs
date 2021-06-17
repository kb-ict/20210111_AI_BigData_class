﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustCar0415.Common
{
    class CommMenu
    {
        // 클래스 변수
        public const int OLD_MODEL = 0;
        public const int NEW_MODEL = 1;
        public static void errMsg(string path, string msg)
        {
            Console.WriteLine(path);
            Console.WriteLine(msg);
        }
        public static void ColorListViewHeader(ref ListView list, Color backColor, Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(
                (sender, e) => headerDraw(sender, e, backColor, foreColor));
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }

        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }
            using(SolidBrush foreBrush =  new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }
        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

    }
}
