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
    public partial class Window : Form
    {
        Control_Main_Menu start_window_control;
        Control_Sudoku_Game game_window_control;
        //PieceSudoku3x3 PieceSudoku;
        public Window()
        {
            InitializeComponent();
            start_window_control = new Control_Main_Menu();
            game_window_control = new Control_Sudoku_Game();
            //PieceSudoku = new PieceSudoku3x3();

            start_window_control.set_after_changes(Push_Butt);

            start_window_control.Dock = DockStyle.Fill;
            game_window_control.Dock = DockStyle.Fill;
            //PieceSudoku.Dock = DockStyle.Fill;

            this.Controls.Add(start_window_control);
            this.Controls.Add(game_window_control);
            //this.Controls.Add(PieceSudoku);
        }

        public void hide_forms()
        {
            start_window_control.Hide();
            game_window_control.Hide();
            //PieceSudoku.Hide();
        }

        public void Push_Butt(Buttons Button)
        {
            switch (Button)
            {
                case Buttons.start:
                    hide_forms();
                    game_window_control.Show();
                    break;
                case Buttons.choose:
                    hide_forms();
                    break;
                case Buttons.exit:
                    hide_forms();
                    this.Close();
                    break;
            }
           Console.WriteLine(Button);
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

    }
}
