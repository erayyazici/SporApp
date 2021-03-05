using SporApp.DAL.DataService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporApp.BLL.SporApp
{
	public class KontenjanBLL
	{
		private KontenjanDAL KontenjanDAL;
		public KontenjanBLL()
		{
			KontenjanDAL = new KontenjanDAL();
		}
		public void KontenjanAdd(string kontenjan_salon, string kontenjan_date,  int kontenjan_kontenjan, string kontenjan_durum)
		{
			KontenjanDAL.KontenjanAdd(kontenjan_salon, kontenjan_date, kontenjan_kontenjan, kontenjan_durum);
		}
		public DataTable KontenjanGet(string kontenjan_salon, string kontenjan_date, string kontenjan_hour)
		{
			return KontenjanDAL.KontenjanGet(kontenjan_salon,kontenjan_date,kontenjan_hour);
		}

		public DataTable KontenjanGets(string kontenjan_salon, string kontenjan_date)
		{
			return KontenjanDAL.KontenjanGets(kontenjan_salon, kontenjan_date);
		}
		public void KontenjanUpdate(string kontenjan_salon, string kontenjan_date, string kontenjan_kapasite, string kontenjan_hour)
		{
			KontenjanDAL.KontenjanUpdate(kontenjan_salon, kontenjan_date, kontenjan_kapasite, kontenjan_hour);
		}
		public void KontenjanUpdateDurum(string kontenjan_salon, string kontenjan_date, string kontenjan_durum, string kontenjan_hour)
		{
			KontenjanDAL.KontenjanUpdateDurum(kontenjan_salon, kontenjan_date, kontenjan_durum, kontenjan_hour);
		}
	}
}
