using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporApp.DAL.DataService
{
	public class KontenjanDAL
	{
		DbConnection con = new DbConnection();
		MySqlCommand cmd = new MySqlCommand();

		public int hour_id(string kontenjan_hour)
		{
			switch (kontenjan_hour)
			{
				case "Tüm Seanslar":
					return 20;
				case "10:00 - 11:00":
					 return 1;
				case "11:00 - 12:00":
					return 2;
				case "12:00 - 13:00":
					return 3;
				case "13:00 - 14:00":
					return 4;
				case "14:00 - 15:00":
					return 5;
				case "15:00 - 16:00":
					return 6;
				case "16:00 - 17:00":
					return 7;
				case "17:00 - 18:00":
					return 8;
				case "18:00 - 19:00":
					return 9;
				case "19:00 - 20:00":
					return 10;
				case "20:00 - 21:00":
					return 11;
				case "21:00 - 22:00":
					return 12;
				case "22:00 - 23:00":
					return 13;
				case "23:00 - 24:00":
					return 14;
			}
			return 0;
		}
		public DataTable KontenjanGet(string kontenjan_salon, string kontenjan_date, string kontenjan_hour)
		{
			DataTable dt = new DataTable();
			if (hour_id(kontenjan_hour) == 20)
			{
				for (int k=1; k<15;k++)
				{
					cmd.Connection = con.dbConn();
					cmd.CommandText = String.Format("SELECT * FROM kontenjan where kontenjan_salon='" + kontenjan_salon + "' and kontenjan_date='" + kontenjan_date + "' and hours_id='" + k + "'");
					
					dt.Load(cmd.ExecuteReader());	
				}
				return dt;
			}
			else
			{
				cmd.Connection = con.dbConn();
				cmd.CommandText = String.Format("SELECT * FROM kontenjan where kontenjan_salon='" + kontenjan_salon + "' and kontenjan_date='" + kontenjan_date + "' and hours_id='" + hour_id(kontenjan_hour)+ "'");
				dt.Load(cmd.ExecuteReader());
				return dt;
			}
		}

		public DataTable KontenjanGets(string kontenjan_salon, string kontenjan_date)
		{
			DataTable dt = new DataTable();
			
				cmd.Connection = con.dbConn();
				cmd.CommandText = String.Format("SELECT * FROM kontenjan where kontenjan_salon='" + kontenjan_salon + "' and kontenjan_date='" + kontenjan_date + "'");
				dt.Load(cmd.ExecuteReader());
				return dt;
		}


		public void KontenjanAdd(string kontenjan_salon, string kontenjan_date,  int kontenjan_kontenjan, string kontenjan_durum)
		{
			cmd.Connection = con.dbConn();
			for (int i=1; i<15;i++)
			{
			cmd.CommandText = String.Format("Insert into kontenjan (kontenjan_salon,kontenjan_date,hours_id,kontenjan_doluluk,kontenjan_kapasite,kontenjan_durum) Values('{0}','{1}','{2}','{3}','{4}','{5}')", kontenjan_salon, kontenjan_date,i,0, kontenjan_kontenjan, kontenjan_durum);
			cmd.ExecuteNonQuery();
			}
		}

		public void KontenjanUpdate(string kontenjan_salon, string kontenjan_date, string kontenjan_kapasite, string kontenjan_hour)
		{
			cmd.Connection = con.dbConn();
			cmd.CommandText = String.Format("Update kontenjan SET kontenjan_kapasite='" + kontenjan_kapasite + "' where kontenjan_salon='" + kontenjan_salon + "' and kontenjan_date='" + kontenjan_date + "' and hours_id='" + hour_id(kontenjan_hour) + "' ");
			cmd.ExecuteNonQuery();
		}

		public void KontenjanUpdateDurum(string kontenjan_salon, string kontenjan_date, string kontenjan_durum, string kontenjan_hour)
		{
			cmd.Connection = con.dbConn();
			if (hour_id(kontenjan_hour) == 20)
			{
				for(int i = 1; i<15; i++)
				{
					cmd.CommandText = String.Format("Update kontenjan SET kontenjan_durum='" + kontenjan_durum + "', kontenjan_kapasite ='" + 0 + "' where kontenjan_salon='" + kontenjan_salon + "' and kontenjan_date='" + kontenjan_date + "' and hours_id='" +i + "'");
					cmd.ExecuteNonQuery();
				}
			}
			else { 
			cmd.CommandText = String.Format("Update kontenjan SET kontenjan_durum='" + kontenjan_durum + "', kontenjan_kapasite ='" + 0 + "' where kontenjan_salon='" + kontenjan_salon + "' and kontenjan_date='" + kontenjan_date + "' and hours_id='" + hour_id(kontenjan_hour) + "'");
			cmd.ExecuteNonQuery();
			}
		}
	}
}
