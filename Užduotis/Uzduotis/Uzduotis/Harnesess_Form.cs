using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzduotis
{
	public partial class Harnesess_Form : Form
	{
		public Harnesess_Form()
		{
			InitializeComponent();

			DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
			cellStyle.Font = new Font("Arial", 18, FontStyle.Bold); 
			dataGridView1.DefaultCellStyle = cellStyle;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoadHarness_drawings();
			dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		private void LoadHarness_drawings() 
		{
		List<HarnessModel> HarnessData = SqliteData.LoadHarness_drawings();
			dataGridView1.Rows.Clear(); // Clear all the previously created rows
			int rowCount = HarnessData.Count/2-1; // Get the number of rows that need to be created
			for(int i=0; i<= rowCount; i++)
            {
				string[] row = { HarnessData[i*2].Harness + ", " + HarnessData[i * 2].Harness_version + ", " + HarnessData[i*2].Drawing + ", " + HarnessData[i * 2].Drawing_version, HarnessData[i * 2 + 1].Harness + ", " + HarnessData[i * 2 + 1].Harness_version + ", " + HarnessData[i * 2 + 1].Drawing + ", " + HarnessData[i * 2 + 1].Drawing_version, HarnessData[i * 2].Housing_1 + ", " + HarnessData[i * 2].Housing_2 + " ; " + HarnessData[i * 2 + 1].Housing_1 + ", " + HarnessData[i * 2 + 1].Housing_2 };
				dataGridView1.Rows.Add(row);
				if (CheckIfHousingIsMatching(i*2, HarnessData)) // Change the color if the criteria is matched
				{
					dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
				}
				else dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.White;
			}
		}
		private bool CheckIfHousingIsMatching(int x, List<HarnessModel> HarnessData) // Check if housing is matching
		{
			if (HarnessData[x].Housing_1 == HarnessData[x + 1].Housing_1 || HarnessData[x].Housing_1 == HarnessData[x + 1].Housing_2 || HarnessData[x].Housing_2 == HarnessData[x + 1].Housing_1 || HarnessData[x].Housing_2 == HarnessData[x + 1].Housing_2)
			{
				return true;
			}
			else return false;
		}
	}
}
