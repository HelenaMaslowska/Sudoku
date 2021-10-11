
namespace Sudoku
{
    partial class Control_Main_Menu
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
            this.Table_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Pack = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Table_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_Menu
            // 
            this.Table_Menu.ColumnCount = 3;
            this.Table_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Table_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Table_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Table_Menu.Controls.Add(this.Button_Exit, 1, 3);
            this.Table_Menu.Controls.Add(this.Button_Pack, 1, 2);
            this.Table_Menu.Controls.Add(this.Button_Start, 1, 1);
            this.Table_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Menu.Location = new System.Drawing.Point(0, 0);
            this.Table_Menu.Name = "Table_Menu";
            this.Table_Menu.RowCount = 5;
            this.Table_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Table_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_Menu.Size = new System.Drawing.Size(772, 569);
            this.Table_Menu.TabIndex = 1;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Exit.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Exit.Location = new System.Drawing.Point(280, 407);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(211, 65);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Pack
            // 
            this.Button_Pack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Pack.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Pack.Location = new System.Drawing.Point(280, 322);
            this.Button_Pack.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Pack.Name = "Button_Pack";
            this.Button_Pack.Size = new System.Drawing.Size(211, 65);
            this.Button_Pack.TabIndex = 2;
            this.Button_Pack.Text = "Choose sudoku";
            this.Button_Pack.UseVisualStyleBackColor = true;
            this.Button_Pack.Click += new System.EventHandler(this.Button_Pack_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Start.Font = new System.Drawing.Font("Impact", 16F);
            this.Button_Start.Location = new System.Drawing.Point(280, 237);
            this.Button_Start.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(211, 65);
            this.Button_Start.TabIndex = 0;
            this.Button_Start.Text = "Start sudoku";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Control_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table_Menu);
            this.Name = "Control_Main_Menu";
            this.Size = new System.Drawing.Size(772, 569);
            this.Table_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table_Menu;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Pack;
        private System.Windows.Forms.Button Button_Start;
    }
}
