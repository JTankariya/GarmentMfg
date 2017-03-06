using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace GarmentMfg
{
    public class CompanyInfo
    {
        private int Comp_Id = 0;
        private string Comp_Name = "";
        private string Comp_Add1 = "";
        private string Comp_Add2 = "";
        private string Comp_Add3 = "";
        private string Comp_Add4 = "";
        private string Comp_Area = "";
        private string Comp_State = "";
        private string Comp_City = "";
        private string Comp_Country = "";
        private System.DateTime Comp_FromDate = System.DateTime.Today;
        private System.DateTime Comp_ToDate = System.DateTime.Today;
        private string Comp_Mobile = "";
        private string Comp_FaxNo = "";
        private string Comp_Phone = "";
        private string Comp_License = "";
        private string Comp_Email = "";
        private string Comp_ITNo = "";
        private string Comp_Stno = "";
        private string Comp_Cstno = "";

        public int CompId
        {
            get { return Comp_Id; }
            set
            {
                Comp_Id = value;
            }
        }

        public string CompName
        {
            get { return Comp_Name; }
            set
            {
                Comp_Name = value;
            }
        }

        public string CompITNo
        {
            get { return Comp_ITNo; }
            set
            {
                Comp_ITNo = value;
            }
        }

        public string CompAdd1
        {
            get { return Comp_Add1; }
            set
            {
                Comp_Add1 = value;
            }
        }
        public string CompAdd2
        {
            get { return Comp_Add2; }
            set
            {
                Comp_Add2 = value;
            }
        }
        public string CompAdd3
        {
            get { return Comp_Add3; }
            set
            {
                Comp_Add3 = value;
            }
        }
        public string CompAdd4
        {
            get { return Comp_Add4; }
            set
            {
                Comp_Add4 = value;
            }
        }

        public string CompArea
        {
            get { return Comp_Area; }
            set
            {
                Comp_Area = value;
            }
        }
        public string CompCity
        {
            get { return Comp_City; }
            set
            {
                Comp_City = value;
            }
        }
        public string CompState
        {
            get { return Comp_State; }
            set
            {
                Comp_State = value;
            }
        }
        public string CompCountry
        {
            get { return Comp_Country; }
            set
            {
                Comp_Country = value;
            }
        }
        public DateTime CompFromDate
        {
            get { return Comp_FromDate; }
            set
            {
                Comp_FromDate = value;
            }
        }
        public DateTime CompToDate
        {
            get { return Comp_ToDate; }
            set
            {
                Comp_ToDate = value;
            }
        }

        public string CompFaxNo
        {
            get { return Comp_FaxNo; }
            set
            {
                Comp_FaxNo = value;
            }
        }
        public string CompEmail
        {
            get { return Comp_Email; }
            set
            {
                Comp_Email = value;
            }
        }
        public string CompMobile
        {
            get { return Comp_Mobile; }
            set
            {
                Comp_Mobile = value;
            }
        }
        public string CompPhone
        {
            get { return Comp_Phone; }
            set
            {
                Comp_Phone = value;
            }
        }
        public string CompLicense
        {
            get { return Comp_License; }
            set
            {
                Comp_License = value;
            }
        }
        public string CompStno
        {
            get { return Comp_Stno; }
            set
            {
                Comp_Stno = value;
            }
        }
        public string CompCstno
        {
            get { return Comp_Cstno; }
            set
            {
                Comp_Cstno = value;
            }
        }
    }
}
