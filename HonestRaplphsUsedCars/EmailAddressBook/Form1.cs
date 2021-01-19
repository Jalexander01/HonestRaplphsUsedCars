using LeapLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonestRaplphsUsedCars
{
    public partial class Form1 : Form
    {

        displayNames display = new displayNames();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager sqlPerson = new DBManager();
             
           
            PersonEntry person = new PersonEntry();
            person.Name = textBoxName.Text;
            person.LastName = textBoxLastname.Text;
            person.PhoneNumber = textBoxPhoneNumber.Text;
            person.DOBMonth = textBoxDOBMonth.Text;
            person.DOBDay = textBoxDOBDay.Text;
            
           


            sqlPerson.WriteData("INSERT INTO Person VALUES ('" + person.Name + "','" + person.LastName + "','" + person.PhoneNumber  + "','" + person.DOBMonth + "','" + person.DOBDay + "')");
            
            sqlPerson.ReadData("SELECT * FROM Person");

            listBox1.Items.Insert(0, "------");
            foreach (var i in DBManager.DataList)
            {
                
                listBox1.Items.Insert(0, i.Name);
            }
            
           


        }//end of butto1_click


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonEntry sentVar = new PersonEntry();
            sentVar.boxItem = listBox1.SelectedItem.ToString();

            
            foreach (var i in DBManager.DataList)
            {
                if (sentVar.boxItem == i.LastName|| sentVar.boxItem == i.Name|| sentVar.boxItem == i.PhoneNumber)
                {
                    display.displayName = i.Name;
                    display.displayLastName = i.LastName;
                    display.displayNumber = i.PhoneNumber;
                    display.displayDOBMonth = i.DOBMonth;
                    display.displayDOBDay = i.DOBDay;
                   
                }
                
            }

            display.Show();
        }//end of select item click


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by James Alexander");
        }//end of aboutstripMenu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end of exitToolMenuStrip

       
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            
            DBManager sqlPerson = new DBManager();
            sqlPerson.ReadData("SELECT * FROM Person");

            listBox1.Items.Insert(0, "------");
            foreach (var i in DBManager.DataList)
            {

                listBox1.Items.Insert(0, i.LastName);
            }
            listBox1.Items.Insert(0, "------");
        }//end button2 click

        private void button3_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem_Click(sender, e);


            listBox1.DataSource = null;
            listBox1.Items.Clear();

            DBManager sqlPerson = new DBManager();
            sqlPerson.ReadData("Select * from Person where lastname = '" + textBox1.Text.Trim() + "'");

            listBox1.Items.Insert(0, "------");
            foreach (var i in DBManager.DataList)
            {

                listBox1.Items.Insert(0, i.Name);
                
            }
            listBox1.Items.Insert(0, "------");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

             listBox1.Items.Clear();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem_Click(sender, e);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            DBManager sqlPerson = new DBManager();
            sqlPerson.ReadData("Select * from Person where name = '" + textBox2.Text.Trim() + "'");
           
            listBox1.Items.Insert(0, "------");
            foreach (var i in DBManager.DataList)
            {

                listBox1.Items.Insert(0, i.LastName);

            }
            listBox1.Items.Insert(0, "------");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem_Click(sender, e);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            DBManager sqlPerson = new DBManager();
            sqlPerson.ReadData("Select * from Person where dobmonth = '" + textBox3.Text.Trim() + "'");

            listBox1.Items.Insert(0, "------");
            foreach (var i in DBManager.DataList)
            {

                listBox1.Items.Insert(0, i.LastName);

            }
            listBox1.Items.Insert(0, "------");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem_Click(sender, e);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            DBManager sqlPerson = new DBManager();
            sqlPerson.ReadData("Select * from Person");

            listBox1.Items.Insert(0, "------");
            foreach (var i in DBManager.DataList)
            {

                listBox1.Items.Insert(0, i.PhoneNumber);

            }
            listBox1.Items.Insert(0, "------");
        }
    }
}
