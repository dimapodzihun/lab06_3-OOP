using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class fPhotoAparat : Form
    {
        private ICamera thePhotoAparat;

        public fPhotoAparat(ICamera thePhotoAparat)
        {
            InitializeComponent();
            this.thePhotoAparat = thePhotoAparat;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            thePhotoAparat.Brand = tbBrand.Text.Trim();
                thePhotoAparat.Model = tbModel.Text.Trim();
                thePhotoAparat.Megapixels = int.Parse(tbmegapixel.Text.Trim());
                thePhotoAparat.ZoomLevel = double.Parse(tbzoom.Text.Trim());
                thePhotoAparat.MemoryCapacity = int.Parse(tbmemory.Text.Trim());
                thePhotoAparat.PhotoSizeMB = double.Parse(tbsize.Text.Trim());
                thePhotoAparat.HasFlash = chbHasFlash.Checked;
                thePhotoAparat.HasAutofokus = chbHasAutofokus.Checked;

                // Закриваємо діалог і передаємо результат
                DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fPhotoAparat_Load(object sender, EventArgs e)
        {
            if (thePhotoAparat != null)
            {
                tbBrand.Text = thePhotoAparat.Brand;
                tbModel.Text = thePhotoAparat.Model;
                tbmegapixel.Text = thePhotoAparat.Megapixels.ToString();
                tbzoom.Text = thePhotoAparat.ZoomLevel.ToString();
                tbmemory.Text = thePhotoAparat.MemoryCapacity.ToString();
                tbsize.Text = thePhotoAparat.PhotoSizeMB.ToString();
                chbHasFlash.Checked = thePhotoAparat.HasFlash;
                chbHasAutofokus.Checked = thePhotoAparat.HasAutofokus;
            }
        }

        private void btnCalculateMaxPhotos_Click(object sender, EventArgs e)
        {
            ICamera cameras = new PhotoAparat(
         tbBrand.Text,
         tbModel.Text,
         Convert.ToInt32(tbmegapixel.Text),
         Convert.ToDouble(tbzoom.Text),
         Convert.ToInt32(tbmemory.Text),
         Convert.ToDouble(tbsize.Text),
         chbHasFlash.Checked,
         chbHasAutofokus.Checked);

            int calculation = cameras.CalculateMaxPhotos();
            tbShowCalculateMaxPhotos.Text = calculation.ToString();
        }
    }
}
