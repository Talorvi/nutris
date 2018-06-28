using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface IDietScreen
    {

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
