using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers.Dominio
{
    public class DtoProduct
    {
        private String idproduct;
        private String gender;
        private String editorial;
        private String price;
        private String name;
        private String description;
        private String stock;

        public DtoProduct(String idproduct, String gender, String editorial, String price, String name, String description, String stock)
        {
            this.idproduct = idproduct;
            this.gender = gender;
            this.editorial = editorial;
            this.price = price;
            this.name = name;
            this.description = description;
            this.stock = stock;
        }
        public string Idproduct
        {
            get
            {
                return idproduct;
            }

            set
            {
                idproduct = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Editorial
        {
            get
            {
                return editorial;
            }

            set
            {
                editorial = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }
    }
}
