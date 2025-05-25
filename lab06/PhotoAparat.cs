using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab06
{
    public class PhotoAparat : ICamera
    {
        public PhotoAparat() : base() { }


        public PhotoAparat(string brand, string model, int megapixels, double zoomLevel,
            int memoryCapacity, double photoSizeMB, bool hasFlash, bool hasAutofokus) 
            : base (brand, model, megapixels, zoomLevel, memoryCapacity, photoSizeMB, hasFlash, hasAutofokus)
        { }
        public override int CalculateMaxPhotos()
        {
            return (int)((MemoryCapacity * 1024) / PhotoSizeMB);
        }
    }

}

