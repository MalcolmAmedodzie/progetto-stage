using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_stage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            revenueBindingSource.DataSource = new List<Revenue>();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title="OrarioScrittura",
                Labels=new[] {"06;00","07;00","08;00", "09;00", "10;00", "11;00", "12;00", "13;00", "14;00", "15;00", "16;00", "17;00", "18;00", "19;00", "20;00", "21;00", "22;00", "23;00", "00;00", "01;00", "02;00", "03;00", "04;00", "05;00" }
               
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Temperatura",
                LabelFormatter = value => value.ToString("C")

            });
            cartesianChart1.LegendLocation=LiveCharts.LegendLocation.Right;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
        }
    }
}
