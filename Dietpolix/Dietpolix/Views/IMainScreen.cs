﻿using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface IMainScreen
    {
        event Action<object, EventArgs> VEvent_OnSelectedIndexChanged;
        //event EventHandler VEvent_OnRegisterLink;

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
