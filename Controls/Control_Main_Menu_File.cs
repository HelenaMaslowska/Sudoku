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
    /*
    public enum Buttons
    {
        start,
        choose,
        exit,
    };
    */
    
    public partial class Control_Main_Menu : Button_Controls
    {
        public Control_Main_Menu()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, EventArgs e) { /*this.Hide();*/ after_changes(Buttons.start); }
        private void Button_Pack_Click(object sender, EventArgs e) { after_changes(Buttons.choose); }
        private void Button_Exit_Click(object sender, EventArgs e) { after_changes(Buttons.exit); }
    }
}
