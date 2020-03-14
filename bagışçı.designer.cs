namespace HayvanBarınağı
{
    partial class Bagışçı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bagışçı));
            System.Windows.Forms.Label b_tcLabel;
            System.Windows.Forms.Label b_isimLabel;
            System.Windows.Forms.Label tarihLabel;
            System.Windows.Forms.Label miktarLabel;
            System.Windows.Forms.Label sube_noLabel;
            this.vtyssDataSet = new HayvanBarınağı.vtyssDataSet();
            this.bagisciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bagisciTableAdapter = new HayvanBarınağı.vtyssDataSetTableAdapters.bagisciTableAdapter();
            this.tableAdapterManager = new HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager();
            this.bagisciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bagisciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bagisciDataGridView = new System.Windows.Forms.DataGridView();
            this.b_tcTextBox = new System.Windows.Forms.TextBox();
            this.b_isimTextBox = new System.Windows.Forms.TextBox();
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.miktarTextBox = new System.Windows.Forms.TextBox();
            this.sube_noTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            b_tcLabel = new System.Windows.Forms.Label();
            b_isimLabel = new System.Windows.Forms.Label();
            tarihLabel = new System.Windows.Forms.Label();
            miktarLabel = new System.Windows.Forms.Label();
            sube_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciBindingNavigator)).BeginInit();
            this.bagisciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vtyssDataSet
            // 
            this.vtyssDataSet.DataSetName = "vtyssDataSet";
            this.vtyssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagisciBindingSource
            // 
            this.bagisciBindingSource.DataMember = "bagisci";
            this.bagisciBindingSource.DataSource = this.vtyssDataSet;
            // 
            // bagisciTableAdapter
            // 
            this.bagisciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bagisciTableAdapter = this.bagisciTableAdapter;
            this.tableAdapterManager.bagısTableAdapter = null;
            this.tableAdapterManager.bolgeTableAdapter = null;
            this.tableAdapterManager.calisanTableAdapter = null;
            this.tableAdapterManager.departmanTableAdapter = null;
            this.tableAdapterManager.hayvanTableAdapter = null;
            this.tableAdapterManager.sahipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bagisciBindingNavigator
            // 
            this.bagisciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bagisciBindingNavigator.BindingSource = this.bagisciBindingSource;
            this.bagisciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bagisciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bagisciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bagisciBindingNavigatorSaveItem});
            this.bagisciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bagisciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bagisciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bagisciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bagisciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bagisciBindingNavigator.Name = "bagisciBindingNavigator";
            this.bagisciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bagisciBindingNavigator.Size = new System.Drawing.Size(585, 25);
            this.bagisciBindingNavigator.TabIndex = 0;
            this.bagisciBindingNavigator.Text = "bindingNavigator1";
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
            // bagisciBindingNavigatorSaveItem
            // 
            this.bagisciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bagisciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bagisciBindingNavigatorSaveItem.Image")));
            this.bagisciBindingNavigatorSaveItem.Name = "bagisciBindingNavigatorSaveItem";
            this.bagisciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bagisciBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.bagisciBindingNavigatorSaveItem.Click += new System.EventHandler(this.bagisciBindingNavigatorSaveItem_Click);
            // 
            // bagisciDataGridView
            // 
            this.bagisciDataGridView.AutoGenerateColumns = false;
            this.bagisciDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.bagisciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bagisciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bagisciDataGridView.DataSource = this.bagisciBindingSource;
            this.bagisciDataGridView.Location = new System.Drawing.Point(12, 28);
            this.bagisciDataGridView.Name = "bagisciDataGridView";
            this.bagisciDataGridView.Size = new System.Drawing.Size(543, 220);
            this.bagisciDataGridView.TabIndex = 1;
            // 
            // b_tcLabel
            // 
            b_tcLabel.AutoSize = true;
            b_tcLabel.Location = new System.Drawing.Point(12, 288);
            b_tcLabel.Name = "b_tcLabel";
            b_tcLabel.Size = new System.Drawing.Size(24, 13);
            b_tcLabel.TabIndex = 2;
            b_tcLabel.Text = "TC:";
            // 
            // b_tcTextBox
            // 
            this.b_tcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bagisciBindingSource, "b_tc", true));
            this.b_tcTextBox.Location = new System.Drawing.Point(88, 285);
            this.b_tcTextBox.Name = "b_tcTextBox";
            this.b_tcTextBox.Size = new System.Drawing.Size(200, 20);
            this.b_tcTextBox.TabIndex = 3;
            // 
            // b_isimLabel
            // 
            b_isimLabel.AutoSize = true;
            b_isimLabel.Location = new System.Drawing.Point(12, 314);
            b_isimLabel.Name = "b_isimLabel";
            b_isimLabel.Size = new System.Drawing.Size(25, 13);
            b_isimLabel.TabIndex = 4;
            b_isimLabel.Text = "Adı:";
            // 
            // b_isimTextBox
            // 
            this.b_isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bagisciBindingSource, "b_isim", true));
            this.b_isimTextBox.Location = new System.Drawing.Point(88, 311);
            this.b_isimTextBox.Name = "b_isimTextBox";
            this.b_isimTextBox.Size = new System.Drawing.Size(200, 20);
            this.b_isimTextBox.TabIndex = 5;
            // 
            // tarihLabel
            // 
            tarihLabel.AutoSize = true;
            tarihLabel.Location = new System.Drawing.Point(12, 341);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new System.Drawing.Size(65, 13);
            tarihLabel.TabIndex = 6;
            tarihLabel.Text = "Bağış Tarihi:";
            // 
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bagisciBindingSource, "tarih", true));
            this.tarihDateTimePicker.Location = new System.Drawing.Point(88, 337);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tarihDateTimePicker.TabIndex = 7;
            // 
            // miktarLabel
            // 
            miktarLabel.AutoSize = true;
            miktarLabel.Location = new System.Drawing.Point(12, 366);
            miktarLabel.Name = "miktarLabel";
            miktarLabel.Size = new System.Drawing.Size(70, 13);
            miktarLabel.TabIndex = 8;
            miktarLabel.Text = "Bağış Miktarı:";
            // 
            // miktarTextBox
            // 
            this.miktarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bagisciBindingSource, "miktar", true));
            this.miktarTextBox.Location = new System.Drawing.Point(88, 363);
            this.miktarTextBox.Name = "miktarTextBox";
            this.miktarTextBox.Size = new System.Drawing.Size(200, 20);
            this.miktarTextBox.TabIndex = 9;
            // 
            // sube_noLabel
            // 
            sube_noLabel.AutoSize = true;
            sube_noLabel.Location = new System.Drawing.Point(12, 392);
            sube_noLabel.Name = "sube_noLabel";
            sube_noLabel.Size = new System.Drawing.Size(52, 13);
            sube_noLabel.TabIndex = 10;
            sube_noLabel.Text = "Şube No:";
            // 
            // sube_noTextBox
            // 
            this.sube_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bagisciBindingSource, "sube_no", true));
            this.sube_noTextBox.Location = new System.Drawing.Point(88, 389);
            this.sube_noTextBox.Name = "sube_noTextBox";
            this.sube_noTextBox.Size = new System.Drawing.Size(200, 20);
            this.sube_noTextBox.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "b_tc";
            this.dataGridViewTextBoxColumn1.HeaderText = "TC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "b_isim";
            this.dataGridViewTextBoxColumn2.HeaderText = "İsim";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tarih";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "miktar";
            this.dataGridViewTextBoxColumn4.HeaderText = "Miktar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sube_no";
            this.dataGridViewTextBoxColumn5.HeaderText = "Şube No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Bagışçı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(585, 433);
            this.Controls.Add(b_tcLabel);
            this.Controls.Add(this.b_tcTextBox);
            this.Controls.Add(b_isimLabel);
            this.Controls.Add(this.b_isimTextBox);
            this.Controls.Add(tarihLabel);
            this.Controls.Add(this.tarihDateTimePicker);
            this.Controls.Add(miktarLabel);
            this.Controls.Add(this.miktarTextBox);
            this.Controls.Add(sube_noLabel);
            this.Controls.Add(this.sube_noTextBox);
            this.Controls.Add(this.bagisciDataGridView);
            this.Controls.Add(this.bagisciBindingNavigator);
            this.Name = "Bagışçı";
            this.Text = "Bagışçı";
            this.Load += new System.EventHandler(this.Bagışçı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciBindingNavigator)).EndInit();
            this.bagisciBindingNavigator.ResumeLayout(false);
            this.bagisciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vtyssDataSet vtyssDataSet;
        private System.Windows.Forms.BindingSource bagisciBindingSource;
        private vtyssDataSetTableAdapters.bagisciTableAdapter bagisciTableAdapter;
        private vtyssDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bagisciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bagisciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bagisciDataGridView;
        private System.Windows.Forms.TextBox b_tcTextBox;
        private System.Windows.Forms.TextBox b_isimTextBox;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.TextBox miktarTextBox;
        private System.Windows.Forms.TextBox sube_noTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}