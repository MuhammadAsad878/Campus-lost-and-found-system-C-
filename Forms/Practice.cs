using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusLostAndFoundSystem.Forms
{
    public partial class Practice : Form
    {
        public Practice()
        {
            InitializeComponent();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem , DragDropEffects.Move);
            }
        }

        private void guna2TextBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(guna2TextBox1.Text == null)
            {
                guna2TextBox1.Text = e.ToString();
            }
        }

        private void guna2TextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void guna2TextBox1_DragDrop(object sender, DragEventArgs e)
        {
           if(e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
                guna2TextBox1.Text = e.Data.GetData(typeof(String)).ToString();
            }
        }

        private void guna2TextBox2_DragDrop(object sender, DragEventArgs e)
        {
            guna2TextBox2.Text = (String)e.Data.GetData(typeof(string));
        }

        private void guna2TextBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
