namespace HayvanBarınağı
{
    partial class Hayvan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hayvan));
            System.Windows.Forms.Label h_isimLabel;
            System.Windows.Forms.Label turLabel;
            System.Windows.Forms.Label cinsLabel;
            System.Windows.Forms.Label kayit_tarihiLabel;
            System.Windows.Forms.Label dogum_tarihiLabel;
            System.Windows.Forms.Label h_noLabel;
            System.Windows.Forms.Label s_tcLabel;
            System.Windows.Forms.Label sube_noLabel;
            this.vtyssDataSet = new HayvanBarınağı.vtyssDataSet();
            this.hayvanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hayvanTableAdapter = new HayvanBarınağı.vtyssDataSetTableAdapters.hayvanTableAdapter();
            this.tableAdapterManager = new HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager();
            this.hayvanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hayvanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hayvanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_isimTextBox = new System.Windows.Forms.TextBox();
            this.turTextBox = new System.Windows.Forms.TextBox();
            this.cinsTextBox = new System.Windows.Forms.TextBox();
            this.kayit_tarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dogum_tarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.h_noTextBox = new System.Windows.Forms.TextBox();
            this.s_tcTextBox = new System.Windows.Forms.TextBox();
            this.sube_noTextBox = new System.Windows.Forms.TextBox();
            h_isimLabel = new System.Windows.Forms.Label();
            turLabel = new System.Windows.Forms.Label();
            cinsLabel = new System.Windows.Forms.Label();
            kayit_tarihiLabel = new System.Windows.Forms.Label();
            dogum_tarihiLabel = new System.Windows.Forms.Label();
            h_noLabel = new System.Windows.Forms.Label();
            s_tcLabel = new System.Windows.Forms.Label();
            sube_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanBindingNavigator)).BeginInit();
            this.hayvanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vtyssDataSet
            // 
            this.vtyssDataSet.DataSetName = "vtyssDataSet";
            this.vtyssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hayvanBindingSource
            // 
            this.hayvanBindingSource.DataMember = "hayvan";
            this.hayvanBindingSource.DataSource = this.vtyssDataSet;
            // 
            // hayvanTableAdapter
            // 
            this.hayvanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bagisciTableAdapter = null;
            this.tableAdapterManager.bagısTableAdapter = null;
            this.tableAdapterManager.bolgeTableAdapter = null;
            this.tableAdapterManager.calisanTableAdapter = null;
            this.tableAdapterManager.departmanTableAdapter = null;
            this.tableAdapterManager.hayvanTableAdapter = this.hayvanTableAdapter;
            this.tableAdapterManager.sahipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HayvanBarınağı.vtyssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hayvanBindingNavigator
            // 
            this.hayvanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hayvanBindingNavigator.BindingSource = this.hayvanBindingSource;
            this.hayvanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hayvanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hayvanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hayvanBindingNavigatorSaveItem});
            this.hayvanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hayvanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hayvanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hayvanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hayvanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hayvanBindingNavigator.Name = "hayvanBindingNavigator";
            this.hayvanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hayvanBindingNavigator.Size = new System.Drawing.Size(875, 25);
            this.hayvanBindingNavigator.TabIndex = 0;
            this.hayvanBindingNavigator.Text = "bindingNavigator1";
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
            // hayvanBindingNavigatorSaveItem
            // 
            this.hayvanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hayvanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hayvanBindingNavigatorSaveItem.Image")));
            this.hayvanBindingNavigatorSaveItem.Name = "hayvanBindingNavigatorSaveItem";
            this.hayvanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hayvanBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.hayvanBindingNavigatorSaveItem.Click += new System.EventHandler(this.hayvanBindingNavigatorSaveItem_Click);
            // 
            // hayvanDataGridView
            // 
            this.hayvanDataGridView.AutoGenerateColumns = false;
            this.hayvanDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.hayvanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hayvanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.hayvanDataGridView.DataSource = this.hayvanBindingSource;
            this.hayvanDataGridView.Location = new System.Drawing.Point(12, 28);
            this.hayvanDataGridView.Name = "hayvanDataGridView";
            this.hayvanDataGridView.Size = new System.Drawing.Size(843, 220);
            this.hayvanDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "h_isim";
            this.dataGridViewTextBoxColumn1.HeaderText = "h_isim";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tur";
            this.dataGridViewTextBoxColumn2.HeaderText = "tur";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cins";
            this.dataGridViewTextBoxColumn3.HeaderText = "cins";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kayit_tarihi";
            this.dataGridViewTextBoxColumn4.HeaderText = "kayit_tarihi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dogum_tarihi";
            this.dataGridViewTextBoxColumn5.HeaderText = "dogum_tarihi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "h_no";
            this.dataGridViewTextBoxColumn6.HeaderText = "h_no";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "s_tc";
            this.dataGridViewTextBoxColumn7.HeaderText = "s_tc";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "sube_no";
            this.dataGridViewTextBoxColumn8.HeaderText = "sube_no";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // h_isimLabel
            // 
            h_isimLabel.AutoSize = true;
            h_isimLabel.Location = new System.Drawing.Point(74, 269);
            h_isimLabel.Name = "h_isimLabel";
            h_isimLabel.Size = new System.Drawing.Size(25, 13);
            h_isimLabel.TabIndex = 2;
            h_isimLabel.Text = "Adı:";
            // 
            // h_isimTextBox
            // 
            this.h_isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hayvanBindingSource, "h_isim", true));
            this.h_isimTextBox.Location = new System.Drawing.Point(147, 266);
            this.h_isimTextBox.Name = "h_isimTextBox";
            this.h_isimTextBox.Size = new System.Drawing.Size(200, 20);
            this.h_isimTextBox.TabIndex = 3;
            // 
            // turLabel
            // 
            turLabel.AutoSize = true;
            turLabel.Location = new System.Drawing.Point(74, 295);
            turLabel.Name = "turLabel";
            turLabel.Size = new System.Drawing.Size(32, 13);
            turLabel.TabIndex = 4;
            turLabel.Text = "Türü:";
            // 
            // turTextBox
            // 
            this.turTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hayvanBindingSource, "tur", true));
            this.turTextBox.Location = new System.Drawing.Point(147, 292);
            this.turTextBox.Name = "turTextBox";
            this.turTextBox.Size = new System.Drawing.Size(200, 20);
            this.turTextBox.TabIndex = 5;
            // 
            // cinsLabel
            // 
            cinsLabel.AutoSize = true;
            cinsLabel.Location = new System.Drawing.Point(74, 321);
            cinsLabel.Name = "cinsLabel";
            cinsLabel.Size = new System.Drawing.Size(32, 13);
            cinsLabel.TabIndex = 6;
            cinsLabel.Text = "Cinsi:";
            // 
            // cinsTextBox
            // 
            this.cinsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hayvanBindingSource, "cins", true));
            this.cinsTextBox.Location = new System.Drawing.Point(147, 318);
            this.cinsTextBox.Name = "cinsTextBox";
            this.cinsTextBox.Size = new System.Drawing.Size(200, 20);
            this.cinsTextBox.TabIndex = 7;
            // 
            // kayit_tarihiLabel
            // 
            kayit_tarihiLabel.AutoSize = true;
            kayit_tarihiLabel.Location = new System.Drawing.Point(74, 348);
            kayit_tarihiLabel.Name = "kayit_tarihiLabel";
            kayit_tarihiLabel.Size = new System.Drawing.Size(62, 13);
            kayit_tarihiLabel.TabIndex = 8;
            kayit_tarihiLabel.Text = "Kayıt Tarihi:";
            // 
            // kayit_tarihiDateTimePicker
            // 
            this.kayit_tarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hayvanBindingSource, "kayit_tarihi", true));
            this.kayit_tarihiDateTimePicker.Location = new System.Drawing.Point(147, 344);
            this.kayit_tarihiDateTimePicker.Name = "kayit_tarihiDateTimePicker";
            this.kayit_tarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.kayit_tarihiDateTimePicker.TabIndex = 9;
            // 
            // dogum_tarihiLabel
            // 
            dogum_tarihiLabel.AutoSize = true;
            dogum_tarihiLabel.Location = new System.Drawing.Point(74, 374);
            dogum_tarihiLabel.Name = "dogum_tarihiLabel";
            dogum_tarihiLabel.Size = new System.Drawing.Size(73, 13);
            dogum_tarihiLabel.TabIndex = 10;
            dogum_tarihiLabel.Text = "Doğum Tarihi:";
            // 
            // dogum_tarihiDateTimePicker
            // 
            this.dogum_tarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hayvanBindingSource, "dogum_tarihi", true));
            this.dogum_tarihiDateTimePicker.Location = new System.Drawing.Point(147, 370);
            this.dogum_tarihiDateTimePicker.Name = "dogum_tarihiDateTimePicker";
            this.dogum_tarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dogum_tarihiDateTimePicker.TabIndex = 11;
            // 
            // h_noLabel
            // 
            h_noLabel.AutoSize = true;
            h_noLabel.Location = new System.Drawing.Point(74, 399);
            h_noLabel.Name = "h_noLabel";
            h_noLabel.Size = new System.Drawing.Size(61, 13);
            h_noLabel.TabIndex = 12;
            h_noLabel.Text = "Hayvan ID:";
            // 
            // h_noTextBox
            // 
            this.h_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hayvanBindingSource, "h_no", true));
            this.h_noTextBox.Location = new System.Drawing.Point(147, 396);
            this.h_noTextBox.Name = "h_noTextBox";
            this.h_noTextBox.Size = new System.Drawing.Size(200, 20);
            this.h_noTextBox.TabIndex = 13;
            // 
            // s_tcLabel
            // 
            s_tcLabel.AutoSize = true;
            s_tcLabel.Location = new System.Drawing.Point(21, 425);
            s_tcLabel.Name = "s_tcLabel";
            s_tcLabel.Size = new System.Drawing.Size(115, 13);
            s_tcLabel.TabIndex = 14;
            s_tcLabel.Text = "Sahibinin TC numarası:";
            // 
            // s_tcTextBox
            // 
            this.s_tcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hayvanBindingSource, "s_tc", true));
            this.s_tcTextBox.Location = new System.Drawing.Point(147, 422);
            this.s_tcTextBox.Name = "s_tcTextBox";
            this.s_tcTextBox.Size = new System.Drawing.Size(200, 20);
            this.s_tcTextBox.TabIndex = 15;
            // 
            // sube_noLabel
            // 
            sube_noLabel.AutoSize = true;
            sube_noLabel.Location = new System.Drawing.Point(74, 451);
            sube_noLabel.Name = "sube_noLabel";
            sube_noLabel.Size = new System.Drawing.Size(52, 13);
            sube_noLabel.TabIndex = 16;
            sube_noLabel.Text = "Şube No:";
            // 
            // sube_noTextBox
            // 
            this.sube_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hayvanBindingSource, "sube_no", true));
            this.sube_noTextBox.Location = new System.Drawing.Point(147, 448);
            this.sube_noTextBox.Name = "sube_noTextBox";
            this.sube_noTextBox.Size = new System.Drawing.Size(200, 20);
            this.sube_noTextBox.TabIndex = 17;
            // 
            // Hayvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(875, 495);
            this.Controls.Add(h_isimLabel);
            this.Controls.Add(this.h_isimTextBox);
            this.Controls.Add(turLabel);
            this.Controls.Add(this.turTextBox);
            this.Controls.Add(cinsLabel);
            this.Controls.Add(this.cinsTextBox);
            this.Controls.Add(kayit_tarihiLabel);
            this.Controls.Add(this.kayit_tarihiDateTimePicker);
            this.Controls.Add(dogum_tarihiLabel);
            this.Controls.Add(this.dogum_tarihiDateTimePicker);
            this.Controls.Add(h_noLabel);
            this.Controls.Add(this.h_noTextBox);
            this.Controls.Add(s_tcLabel);
            this.Controls.Add(this.s_tcTextBox);
            this.Controls.Add(sube_noLabel);
            this.Controls.Add(this.sube_noTextBox);
            this.Controls.Add(this.hayvanDataGridView);
            this.Controls.Add(this.hayvanBindingNavigator);
            this.Name = "Hayvan";
            this.Text = "Hayvan";
            this.Load += new System.EventHandler(this.Hayvan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtyssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanBindingNavigator)).EndInit();
            this.hayvanBindingNavigator.ResumeLayout(false);
            this.hayvanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vtyssDataSet vtyssDataSet;
        private System.Windows.Forms.BindingSource hayvanBindingSource;
        private vtyssDataSetTableAdapters.hayvanTableAdapter hayvanTableAdapter;
        private vtyssDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hayvanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hayvanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hayvanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox h_isimTextBox;
        private System.Windows.Forms.TextBox turTextBox;
        private System.Windows.Forms.TextBox cinsTextBox;
        private System.Windows.Forms.DateTimePicker kayit_tarihiDateTimePicker;
        private System.Windows.Forms.DateTimePicker dogum_tarihiDateTimePicker;
        private System.Windows.Forms.TextBox h_noTextBox;
        private System.Windows.Forms.TextBox s_tcTextBox;
        private System.Windows.Forms.TextBox sube_noTextBox;
    }
}