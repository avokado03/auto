namespace WindowsFormsApplication3
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.autoOwnerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoDataSet = new WindowsFormsApplication3.autoDataSet();
            this.placeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoOwnerInfoTableAdapter = new WindowsFormsApplication3.autoDataSetTableAdapters.autoOwnerInfoTableAdapter();
            this.placeInfoTableAdapter = new WindowsFormsApplication3.autoDataSetTableAdapters.placeInfoTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.autoOwnerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoOwnerInfoBindingSource
            // 
            this.autoOwnerInfoBindingSource.DataMember = "autoOwnerInfo";
            this.autoOwnerInfoBindingSource.DataSource = this.autoDataSet;
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeInfoBindingSource
            // 
            this.placeInfoBindingSource.DataMember = "placeInfo";
            this.placeInfoBindingSource.DataSource = this.autoDataSet;
            // 
            // autoOwnerInfoTableAdapter
            // 
            this.autoOwnerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // placeInfoTableAdapter
            // 
            this.placeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(361, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Добавление новой операции парковки";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(521, 114);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = resources.GetString("metroLabel2.Text");
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(211, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Формирование отчета";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 251);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(561, 57);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Укажите диапазон дат, по которым необходимо сформировать отчет. После\r\nнажатия кн" +
    "опки \"Сформировать отчет\" появится таблица со списком осуществленных\r\nпарковок з" +
    "а выбранный период.";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(23, 331);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(130, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Информация";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(23, 366);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(209, 57);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Разработал Владислав Малахов\r\nгруппа 3При\r\n2018г.";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Info";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.ParkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoOwnerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource autoOwnerInfoBindingSource;
        private autoDataSetTableAdapters.autoOwnerInfoTableAdapter autoOwnerInfoTableAdapter;
        private System.Windows.Forms.BindingSource placeInfoBindingSource;
        private autoDataSetTableAdapters.placeInfoTableAdapter placeInfoTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}