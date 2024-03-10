
namespace WorkHourCalculator
{
    partial class Form
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Weekday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Start1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.End1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Start2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.End2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Start3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.End3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CalculateMinutes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CalculateHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerateExcel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTotalMinites = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalHour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl1.Location = new System.Drawing.Point(0, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1054, 287);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.EditorKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Date,
            this.Weekday,
            this.Start1,
            this.End1,
            this.Start2,
            this.End2,
            this.Start3,
            this.End3,
            this.CalculateMinutes,
            this.CalculateHours});
            this.gridView1.DetailHeight = 547;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            // 
            // Date
            // 
            this.Date.Caption = "تاریخ";
            this.Date.FieldName = "Date";
            this.Date.MinWidth = 28;
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            this.Date.Width = 115;
            // 
            // Weekday
            // 
            this.Weekday.Caption = "روز هفته";
            this.Weekday.FieldName = "WeekDay";
            this.Weekday.MinWidth = 28;
            this.Weekday.Name = "Weekday";
            this.Weekday.Visible = true;
            this.Weekday.VisibleIndex = 1;
            this.Weekday.Width = 117;
            // 
            // Start1
            // 
            this.Start1.Caption = "شروع";
            this.Start1.FieldName = "Start1.Start";
            this.Start1.MinWidth = 28;
            this.Start1.Name = "Start1";
            this.Start1.Visible = true;
            this.Start1.VisibleIndex = 2;
            this.Start1.Width = 93;
            // 
            // End1
            // 
            this.End1.Caption = "نوقف";
            this.End1.FieldName = "Start1.End";
            this.End1.MinWidth = 28;
            this.End1.Name = "End1";
            this.End1.Visible = true;
            this.End1.VisibleIndex = 3;
            this.End1.Width = 110;
            // 
            // Start2
            // 
            this.Start2.Caption = "شروع مجدد2";
            this.Start2.FieldName = "Start2.Start";
            this.Start2.MinWidth = 28;
            this.Start2.Name = "Start2";
            this.Start2.Visible = true;
            this.Start2.VisibleIndex = 4;
            this.Start2.Width = 118;
            // 
            // End2
            // 
            this.End2.Caption = "توقف مجدد2";
            this.End2.FieldName = "Start2.End";
            this.End2.MinWidth = 28;
            this.End2.Name = "End2";
            this.End2.Visible = true;
            this.End2.VisibleIndex = 5;
            this.End2.Width = 118;
            // 
            // Start3
            // 
            this.Start3.Caption = "شروع مجدد3";
            this.Start3.FieldName = "Start3.Start";
            this.Start3.MinWidth = 28;
            this.Start3.Name = "Start3";
            this.Start3.Visible = true;
            this.Start3.VisibleIndex = 6;
            this.Start3.Width = 118;
            // 
            // End3
            // 
            this.End3.Caption = "نوقف3";
            this.End3.FieldName = "Start3.End";
            this.End3.MinWidth = 28;
            this.End3.Name = "End3";
            this.End3.Visible = true;
            this.End3.VisibleIndex = 7;
            this.End3.Width = 127;
            // 
            // CalculateMinutes
            // 
            this.CalculateMinutes.Caption = "جمع دقایق کارکرد";
            this.CalculateMinutes.FieldName = "CalculateMinutes";
            this.CalculateMinutes.MinWidth = 28;
            this.CalculateMinutes.Name = "CalculateMinutes";
            this.CalculateMinutes.Visible = true;
            this.CalculateMinutes.VisibleIndex = 9;
            this.CalculateMinutes.Width = 106;
            // 
            // CalculateHours
            // 
            this.CalculateHours.Caption = "جمع ساعات کارکرد";
            this.CalculateHours.FieldName = "CalculateHours";
            this.CalculateHours.MinWidth = 28;
            this.CalculateHours.Name = "CalculateHours";
            this.CalculateHours.Visible = true;
            this.CalculateHours.VisibleIndex = 8;
            this.CalculateHours.Width = 148;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(960, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "تاریخ شروع";
            // 
            // btnGenerateExcel
            // 
            this.btnGenerateExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateExcel.Location = new System.Drawing.Point(475, 25);
            this.btnGenerateExcel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGenerateExcel.Name = "btnGenerateExcel";
            this.btnGenerateExcel.Size = new System.Drawing.Size(199, 33);
            this.btnGenerateExcel.TabIndex = 3;
            this.btnGenerateExcel.Text = "ایجاد اکسل و  دیتا";
            this.btnGenerateExcel.UseVisualStyleBackColor = true;
            this.btnGenerateExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(372, 25);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ذخیره دیتا";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(812, 25);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(142, 32);
            this.dateTimePicker.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(703, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // txtTotalMinites
            // 
            this.txtTotalMinites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMinites.Location = new System.Drawing.Point(188, 25);
            this.txtTotalMinites.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTotalMinites.Name = "txtTotalMinites";
            this.txtTotalMinites.Size = new System.Drawing.Size(76, 32);
            this.txtTotalMinites.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(270, 29);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 25);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "جمع دقیقه ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(103, 28);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 25);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "جمع ساعت";
            // 
            // txtTotalHour
            // 
            this.txtTotalHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalHour.Location = new System.Drawing.Point(21, 25);
            this.txtTotalHour.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTotalHour.Name = "txtTotalHour";
            this.txtTotalHour.Size = new System.Drawing.Size(76, 32);
            this.txtTotalHour.TabIndex = 9;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 373);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTotalHour);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTotalMinites);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerateExcel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1068, 420);
            this.Name = "Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Weekday;
        private DevExpress.XtraGrid.Columns.GridColumn Start1;
        private DevExpress.XtraGrid.Columns.GridColumn End1;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn CalculateHours;
        private System.Windows.Forms.Button btnGenerateExcel;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn Start2;
        private DevExpress.XtraGrid.Columns.GridColumn End2;
        private DevExpress.XtraGrid.Columns.GridColumn Start3;
        private DevExpress.XtraGrid.Columns.GridColumn End3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn CalculateMinutes;
        private System.Windows.Forms.TextBox txtTotalMinites;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtTotalHour;
    }
}

