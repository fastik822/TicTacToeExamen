namespace TicTacToe
{
    public partial class Main : Form
    {
        private readonly int index = 3;
        private readonly Button[,] cells;
        private int ply;

        public Main()
        {
            InitializeComponent();

            cells = new Button[index, index];

            LoadCells();
            StartNewGame();
        }

        private void LoadCells()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j] = new Button();
                    cells[i, j].Click += new EventHandler(button1_Click);
                    cells[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                    tableLayoutPanel1.Controls.Add(cells[i, j], i, j);
                }
            }
        }

        
    }
}