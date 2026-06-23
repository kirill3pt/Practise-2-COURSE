using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class AddEditForm : Form
    {
        public TransportRecord Result { get; private set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        // 1. загрузка данных для редактирования
        public void LoadData(TransportRecord r)
        {
            txtTransport.Text = r.Transport;
            txtCargo2011.Text = r.Cargo2011.ToString();
            txtCargo2013.Text = r.Cargo2013.ToString();
            txtCargo2015.Text = r.Cargo2015.ToString();
            txtPassenger2013.Text = r.Passenger2013.ToString();
            txtPassenger2017.Text = r.Passenger2017.ToString();
            txtPassenger2018.Text = r.Passenger2018.ToString();
        }

        // 2. сохранение результата
        private void btnOK_Click(object sender, EventArgs e)
        {
            Result = new TransportRecord
            {
                Transport = txtTransport.Text,
                Cargo2011 = double.Parse(txtCargo2011.Text),
                Cargo2013 = double.Parse(txtCargo2013.Text),
                Cargo2015 = double.Parse(txtCargo2015.Text),
                Passenger2013 = double.Parse(txtPassenger2013.Text),
                Passenger2017 = double.Parse(txtPassenger2017.Text),
                Passenger2018 = double.Parse(txtPassenger2018.Text)
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
