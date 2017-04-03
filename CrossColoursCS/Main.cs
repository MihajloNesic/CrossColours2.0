using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossColoursCS
{
    public partial class Main : Form
    {
        private Color CCGreen = Color.FromArgb(255, 51, 255, 0);

        private Button[,] ButtonMatrix;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateGame(6, 6);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tlp_game.RowCount; i++)
                for (int j = 0; j < tlp_game.ColumnCount; j++)
                    ButtonMatrix[i, j].BackColor = Color.Red;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(nud_rows.Value);
            int c = Convert.ToInt32(nud_cols.Value);
            CreateGame(r, c);
        }

        private void pcb_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.brainbashers.com/crosscolours.asp");
            System.Diagnostics.Process.Start("https://mihajlonesic.gitlab.io/");
        }

        private void CreateGame(int row, int col)
        {
            tlp_game.Controls.Clear();

            tlp_game.RowStyles.Clear();
            tlp_game.ColumnStyles.Clear();

            tlp_game.RowCount = row;
            tlp_game.ColumnCount = col;

            ButtonMatrix = new Button[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    ButtonMatrix[i, j] = new Button();
                    ButtonMatrix[i, j].BackColor = Color.Red;
                    ButtonMatrix[i, j].Padding = new Padding(0);
                    ButtonMatrix[i, j].Margin = new Padding(0);
                    ButtonMatrix[i, j].Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                    ButtonMatrix[i, j].Click += new EventHandler(CCButtonClickHandler);
                    tlp_game.Controls.Add(ButtonMatrix[i, j], j, i);
                }
            }

            for (int i = 1; i <= tlp_game.RowCount; i++)
            {
                tlp_game.RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            }
            for (int i = 1; i <= tlp_game.ColumnCount; i++)
            {
                tlp_game.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
            }
        }

        private void CCButtonClickHandler(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b != null)
            {
                ToggleColor(b);

                TableLayoutPanelCellPosition pos = tlp_game.GetCellPosition(b);

                if (pos.Row < (tlp_game.RowCount))
                {
                    Button neig1 = (Button)tlp_game.GetControlFromPosition(pos.Column, pos.Row + 1);
                    if (neig1 != null)
                        ToggleColor(neig1);

                    if (pos.Row > 0)
                    {
                        Button neig2 = (Button)tlp_game.GetControlFromPosition(pos.Column, pos.Row - 1);
                        if (neig2 != null)
                            ToggleColor(neig2);
                    }
                }

                if (pos.Column < (tlp_game.ColumnCount))
                {
                    Button neig3 = (Button)tlp_game.GetControlFromPosition(pos.Column + 1, pos.Row);
                    if (neig3 != null)
                        ToggleColor(neig3);

                    if (pos.Column > 0)
                    {
                        Button neig4 = (Button)tlp_game.GetControlFromPosition(pos.Column - 1, pos.Row);
                        if (neig4 != null)
                            ToggleColor(neig4);
                    }
                }

            }

            if (Win())
                MessageBox.Show("You are victorious!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ToggleColor(Button b)
        {
            if (b.BackColor == Color.Red)
                b.BackColor = CCGreen;
            else b.BackColor = Color.Red;
        }

        private bool Win()
        {
            for (int i = 0; i < tlp_game.RowCount; i++)
                for (int j = 0; j < tlp_game.ColumnCount; j++)
                    if (ButtonMatrix[i, j].BackColor != CCGreen)
                        return false;
            return true;
        }
    }
}
