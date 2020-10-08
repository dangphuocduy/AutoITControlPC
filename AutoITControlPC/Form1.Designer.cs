namespace AutoITControlPC
{
    partial class Form1
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
            this.btnCmd = new System.Windows.Forms.Button();
            this.btnCmdHide = new System.Windows.Forms.Button();
            this.btnCmdHideResult = new System.Windows.Forms.Button();
            this.pointCursorX = new System.Windows.Forms.NumericUpDown();
            this.pointCursorY = new System.Windows.Forms.NumericUpDown();
            this.chkMouseRightClick = new System.Windows.Forms.CheckBox();
            this.chkMouseDoubleClick = new System.Windows.Forms.CheckBox();
            this.btnClickPoint = new System.Windows.Forms.Button();
            this.btnClickPointApp = new System.Windows.Forms.Button();
            this.btnClickControlApp = new System.Windows.Forms.Button();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnSendKey = new System.Windows.Forms.Button();
            this.btnSendMutilKey = new System.Windows.Forms.Button();
            this.btnEditTittle = new System.Windows.Forms.Button();
            this.btnSetTextToCbb = new System.Windows.Forms.Button();
            this.btnClickCtr = new System.Windows.Forms.Button();
            this.btnClickPointHide = new System.Windows.Forms.Button();
            this.btnSendEnter = new System.Windows.Forms.Button();
            this.btnCheckImage = new System.Windows.Forms.Button();
            this.btnExportPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointCursorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCursorY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(12, 22);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(116, 23);
            this.btnCmd.TabIndex = 1;
            this.btnCmd.Text = "Chạy lệnh CMD";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmdHide
            // 
            this.btnCmdHide.Location = new System.Drawing.Point(134, 22);
            this.btnCmdHide.Name = "btnCmdHide";
            this.btnCmdHide.Size = new System.Drawing.Size(147, 23);
            this.btnCmdHide.TabIndex = 2;
            this.btnCmdHide.Text = "Chạy lệnh CMD ngầm";
            this.btnCmdHide.UseVisualStyleBackColor = true;
            this.btnCmdHide.Click += new System.EventHandler(this.btnCmdHide_Click);
            // 
            // btnCmdHideResult
            // 
            this.btnCmdHideResult.Location = new System.Drawing.Point(287, 22);
            this.btnCmdHideResult.Name = "btnCmdHideResult";
            this.btnCmdHideResult.Size = new System.Drawing.Size(194, 23);
            this.btnCmdHideResult.TabIndex = 3;
            this.btnCmdHideResult.Text = "Chạy lệnh CMD ngầm và lấy kết quả";
            this.btnCmdHideResult.UseVisualStyleBackColor = true;
            this.btnCmdHideResult.Click += new System.EventHandler(this.btnCmdHideResult_Click);
            // 
            // pointCursorX
            // 
            this.pointCursorX.Location = new System.Drawing.Point(12, 60);
            this.pointCursorX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.pointCursorX.Name = "pointCursorX";
            this.pointCursorX.Size = new System.Drawing.Size(79, 20);
            this.pointCursorX.TabIndex = 4;
            // 
            // pointCursorY
            // 
            this.pointCursorY.Location = new System.Drawing.Point(97, 60);
            this.pointCursorY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.pointCursorY.Name = "pointCursorY";
            this.pointCursorY.Size = new System.Drawing.Size(79, 20);
            this.pointCursorY.TabIndex = 5;
            // 
            // chkMouseRightClick
            // 
            this.chkMouseRightClick.AutoSize = true;
            this.chkMouseRightClick.Location = new System.Drawing.Point(201, 61);
            this.chkMouseRightClick.Name = "chkMouseRightClick";
            this.chkMouseRightClick.Size = new System.Drawing.Size(77, 17);
            this.chkMouseRightClick.TabIndex = 6;
            this.chkMouseRightClick.Text = "Chuột phải";
            this.chkMouseRightClick.UseVisualStyleBackColor = true;
            // 
            // chkMouseDoubleClick
            // 
            this.chkMouseDoubleClick.AutoSize = true;
            this.chkMouseDoubleClick.Location = new System.Drawing.Point(287, 61);
            this.chkMouseDoubleClick.Name = "chkMouseDoubleClick";
            this.chkMouseDoubleClick.Size = new System.Drawing.Size(86, 17);
            this.chkMouseDoubleClick.TabIndex = 7;
            this.chkMouseDoubleClick.Text = "Double Click";
            this.chkMouseDoubleClick.UseVisualStyleBackColor = true;
            // 
            // btnClickPoint
            // 
            this.btnClickPoint.Location = new System.Drawing.Point(380, 55);
            this.btnClickPoint.Name = "btnClickPoint";
            this.btnClickPoint.Size = new System.Drawing.Size(101, 23);
            this.btnClickPoint.TabIndex = 8;
            this.btnClickPoint.Text = "Click vào toạ độ";
            this.btnClickPoint.UseVisualStyleBackColor = true;
            this.btnClickPoint.Click += new System.EventHandler(this.btnClickPoint_Click);
            // 
            // btnClickPointApp
            // 
            this.btnClickPointApp.Location = new System.Drawing.Point(487, 55);
            this.btnClickPointApp.Name = "btnClickPointApp";
            this.btnClickPointApp.Size = new System.Drawing.Size(149, 23);
            this.btnClickPointApp.TabIndex = 9;
            this.btnClickPointApp.Text = "Click vào toạ độ ứng dụng";
            this.btnClickPointApp.UseVisualStyleBackColor = true;
            this.btnClickPointApp.Click += new System.EventHandler(this.btnClickPoint_Click);
            // 
            // btnClickControlApp
            // 
            this.btnClickControlApp.Location = new System.Drawing.Point(12, 108);
            this.btnClickControlApp.Name = "btnClickControlApp";
            this.btnClickControlApp.Size = new System.Drawing.Size(149, 23);
            this.btnClickControlApp.TabIndex = 9;
            this.btnClickControlApp.Text = "Click vào control ứng dụng";
            this.btnClickControlApp.UseVisualStyleBackColor = true;
            this.btnClickControlApp.Click += new System.EventHandler(this.btnClickControlApp_Click);
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Location = new System.Drawing.Point(498, 22);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(230, 20);
            this.txtApplicationName.TabIndex = 10;
            this.txtApplicationName.Text = "Remote Desktop Connection";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(178, 110);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(230, 20);
            this.txtClass.TabIndex = 10;
            // 
            // btnSendKey
            // 
            this.btnSendKey.Location = new System.Drawing.Point(12, 151);
            this.btnSendKey.Name = "btnSendKey";
            this.btnSendKey.Size = new System.Drawing.Size(149, 23);
            this.btnSendKey.TabIndex = 9;
            this.btnSendKey.Text = "Gửi phím cho ứng dụng";
            this.btnSendKey.UseVisualStyleBackColor = true;
            this.btnSendKey.Click += new System.EventHandler(this.btnSendKey_Click);
            // 
            // btnSendMutilKey
            // 
            this.btnSendMutilKey.Location = new System.Drawing.Point(178, 151);
            this.btnSendMutilKey.Name = "btnSendMutilKey";
            this.btnSendMutilKey.Size = new System.Drawing.Size(184, 23);
            this.btnSendMutilKey.TabIndex = 9;
            this.btnSendMutilKey.Text = "Gửi mutil phím cho ứng dụng";
            this.btnSendMutilKey.UseVisualStyleBackColor = true;
            this.btnSendMutilKey.Click += new System.EventHandler(this.btnSendMutilKey_Click);
            // 
            // btnEditTittle
            // 
            this.btnEditTittle.Location = new System.Drawing.Point(12, 241);
            this.btnEditTittle.Name = "btnEditTittle";
            this.btnEditTittle.Size = new System.Drawing.Size(184, 23);
            this.btnEditTittle.TabIndex = 9;
            this.btnEditTittle.Text = "Sửa tiêu đề cho cửa sổ";
            this.btnEditTittle.UseVisualStyleBackColor = true;
            this.btnEditTittle.Click += new System.EventHandler(this.btnEditTittle_Click);
            // 
            // btnSetTextToCbb
            // 
            this.btnSetTextToCbb.Location = new System.Drawing.Point(202, 241);
            this.btnSetTextToCbb.Name = "btnSetTextToCbb";
            this.btnSetTextToCbb.Size = new System.Drawing.Size(184, 23);
            this.btnSetTextToCbb.TabIndex = 9;
            this.btnSetTextToCbb.Text = "Set Text cho Combobox";
            this.btnSetTextToCbb.UseVisualStyleBackColor = true;
            this.btnSetTextToCbb.Click += new System.EventHandler(this.btnSetTextToCbb_Click);
            // 
            // btnClickCtr
            // 
            this.btnClickCtr.Location = new System.Drawing.Point(12, 286);
            this.btnClickCtr.Name = "btnClickCtr";
            this.btnClickCtr.Size = new System.Drawing.Size(149, 23);
            this.btnClickCtr.TabIndex = 9;
            this.btnClickCtr.Text = "Click vào control ứng dụng";
            this.btnClickCtr.UseVisualStyleBackColor = true;
            this.btnClickCtr.Click += new System.EventHandler(this.btnClickCtr_Click);
            // 
            // btnClickPointHide
            // 
            this.btnClickPointHide.Location = new System.Drawing.Point(201, 286);
            this.btnClickPointHide.Name = "btnClickPointHide";
            this.btnClickPointHide.Size = new System.Drawing.Size(185, 23);
            this.btnClickPointHide.TabIndex = 9;
            this.btnClickPointHide.Text = "Click vào toạ độ ngầm";
            this.btnClickPointHide.UseVisualStyleBackColor = true;
            this.btnClickPointHide.Click += new System.EventHandler(this.btnClickPointHide_Click);
            // 
            // btnSendEnter
            // 
            this.btnSendEnter.Location = new System.Drawing.Point(427, 344);
            this.btnSendEnter.Name = "btnSendEnter";
            this.btnSendEnter.Size = new System.Drawing.Size(185, 23);
            this.btnSendEnter.TabIndex = 9;
            this.btnSendEnter.Text = "Gửi phím ENTER cho ứng dụng";
            this.btnSendEnter.UseVisualStyleBackColor = true;
            this.btnSendEnter.Click += new System.EventHandler(this.btnSendEnter_Click);
            // 
            // btnCheckImage
            // 
            this.btnCheckImage.Location = new System.Drawing.Point(12, 344);
            this.btnCheckImage.Name = "btnCheckImage";
            this.btnCheckImage.Size = new System.Drawing.Size(149, 23);
            this.btnCheckImage.TabIndex = 9;
            this.btnCheckImage.Text = "Kiểm tra hình có xuất hiện";
            this.btnCheckImage.UseVisualStyleBackColor = true;
            this.btnCheckImage.Click += new System.EventHandler(this.btnCheckImage_Click);
            // 
            // btnExportPoint
            // 
            this.btnExportPoint.Location = new System.Drawing.Point(201, 344);
            this.btnExportPoint.Name = "btnExportPoint";
            this.btnExportPoint.Size = new System.Drawing.Size(185, 23);
            this.btnExportPoint.TabIndex = 9;
            this.btnExportPoint.Text = "Xuất ra toạ độ của ảnh";
            this.btnExportPoint.UseVisualStyleBackColor = true;
            this.btnExportPoint.Click += new System.EventHandler(this.btnExportPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 408);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtApplicationName);
            this.Controls.Add(this.btnSetTextToCbb);
            this.Controls.Add(this.btnEditTittle);
            this.Controls.Add(this.btnSendMutilKey);
            this.Controls.Add(this.btnSendKey);
            this.Controls.Add(this.btnClickCtr);
            this.Controls.Add(this.btnClickControlApp);
            this.Controls.Add(this.btnExportPoint);
            this.Controls.Add(this.btnCheckImage);
            this.Controls.Add(this.btnSendEnter);
            this.Controls.Add(this.btnClickPointHide);
            this.Controls.Add(this.btnClickPointApp);
            this.Controls.Add(this.btnClickPoint);
            this.Controls.Add(this.chkMouseDoubleClick);
            this.Controls.Add(this.chkMouseRightClick);
            this.Controls.Add(this.pointCursorY);
            this.Controls.Add(this.pointCursorX);
            this.Controls.Add(this.btnCmdHideResult);
            this.Controls.Add(this.btnCmdHide);
            this.Controls.Add(this.btnCmd);
            this.Name = "Form1";
            this.Text = "Control PC";
            ((System.ComponentModel.ISupportInitialize)(this.pointCursorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCursorY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.Button btnCmdHide;
        private System.Windows.Forms.Button btnCmdHideResult;
        private System.Windows.Forms.NumericUpDown pointCursorX;
        private System.Windows.Forms.NumericUpDown pointCursorY;
        private System.Windows.Forms.CheckBox chkMouseRightClick;
        private System.Windows.Forms.CheckBox chkMouseDoubleClick;
        private System.Windows.Forms.Button btnClickPoint;
        private System.Windows.Forms.Button btnClickPointApp;
        private System.Windows.Forms.Button btnClickControlApp;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnSendKey;
        private System.Windows.Forms.Button btnSendMutilKey;
        private System.Windows.Forms.Button btnEditTittle;
        private System.Windows.Forms.Button btnSetTextToCbb;
        private System.Windows.Forms.Button btnClickCtr;
        private System.Windows.Forms.Button btnClickPointHide;
        private System.Windows.Forms.Button btnSendEnter;
        private System.Windows.Forms.Button btnCheckImage;
        private System.Windows.Forms.Button btnExportPoint;
    }
}

