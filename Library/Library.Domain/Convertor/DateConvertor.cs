﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Library.Domain.Convertor
{
    public static class Convertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
        }
    }
}
