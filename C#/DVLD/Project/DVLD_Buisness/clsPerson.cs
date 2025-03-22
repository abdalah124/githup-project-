using System;
using System.Data;
using System.Xml.Linq;
using DVLD_DataAccess;


namespace DVLD_Buisness
{
    public  class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public string NationalNo { set; get; }
        public DateTime DateOfBirth { set; get; }
        public short Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }

        public clsCountry CountryInfo;
        public string Car { set; get; }
        public string CarNumber { set; get; }

        private string _ImagePath;
      
        public string ImagePath   
        {
            get { return _ImagePath; }   
            set { _ImagePath = value; }  
        }
        private string _CarImagePath;

        public string CarImagePath
        {
            get { return _CarImagePath; }
            set { _CarImagePath = value; }
        }

        public clsPerson()

        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            this.Car = "";
            this.CarImagePath = "";
            this.CarNumber = "";

            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName,string SecondName, string ThirdName,
            string LastName,string NationalNo, DateTime DateOfBirth,short Gendor,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath,string Car,string CarImagePath,string CarNumber)

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName= SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;   
            this.DateOfBirth = DateOfBirth;
            this.Gendor= Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            this.Car = Car;
            this.CarNumber = CarNumber;
            this.CarImagePath = CarImagePath;
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPersonData.AddNewPerson(
                this.FirstName,this.SecondName ,this.ThirdName,
                this.LastName,this.NationalNo,
                this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath,this.Car,this.CarImagePath,this.CarNumber);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPersonData.UpdatePerson(
                this.PersonID, this.FirstName,this.SecondName,this.ThirdName,
                this.LastName, this.NationalNo, this.DateOfBirth, this.Gendor,
                this.Address, this.Phone, this.Email, 
                  this.NationalityCountryID, this.ImagePath,this.Car,this._CarImagePath,this.CarNumber);
        }

        public static clsPerson Find(int PersonID)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",NationalNo="", Email = "", Phone = "", Address = "", ImagePath = "",Car = "" ,CarImagePath ="",CarNumber = "";
            DateTime DateOfBirth = DateTime.Now ;
            int NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData.GetPersonInfoByID
                                (
                                    PersonID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth,
                                    ref Gendor, ref Address, ref Phone, ref Email,
                                    ref NationalityCountryID, ref ImagePath,
                                    ref Car, ref CarImagePath,ref CarNumber
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPerson(PersonID, FirstName,SecondName ,ThirdName, LastName,
                          NationalNo, DateOfBirth,Gendor, Address, Phone, Email,NationalityCountryID, ImagePath,Car,CarImagePath,CarNumber);
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",  Email = "", Phone = "", Address = "", ImagePath = "",Car="" , CarImagePath = "", CarNumber= "";
            DateTime DateOfBirth = DateTime.Now;
            int PersonID=-1,NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData.GetPersonInfoByNationalNo
                                (
                                    NationalNo, ref PersonID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, ref DateOfBirth,
                                    ref Gendor,ref Address, ref Phone, ref Email,
                                    ref NationalityCountryID, ref ImagePath,
                                    ref Car , ref CarImagePath, ref CarNumber
                                );

            if (IsFound)

                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth,Gendor, Address, Phone, Email, NationalityCountryID, ImagePath,Car,CarImagePath,CarNumber);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID); 
        }

        public static bool isPersonExist(int ID)
        {
           return clsPersonData.IsPersonExist(ID);
        }

        public static bool isPersonExist(string NationlNo)
        {
            return clsPersonData.IsPersonExist(NationlNo);
        }

    }
}
