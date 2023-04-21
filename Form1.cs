using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            listBox1.AllowDrop = true;

            listBox1.MouseDown += listBox1_MouseDown;
            listBox1.DragOver += listBox1_DragOver;
            listBox1.DragDrop += listBox1_DragDrop;
            button1.Click += button1_Click;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                this.listBox1.Items.Add(DateTime.Now.AddDays(i));
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItem == null) return;
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox1.PointToClient(new Point(e.X, e.Y));
            int index = this.listBox1.IndexFromPoint(point);
            if (index < 0) index = this.listBox1.Items.Count - 1;
            object data = e.Data.GetData(typeof(DateTime));
            this.listBox1.Items.Remove(data);
            this.listBox1.Items.Insert(index, data);
        }
    }
}
