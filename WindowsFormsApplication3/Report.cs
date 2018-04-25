using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        public Report()
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.autoConnectionString);
            DateTime from = metroDateTime1.Value;
            DateTime to = metroDateTime2.Value;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    @"select ai.Mark + ai.PolicyNumber as Авто, po.BeginDate as Начало, po.EndDate as Окончание, po.id_place as Место, po.Price as Стоимость
                      from parkingOrder as po
                      join autoInfo as ai on po.id_auto=ai.id_auto
                      where po.BeginDate >= '" + from + "' and po.EndDate <= '" + to + "'", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroGrid1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "dB Error!");
            }
            finally
            {
                connect.Close();
            }

        }
    }
}
