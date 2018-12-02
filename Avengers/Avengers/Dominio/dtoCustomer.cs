using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers.Dominio
{
    public class DtoCustomer
    {
        private String idcustomer;
        private String name;
        private String surname;
        private String address;
        private String phone;
        private String email;

        private String refzipcodescities;
        private String dni;

        public DtoCustomer(String id, String name, String surname, String address, String phone, String email, String refzipcodescities, String dni)
        {
            this.idcustomer = id;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.refzipcodescities = refzipcodescities;
            this.dni = dni;

        }


        public string Idcustomer
        {
            get
            {
                return idcustomer;
            }

            set
            {
                idcustomer = value;
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

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }


        public string Refzipcodescities
        {
            get
            {
                return refzipcodescities;
            }

            set
            {
                refzipcodescities = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }
    }
}
