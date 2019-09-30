using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItemLibrary.Model
{
    public class Item
    {
        public int Id;
        public string Name;
        public string Quality;
        public double Quantity;

        void Data() {}

        public Item(int id, string name, string quality, double quantity)
        {
            Id = id;
            Name = name;
            Quality = quality;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return Id+Name+Quality+Quantity;
        }

    }
}
