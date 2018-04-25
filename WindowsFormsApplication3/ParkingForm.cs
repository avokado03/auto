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
    public partial class ParkingForm : MetroFramework.Forms.MetroForm
    {
        public ParkingForm()
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
            AddOwner ao = new AddOwner();
            ao.ShowDialog();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.autoConnectionString);
            try
            {
                int id = (int)metroComboBox1.SelectedValue;
                metroComboBox2.DisplayMember = "PolicyNumber";
                metroComboBox2.ValueMember = "id_auto";
                connect.Open();
                SqlCommand cmd = new SqlCommand(@"select id_auto, PolicyNumber from autoInfo where id_autoOwner = " + id, connect);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                metroComboBox2.DataSource = dt;
            }
            catch  {  }
            finally {
                connect.Close();
            }
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.autoConnectionString);
            connect.Open();
            SqlCommand cmd = new SqlCommand(@"select isBusy from placeInfo where id_place = " + Convert.ToInt32(metroComboBox3.Text), connect);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            bool isBusy = reader.GetBoolean(0);
            if (isBusy)
            {
                MetroFramework.MetroMessageBox.Show(this, "Место занято! Выберите другое");
                metroButton1.Enabled = false;
            }
            else {
                metroButton1.Enabled = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.autoConnectionString);
            int auto, place;
            DateTime from, to;
            float price;
            try
            {
                auto = Convert.ToInt32(metroComboBox2.SelectedValue);
                place = Convert.ToInt32(metroComboBox3.Text);
                from = metroDateTime1.Value;
                to = metroDateTime2.Value;
                price = Convert.ToSingle(metroTextBox1.Text);
                connect.Open();
                SqlCommand cmd = new SqlCommand(@"insert into parkingOrder values ('"+from+
                    "','"+to+"',"+price+","+auto+","+place+")",connect);
                cmd.ExecuteNonQuery();
                SqlCommand cmdBusy = new SqlCommand(@"update placeInfo set isBusy = 1 where id_place ="+place,connect);
                cmdBusy.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Парковка совершена!");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message, "dB Error!");
            }
            finally {
                connect.Close();
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = metroDateTime1.Value;
            DateTime to = metroDateTime2.Value;
            TimeSpan ts = to - from;
            if (ts.Days < 0)
                MetroFramework.MetroMessageBox.Show(this, "Неверный диапазон дат!");
            else if (ts.Days == 0)
                metroTextBox1.Text = "100";
            else
                metroTextBox1.Text = (ts.Days * 100+100).ToString();
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = metroDateTime1.Value;
            DateTime to = metroDateTime2.Value;
            TimeSpan ts = to - from;
            if (ts.Days < 0)
                MetroFramework.MetroMessageBox.Show(this, "Неверный диапазон дат!");
            else if (ts.Days == 0)
                metroTextBox1.Text = "100";
            else
                metroTextBox1.Text = (ts.Days * 100 + 100).ToString();
        }
    }
}
