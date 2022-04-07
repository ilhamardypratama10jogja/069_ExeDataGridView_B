using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe1_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.YellowGreen;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.AliceBlue;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.RosyBrown;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DarkRed;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Yellow;
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Pink;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.BlueViolet;


        }
    }
}
