using System;
using System.Collections.Generic;
using System.Text;

namespace XMLParsing
{
    public class Product
    {
        private string _Category;
        private string _ModelNumber;
        private string _ProductImage;
        private string _ModelName;
        private decimal _UnitCost;
        private string _Description;

        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        public string ModelNumber
        {
            get { return _ModelNumber; }
            set { _ModelNumber = value; }
        }

        public string ProductImage
        {
            get { return _ProductImage; }
            set { _ProductImage = value; }
        }

        public string ModelName
        {
            get { return _ModelName; }
            set { _ModelName = value; }
        }

        public decimal UnitCost
        {
            get { return _UnitCost; }
            set { _UnitCost = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
