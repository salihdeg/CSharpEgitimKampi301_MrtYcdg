using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301_MrtYcdg.EFProject
{
    public partial class Form1 : Form
    {
        EgitimKampiEFTravelDbEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new EgitimKampiEFTravelDbEntities();
            List();
            dataGridView1.ClearSelection();
        }

        private void List()
        {
            List<TblGuide> values = db.TblGuide.ToList();
            dataGridView1.DataSource = values;
        }

        private bool CheckTextBoxes()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text))
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

            TblGuide guide = new TblGuide();

            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;

            db.TblGuide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide added successfully!");
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please fill the ID field!");
                return;
            }

            int id = int.Parse(txtId.Text);
            var guide = db.TblGuide.Find(id);
            db.TblGuide.Remove(guide);
            db.SaveChanges();
            MessageBox.Show("Guide deleted successfully!");
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var guide = db.TblGuide.Find(id);
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Guide updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            dataGridView1.ClearSelection();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.TblGuide.Where(guide => guide.GuideId == id).ToList();
            dataGridView1.DataSource = values;

            //var guide = db.TblGuide.Find(id);
            //dataGridView1.DataSource = new List<TblGuide> { guide };
        }
    }
}
