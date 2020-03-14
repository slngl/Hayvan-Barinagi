namespace HayvanBarınağı
{
    partial class Sahip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sahip));
            System.Windows.Forms.Label s_isimLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label s_tcLabel;
            System.Windows.Forms.Label h_noLabel;
            this.vtyssDataSet = new HayvanBarınağı.vtyssDataSet();
            this.sahipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sahipTableAdapter = new HayvanBarınağı.vtyssDataSetTableAdapters.sahipTableAdapter();
            this.tableAdapterManager = new HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager();
            this.sahipBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sahipBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sahipDataGridView = new System.Windows.Forms.DataGridView();
            this.s_isimTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.s_tcTextBox = new System.Windows.Forms.TextBox();
            this.h_noTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            s_isimLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            s_tcLabel = new System.Windows.Forms.Label();
            h_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipBindingNavigator)).BeginInit();
            this.sahipBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sahipDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vtyssDataSet
            // 
            this.vtyssDataSet.DataSetName = "vtyssDataSet";
            this.vtyssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahipBindingSource
            // 
            this.sahipBindingSource.DataMember = "sahip";
            this.sahipBindingSource.DataSource = this.vtyssDataSet;
            // 
            // sahipTableAdapter
            // 
            this.sahipTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bagisciTableAdapter = null;
            this.tableAdapterManager.bagısTableAdapter = null;
            this.tableAdapterManager.bolgeTableAdapter = null;
            this.tableAdapterManager.calisanTableAdapter = null;
            this.tableAdapterManager.departmanTableAdapter = null;
            this.tableAdapterManager.hayvanTableAdapter = null;
            this.tableAdapterManager.sahipTableAdapter = this.sahipTableAdapter;
            this.tableAdapterManager.UpdateOrder = HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sahipBindingNavigator
            // 
            this.sahipBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sahipBindingNavigator.BindingSource = this.sahipBindingSource;
            this.sahipBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sahipBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sahipBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sahipBindingNavigatorSaveItem});
            this.sahipBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sahipBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sahipBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sahipBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sahipBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sahipBindingNavigator.Name = "sahipBindingNavigator";
            this.sahipBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sahipBindingNavigator.Size = new System.Drawing.Size(475, 25);
            this.sahipBindingNavigator.TabIndex = 0;
            this.sahipBindingNavigator.Text = "bindingNavigator1";
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
            // sahipBindingNavigatorSaveItem
            // 
            this.sahipBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sahipBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sahipBindingNavigatorSaveItem.Image")));
            this.sahipBindingNavigatorSaveItem.Name = "sahipBindingNavigatorSaveItem";
            this.sahipBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sahipBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.sahipBindingNavigatorSaveItem.Click += new System.EventHandler(this.sahipBindingNavigatorSaveItem_Click);
            // 
            // sahipDataGridView
            // 
            this.sahipDataGridView.AutoGenerateColumns = false;
            this.sahipDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.sahipDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sahipDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sahipDataGridView.DataSource = this.sahipBindingSource;
            this.sahipDataGridView.Location = new System.Drawing.Point(12, 28);
            this.sahipDataGridView.Name = "sahipDataGridView";
            this.sahipDataGridView.Size = new System.Drawing.Size(450, 220);
            this.sahipDataGridView.TabIndex = 1;
            // 
            // s_isimLabel
            // 
            s_isimLabel.AutoSize = true;
            s_isimLabel.Location = new System.Drawing.Point(128, 270);
            s_isimLabel.Name = "s_isimLabel";
            s_isimLabel.Size = new System.Drawing.Size(25, 13);
            s_isimLabel.TabIndex = 2;
            s_isimLabel.Text = "Adı:";
            // 
            // s_isimTextBox
            // 
            this.s_isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sahipBindingSource, "s_isim", true));
            this.s_isimTextBox.Location = new System.Drawing.Point(170, 267);
            this.s_isimTextBox.Name = "s_isimTextBox";
            this.s_isimTextBox.Size = new System.Drawing.Size(100, 20);
            this.s_isimTextBox.TabIndex = 3;
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(128, 296);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 4;
            adresLabel.Text = "Adres:";
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sahipBindingSource, "adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(170, 293);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresTextBox.TabIndex = 5;
            // 
            // s_tcLabel
            // 
            s_tcLabel.AutoSize = true;
            s_tcLabel.Location = new System.Drawing.Point(128, 322);
            s_tcLabel.Name = "s_tcLabel";
            s_tcLabel.Size = new System.Drawing.Size(24, 13);
            s_tcLabel.TabIndex = 6;
            s_tcLabel.Text = "TC:";
            // 
            // s_tcTextBox
            // 
            this.s_tcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sahipBindingSource, "s_tc", true));
            this.s_tcTextBox.Location = new System.Drawing.Point(170, 319);
            this.s_tcTextBox.Name = "s_tcTextBox";
            this.s_tcTextBox.Size = new System.Drawing.Size(100, 20);
            this.s_tcTextBox.TabIndex = 7;
            // 
            // h_noLabel
            // 
            h_noLabel.AutoSize = true;
            h_noLabel.Location = new System.Drawing.Point(104, 348);
            h_noLabel.Name = "h_noLabel";
            h_noLabel.Size = new System.Drawing.Size(61, 13);
            h_noLabel.TabIndex = 8;
            h_noLabel.Text = "Hayvan ID:";
            // 
            // h_noTextBox
            // 
            this.h_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sahipBindingSource, "h_no", true));
            this.h_noTextBox.Location = new System.Drawing.Point(170, 345);
            this.h_noTextBox.Name = "h_noTextBox";
            this.h_noTextBox.Size = new System.Drawing.Size(100, 20);
            this.h_noTextBox.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "s_isim";
            this.dataGridViewTextBoxColumn1.HeaderText = "Adı";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "adres";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "s_tc";
            this.dataGridViewTextBoxColumn3.HeaderText = "TC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "h_no";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hayvan ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Sahip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(475, 427);
            this.Controls.Add(s_isimLabel);
            this.Controls.Add(this.s_isimTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(s_tcLabel);
            this.Controls.Add(this.s_tcTextBox);
            this.Controls.Add(h_noLabel);
            this.Controls.Add(this.h_noTextBox);
            this.Controls.Add(this.sahipDataGridView);
            this.Controls.Add(this.sahipBindingNavigator);
            this.Name = "Sahip";
            this.Text = "Sahip";
            this.Load += new System.EventHandler(this.Sahip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipBindingNavigator)).EndInit();
            this.sahipBindingNavigator.ResumeLayout(false);
            this.sahipBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sahipDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vtyssDataSet vtyssDataSet;
        private System.Windows.Forms.BindingSource sahipBindingSource;
        private vtyssDataSetTableAdapters.sahipTableAdapter sahipTableAdapter;
        private vtyssDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sahipBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sahipBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sahipDataGridView;
        private System.Windows.Forms.TextBox s_isimTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox s_tcTextBox;
        private System.Windows.Forms.TextBox h_noTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}