namespace HayvanBarınağı
{
    partial class Çalışan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çalışan));
            System.Windows.Forms.Label c_tcLabel;
            System.Windows.Forms.Label c_dogum_tarihiLabel;
            System.Windows.Forms.Label c_isimLabel;
            System.Windows.Forms.Label maasLabel;
            System.Windows.Forms.Label sube_noLabel;
            System.Windows.Forms.Label d_noLabel;
            this.vtyssDataSet = new HayvanBarınağı.vtyssDataSet();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter = new HayvanBarınağı.vtyssDataSetTableAdapters.calisanTableAdapter();
            this.tableAdapterManager = new HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager();
            this.calisanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.calisanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.calisanDataGridView = new System.Windows.Forms.DataGridView();
            this.c_tcTextBox = new System.Windows.Forms.TextBox();
            this.c_dogum_tarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.c_isimTextBox = new System.Windows.Forms.TextBox();
            this.maasTextBox = new System.Windows.Forms.TextBox();
            this.sube_noTextBox = new System.Windows.Forms.TextBox();
            this.d_noTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            c_tcLabel = new System.Windows.Forms.Label();
            c_dogum_tarihiLabel = new System.Windows.Forms.Label();
            c_isimLabel = new System.Windows.Forms.Label();
            maasLabel = new System.Windows.Forms.Label();
            sube_noLabel = new System.Windows.Forms.Label();
            d_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingNavigator)).BeginInit();
            this.calisanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calisanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vtyssDataSet
            // 
            this.vtyssDataSet.DataSetName = "vtyssDataSet";
            this.vtyssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "calisan";
            this.calisanBindingSource.DataSource = this.vtyssDataSet;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bagisciTableAdapter = null;
            this.tableAdapterManager.bagısTableAdapter = null;
            this.tableAdapterManager.bolgeTableAdapter = null;
            this.tableAdapterManager.calisanTableAdapter = this.calisanTableAdapter;
            this.tableAdapterManager.departmanTableAdapter = null;
            this.tableAdapterManager.hayvanTableAdapter = null;
            this.tableAdapterManager.sahipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calisanBindingNavigator
            // 
            this.calisanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.calisanBindingNavigator.BindingSource = this.calisanBindingSource;
            this.calisanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.calisanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.calisanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.calisanBindingNavigatorSaveItem});
            this.calisanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.calisanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.calisanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.calisanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.calisanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.calisanBindingNavigator.Name = "calisanBindingNavigator";
            this.calisanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.calisanBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.calisanBindingNavigator.TabIndex = 0;
            this.calisanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // calisanBindingNavigatorSaveItem
            // 
            this.calisanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.calisanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("calisanBindingNavigatorSaveItem.Image")));
            this.calisanBindingNavigatorSaveItem.Name = "calisanBindingNavigatorSaveItem";
            this.calisanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.calisanBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.calisanBindingNavigatorSaveItem.Click += new System.EventHandler(this.calisanBindingNavigatorSaveItem_Click);
            // 
            // calisanDataGridView
            // 
            this.calisanDataGridView.AutoGenerateColumns = false;
            this.calisanDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.calisanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calisanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.calisanDataGridView.DataSource = this.calisanBindingSource;
            this.calisanDataGridView.Location = new System.Drawing.Point(0, 28);
            this.calisanDataGridView.Name = "calisanDataGridView";
            this.calisanDataGridView.Size = new System.Drawing.Size(643, 220);
            this.calisanDataGridView.TabIndex = 1;
            // 
            // c_tcLabel
            // 
            c_tcLabel.AutoSize = true;
            c_tcLabel.Location = new System.Drawing.Point(60, 287);
            c_tcLabel.Name = "c_tcLabel";
            c_tcLabel.Size = new System.Drawing.Size(24, 13);
            c_tcLabel.TabIndex = 2;
            c_tcLabel.Text = "TC:";
            // 
            // c_tcTextBox
            // 
            this.c_tcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calisanBindingSource, "c_tc", true));
            this.c_tcTextBox.Location = new System.Drawing.Point(142, 284);
            this.c_tcTextBox.Name = "c_tcTextBox";
            this.c_tcTextBox.Size = new System.Drawing.Size(200, 20);
            this.c_tcTextBox.TabIndex = 3;
            // 
            // c_dogum_tarihiLabel
            // 
            c_dogum_tarihiLabel.AutoSize = true;
            c_dogum_tarihiLabel.Location = new System.Drawing.Point(60, 314);
            c_dogum_tarihiLabel.Name = "c_dogum_tarihiLabel";
            c_dogum_tarihiLabel.Size = new System.Drawing.Size(73, 13);
            c_dogum_tarihiLabel.TabIndex = 4;
            c_dogum_tarihiLabel.Text = "Doğum Tarihi:";
            // 
            // c_dogum_tarihiDateTimePicker
            // 
            this.c_dogum_tarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.calisanBindingSource, "c_dogum_tarihi", true));
            this.c_dogum_tarihiDateTimePicker.Location = new System.Drawing.Point(142, 310);
            this.c_dogum_tarihiDateTimePicker.Name = "c_dogum_tarihiDateTimePicker";
            this.c_dogum_tarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.c_dogum_tarihiDateTimePicker.TabIndex = 5;
            // 
            // c_isimLabel
            // 
            c_isimLabel.AutoSize = true;
            c_isimLabel.Location = new System.Drawing.Point(60, 339);
            c_isimLabel.Name = "c_isimLabel";
            c_isimLabel.Size = new System.Drawing.Size(25, 13);
            c_isimLabel.TabIndex = 6;
            c_isimLabel.Text = "Adı:";
            // 
            // c_isimTextBox
            // 
            this.c_isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calisanBindingSource, "c_isim", true));
            this.c_isimTextBox.Location = new System.Drawing.Point(142, 336);
            this.c_isimTextBox.Name = "c_isimTextBox";
            this.c_isimTextBox.Size = new System.Drawing.Size(200, 20);
            this.c_isimTextBox.TabIndex = 7;
            // 
            // maasLabel
            // 
            maasLabel.AutoSize = true;
            maasLabel.Location = new System.Drawing.Point(60, 365);
            maasLabel.Name = "maasLabel";
            maasLabel.Size = new System.Drawing.Size(38, 13);
            maasLabel.TabIndex = 8;
            maasLabel.Text = "Maaşı:";
            // 
            // maasTextBox
            // 
            this.maasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calisanBindingSource, "maas", true));
            this.maasTextBox.Location = new System.Drawing.Point(142, 362);
            this.maasTextBox.Name = "maasTextBox";
            this.maasTextBox.Size = new System.Drawing.Size(200, 20);
            this.maasTextBox.TabIndex = 9;
            // 
            // sube_noLabel
            // 
            sube_noLabel.AutoSize = true;
            sube_noLabel.Location = new System.Drawing.Point(60, 391);
            sube_noLabel.Name = "sube_noLabel";
            sube_noLabel.Size = new System.Drawing.Size(52, 13);
            sube_noLabel.TabIndex = 10;
            sube_noLabel.Text = "Şube No:";
            // 
            // sube_noTextBox
            // 
            this.sube_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calisanBindingSource, "sube_no", true));
            this.sube_noTextBox.Location = new System.Drawing.Point(142, 388);
            this.sube_noTextBox.Name = "sube_noTextBox";
            this.sube_noTextBox.Size = new System.Drawing.Size(200, 20);
            this.sube_noTextBox.TabIndex = 11;
            // 
            // d_noLabel
            // 
            d_noLabel.AutoSize = true;
            d_noLabel.Location = new System.Drawing.Point(60, 417);
            d_noLabel.Name = "d_noLabel";
            d_noLabel.Size = new System.Drawing.Size(79, 13);
            d_noLabel.TabIndex = 12;
            d_noLabel.Text = "Departman No:";
            // 
            // d_noTextBox
            // 
            this.d_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calisanBindingSource, "d_no", true));
            this.d_noTextBox.Location = new System.Drawing.Point(142, 414);
            this.d_noTextBox.Name = "d_noTextBox";
            this.d_noTextBox.Size = new System.Drawing.Size(200, 20);
            this.d_noTextBox.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "c_tc";
            this.dataGridViewTextBoxColumn1.HeaderText = "TC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "c_dogum_tarihi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doğum Tarihi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "c_isim";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adı";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "maas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maaşı";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sube_no";
            this.dataGridViewTextBoxColumn5.HeaderText = "Şube No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "d_no";
            this.dataGridViewTextBoxColumn6.HeaderText = "Departman No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Çalışan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(663, 499);
            this.Controls.Add(c_tcLabel);
            this.Controls.Add(this.c_tcTextBox);
            this.Controls.Add(c_dogum_tarihiLabel);
            this.Controls.Add(this.c_dogum_tarihiDateTimePicker);
            this.Controls.Add(c_isimLabel);
            this.Controls.Add(this.c_isimTextBox);
            this.Controls.Add(maasLabel);
            this.Controls.Add(this.maasTextBox);
            this.Controls.Add(sube_noLabel);
            this.Controls.Add(this.sube_noTextBox);
            this.Controls.Add(d_noLabel);
            this.Controls.Add(this.d_noTextBox);
            this.Controls.Add(this.calisanDataGridView);
            this.Controls.Add(this.calisanBindingNavigator);
            this.Name = "Çalışan";
            this.Text = "Çalışan";
            this.Load += new System.EventHandler(this.Çalışan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingNavigator)).EndInit();
            this.calisanBindingNavigator.ResumeLayout(false);
            this.calisanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calisanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vtyssDataSet vtyssDataSet;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private vtyssDataSetTableAdapters.calisanTableAdapter calisanTableAdapter;
        private vtyssDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator calisanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton calisanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView calisanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox c_tcTextBox;
        private System.Windows.Forms.DateTimePicker c_dogum_tarihiDateTimePicker;
        private System.Windows.Forms.TextBox c_isimTextBox;
        private System.Windows.Forms.TextBox maasTextBox;
        private System.Windows.Forms.TextBox sube_noTextBox;
        private System.Windows.Forms.TextBox d_noTextBox;
    }
}