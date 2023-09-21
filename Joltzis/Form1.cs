using System.Drawing;
using System.Windows.Forms;

namespace Joltzis {
    public partial class Form1 : Form {

        StackTetris<Block> stackBlocks;

        Block currentBlock;
        Block nextBlock;

        string pn;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1(int difficultModifierInterval, string textboxNome) {
            InitializeComponent();
            loadCanvas();

            pn = textboxNome;
            stackBlocks = new StackTetris<Block>(new(BlockHandler.shapesArray));

            for (int i = 0; i < 125; i++) {
                stackBlocks.GenerateRandomItem();
            }

            currentBlock = getRandomShapeWithCenterAligned();
            nextBlock = getNextBlock();

            timer.Tick += Timer_Tick;
            timer.Interval = difficultModifierInterval;
            timer.Start();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            var verticalMove = 0;
            var horizontalMove = 0;

            switch (e.KeyCode) {

                case Keys.Left:
                    verticalMove--;
                    break;

                case Keys.Right:
                    verticalMove++;
                    break;

                case Keys.Down:
                    horizontalMove++;
                    break;

                case Keys.Up:
                    currentBlock.Rotate();
                    break;
                case Keys.Escape:
                    Pause();
                    break;
                default:
                    return;
            }

            var isMoveSuccess = moveShapeIfPossible(horizontalMove, verticalMove);

            if (!isMoveSuccess && e.KeyCode == Keys.Up)
                currentBlock.Rollback();
        }


        public void Pause() {

            if (timer.Enabled == true) {
                timer.Enabled = false;
                lbPause.Visible = true;
                lbPause.Enabled = true;
                btnExit.Visible = true;
                btnExit.Enabled = true;
                btnResume.Enabled = true;
                btnResume.Visible = true;
                panelPause.Visible = true;
                panelPause.Enabled = true;

                return;
            }

            if (timer.Enabled == false) {
                timer.Enabled = true;
                btnResume.Enabled = false;
                btnResume.Visible = false;
                lbPause.Visible = false;
                lbPause.Enabled = false;
                btnExit.Visible = false;
                btnExit.Enabled = false;
                panelPause.Visible = false;
                panelPause.Enabled = false;

                return;
            }

        }

        Bitmap canvasBitmap;
        Graphics canvasGraphics;
        int canvasWidth = 10;
        int canvasHeight = 20;
        int[,] canvasDotArray;
        int dotSize = 50;
        int nextBlockDotSize = 20;

        private void loadCanvas() {
            pictureBox1.Width = canvasWidth * dotSize;
            pictureBox1.Height = canvasHeight * dotSize;


            canvasBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            canvasGraphics = Graphics.FromImage(canvasBitmap);

            canvasGraphics.FillRectangle(Brushes.White, 0, 0, canvasBitmap.Width, canvasBitmap.Height);

            pictureBox1.Image = canvasBitmap;

            canvasDotArray = new int[canvasWidth, canvasHeight];
        }

        int currentX;
        int currentY;

        private Block getRandomShapeWithCenterAligned() {
            var shape = stackBlocks.Pop();
            stackBlocks.GenerateRandomItem();

            currentX = 4;
            currentY = -shape.Height;

            return shape;
        }

        private bool moveShapeIfPossible(int moveDown = 0, int moveSide = 0) {
            var newX = currentX + moveSide;
            var newY = currentY + moveDown;

            if (newX < 0 || newX + currentBlock.Width > canvasWidth
                || newY + currentBlock.Height > canvasHeight)
                return false;

            for (int i = 0; i < currentBlock.Width; i++) {
                for (int j = 0; j < currentBlock.Height; j++) {
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] != 0 && currentBlock.Dots[j, i] != 0)
                        return false;
                }
            }

            currentX = newX;
            currentY = newY;

            drawShape();

            return true;
        }

        Bitmap workingBitmap;
        Graphics workingGraphics;

        private void drawShape() {
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);

            for (int i = 0; i < currentBlock.Width; i++) {
                for (int j = 0; j < currentBlock.Height; j++) {
                    if (currentBlock.Dots[j, i] != 0) {


                        workingGraphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml(currentBlock.selectColor(currentBlock.Id))),
                            (currentX + i) * dotSize,
                            (currentY + j) * dotSize,
                            dotSize, dotSize);

                        Pen penRectangle = new Pen(Brushes.DarkSlateGray);
                        penRectangle.Width = 8.0F;
                        workingGraphics.DrawRectangle(penRectangle, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 5, dotSize - 5);

                    }
                }
            }

            pictureBox1.Image = workingBitmap;
        }

        private void updateCanvasDotArrayWithCurrentShape() {
            for (int i = 0; i < currentBlock.Width; i++) {
                for (int j = 0; j < currentBlock.Height; j++) {
                    if (currentBlock.Dots[j, i] == 1) {
                        if (!checkIfGameOver()){ 
                            canvasDotArray[currentX + i, currentY + j] = currentBlock.Id;
                        }else {
                            return;
                        }
                    }
                }
            }
        }

        
        private bool checkIfGameOver() {
            if (currentY < 0) {

                SaveScore saveScore = new SaveScore(pn, score);
                
                timer.Stop();
                DialogResult result = MessageBox.Show("Play again?", "Game Over", MessageBoxButtons.YesNo);
                
                switch (result) {
                    case DialogResult.Yes:
                        //this.Close();
                        Application.Restart();
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                    default:
                        Application.Exit();
                        break;
                }

                return true;
            }

            return false;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            var isMoveSuccess = moveShapeIfPossible(moveDown: 1);

            if (!isMoveSuccess) {
                canvasBitmap = new Bitmap(workingBitmap);

                updateCanvasDotArrayWithCurrentShape();

                currentBlock = getRandomShapeWithCenterAligned();
                nextBlock = getNextBlock();

                clearFilledRowsAndUpdateScore();
            }


        }

        int score;
        int level = 0;
        public void clearFilledRowsAndUpdateScore() {
            for (int i = 0; i < canvasHeight; i++) {
                int j;
                for (j = canvasWidth - 1; j >= 0; j--) {
                    if (canvasDotArray[j, i] == 0)
                        break;
                }

                if (j == -1) {
                    score += 125;
                    level++;
                    label1.Text = "Score: " + score;
                    label2.Text = "Level: " + level;
                    timer.Interval -= 10;

                    for (j = 0; j < canvasWidth; j++) {
                        for (int k = i; k > 0; k--) {
                            canvasDotArray[j, k] = canvasDotArray[j, k - 1];
                        }

                        canvasDotArray[j, 0] = 0;
                    }
                }
            }

            for (int i = 0; i < canvasWidth; i++) {
                for (int j = 0; j < canvasHeight; j++) {

                    Pen penRectangle = new Pen(Brushes.DarkSlateGray);
                    penRectangle.Width = 10.0F;
                    workingGraphics.DrawRectangle(penRectangle, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 5, dotSize - 5);

                    canvasGraphics = Graphics.FromImage(canvasBitmap);
                    canvasGraphics.FillRectangle(
                        canvasDotArray[i, j] != 0 ? new SolidBrush(ColorTranslator.FromHtml(currentBlock.selectColor(canvasDotArray[i, j]))) : Brushes.White,
                        i * dotSize, j * dotSize, dotSize, dotSize
                        );
                }
            }

            pictureBox1.Image = canvasBitmap;
        }

        Bitmap nextShapeBitmap;
        Graphics nextShapeGraphics;

        private Block getNextBlock() {

            var shape = stackBlocks.GetNextItem();

            nextShapeBitmap = new Bitmap(6 * dotSize, 6 * dotSize);
            nextShapeGraphics = Graphics.FromImage(nextShapeBitmap);

            nextShapeGraphics.FillRectangle(Brushes.WhiteSmoke, -40, 0, 250, 250);

            var startX = (6 - shape.Width) / 2;
            var startY = (6 - shape.Height) / 2;

            for (int i = 0; i < shape.Height; i++) {
                for (int j = 0; j < shape.Width; j++) {
                    nextShapeGraphics.FillRectangle(
                        shape.Dots[i, j] != 0 ? new SolidBrush(ColorTranslator.FromHtml(shape.selectColor(shape.Id))) : Brushes.Transparent,
                        shape.Id == 1 ? ((startX + j) * dotSize) - 45 : ((startX + j) * dotSize) - 15,
                        shape.Id == 1 ? ((startY + i) * dotSize) - 30 : ((startY + i) * dotSize) - 20,
                        dotSize,
                        dotSize);
                }
            }

            pbNextBlock.Size = nextShapeBitmap.Size;
            pbNextBlock.Image = nextShapeBitmap;

            return shape;
        }



        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void pictureBox3_Click(object sender, EventArgs e) {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panelPause_Click(object sender, EventArgs e) {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e) {

        }

        private void pbNextBlock_Click(object sender, EventArgs e) {

        }

        private void btnResume_Click_1(object sender, EventArgs e) {
            Pause();
        }

        private void btnExit_Click_1(object sender, EventArgs e) {
            this.Close();
            formStartMenu smForm = new formStartMenu();
            smForm.Show();
        }

        private void lbPressEsc_Click(object sender, EventArgs e) {

        }
    }
}