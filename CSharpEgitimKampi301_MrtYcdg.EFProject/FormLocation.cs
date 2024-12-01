using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharpEgitimKampi301_MrtYcdg.EFProject
{
    public partial class FormLocation : Form
    {
        EgitimKampiEFTravelDbEntities db;

        public FormLocation()
        {
            InitializeComponent();
            db = new EgitimKampiEFTravelDbEntities();
            GetGuides();
            List();
        }

        private void GetGuides()
        {
            var guides = db.TblGuide.Select(guide=> new
            {
                FullName = guide.GuideName + " " + guide.GuideSurname,
                guide.GuideId
            }).ToList();
            cmbGuide.DataSource = guides;
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
        }

        private void List()
        {
            var locations = db.TblLocation.ToList();
            dataGridView1.DataSource = locations;
        }

        private bool CheckTextBoxes()
        {
            if (string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtCountry.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtDayNight.Text))
            {
                MessageBox.Show("Please fill all the fields!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                return;
            }

            TblLocation location = new TblLocation();
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location added successfully.", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var location = db.TblLocation.Find(id);
            db.TblLocation.Remove(location);
            db.SaveChanges();
            MessageBox.Show("Location deleted successfully.", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var location = db.TblLocation.Find(id);
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());

            db.SaveChanges();
            MessageBox.Show("Location updated successfully.", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
            txtCity.Text = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
            txtCountry.Text = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
            nudCapacity.Value = int.Parse(dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString());
            txtPrice.Text = dataGridView1.Rows[selectedIndex].Cells[4].Value.ToString();
            txtDayNight.Text = dataGridView1.Rows[selectedIndex].Cells[5].Value.ToString();
            cmbGuide.SelectedValue = dataGridView1.Rows[selectedIndex].Cells[6].Value;
        }
    }
}
