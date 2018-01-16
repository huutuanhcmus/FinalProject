namespace QuickNote2
{
    partial class ViewNote
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quickNodeDataSet = new QuickNote2.QuickNodeDataSet();
            this.noteTableAdapter = new QuickNote2.QuickNodeDataSetTableAdapters.NoteTableAdapter();
            this.tagTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quịckNote1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quịckNote1DataSet = new QuickNote2.QuịckNote1DataSet();
            this.noteTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteTableTableAdapter = new QuickNote2.QuịckNote1DataSetTableAdapters.NoteTableTableAdapter();
            this.tagTableTableAdapter = new QuickNote2.QuịckNote1DataSetTableAdapters.TagTableTableAdapter();
            this.tagTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tagTableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickNodeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quịckNote1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quịckNote1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataMember = "Note";
            this.noteBindingSource.DataSource = this.quickNodeDataSet;
            // 
            // quickNodeDataSet
            // 
            this.quickNodeDataSet.DataSetName = "QuickNodeDataSet";
            this.quickNodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteTableAdapter
            // 
            this.noteTableAdapter.ClearBeforeFill = true;
            // 
            // tagTableBindingSource
            // 
            this.tagTableBindingSource.DataMember = "TagTable";
            this.tagTableBindingSource.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // quịckNote1DataSetBindingSource
            // 
            this.quịckNote1DataSetBindingSource.DataSource = this.quịckNote1DataSet;
            this.quịckNote1DataSetBindingSource.Position = 0;
            // 
            // quịckNote1DataSet
            // 
            this.quịckNote1DataSet.DataSetName = "QuịckNote1DataSet";
            this.quịckNote1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteTableBindingSource
            // 
            this.noteTableBindingSource.DataMember = "NoteTable";
            this.noteTableBindingSource.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // noteTableTableAdapter
            // 
            this.noteTableTableAdapter.ClearBeforeFill = true;
            // 
            // tagTableTableAdapter
            // 
            this.tagTableTableAdapter.ClearBeforeFill = true;
            // 
            // tagTableBindingSource1
            // 
            this.tagTableBindingSource1.DataMember = "TagTable";
            this.tagTableBindingSource1.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // tagTableBindingSource2
            // 
            this.tagTableBindingSource2.DataMember = "TagTable";
            this.tagTableBindingSource2.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // tagTableBindingSource3
            // 
            this.tagTableBindingSource3.DataMember = "TagTable";
            this.tagTableBindingSource3.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(211, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 268);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tagTableBindingSource4
            // 
            this.tagTableBindingSource4.DataMember = "TagTable";
            this.tagTableBindingSource4.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // tagTableBindingSource5
            // 
            this.tagTableBindingSource5.DataMember = "TagTable";
            this.tagTableBindingSource5.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Date,
            this.Tag,
            this.Content});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView1.FullRowSelect = true;
            this.listView1.HoverSelection = true;
            listViewItem1.IndentCount = 100;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(450, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(653, 218);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // Tag
            // 
            this.Tag.Text = "Tag";
            this.Tag.Width = 150;
            // 
            // Content
            // 
            this.Content.Text = "Sample Content";
            this.Content.Width = 300;
            // 
            // tagTableBindingSource6
            // 
            this.tagTableBindingSource6.DataMember = "TagTable";
            this.tagTableBindingSource6.DataSource = this.quịckNote1DataSetBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(962, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(785, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(-188, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 409);
            this.panel1.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(450, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 33);
            this.button4.TabIndex = 24;
            this.button4.Text = "Reload";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(569, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "VIEW NOTE";
            // 
            // ViewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 425);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewNote";
            this.Text = "View notes";
            this.Load += new System.EventHandler(this.Note_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickNodeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quịckNote1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quịckNote1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private QuickNodeDataSet quickNodeDataSet;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private QuickNodeDataSetTableAdapters.NoteTableAdapter noteTableAdapter;

        private System.Windows.Forms.BindingSource tagBindingSource;
        private System.Windows.Forms.BindingSource quịckNote1DataSetBindingSource;
        private QuịckNote1DataSet quịckNote1DataSet;
        private System.Windows.Forms.BindingSource noteTableBindingSource;
        private QuịckNote1DataSetTableAdapters.NoteTableTableAdapter noteTableTableAdapter;
        private System.Windows.Forms.BindingSource tagTableBindingSource;
        private QuịckNote1DataSetTableAdapters.TagTableTableAdapter tagTableTableAdapter;
        private System.Windows.Forms.BindingSource tagTableBindingSource1;
        private System.Windows.Forms.BindingSource tagTableBindingSource2;
        private System.Windows.Forms.BindingSource tagTableBindingSource3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource tagTableBindingSource4;
        private System.Windows.Forms.BindingSource tagTableBindingSource5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.BindingSource tagTableBindingSource6;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Tag;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}