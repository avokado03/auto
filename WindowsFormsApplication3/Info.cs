using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Info : MetroFramework.Forms.MetroForm
    {
        public Info()
        {
            InitializeComponent();
        }

        private void ParkingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet.placeInfo". При необходимости она может быть перемещена или удалена.
            this.placeInfoTableAdapter.Fill(this.autoDataSet.placeInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet.autoOwnerInfo". При необходимости она может быть перемещена или удалена.
            this.autoOwnerInfoTableAdapter.Fill(this.autoDataSet.autoOwnerInfo);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.placeInfoTableAdapter.FillBy(this.autoDataSet.placeInfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
