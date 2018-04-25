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
    public partial class UpdAuto : MetroFramework.Forms.MetroForm
    {
        public UpdAuto()
        {
            InitializeComponent();
        }

        private void ParkingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet.autoInfo". При необходимости она может быть перемещена или удалена.
            this.autoInfoTableAdapter.Fill(this.autoDataSet.autoInfo);
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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)metroComboBox1.SelectedValue;
                var owner = autoDataSet.autoInfo.Where(i => i.id_auto == id).First();
                metroTextBox1.Text = owner.Mark;
                metroTextBox2.Text = owner.PolicyNumber;
                metroTextBox3.Text = owner.PTCNumber;
            }
            catch { }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string mark, pn, pts;
            int idOwner;
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.autoConnectionString);
            try
            {
                mark = metroTextBox1.Text;
                pn = metroTextBox2.Text;
                pts = metroTextBox3.Text;
                idOwner = (int)metroComboBox1.SelectedValue;
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    @"update autoInfo set Mark = '" + mark + "', PolicyNumber = '" + pn + "', PTCNumber = '" + pts + "' where id_auto = "+(int)metroComboBox1.SelectedValue,
                    connect
                    );
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Успешно изменено!");
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
