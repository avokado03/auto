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
    public partial class AddOwner : MetroFramework.Forms.MetroForm
    {
        public AddOwner()
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
            string f, i, o, phone;
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.autoConnectionString);
            try
            {
                f = metroTextBox1.Text;
                i = metroTextBox2.Text;
                o = metroTextBox3.Text;
                phone = metroTextBox4.Text;
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    @"insert into autoOwnerInfo values ('" + f + "', '" + i + "', '" + o + "', '" + phone + "')",
                    connect
                    );
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this,"Успешно добавлено!");
            }
            catch (Exception ex )
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message, "dB Error!");
            }
            finally {
                connect.Close();
            }
        }

        private void metroLinkAddOwner_Click(object sender, EventArgs e)
        {
            AddAuto aa = new AddAuto();
            aa.Show();
            Close();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            UpdOwner uo = new UpdOwner();
            uo.Show();
            Close();
        }
    }
}
