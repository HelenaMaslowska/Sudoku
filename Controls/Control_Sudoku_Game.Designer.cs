
namespace Sudoku
{
    partial class Control_Sudoku_Game
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table_Game = new System.Windows.Forms.TableLayoutPanel();
            this.Table_Game_Options = new System.Windows.Forms.TableLayoutPanel();
            this.GButton_Solution = new System.Windows.Forms.Button();
            this.GButton_Check = new System.Windows.Forms.Button();
            this.GButton_Save = new System.Windows.Forms.Button();
            this.GButton_Back = new System.Windows.Forms.Button();
            this.sudoku_Board1 = new Sudoku.Sudoku_Board();
            this.Table_Game.SuspendLayout();
            this.Table_Game_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_Game
            // 
            this.Table_Game.ColumnCount = 3;
            this.Table_Game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Table_Game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Table_Game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Table_Game.Controls.Add(this.Table_Game_Options, 2, 1);
            this.Table_Game.Controls.Add(this.GButton_Back, 2, 2);
            this.Table_Game.Controls.Add(this.sudoku_Board1, 1, 1);
            this.Table_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Game.Location = new System.Drawing.Point(0, 0);
            this.Table_Game.Name = "Table_Game";
            this.Table_Game.RowCount = 3;
            this.Table_Game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_Game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Table_Game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_Game.Size = new System.Drawing.Size(774, 577);
            this.Table_Game.TabIndex = 0;
            // 
            // Table_Game_Options
            // 
            this.Table_Game_Options.ColumnCount = 3;
            this.Table_Game_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_Game_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Table_Game_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_Game_Options.Controls.Add(this.GButton_Solution, 1, 2);
            this.Table_Game_Options.Controls.Add(this.GButton_Check, 1, 4);
            this.Table_Game_Options.Controls.Add(this.GButton_Save, 1, 3);
            this.Table_Game_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Game_Options.Location = new System.Drawing.Point(505, 60);
            this.Table_Game_Options.Name = "Table_Game_Options";
            this.Table_Game_Options.RowCount = 6;
            this.Table_Game_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_Game_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_Game_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_Game_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_Game_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_Game_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_Game_Options.Size = new System.Drawing.Size(266, 397);
            this.Table_Game_Options.TabIndex = 0;
            // 
            // GButton_Solution
            // 
            this.GButton_Solution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GButton_Solution.Font = new System.Drawing.Font("Impact", 16F);
            this.GButton_Solution.Location = new System.Drawing.Point(46, 128);
            this.GButton_Solution.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.GButton_Solution.Name = "GButton_Solution";
            this.GButton_Solution.Size = new System.Drawing.Size(172, 59);
            this.GButton_Solution.TabIndex = 2;
            this.GButton_Solution.Text = "Solution";
            this.GButton_Solution.UseVisualStyleBackColor = true;
            // 
            // GButton_Check
            // 
            this.GButton_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GButton_Check.Font = new System.Drawing.Font("Impact", 16F);
            this.GButton_Check.Location = new System.Drawing.Point(46, 286);
            this.GButton_Check.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.GButton_Check.Name = "GButton_Check";
            this.GButton_Check.Size = new System.Drawing.Size(172, 59);
            this.GButton_Check.TabIndex = 0;
            this.GButton_Check.Text = "Check";
            this.GButton_Check.UseVisualStyleBackColor = true;
            // 
            // GButton_Save
            // 
            this.GButton_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GButton_Save.Font = new System.Drawing.Font("Impact", 16F);
            this.GButton_Save.Location = new System.Drawing.Point(46, 207);
            this.GButton_Save.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.GButton_Save.Name = "GButton_Save";
            this.GButton_Save.Size = new System.Drawing.Size(172, 59);
            this.GButton_Save.TabIndex = 2;
            this.GButton_Save.Text = "Save";
            this.GButton_Save.UseVisualStyleBackColor = true;
            // 
            // GButton_Back
            // 
            this.GButton_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GButton_Back.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GButton_Back.Location = new System.Drawing.Point(562, 490);
            this.GButton_Back.Margin = new System.Windows.Forms.Padding(60, 30, 60, 30);
            this.GButton_Back.Name = "GButton_Back";
            this.GButton_Back.Size = new System.Drawing.Size(152, 57);
            this.GButton_Back.TabIndex = 1;
            this.GButton_Back.Text = "Back";
            this.GButton_Back.UseVisualStyleBackColor = true;
            this.GButton_Back.Click += new System.EventHandler(this.GButton_Back_Click);
            // 
            // sudoku_Board1
            // 
            this.sudoku_Board1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sudoku_Board1.Location = new System.Drawing.Point(41, 60);
            this.sudoku_Board1.Name = "sudoku_Board1";
            this.sudoku_Board1.Size = new System.Drawing.Size(458, 397);
            this.sudoku_Board1.TabIndex = 2;
            // 
            // Control_Sudoku_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table_Game);
            this.Name = "Control_Sudoku_Game";
            this.Size = new System.Drawing.Size(774, 577);
            this.Table_Game.ResumeLayout(false);
            this.Table_Game_Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table_Game;
        private System.Windows.Forms.TableLayoutPanel Table_Game_Options;
        private System.Windows.Forms.Button GButton_Back;
        private System.Windows.Forms.Button GButton_Solution;
        private System.Windows.Forms.Button GButton_Check;
        private System.Windows.Forms.Button GButton_Save;
        private Sudoku_Board sudoku_Board1;
    }
}
