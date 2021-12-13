using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab5
{
    public partial class Form1 : Form
    {
        Car citroen;
        List<Street> streets;
        Image grass;
        TextureBrush texture;
        public Form1()
        {
            grass = Image.FromFile(@"Img\grass.jpg");
            texture = new TextureBrush(grass);
            streets = new List<Street>();
            var odkryta = new Street(Image.FromFile(@"Img\asfalt.jpg"));

            citroen = new Car(Image.FromFile(@"Img\auto_czerwone.png"), 100, 100);
            citroen.V = 20;
            InitializeComponent();
            
        }

        private void LoadingData()
        {
            var sbmp = Image.FromFile(@"Img\asfalt.jpg");
            streets.Clear();
            streetsTableAdapter1.Fill(mapDataSet1.Streets);
            foreach (var street in mapDataSet1.Streets)
            {
                var novel = new Street(sbmp);
                novel.Name = street.Name;
                streets.Add(novel);
                foreach (var po in pointsStreetTableAdapter1.GetData(street.Id))
                {
                    novel.AddPoint(po.X, po.Y);
                }
            }
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.ScaleTransform(0.8f, 0.8f);
            e.Graphics.RotateTransform(-citroen.Direction - 90);
            e.Graphics.TranslateTransform(-citroen.X, -citroen.Y);
            e.Graphics.FillRectangle(texture,-10000,-10000,20000,20000);
            foreach (var s in streets)
            {
                s.Draw(e.Graphics);
            }
            citroen.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //citroen.Direction += 0.5f;
            citroen.Operate(0.02f);
            this.Refresh();

        }
        EditStreet Editor;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardOperation(e,true);
            if (e.KeyCode == Keys.F5)
            {
                if(Editor==null)
                {
                    timer1.Stop();
                    Editor = new EditStreet();
                    Editor.FormClosed += Editor_FormClosed;
                    Editor.SaveChanges += SaveChanges;
                    Editor.Show();
                }
            }

        }

        private void SaveChanges(object sender, EventArgs e)
        {
            LoadingData();
            this.Refresh();
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Start();
            Editor = null;
        }

        private void KeyboardOperation(KeyEventArgs e,bool state)
        {
            if (e.KeyCode == Keys.Left) citroen.left = state;
            if (e.KeyCode == Keys.Right) citroen.right = state;
            if (e.KeyCode == Keys.Up) citroen.gas = state;
            if (e.KeyCode == Keys.Down) citroen.brake = state;
            if (e.KeyCode == Keys.Space) citroen.handbrake = state;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeyboardOperation(e, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingData();
        }
    }
}
