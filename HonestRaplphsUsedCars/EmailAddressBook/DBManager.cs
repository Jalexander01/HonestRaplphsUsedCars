using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;    
using System.Data;
using HonestRaplphsUsedCars;

namespace LeapLog
{
	class DBManager
	{
		SqlConnection connection;

		public static List<PersonEntry> DataList { get; set; } = new List<PersonEntry>(); // to save list of names from db

		public DBManager()
		{

			connection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Environment.CurrentDirectory}\EmailAddressBook.MDF;Integrated Security=True");
		}

		public DBManager(string connectionString)
		{
			connection = new SqlConnection(connectionString);
		}

	
		//<<------ this is read data method tables------>>
		////in porgress
		public void ReadData(string databaseCommand)
		{
			//PersonEntry person = new PersonEntry();

			// List<String> list = new List<String>();

			string query = databaseCommand;
			SqlDataAdapter sda = new SqlDataAdapter(query, connection);
			DataTable dataTable = new DataTable();
			sda.Fill(dataTable);

			string name;
			string lastname;
			string phoneNumber;
			string DOBMonth;
			string DOBDay;
			string email;

			foreach (DataRow row in dataTable.Rows)
			{
				name = row["Name"].ToString().Trim();
				lastname = row["LastName"].ToString().Trim();
			
				//email = row["Email"].ToString().Trim();
				phoneNumber = row["PhoneNumber"].ToString().Trim();
				DOBMonth = row["DOBMonth"].ToString().Trim();
				DOBDay = row["DOBDay"].ToString().Trim();


				DataList.Add(new PersonEntry(name, lastname, phoneNumber, DOBMonth, DOBDay));
				

				System.Diagnostics.Debug.WriteLine(name + " " + lastname + " " + phoneNumber);
			}

		}

		//<<------ this method writes data to tables------>>
		public void WriteData(string databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);
				command.ExecuteNonQuery();
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
		}

	 
	}
} //leaplog
