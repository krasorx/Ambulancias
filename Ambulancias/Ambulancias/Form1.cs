using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulancias
{
    public partial class Form1 : Form
    {
        private Ambulance[] ambulance;
        private int df = 5;
        public Form1()
        {
            InitializeComponent();
            ambulance = new Ambulance[df];
            for (int i = 0;i<df;i++)
            {
                ambulance[i] = new Ambulance(i);
            }
            LtbAmbulancias.DataSource = ambulance;
            
            //var myOtherList = LtbAmbulancias.Items.Cast<Ambulance>().ToList();
            LtbAmbulancias.DisplayMember = "Nombre";
            LtbAmbulancias.ValueMember = "Index";
            
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            TxbDate.Text = Calendar.SelectionEnd.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int ind = LtbEmergencies.SelectedIndex;
            
            if (ind != -1)
            {
                ambulance[ind].LoadEmergencies(Convert.ToInt32(TxbTipo.Text), Convert.ToDateTime(TxbDate.Text), TxbDir.Text, Convert.ToInt32(TxbCode));
            }
            MessageBox.Show("Error, seleccione un valor de la lista de ambulancias.");
        }

        private void LtbAmbulancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = LtbAmbulancias.SelectedIndex;
            if (ind != -1)
            {
                LtbEmergencies.DataSource = ambulance[ind].Emergencies;
            }
        }
    }
}
