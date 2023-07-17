namespace RM
{
    partial class frmoperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rMDataSet1 = new RM.RMDataSet1();
            this.operationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.operationTableAdapter1 = new RM.RMDataSet1TableAdapters.operationTableAdapter();
            this.rMDataSet = new RM.RMDataSet();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationTableAdapter = new RM.RMDataSetTableAdapters.operationTableAdapter();
            this.rMDataSet2 = new RM.RMDataSet2();
            this.operationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.operationTableAdapter2 = new RM.RMDataSet2TableAdapters.operationTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uruntipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN ADI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÜRÜN FİYATI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 114);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(395, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(395, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(395, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "ÜRÜN TİPİ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(395, 176);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "Görüntüle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yiyecek",
            "İçecek"});
            this.comboBox1.Location = new System.Drawing.Point(163, 146);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // rMDataSet1
            // 
            this.rMDataSet1.DataSetName = "RMDataSet1";
            this.rMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationBindingSource1
            // 
            this.operationBindingSource1.DataMember = "operation";
            this.operationBindingSource1.DataSource = this.rMDataSet1;
            // 
            // operationTableAdapter1
            // 
            this.operationTableAdapter1.ClearBeforeFill = true;
            // 
            // rMDataSet
            // 
            this.rMDataSet.DataSetName = "RMDataSet";
            this.rMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataMember = "operation";
            this.operationBindingSource.DataSource = this.rMDataSet;
            // 
            // operationTableAdapter
            // 
            this.operationTableAdapter.ClearBeforeFill = true;
            // 
            // rMDataSet2
            // 
            this.rMDataSet2.DataSetName = "RMDataSet2";
            this.rMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationBindingSource2
            // 
            this.operationBindingSource2.DataMember = "operation";
            this.operationBindingSource2.DataSource = this.rMDataSet2;
            // 
            // operationTableAdapter2
            // 
            this.operationTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.urunfiyatiDataGridViewTextBoxColumn,
            this.uruntipiDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.operationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(37, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 277);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "urunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "urunID";
            this.urunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunfiyatiDataGridViewTextBoxColumn
            // 
            this.urunfiyatiDataGridViewTextBoxColumn.DataPropertyName = "urunfiyati";
            this.urunfiyatiDataGridViewTextBoxColumn.HeaderText = "urunfiyati";
            this.urunfiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunfiyatiDataGridViewTextBoxColumn.Name = "urunfiyatiDataGridViewTextBoxColumn";
            this.urunfiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // uruntipiDataGridViewTextBoxColumn
            // 
            this.uruntipiDataGridViewTextBoxColumn.DataPropertyName = "uruntipi";
            this.uruntipiDataGridViewTextBoxColumn.HeaderText = "uruntipi";
            this.uruntipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uruntipiDataGridViewTextBoxColumn.Name = "uruntipiDataGridViewTextBoxColumn";
            this.uruntipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            this.durumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // frmoperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmoperation";
            this.Text = "frmoperation";
            this.Load += new System.EventHandler(this.frmoperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private RMDataSet rMDataSet;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private RMDataSetTableAdapters.operationTableAdapter operationTableAdapter;
        private RMDataSet1 rMDataSet1;
        private System.Windows.Forms.BindingSource operationBindingSource1;
        private RMDataSet1TableAdapters.operationTableAdapter operationTableAdapter1;
        private RMDataSet2 rMDataSet2;
        private System.Windows.Forms.BindingSource operationBindingSource2;
        private RMDataSet2TableAdapters.operationTableAdapter operationTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uruntipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}