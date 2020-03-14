namespace HayvanBarınağı
{
    partial class Departman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departman));
            System.Windows.Forms.Label bolumLabel;
            System.Windows.Forms.Label d_noLabel;
            this.vtyssDataSet = new HayvanBarınağı.vtyssDataSet();
            this.departmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanTableAdapter = new HayvanBarınağı.vtyssDataSetTableAdapters.departmanTableAdapter();
            this.tableAdapterManager = new HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager();
            this.departmanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.departmanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.departmanDataGridView = new System.Windows.Forms.DataGridView();
            this.bolumTextBox = new System.Windows.Forms.TextBox();
            this.d_noTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bolumLabel = new System.Windows.Forms.Label();
            d_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingNavigator)).BeginInit();
            this.departmanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vtyssDataSet
            // 
            this.vtyssDataSet.DataSetName = "vtyssDataSet";
            this.vtyssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmanBindingSource
            // 
            this.departmanBindingSource.DataMember = "departman";
            this.departmanBindingSource.DataSource = this.vtyssDataSet;
            // 
            // departmanTableAdapter
            // 
            this.departmanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bagisciTableAdapter = null;
            this.tableAdapterManager.bagısTableAdapter = null;
            this.tableAdapterManager.bolgeTableAdapter = null;
            this.tableAdapterManager.calisanTableAdapter = null;
            this.tableAdapterManager.departmanTableAdapter = this.departmanTableAdapter;
            this.tableAdapterManager.hayvanTableAdapter = null;
            this.tableAdapterManager.sahipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmanBindingNavigator
            // 
            this.departmanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departmanBindingNavigator.BindingSource = this.departmanBindingSource;
            this.departmanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departmanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departmanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.departmanBindingNavigatorSaveItem});
            this.departmanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.departmanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departmanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departmanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departmanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departmanBindingNavigator.Name = "departmanBindingNavigator";
            this.departmanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departmanBindingNavigator.Size = new System.Drawing.Size(285, 25);
            this.departmanBindingNavigator.TabIndex = 0;
            this.departmanBindingNavigator.Text = "bindingNavigator1";
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
            // departmanBindingNavigatorSaveItem
            // 
            this.departmanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.departmanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("departmanBindingNavigatorSaveItem.Image")));
            this.departmanBindingNavigatorSaveItem.Name = "departmanBindingNavigatorSaveItem";
            this.departmanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.departmanBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.departmanBindingNavigatorSaveItem.Click += new System.EventHandler(this.departmanBindingNavigatorSaveItem_Click);
            // 
            // departmanDataGridView
            // 
            this.departmanDataGridView.AutoGenerateColumns = false;
            this.departmanDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.departmanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.departmanDataGridView.DataSource = this.departmanBindingSource;
            this.departmanDataGridView.Location = new System.Drawing.Point(15, 28);
            this.departmanDataGridView.Name = "departmanDataGridView";
            this.departmanDataGridView.Size = new System.Drawing.Size(244, 220);
            this.departmanDataGridView.TabIndex = 1;
            // 
            // bolumLabel
            // 
            bolumLabel.AutoSize = true;
            bolumLabel.Location = new System.Drawing.Point(36, 289);
            bolumLabel.Name = "bolumLabel";
            bolumLabel.Size = new System.Drawing.Size(57, 13);
            bolumLabel.TabIndex = 2;
            bolumLabel.Text = "Bölüm Adı:";
            // 
            // bolumTextBox
            // 
            this.bolumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmanBindingSource, "bolum", true));
            this.bolumTextBox.Location = new System.Drawing.Point(99, 286);
            this.bolumTextBox.Name = "bolumTextBox";
            this.bolumTextBox.Size = new System.Drawing.Size(100, 20);
            this.bolumTextBox.TabIndex = 3;
            // 
            // d_noLabel
            // 
            d_noLabel.AutoSize = true;
            d_noLabel.Location = new System.Drawing.Point(12, 315);
            d_noLabel.Name = "d_noLabel";
            d_noLabel.Size = new System.Drawing.Size(86, 13);
            d_noLabel.TabIndex = 4;
            d_noLabel.Text = "Bölüm Numarası:";
            // 
            // d_noTextBox
            // 
            this.d_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmanBindingSource, "d_no", true));
            this.d_noTextBox.Location = new System.Drawing.Point(99, 312);
            this.d_noTextBox.Name = "d_noTextBox";
            this.d_noTextBox.Size = new System.Drawing.Size(100, 20);
            this.d_noTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bolum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bölüm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "d_no";
            this.dataGridViewTextBoxColumn2.HeaderText = "Bölüm No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Departman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(285, 381);
            this.Controls.Add(bolumLabel);
            this.Controls.Add(this.bolumTextBox);
            this.Controls.Add(d_noLabel);
            this.Controls.Add(this.d_noTextBox);
            this.Controls.Add(this.departmanDataGridView);
            this.Controls.Add(this.departmanBindingNavigator);
            this.Name = "Departman";
            this.Text = "Departman";
            this.Load += new System.EventHandler(this.Departman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingNavigator)).EndInit();
            this.departmanBindingNavigator.ResumeLayout(false);
            this.departmanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vtyssDataSet vtyssDataSet;
        private System.Windows.Forms.BindingSource departmanBindingSource;
        private vtyssDataSetTableAdapters.departmanTableAdapter departmanTableAdapter;
        private vtyssDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departmanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton departmanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView departmanDataGridView;
        private System.Windows.Forms.TextBox bolumTextBox;
        private System.Windows.Forms.TextBox d_noTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}