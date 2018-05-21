namespace ProductionDB
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.RadioDoll = new System.Windows.Forms.RadioButton();
            this.RadioEquipment = new System.Windows.Forms.RadioButton();
            this.ListResult = new System.Windows.Forms.ListView();
            this.ColCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmdFind = new System.Windows.Forms.Button();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.TxtMinute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // RadioDoll
            // 
            this.RadioDoll.AutoSize = true;
            this.RadioDoll.Checked = true;
            this.RadioDoll.Location = new System.Drawing.Point(14, 15);
            this.RadioDoll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioDoll.Name = "RadioDoll";
            this.RadioDoll.Size = new System.Drawing.Size(58, 19);
            this.RadioDoll.TabIndex = 3;
            this.RadioDoll.TabStop = true;
            this.RadioDoll.Text = "인형";
            this.RadioDoll.UseVisualStyleBackColor = true;
            this.RadioDoll.Click += new System.EventHandler(this.RadioDoll_Click);
            // 
            // RadioEquipment
            // 
            this.RadioEquipment.AutoSize = true;
            this.RadioEquipment.Location = new System.Drawing.Point(74, 15);
            this.RadioEquipment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioEquipment.Name = "RadioEquipment";
            this.RadioEquipment.Size = new System.Drawing.Size(58, 19);
            this.RadioEquipment.TabIndex = 4;
            this.RadioEquipment.Text = "장비";
            this.RadioEquipment.UseVisualStyleBackColor = true;
            this.RadioEquipment.Click += new System.EventHandler(this.RadioEquipment_Click);
            // 
            // ListResult
            // 
            this.ListResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColCategory,
            this.ColGrade,
            this.ColName});
            this.ListResult.FullRowSelect = true;
            this.ListResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListResult.Location = new System.Drawing.Point(14, 46);
            this.ListResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListResult.MultiSelect = false;
            this.ListResult.Name = "ListResult";
            this.ListResult.Size = new System.Drawing.Size(383, 152);
            this.ListResult.TabIndex = 4;
            this.ListResult.TabStop = false;
            this.ListResult.UseCompatibleStateImageBehavior = false;
            this.ListResult.View = System.Windows.Forms.View.Details;
            // 
            // ColCategory
            // 
            this.ColCategory.Text = "종류";
            this.ColCategory.Width = 92;
            // 
            // ColGrade
            // 
            this.ColGrade.Text = "등급";
            this.ColGrade.Width = 80;
            // 
            // ColName
            // 
            this.ColName.Text = "이름";
            this.ColName.Width = 155;
            // 
            // CmdFind
            // 
            this.CmdFind.Location = new System.Drawing.Point(312, 12);
            this.CmdFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdFind.Name = "CmdFind";
            this.CmdFind.Size = new System.Drawing.Size(86, 26);
            this.CmdFind.TabIndex = 2;
            this.CmdFind.Text = "검색";
            this.CmdFind.UseVisualStyleBackColor = true;
            this.CmdFind.Click += new System.EventHandler(this.CmdFind_Click);
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(230, 14);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtHour.MaxLength = 1;
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(22, 25);
            this.TxtHour.TabIndex = 0;
            this.TxtHour.Text = "0";
            this.TxtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtHour.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtHour_MouseClick);
            this.TxtHour.TextChanged += new System.EventHandler(this.TxtHour_TextChanged);
            this.TxtHour.Enter += new System.EventHandler(this.TxtHour_Enter);
            this.TxtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHour_KeyPress);
            this.TxtHour.Leave += new System.EventHandler(this.TxtHour_Leave);
            // 
            // TxtMinute
            // 
            this.TxtMinute.Location = new System.Drawing.Point(277, 14);
            this.TxtMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtMinute.MaxLength = 2;
            this.TxtMinute.Name = "TxtMinute";
            this.TxtMinute.Size = new System.Drawing.Size(28, 25);
            this.TxtMinute.TabIndex = 1;
            this.TxtMinute.Text = "0";
            this.TxtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMinute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtMinute_MouseClick);
            this.TxtMinute.TextChanged += new System.EventHandler(this.TxtMinute_TextChanged);
            this.TxtMinute.Enter += new System.EventHandler(this.TxtMinute_Enter);
            this.TxtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMinute_KeyPress);
            this.TxtMinute.Leave += new System.EventHandler(this.TxtMinute_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "시간";
            // 
            // Copyright
            // 
            this.Copyright.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Copyright.Location = new System.Drawing.Point(155, 202);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(243, 23);
            this.Copyright.TabIndex = 6;
            this.Copyright.Text = "Copyright (c) 2018 이상한녀석";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.CmdFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 227);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMinute);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.CmdFind);
            this.Controls.Add(this.ListResult);
            this.Controls.Add(this.RadioEquipment);
            this.Controls.Add(this.RadioDoll);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "G.F. ProductionDB";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioDoll;
        private System.Windows.Forms.RadioButton RadioEquipment;
        private System.Windows.Forms.ListView ListResult;
        private System.Windows.Forms.ColumnHeader ColCategory;
        private System.Windows.Forms.ColumnHeader ColGrade;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.Button CmdFind;
        private System.Windows.Forms.TextBox TxtHour;
        private System.Windows.Forms.TextBox TxtMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Copyright;
    }
}

