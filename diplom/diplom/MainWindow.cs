using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void еЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр UserControl1
            UserControl2 equipmentControl = new UserControl2();

            panel1.Controls.Clear();

            equipmentControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(equipmentControl);

        }

        private void сменитьИмяПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }

        private void сменитьПарольToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
        }

        private void выполненныеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sotrudnici equipmentControl = new sotrudnici();

            panel1.Controls.Clear();

            equipmentControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(equipmentControl);
        }

        private void списокОтпусковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vacasion equipmentControl = new vacasion();

            panel1.Controls.Clear();

            equipmentControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(equipmentControl);
        }
    }
}
