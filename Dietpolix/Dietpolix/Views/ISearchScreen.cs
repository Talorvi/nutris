﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface ISearchScreen
    {
        event Action<object, EventArgs> VEvent_OnbuttonAddToDiet;

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
