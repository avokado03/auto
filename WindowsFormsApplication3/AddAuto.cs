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
    public partial class AddAuto : MetroFramework.Forms.MetroForm
    {
        public AddAuto()
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

        private void metroLinkAddOwner_Click(object sender, EventArgs e)
        {
            UpdAuto ua = new UpdAuto();
            ua.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string mark, pn, pts;
            int idOwner;
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.autoConnectionString);
            try
            {
                mark = metroTextBox2.Text;
                pn = metroTextBox3.Text;
                pts = metroTextBox4.Text;
                idOwner = (int)metroComboBox1.SelectedValue;
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    @"insert into autoInfo values ('" + mark + "', '" + pn + "', '" + pts + "', '" + idOwner + "')",
                    connect
                    );
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Успешно добавлено!");
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
