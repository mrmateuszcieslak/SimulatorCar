using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public delegate void SelectionHandler(int Id);
    public partial class EditStreet : Form
    {
        public event EventHandler SaveChanges;
        public event SelectionHandler ChangeoftheSelectedStreet;
        public EditStreet()
        {
            InitializeComponent();
        }

        private void EditStreet_Load(object sender, EventArgs e)
        {
            this.streetsTableAdapter.Fill(this.mapDataSet.Streets);
        }

        private void ModifyStreet_Click(object sender, EventArgs e)
        {
            streetsBindingSource.EndEdit();
            streetsTableAdapter.Update(mapDataSet.Streets);
            pointsStreetBindingSource.EndEdit();
            pointsStreetTableAdapter.Update(mapDataSet.PointsStreet);
            SaveChanges?.Invoke(this,new EventArgs());
        }

        private void streetsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var street = (streetsBindingSource.Current as DataRowView).Row as MapDataSet.StreetsRow;
            pointsStreetTableAdapter.Fill(mapDataSet.PointsStreet, street.Id);
            ChangeoftheSelectedStreet?.Invoke(street.Id);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
