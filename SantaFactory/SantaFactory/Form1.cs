using SantaFactory.Abstractions;
using SantaFactory.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaFactory
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        Toy _nextToy;
        

        private IToyFactory _toyFactory;
        public IToyFactory ToyFactory
        {
            get { return _toyFactory; }
            set { _toyFactory = value;
                DisplayNext();
                }
        }

        public Form1()
        {
            InitializeComponent();

            ToyFactory = new CarFactory();
        


        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Toy toy = (Toy)ToyFactory.CreateNew();
            _toys.Add(toy);
            mainPanel.Controls.Add(toy);
            toy.Left = -toy.Width;
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToyFactory = new CarFactory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToyFactory = new BallFactory()
            {
                BallColor = btnColor.BackColor
            };
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ToyFactory = new PresentFactory()
            {
                BoxColor = btnColorBox.BackColor,
                RibbonColor = btnColorRibbon.BackColor
            };
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = ToyFactory.CreateNew();
            _nextToy.Top = lblNext.Top + lblNext.Height + 20;
            _nextToy.Left = lblNext.Left;
            Controls.Add(_nextToy);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }

       
    }
}
