using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Sudoku_Board : UserControl
    {
        public Sudoku_Board()
        {
            InitializeComponent();
        }

		protected override void OnPaint(PaintEventArgs e)
		{
			/*try
			{*/
			Graphics g = e.Graphics;
			//g.SmoothingMode = SmoothingMode.AntiAlias;
			e.Graphics.ResetClip();

			g.SmoothingMode = SmoothingMode.HighSpeed;
			Brush brush = new SolidBrush(Color.Green);
			g.FillRectangle(brush, 0, 0, Width, Height);
			brush.Dispose();

			Console.WriteLine("W: H:" + Width + " " + Height);
			/*Rectangle obszar_siatki = oblicz_obszar_siatki();

			PointF ss = srodek_siatki(obszar_siatki);

			narysuj_tlo(g);
			narysuj_siatke(g, ss, obszar_siatki);
			narysuj_opis_osi_x(g, ss, obszar_siatki);
			narysuj_strzalki_powiekszania_skali_osi_y_po_lewej(g, ss, obszar_siatki);
			narysuj_opis_osi_y(g, ss, obszar_siatki);
			narysuj_strzalki_poziomu_zero(g, ss, obszar_siatki);
			//narysuj_strzalki_poziomu_wyzwalania(g, ss, obszar_siatki);


			e.Graphics.Clip = new Region(obszar_siatki);

			narysuj_kanaly(g, ss, obszar_siatki);

		}
		catch { }
		//debuger.wyswietl_na_konsoli("Zakonczone malowanie");

		odmalowano = true;
		//debuger.wyswietl_ile_minelo_ms("Odmalowanie obrazu trwalo: ", t);
			*/

			base.OnPaint(e);
		}

	}
}
