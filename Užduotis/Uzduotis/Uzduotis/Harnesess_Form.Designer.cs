
namespace Uzduotis
{
	partial class Harnesess_Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Harness_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harness_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Housing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(523, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sugeneruoti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Harness_1,
            this.Harness_2,
            this.Housing});
            this.dataGridView1.Location = new System.Drawing.Point(43, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 184);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Harness_1
            // 
            this.Harness_1.HeaderText = "Harness 1 (Name, version, drawing, drawing version)";
            this.Harness_1.MinimumWidth = 10;
            this.Harness_1.Name = "Harness_1";
            this.Harness_1.ReadOnly = true;
            this.Harness_1.Width = 185;
            // 
            // Harness_2
            // 
            this.Harness_2.HeaderText = "Harness 2 (Name, version, drawing, drawing version)";
            this.Harness_2.Name = "Harness_2";
            this.Harness_2.ReadOnly = true;
            this.Harness_2.Width = 185;
            // 
            // Housing
            // 
            this.Housing.HeaderText = "Housing (Harness1- Housing1,2; Harness2- Housing1,2 )";
            this.Housing.Name = "Housing";
            this.Housing.ReadOnly = true;
            this.Housing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Housing.Width = 171;
            // 
            // Harnesess_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1239, 574);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Harnesess_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harness_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harness_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Housing;
    }
}

