namespace HayvanBarınağı
{
    partial class Bölge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bölge));
            System.Windows.Forms.Label sehirLabel;
            System.Windows.Forms.Label sube_noLabel;
            this.vtyssDataSet = new HayvanBarınağı.vtyssDataSet();
            this.bolgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolgeTableAdapter = new HayvanBarınağı.vtyssDataSetTableAdapters.bolgeTableAdapter();
            this.tableAdapterManager = new HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager();
            this.bolgeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bolgeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bolgeDataGridView = new System.Windows.Forms.DataGridView();
            this.sehirTextBox = new System.Windows.Forms.TextBox();
            this.sube_noTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sehirLabel = new System.Windows.Forms.Label();
            sube_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeBindingNavigator)).BeginInit();
            this.bolgeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vtyssDataSet
            // 
            this.vtyssDataSet.DataSetName = "vtyssDataSet";
            this.vtyssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolgeBindingSource
            // 
            this.bolgeBindingSource.DataMember = "bolge";
            this.bolgeBindingSource.DataSource = this.vtyssDataSet;
            // 
            // bolgeTableAdapter
            // 
            this.bolgeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bagisciTableAdapter = null;
            this.tableAdapterManager.bagısTableAdapter = null;
            this.tableAdapterManager.bolgeTableAdapter = this.bolgeTableAdapter;
            this.tableAdapterManager.calisanTableAdapter = null;
            this.tableAdapterManager.departmanTableAdapter = null;
            this.tableAdapterManager.hayvanTableAdapter = null;
            this.tableAdapterManager.sahipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bolgeBindingNavigator
            // 
            this.bolgeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bolgeBindingNavigator.BindingSource = this.bolgeBindingSource;
            this.bolgeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bolgeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bolgeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bolgeBindingNavigatorSaveItem});
            this.bolgeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bolgeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bolgeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bolgeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bolgeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bolgeBindingNavigator.Name = "bolgeBindingNavigator";
            this.bolgeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bolgeBindingNavigator.Size = new System.Drawing.Size(299, 25);
            this.bolgeBindingNavigator.TabIndex = 0;
            this.bolgeBindingNavigator.Text = "bindingNavigator1";
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
            // bolgeBindingNavigatorSaveItem
            // 
            this.bolgeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bolgeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bolgeBindingNavigatorSaveItem.Image")));
            this.bolgeBindingNavigatorSaveItem.Name = "bolgeBindingNavigatorSaveItem";
            this.bolgeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bolgeBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.bolgeBindingNavigatorSaveItem.Click += new System.EventHandler(this.bolgeBindingNavigatorSaveItem_Click);
            // 
            // bolgeDataGridView
            // 
            this.bolgeDataGridView.AutoGenerateColumns = false;
            this.bolgeDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.bolgeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bolgeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bolgeDataGridView.DataSource = this.bolgeBindingSource;
            this.bolgeDataGridView.Location = new System.Drawing.Point(28, 28);
            this.bolgeDataGridView.Name = "bolgeDataGridView";
            this.bolgeDataGridView.Size = new System.Drawing.Size(243, 220);
            this.bolgeDataGridView.TabIndex = 1;
            // 
            // sehirLabel
            // 
            sehirLabel.AutoSize = true;
            sehirLabel.Location = new System.Drawing.Point(51, 281);
            sehirLabel.Name = "sehirLabel";
            sehirLabel.Size = new System.Drawing.Size(34, 13);
            sehirLabel.TabIndex = 2;
            sehirLabel.Text = "Şehir:";
            // 
            // sehirTextBox
            // 
            this.sehirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bolgeBindingSource, "sehir", true));
            this.sehirTextBox.Location = new System.Drawing.Point(105, 278);
            this.sehirTextBox.Name = "sehirTextBox";
            this.sehirTextBox.Size = new System.Drawing.Size(100, 20);
            this.sehirTextBox.TabIndex = 3;
            // 
            // sube_noLabel
            // 
            sube_noLabel.AutoSize = true;
            sube_noLabel.Location = new System.Drawing.Point(51, 307);
            sube_noLabel.Name = "sube_noLabel";
            sube_noLabel.Size = new System.Drawing.Size(52, 13);
            sube_noLabel.TabIndex = 4;
            sube_noLabel.Text = "Şube No:";
            // 
            // sube_noTextBox
            // 
            this.sube_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bolgeBindingSource, "sube_no", true));
            this.sube_noTextBox.Location = new System.Drawing.Point(105, 304);
            this.sube_noTextBox.Name = "sube_noTextBox";
            this.sube_noTextBox.Size = new System.Drawing.Size(100, 20);
            this.sube_noTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sehir";
            this.dataGridViewTextBoxColumn1.HeaderText = "Şehir";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sube_no";
            this.dataGridViewTextBoxColumn2.HeaderText = "Şube No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Bölge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(299, 366);
            this.Controls.Add(sehirLabel);
            this.Controls.Add(this.sehirTextBox);
            this.Controls.Add(sube_noLabel);
            this.Controls.Add(this.sube_noTextBox);
            this.Controls.Add(this.bolgeDataGridView);
            this.Controls.Add(this.bolgeBindingNavigator);
            this.Name = "Bölge";
            this.Text = "Bölge";
            this.Load += new System.EventHandler(this.Bölge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeBindingNavigator)).EndInit();
            this.bolgeBindingNavigator.ResumeLayout(false);
            this.bolgeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vtyssDataSet vtyssDataSet;
        private System.Windows.Forms.BindingSource bolgeBindingSource;
        private vtyssDataSetTableAdapters.bolgeTableAdapter bolgeTableAdapter;
        private vtyssDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bolgeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bolgeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bolgeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox sehirTextBox;
        private System.Windows.Forms.TextBox sube_noTextBox;
    }
}