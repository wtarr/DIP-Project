using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DIP_ClassLib
{
    public class HistoryManagement
    {
        private List<ImageModification> _historyList;

        public HistoryManagement()
        {
           _historyList = new List<ImageModification>();
        }

        public void PushImageToList(Bitmap bitmap, string description)
        {
            var image = new ImageModification
            {
                Description = description,
                Image = bitmap
            };
            
        }

    }

    public class ImageModification
    {
        public string Description { get; set; }
        public Bitmap Image { get; set; }
    }
}
