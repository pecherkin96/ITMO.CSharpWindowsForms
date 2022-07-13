﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnimatedWindow
{
    public class WinAPIClass
    {
        /// Тип анимации окна. Перечисление возвращает тип данных int 
        /// после приведения. Каждому элементу перечисления присвоено 
        /// свое значение типа int. 
        [Flags]
        public enum AnimateWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTER = 16,
            AW_HIDE = 65536,
            AW_ACTIVATE = 131072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288
        };

        [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError =
        true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int
        dwFlags);

        public static bool AnimateWindow(Control ctrl, int dwTime,
        AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
    }
}