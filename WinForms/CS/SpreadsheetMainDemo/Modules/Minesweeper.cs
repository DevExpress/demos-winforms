using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.Office;
using DevExpress.Spreadsheet;
using DevExpress.Utils;
using FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle;
using SpreadsheetHorizontalAlignment = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MinesweeperModule : SpreadSheetTutorialControlBase {
        enum CellState {
            Closed,
            Open,
            HasMine
        }

        readonly Color closedCellColor = Color.FromArgb(222, 222, 222);
        readonly Color hasMineColor = Color.FromArgb(159, 203, 87);
        readonly Color openCellColor = Color.FromArgb(242, 242, 242);
        readonly Color wrongCellColor = Color.FromArgb(236, 111, 105);

        int[,] map;
        CellState[,] vmap;
        int mapWidth;
        int mapHeight;
        int mines;
        IWorkbook book;
        Worksheet sheet;
        CellCollection cells;
        const int Dx = 3;
        const int Dy = 6;
        string previousCell;
        string selectedCell;
        int closedCells;
        bool isGameOver;
        readonly int[] offsetX = { -1, 0, 1, 1, 1, 0, -1, -1 };
        readonly int[] offsetY = { -1, -1, -1, 0, 1, 1, 1, 0 };
        bool leftMouseButton;
        bool rightMouseButton;
        long mouseTicks;
        readonly Bitmap flag;
        readonly Bitmap mine;
        Cell failedCell;
        DateTime startTime;
        string minesString { get { return " Mines:  " + mines; } }

        string timerString {
            get {
                return timer1.Enabled || isGameOver
                           ? " Timer:  " + (DateTime.Now - startTime).ToString("hh\\ \\:\\ mm\\ \\:\\ ss")
                           : " Timer:  00 : 00 : 00";
            }
        }

        public MinesweeperModule() {
            InitializeComponent();
            spreadsheetControl.PopupMenuShowing += spreadsheetControl_PopupMenuShowing;
            spreadsheetControl.CustomDrawCell += SpreadsheetControlCustomDrawCell;
            spreadsheetControl.MouseDown += SpreadsheetControlMouseDown;
            spreadsheetControl.MouseMove += SpreadsheetControlMouseMove;
            spreadsheetControl.MouseUp += SpreadsheetControlMouseUp;

            flag = DemoUtils.LoadImageByName("Flag.png");
            mine = DemoUtils.LoadImageByName("Mine.png");

            spreadsheetControl.ReadOnly = true;
            spreadsheetControl.BeginUpdate();
            PrepareWorkbook();
            radioGroup1.SelectedIndex = 0;
            NewGame();
            spreadsheetControl.EndUpdate();
            spreadsheetControl.Options.Culture = DefaultCulture;
            spreadsheetControl.Document.History.Clear();
        }

        void PrepareMap() {
            map = new int[mapWidth, mapHeight];
            vmap = new CellState[mapWidth, mapHeight];
            NonCryptographicRandom rnd = NonCryptographicRandom.System;
            for(int i = 0; i < mines; i++) {
                int x;
                int y;
                do {
                    x = rnd.Next(mapWidth);
                    y = rnd.Next(mapHeight);
                } while(map[x, y] == 9);
                map[x, y] = 9;
                for(int j = 0; j < 8; j++) {
                    if(IsCellExistent(x + offsetX[j], y + offsetY[j]) && map[x + offsetX[j], y + offsetY[j]] != 9)
                        map[x + offsetX[j], y + offsetY[j]]++;
                }
            }
            closedCells = mapWidth * mapHeight;
        }

        void SetCellsSize() {
            int cellSize = cellSizeTrack.Value;

            for(int i = 0; i < mapWidth; i++) {
                sheet.Columns[Dx + i].Width = cellSize;
            }

            for(int i = 0; i < mapHeight; i++) {
                sheet.Rows[Dy + i].Height = cellSize;
            }

            sheet.Columns[Dx - 1].Width = 15;
            sheet.Columns[Dx + mapWidth].Width = 15;
            sheet.Rows[Dy - 1].Height = 15;
            sheet.Rows[Dy + mapHeight].Height = 15;


            CellRange range =
                sheet[
                    cells[Dy, Dx].GetReferenceA1() + ":" + cells[Dy + mapHeight - 1, Dx + mapWidth - 1].GetReferenceA1()
                    ];
            Formatting style = range.BeginUpdateFormatting();
            try {
                style.Font.Size = 0.6 * cellSizeTrack.Value;
            }
            finally {
                range.EndUpdateFormatting(style);
            }
            range =
                sheet[
                    cells[Dy - 1, Dx - 1].GetReferenceA1() + ":" + cells[Dy + mapHeight, Dx + mapWidth].GetReferenceA1()
                    ];
            style = range.BeginUpdateFormatting();
            try {
                style.Borders.SetOutsideBorders(Color.FromArgb(233, 233, 233), BorderLineStyle.Thin);
            }
            finally {
                range.EndUpdateFormatting(style);
            }
        }

        void PrepareWorkbook() {
            book = spreadsheetControl.Document;
            book.Unit = DocumentUnit.Point;
            sheet = book.Worksheets[0];
            sheet.ActiveView.ShowGridlines = false;
            cells = sheet.Cells;
            sheet.Columns["A"].Width = 20;
            sheet.Columns["B"].Width = 10.75;
            sheet.Columns["C"].Width = 62;
            sheet.Columns["D"].Width = 13;
            sheet.Rows[0].Height = 21.5;
            sheet.Rows[2].Height = 22.25;
            sheet.Rows[3].Height = 14;
            sheet.Rows[4].Height = 12.75;
            CellRange range = sheet["B2:AG2"];
            range.Merge();
            Formatting style = range.BeginUpdateFormatting();
            try {
                style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
                style.Alignment.Indent = 1;
                style.Font.Size = 24;
                style.Font.FontStyle = FontStyle.Regular;
                style.Font.Name = "Segoe UI";
                style.Font.Color = Color.FromArgb(64, 64, 64);
            }
            finally {
                range.EndUpdateFormatting(style);
            }
            cells["B2"].Value = "Minesweeper";

            sheet["B3:AG3"].Merge();
            sheet["B4:AG4"].Merge();

            range = sheet["B3:B4"];
            style = range.BeginUpdateFormatting();
            try {
                style.Font.Name = "Segoe UI";
                style.Font.Size = 9.75;
                style.Font.Color = Color.FromArgb(64, 64, 64);
                style.Font.FontStyle = FontStyle.Regular;
                style.Alignment.Indent = 1;
            }
            finally {
                range.EndUpdateFormatting(style);
            }

            cells["B3"].Value = minesString;
            cells["B4"].Value = timerString;
        }

        void ClearFieldOfPlay() {
            CellRange range =
                sheet[
                    cells[Dy - 1, Dx - 1].GetReferenceA1() + ":" + cells[Dy + mapHeight, Dx + mapWidth].GetReferenceA1()
                    ];
            sheet.Clear(range);
        }

        void GenerateWorkbook() {
            cells["B3"].Value = minesString;
            cells["B4"].Value = timerString;

            SetCellsSize();

            CellRange range =
                sheet[
                    cells[Dy, Dx].GetReferenceA1() + ":" + cells[Dy + mapHeight - 1, Dx + mapWidth - 1].GetReferenceA1()
                    ];
            Formatting style = range.BeginUpdateFormatting();
            try {
                style.Borders.SetAllBorders(Color.White, BorderLineStyle.Medium);
                style.Fill.BackgroundColor = closedCellColor;
                style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            }
            finally {
                range.EndUpdateFormatting(style);
            }
        }

        void NewGame() {
            isGameOver = false;
            timer1.Enabled = false;
            cells["B4"].Value = timerString;
            spreadsheetControl.BeginUpdate();
            ClearFieldOfPlay();
            if(radioGroup1.SelectedIndex == 0) {
                mapWidth = 8;
                mapHeight = 8;
                mines = 9;
                cellSizeTrack.Value = 35;
            }
            else if(radioGroup1.SelectedIndex == 1) {
                mapWidth = 16;
                mapHeight = 16;
                mines = 40;
                cellSizeTrack.Value = 18;
            }
            else if(radioGroup1.SelectedIndex == 2) {
                mapWidth = 30;
                mapHeight = 16;
                mines = 99;
                cellSizeTrack.Value = 18;
            }
            PrepareMap();
            GenerateWorkbook();
            failedCell = null;
            spreadsheetControl.EndUpdate();
        }

        void Button1Click(object sender, EventArgs e) {
            NewGame();
        }

        void RadioGroup1SelectedIndexChanged(object sender, EventArgs e) {
            NewGame();
        }

        void Timer1Tick(object sender, EventArgs e) {
            cells["B4"].Value = timerString;
        }

        void CellSizeTrackValueChanged(object sender, EventArgs e) {
            if(book == null)
                return;
            spreadsheetControl.BeginUpdate();
            SetCellsSize();
            spreadsheetControl.EndUpdate();
        }

        bool IsCellExistent(int x, int y) { return !(x < 0 || y < 0 || x >= mapWidth || y >= mapHeight); }

        void SpreadsheetControlMouseMove(object sender, MouseEventArgs e) {
            Cell cell = spreadsheetControl.GetCellFromPoint(new PointF(e.X, e.Y));
            if(cell == null)
                return;
            if(!IsCellExistent(cell.ColumnIndex - Dx, cell.RowIndex - Dy))
                return;
            string cellReference = cell.GetReferenceA1();
            if(previousCell == cellReference)
                return;
            previousCell = selectedCell;
            selectedCell = cellReference;
            spreadsheetControl.Refresh();
        }

        void OpenAllNeighborhood(Cell cell) {
            int x = cell.ColumnIndex - Dx;
            int y = cell.RowIndex - Dy;
            for(int i = 0; i < 8; i++) {
                if(IsCellExistent(x + offsetX[i], y + offsetY[i]))
                    OpenCell(cells[cell.RowIndex + offsetY[i], cell.ColumnIndex + offsetX[i]]);
            }
        }

        void OpenDigit(Cell cell) {
            int x = cell.ColumnIndex - Dx;
            int y = cell.RowIndex - Dy;
            cell.Fill.BackgroundColor = openCellColor;
            vmap[x, y] = CellState.Open;
            if(map[x, y] == 0)
                OpenAllNeighborhood(cell);
            else {
                cell.Font.Color = Color.FromArgb(52, 52, 52);
                cell.Value = map[x, y];
            }
            closedCells--;
            if(closedCells == mines)
                Win();
        }

        void OpenCell(Cell cell) {
            int x = cell.ColumnIndex - Dx;
            int y = cell.RowIndex - Dy;
            if(vmap[x, y] != CellState.Closed)
                return;
            if(map[x, y] == 9)
                Failed(cell);
            else
                OpenDigit(cell);
        }

        void Failed(Cell cell) {
            timer1.Enabled = false;
            failedCell = cell;
            isGameOver = true;
            spreadsheetControl.Refresh();
        }

        void Win() {
            timer1.Enabled = false;
            isGameOver = true;
            for(int xi = 0; xi < mapWidth; xi++)
                for(int yi = 0; yi < mapHeight; yi++)
                    if(vmap[xi, yi] == CellState.Closed)
                        vmap[xi, yi] = CellState.HasMine;
            mines = 0;
            cells["B3"].Value = minesString;
        }

        void LeftMouseButtonClick(Cell cell) { OpenCell(cell); }

        void RightMouseButtonClick(Cell cell) {
            int x = cell.ColumnIndex - Dx;
            int y = cell.RowIndex - Dy;
            if(vmap[x, y] == CellState.HasMine) {
                vmap[x, y] = CellState.Closed;
                cell.Fill.BackgroundColor = closedCellColor;
                mines++;
                closedCells++;
            }
            else if(vmap[x, y] == CellState.Closed) {
                vmap[x, y] = CellState.HasMine;
                mines--;
                closedCells--;
            }
            cells["B3"].Value = minesString;
        }

        void MiddleMouseButtonClick(Cell cell) {
            int x = cell.ColumnIndex - Dx;
            int y = cell.RowIndex - Dy;
            if(vmap[x, y] == CellState.Open) {
                int need = 0;
                for(int i = 0; i < 8; i++) {
                    if(IsCellExistent(x + offsetX[i], y + offsetY[i]) &&
                       vmap[x + offsetX[i], y + offsetY[i]] == CellState.HasMine)
                        need++;
                }
                if(need == map[x, y])
                    OpenAllNeighborhood(cell);
            }
        }

        void SpreadsheetControlMouseDown(object sender, MouseEventArgs e) {
            Cell cell = spreadsheetControl.GetCellFromPoint(new PointF(e.X, e.Y));
            if(cell == null)
                return;
            int x = cell.ColumnIndex - Dx;
            int y = cell.RowIndex - Dy;
            if(!IsCellExistent(x, y))
                return;
            if(isGameOver)
                return;

            if(!timer1.Enabled) {
                startTime = DateTime.Now;
                timer1.Enabled = true;
            }
            spreadsheetControl.BeginUpdate();

            if(e.Button == MouseButtons.Left) {
                leftMouseButton = true;
                if(rightMouseButton) {
                    TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - mouseTicks);
                    if(ts.Milliseconds < 600)
                        MiddleMouseButtonClick(cell);
                }
                else {
                    mouseTicks = DateTime.Now.Ticks;
                    LeftMouseButtonClick(cell);
                }
            }
            else if(e.Button == MouseButtons.Right) {
                rightMouseButton = true;
                if(leftMouseButton) {
                    TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - mouseTicks);
                    if(ts.Milliseconds < 600)
                        MiddleMouseButtonClick(cell);
                }
                else {
                    mouseTicks = DateTime.Now.Ticks;
                    RightMouseButtonClick(cell);
                }
            }
            else if(e.Button == MouseButtons.Middle)
                MiddleMouseButtonClick(cell);
            spreadsheetControl.EndUpdate();
            spreadsheetControl.Refresh();
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl.Focus();
        }

        void spreadsheetControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) { e.Menu = null; }

        void SpreadsheetControlMouseUp(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left)
                leftMouseButton = false;
            else if(e.Button == MouseButtons.Right)
                rightMouseButton = false;
        }

        void SpreadsheetControlCustomDrawCell(object sender, CustomDrawCellEventArgs e) {
            e.DrawDefault();
            int x = e.Cell.ColumnIndex - Dx;
            int y = e.Cell.RowIndex - Dy;
            Color fillColor = Color.Empty;
            Image image = null;
            if(!IsCellExistent(x, y))
                return;
            if(failedCell != null) {
                if(map[x, y] == 9) {
                    if(e.Cell == failedCell)
                        fillColor = wrongCellColor;
                    image = mine;
                }
            }
            if(vmap[x, y] == CellState.HasMine) {
                fillColor = isGameOver && map[x, y] != 9 ? wrongCellColor : hasMineColor;
                image = flag;
            }
            if(e.Cell.GetReferenceA1() == selectedCell) {
                fillColor = vmap[x, y] == CellState.HasMine
                                ? Color.FromArgb(103, 169, 24)
                                : Color.FromArgb(200, 200, 200);
            }
            if(!DXColor.IsEmpty(fillColor)) {
                e.Cache.FillRectangle(fillColor, e.FillBounds);
                e.Cache.DrawRectangle(new Pen(Color.White, 1), e.FillBounds);
            }
            if(image != null) {
                int l = Convert.ToInt32(e.FillBounds.Left + (e.FillBounds.Width + 1 - mine.Width) / 2);
                int t = Convert.ToInt32(e.Bounds.Top + (e.FillBounds.Height + 1 - mine.Height) / 2);
                e.Graphics.DrawImageUnscaled(image, l, t);
            }
        }
    }
}
