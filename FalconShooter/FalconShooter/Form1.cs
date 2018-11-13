using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalconShooter
{
    public partial class FrmMain : Form
    {
        private Graphics playArea;
        private Pen pen;
        private Pen lapizNave;
        private Brush pincelFondo;
        private Brush PincelImpactor;
        private Brush pincel;
        private Brush pincelAst;
        private Random random = new Random();
        private int interval = 100;
        private int intResAst = 1000;
        private Asteroid[] asteroids;
        private int maxAst = 50;
        private Player player;
        private int paWidth;
        private int paHeight;
        private int index = 0;
        private int[,] nave;
        private Star[] stars;
        private int nStars;
        private int speed = 1;
        private Impactor[] impactors;
        private int indexImp = 0;
        private int maxImp = 5;
        private int[] vecImpDest = new int[5]  {0,0,0,0,0};


        public FrmMain()
        {
            InitializeComponent();
            playArea = GameArea.CreateGraphics();
            pen = new Pen(Color.SaddleBrown);
            lapizNave = new Pen(Color.White);
            pincelAst = new SolidBrush(Color.SaddleBrown);
            pincel = new SolidBrush(Color.White);
            PincelImpactor = new SolidBrush(Color.Yellow);
            playArea.Clear(Color.Black);
            timer1.Interval = interval;
            timer2.Interval = intResAst;
            paHeight = GameArea.Width;
            paWidth = GameArea.Height;
            asteroids = new Asteroid[maxAst];
            nave = new int[7, 2]  { { 270, 600},{ 250, 630},{ 280, 630},{ 290, 630},{ 290, 630},
                                    { 290, 630},{ 270, 600}};
            player = new Player(GameArea.Width / 2, GameArea.Height - 15, 20, 37, 30, 30, nave);
            impactors = new Impactor[maxImp];
            nStars = random.Next(50, 100);
            CreateStars();
            GameArea.Select();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            playArea.Clear(Color.Black);
            lblScore.BackColor = Color.Transparent;
            GameArea.Select();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameArea.Refresh();
            DrawGame();
            timer1.Stop();
            timer1.Interval = interval;
            timer1.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            btnStart.Visible = false;
            gpbInicio.Visible = false;
            GameArea.Select();
        }
        public void CreateStars()
        {
            nStars = random.Next(100, 150);
            int radio = 1;
            stars = new Star[nStars];
            for (int i = 0; i < nStars; i++)
            {
                CreateStar(radio,i,radio);
            }
        }
        public void CreateStar(int radio,int i,int n)
        {
            stars[i] = new Star();
            stars[i].setX(random.Next(1, paWidth));
            if(n == 1)
                stars[i].setY(random.Next(1, 635));
            else
                stars[i].setY(1);
            radio = random.Next(1, 5);
            stars[i].setWidth(radio);
            stars[i].setHeight(radio);
            
        }
        public void RefreshStars()
        {
            for (int i = 0; i < nStars; i++)
            {
                stars[i].setY(stars[i].getCoordY() + speed );
                if (stars[i].getCoordY() > 635)
                {
                    int r = 0;
                    CreateStar(r,i,r);
                }
            }
        }
        public void DrawGame()
        {
            PaintEventArgs e;
            playArea.Clear(Color.Black);
            lblScore.Refresh();
            DrawStars();
            DrawAsteroids();
            DrawPlayer();
            DrawImpactors();
        }
        public void DrawStars()
        {
            RefreshStars();
            for(int i = 0; i < nStars;i++)
            {
                playArea.FillRectangle(pincel,stars[i].getCoordX(), stars[i].getCoordY(), stars[i].getWidth(), stars[i].getHeight());
            }
        }
        public void DrawAsteroids()
        {
            for (int i = 0; i < index; i++)
            {
                asteroids[i].setY(asteroids[i].getCoordY() + 3); ;
                playArea.FillEllipse(pincelAst, asteroids[i].getCoordX(), asteroids[i].getCoordY(),
                    asteroids[i].getWidth(), asteroids[i].getHeight());
                if(asteroids[i].getCoordY() > paHeight)
                {
                    asteroids[i].Destroy();
                    // CreateAsteroid(i);
                }
            }
        }
        public void DrawImpactors()
        {
            for (int i = 0; i < indexImp; i++)
            {
                if (impactors[i] != null)
                {
                    impactors[i].setY(impactors[i].getCoordY() - impactors[i].GetSpeed());
                    playArea.FillRectangle(PincelImpactor, impactors[i].getCoordX(), impactors[i].getCoordY(),
                        impactors[i].getHeight(), impactors[i].getWidth());
                
                if (impactors[i].getCoordY() < 15)
                {
                    impactors[i].Destroy();

                    if (indexImp > 4)
                    {
                        indexImp = 0;
                    }
                    else indexImp++;
                }
                }
            }
            
        }
        public void DrawPlayer()
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define polygon.
            Point point1 = new Point(player.getPunto(0,0), player.getPunto(0, 1));
            Point point2 = new Point(player.getPunto(1, 0), player.getPunto(1, 1));
            Point point3 = new Point(player.getPunto(2, 0), player.getPunto(2, 1));
            Point point4 = new Point(player.getPunto(3, 0), player.getPunto(3, 1));
            Point point5 = new Point(player.getPunto(4, 0), player.getPunto(4, 1));
            Point point6 = new Point(player.getPunto(5, 0), player.getPunto(5, 1));
            Point point7 = new Point(player.getPunto(6, 0), player.getPunto(6, 1));
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };

            // Draw polygon to screen.
            playArea.FillPolygon(pincel, curvePoints);
            //e.Graphics.DrawPolygon(blackPen, curvePoints);
        }
        public void CreateAsteroid(int i)
        {
            int x = random.Next(0, paWidth);
            int y = 0;
            int radio2 = random.Next(6, 26);
            int radio = random.Next(5, 20);

            if (index < maxAst)
            {
                if (asteroids[index] == null)
                {
                    asteroids[index] = new Asteroid(x, y, radio, radio2, 2, 5, 1);
                    index++;
                }
                else
                {
                    if (index >= maxAst) index = 0;
                    if (asteroids[index].IsDestroyed())
                    {
                        asteroids[index] = new Asteroid(x, y, radio, radio2, 5, 5, 1);
                        index++;
                    }
                    else asteroids[index].Destroy();
                }
            }
            if (index >= maxAst) index = 0;
        }
        private void CreateImpactor()
        {
            if (impactors[indexImp] == null || impactors[indexImp].IsDestroyed())
            {

                impactors[indexImp] = new Impactor(player.getCoordX(), 600, 8, 4,10);
                indexImp++;
            }
        }
        private void Shoot()
        {
            if (indexImp < maxImp)
            {
                CreateImpactor();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            int i = -1;  // indica que no debe reescribir el el indice
            CreateAsteroid(i);  
            timer2.Interval = intResAst;
            timer2.Start();
        }
        protected override bool IsInputKey(Keys keydata)
        {
            if (keydata == Keys.Left || keydata == Keys.Right || keydata == Keys.Escape)
            {
                return true;
            }
            else
            {
                return base.IsInputKey(keydata);
            }
        }
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void GameArea_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    timer1.Stop();
                    timer2.Stop();
                    gpbInicio.Visible = true;
                    btnContinue.Visible = true;
                    break;
                case Keys.Left:
                    player.MoveLeft();
                    DrawPlayer();
                    break;
                case Keys.Right:
                    player.MoveRight();
                    break;
                case Keys.Space:
                    Shoot();
                    break;

            }
        }

        private void GameArea_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void GameArea_MouseMove(object sender, MouseEventArgs e)
        {
           

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            gpbInicio.Visible = false;
            timer1.Start();
            timer2.Start();
            GameArea.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
