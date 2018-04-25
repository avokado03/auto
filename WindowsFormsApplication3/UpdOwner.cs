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
    public partial class UpdOwner : MetroFramework.Forms.MetroForm
    {
        public UpdOwner()
        {
            InitializeComponent();
        }

        private void ParkingForm_Load(object sender, EventArgs e)
        {
            
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
                var owner = autoDataSet.autoOwnerInfo.Where(i => i.id_autoOwner == id).First();
                metroTextBox1.Text = owner.LName;
                metroTextBox2.Text = owner.FName;
                metroTextBox3.Text = owner.Patr;
                metroTextBox4.Text = owner.Phone;
            }
            catch { }
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
                    @"update autoOwnerInfo set FName = '" + f + "', LName = '" + i + "', Patr = '" + o + "', Phone = '" + phone + "' where [id_autoOwner] = "+ (int)metroComboBox1.SelectedValue,
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
