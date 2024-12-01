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
    public partial class FormStatistics : Form
    {
        EgitimKampiEFTravelDbEntities db;

        public FormStatistics()
        {
            InitializeComponent();
            db = new EgitimKampiEFTravelDbEntities();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            // Total location count
            var totalLocation = db.TblLocation.Count();
            lblTotalLocationCount.Text = totalLocation.ToString();

            // Total capacity
            var totalCapacity = db.TblLocation.Sum(location => location.Capacity);
            lblTotalCapacity.Text = totalCapacity.ToString();

            // Total guide count
            var totalGuide = db.TblGuide.Count();
            lblTotalGuideCount.Text = totalGuide.ToString();

            // Average location capacity
            var avgCapatiy = db.TblLocation.Average(location => location.Capacity);
            lblAvgCapacity.Text = avgCapatiy.ToString();

            // Average location price
            var avgPrice = db.TblLocation.Average(location => (decimal)location.Price);
            lblAvgLocationPrice.Text = avgPrice.ToString("0.00") + "₺";

            // Last added country
            var lastCountry = db.TblLocation.OrderByDescending(location => location.LocationId).FirstOrDefault();
            lblLastAddedCountry.Text = lastCountry.Country;

            // Kapadokya location capacity
            var kapadokyaCapacity = db.TblLocation.Where(location => location.City == "Kapadokya").Sum(location => location.Capacity);
            lblKapadokyaCapacity.Text = kapadokyaCapacity.ToString();

            // Türkiye tours average capacity
            var turkiyeToursAvgCapacity = db.TblLocation.Where(location => location.Country == "Türkiye").Average(location => location.Capacity);
            lblTurkiyeAvgCapacity.Text = turkiyeToursAvgCapacity.ToString();

            // Rome tour guide name
            var romeTourGuide = db.TblLocation.Where(location => location.City == "Roma Turistik").Select(location => location.TblGuide).FirstOrDefault();
            lblRomeTourGuideName.Text = romeTourGuide.GuideName + " " + romeTourGuide.GuideSurname;

            // Most capacity location
            var mostCapacityLocaiton = db.TblLocation.OrderByDescending(location => location.Capacity).FirstOrDefault();
            lblHighestCapacityCity.Text = mostCapacityLocaiton.City;

            // Most expensive location
            var mostExpensiveLocation = db.TblLocation.OrderByDescending(location => location.Price).FirstOrDefault();
            lblMostValuableCity.Text = mostExpensiveLocation.City;

            // Aysegul guide location count
            var aysegulCinarId = db.TblGuide.Where(guide=> guide.GuideName == "Ayşegül" && guide.GuideSurname=="Çınar").Select(guide => guide.GuideId).FirstOrDefault();
            var aysegulLocationCount = db.TblLocation.Where(location => location.GuideId == aysegulCinarId).Count();
            lblAysegulTourCount.Text = aysegulLocationCount.ToString();
        }
    }
}
