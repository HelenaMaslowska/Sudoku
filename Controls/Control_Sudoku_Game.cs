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
    public partial class Control_Sudoku_Game : Button_Controls
    {

        public Control_Sudoku_Game()
        {
            InitializeComponent();
        }

        //private void GButton_Back_Click(object sender, EventArgs e) { after_changes(Buttons.back); }
        private void GButton_Back_Click(object sender, EventArgs e)
        {
            after_changes(Buttons.back);
        }
    }
}
