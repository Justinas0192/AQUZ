using System;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis
{
	public class SqliteData
	{
		public static List<HarnessModel> LoadHarness_drawings()
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				string query;
				Random random = new Random();
				int limit = random.Next(1, 3);
				if (limit == 1)
				{
					 query = $"SELECT harness_drawing.Harness, harness_drawing.Harness_Version, harness_drawing.Drawing, harness_drawing.Drawing_Version, harness_wires.Housing_1, harness_wires.Housing_2 FROM harness_drawing INNER JOIN harness_wires ON harness_drawing.ID = harness_wires.Harness_ID ORDER BY RANDOM() LIMIT 6";
				}
				else 
				{
					 query = $"SELECT harness_drawing.Harness, harness_drawing.Harness_Version, harness_drawing.Drawing, harness_drawing.Drawing_Version, harness_wires.Housing_1, harness_wires.Housing_2 FROM harness_drawing INNER JOIN harness_wires ON harness_drawing.ID = harness_wires.Harness_ID ORDER BY RANDOM() LIMIT 8";
				}
				
				var output = cnn.Query<HarnessModel>(query, new DynamicParameters());
				return output.ToList();

			}
		}
		private static string LoadConnectionString(string id = "Default") 
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
