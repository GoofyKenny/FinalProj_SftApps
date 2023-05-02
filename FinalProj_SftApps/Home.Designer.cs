namespace FinalProj_SftApps
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NoText1 = new System.Windows.Forms.TextBox();
            this.maxlbl1 = new System.Windows.Forms.Label();
            this.typelbl = new System.Windows.Forms.Label();
            this.NoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaxpassText = new System.Windows.Forms.TextBox();
            this.MaxwText = new System.Windows.Forms.TextBox();
            this.Notext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maxpasslbl = new System.Windows.Forms.Label();
            this.maxwlbl = new System.Windows.Forms.Label();
            this.SNlbl = new System.Windows.Forms.Label();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new FinalProj_SftApps.DataSet2();
            this.trainsTableAdapter = new FinalProj_SftApps.DataSet2TableAdapters.TrainsTableAdapter();
            this.removeBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPassengers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.NoText1);
            this.panel1.Controls.Add(this.maxlbl1);
            this.panel1.Controls.Add(this.typelbl);
            this.panel1.Controls.Add(this.NoLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 67);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 37);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Diesel";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "500000";
            // 
            // NoText1
            // 
            this.NoText1.Location = new System.Drawing.Point(19, 38);
            this.NoText1.Margin = new System.Windows.Forms.Padding(2);
            this.NoText1.Name = "NoText1";
            this.NoText1.ReadOnly = true;
            this.NoText1.Size = new System.Drawing.Size(66, 20);
            this.NoText1.TabIndex = 2;
            this.NoText1.Text = "1148";
            // 
            // maxlbl1
            // 
            this.maxlbl1.AutoSize = true;
            this.maxlbl1.Location = new System.Drawing.Point(219, 22);
            this.maxlbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxlbl1.Name = "maxlbl1";
            this.maxlbl1.Size = new System.Drawing.Size(64, 13);
            this.maxlbl1.TabIndex = 1;
            this.maxlbl1.Text = "Max Weight";
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Location = new System.Drawing.Point(110, 22);
            this.typelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(31, 13);
            this.typelbl.TabIndex = 1;
            this.typelbl.Text = "Type";
            // 
            // NoLbl
            // 
            this.NoLbl.AutoSize = true;
            this.NoLbl.Location = new System.Drawing.Point(16, 22);
            this.NoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoLbl.Name = "NoLbl";
            this.NoLbl.Size = new System.Drawing.Size(21, 13);
            this.NoLbl.TabIndex = 1;
            this.NoLbl.Text = "No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MaxpassText);
            this.panel2.Controls.Add(this.MaxwText);
            this.panel2.Controls.Add(this.Notext);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.maxpasslbl);
            this.panel2.Controls.Add(this.maxwlbl);
            this.panel2.Controls.Add(this.SNlbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 558);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 84);
            this.panel2.TabIndex = 1;
            // 
            // MaxpassText
            // 
            this.MaxpassText.Location = new System.Drawing.Point(233, 33);
            this.MaxpassText.Name = "MaxpassText";
            this.MaxpassText.Size = new System.Drawing.Size(91, 20);
            this.MaxpassText.TabIndex = 2;
            // 
            // MaxwText
            // 
            this.MaxwText.Location = new System.Drawing.Point(122, 33);
            this.MaxwText.Name = "MaxwText";
            this.MaxwText.Size = new System.Drawing.Size(91, 20);
            this.MaxwText.TabIndex = 2;
            // 
            // Notext
            // 
            this.Notext.Location = new System.Drawing.Point(9, 34);
            this.Notext.Name = "Notext";
            this.Notext.Size = new System.Drawing.Size(91, 20);
            this.Notext.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 61);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(365, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Rail Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxpasslbl
            // 
            this.maxpasslbl.AutoSize = true;
            this.maxpasslbl.Location = new System.Drawing.Point(229, 10);
            this.maxpasslbl.Name = "maxpasslbl";
            this.maxpasslbl.Size = new System.Drawing.Size(85, 13);
            this.maxpasslbl.TabIndex = 0;
            this.maxpasslbl.Text = "Max Passengers";
            // 
            // maxwlbl
            // 
            this.maxwlbl.AutoSize = true;
            this.maxwlbl.Location = new System.Drawing.Point(122, 10);
            this.maxwlbl.Name = "maxwlbl";
            this.maxwlbl.Size = new System.Drawing.Size(64, 13);
            this.maxwlbl.TabIndex = 0;
            this.maxwlbl.Text = "Max Weight";
            // 
            // SNlbl
            // 
            this.SNlbl.AutoSize = true;
            this.SNlbl.Location = new System.Drawing.Point(13, 10);
            this.SNlbl.Name = "SNlbl";
            this.SNlbl.Size = new System.Drawing.Size(21, 13);
            this.SNlbl.TabIndex = 0;
            this.SNlbl.Text = "No";
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataMember = "Trains";
            this.trainsBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainsTableAdapter
            // 
            this.trainsTableAdapter.ClearBeforeFill = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(232, 77);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(121, 24);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove Selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(9, 77);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(52, 23);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SN,
            this.MaxWeight,
            this.MaxPassengers});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 411);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // SN
            // 
            this.SN.Text = "SN";
            this.SN.Width = 61;
            // 
            // MaxWeight
            // 
            this.MaxWeight.Text = "Max Weight";
            this.MaxWeight.Width = 84;
            // 
            // MaxPassengers
            // 
            this.MaxPassengers.Text = "Max Passengers";
            this.MaxPassengers.Width = 106;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 642);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NoLbl;
        private System.Windows.Forms.Label maxlbl1;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox NoText1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private DataSet2TableAdapters.TrainsTableAdapter trainsTableAdapter;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label SNlbl;
        private System.Windows.Forms.Label maxpasslbl;
        private System.Windows.Forms.Label maxwlbl;
        private System.Windows.Forms.TextBox MaxwText;
        private System.Windows.Forms.TextBox Notext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MaxpassText;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SN;
        private System.Windows.Forms.ColumnHeader MaxWeight;
        private System.Windows.Forms.ColumnHeader MaxPassengers;
    }
}