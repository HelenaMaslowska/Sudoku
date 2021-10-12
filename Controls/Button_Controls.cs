using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public delegate void Push_Button(Buttons Button);
    public enum Buttons
    {
        start,
        choose,
        back,
        exit,
    };


    public partial class Button_Controls : UserControl
    {
        public Button_Controls()
        {
            InitializeComponent();
        }

        private Push_Button _change_button;
        protected void after_changes(Buttons B)
        {
            if (_change_button != null)
            {
                _change_button(B);
            }
        }
        public void set_after_changes(Push_Button func_change)
        {
            _change_button = func_change;
        }
    }
}
