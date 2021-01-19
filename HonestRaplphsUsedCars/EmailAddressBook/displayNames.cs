using System;
using LeapLog;
using System.Windows.Forms;

namespace HonestRaplphsUsedCars
{
    public partial class displayNames : Form
    {
        public displayNames()
        {
            InitializeComponent();
        }

      

        public string displayName
        {
            get
            {
                return this.NameLabel.Text;
            }
            set
            {
                this.NameLabel.Text = value;
            }


        }

        public string displayLastName
        {
            get
            {
                return this.LastNameLabel.Text;
            }
            set
            {
                this.LastNameLabel.Text = value;
            }


        }
        public string displayDOBMonth
        {
            get
            {
                return this.MonthLabel.Text;
            }
            set
            {
                this.MonthLabel.Text = value;
            }


        }

        public string displayDOBDay
        {
            get
            {
                return this.dayLabel.Text;
            }
            set
            {
                this.dayLabel.Text = value;
            }


        }
  
        public string displayNumber
        {
            get
            {
                return this.label6.Text;
            }
            set
            {
                this.label6.Text = value;
            }


        }

        private void displayNames_Load(object sender, EventArgs e)
        {
           // PersonEntry sentVar = new PersonEntry();
             


            foreach (var i in DBManager.DataList)
            {
                NameLabel.Text = i.Name;
                LastNameLabel.Text = i.LastName;
                label6.Text = i.PhoneNumber;
                MonthLabel.Text = i.DOBMonth;
                dayLabel.Text = i.DOBDay;

                
            }

       
    }
    }
}
