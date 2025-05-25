using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public abstract class ICamera
    {
       public string Brand { get; set; }
       public string Model { get; set; }
        public int Megapixels { get; set; }
        public double ZoomLevel { get; set; }
        public int MemoryCapacity { get; set; }
        public double PhotoSizeMB { get; set; }
        public bool HasFlash { get; set; }
        public bool HasAutofokus { get; set; }



        public ICamera() { }

        public ICamera(string brand, string model, int megapixels, double zoomLevel,
            int memoryCapacity, double photoSizeMB, bool hasFlash, bool hasAutofokus)
        {
            Brand = brand;
            Model = model;
            Megapixels = megapixels;
            ZoomLevel = zoomLevel;
            MemoryCapacity = memoryCapacity;
            PhotoSizeMB = photoSizeMB;
            HasFlash = hasFlash;
            HasAutofokus = hasAutofokus;
        }
        public abstract int CalculateMaxPhotos();

    }

}
