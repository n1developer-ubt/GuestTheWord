namespace GuestTheWord
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCurrentWords = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAnswer = new UBTStandardLibrary.UBTTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudHideWords = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWordsSelect = new System.Windows.Forms.NumericUpDown();
            this.nudWordsFlash = new System.Windows.Forms.NumericUpDown();
            this.txtWords = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHideWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordsFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblCurrentWords);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(786, 275);
            this.panel5.TabIndex = 3;
            // 
            // lblCurrentWords
            // 
            this.lblCurrentWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblCurrentWords.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentWords.Name = "lblCurrentWords";
            this.lblCurrentWords.Size = new System.Drawing.Size(786, 275);
            this.lblCurrentWords.TabIndex = 0;
            this.lblCurrentWords.Text = "Words, Will, Appear, Here";
            this.lblCurrentWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtAnswer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 322);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(786, 51);
            this.panel4.TabIndex = 2;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAnswer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAnswer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAnswer.BorderThickness = 1;
            this.txtAnswer.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAnswer.Hint = "Answer, Goes, Here";
            this.txtAnswer.Index = -1;
            this.txtAnswer.isPassword = false;
            this.txtAnswer.Location = new System.Drawing.Point(3, 3);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.MaxLength = 32767;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(778, 43);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.Text = "Answer, Goes, Here";
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(786, 44);
            this.panel3.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Active = false;
            this.btnStart.Activecolor = System.Drawing.Color.Green;
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderRadius = 0;
            this.btnStart.ButtonText = "Start";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledColor = System.Drawing.Color.Gray;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStart.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStart.Iconimage")));
            this.btnStart.Iconimage_right = null;
            this.btnStart.Iconimage_right_Selected = null;
            this.btnStart.Iconimage_Selected = null;
            this.btnStart.IconMarginLeft = 0;
            this.btnStart.IconMarginRight = 0;
            this.btnStart.IconRightVisible = false;
            this.btnStart.IconRightZoom = 0D;
            this.btnStart.IconVisible = false;
            this.btnStart.IconZoom = 90D;
            this.btnStart.IsTab = false;
            this.btnStart.Location = new System.Drawing.Point(684, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.Green;
            this.btnStart.OnHovercolor = System.Drawing.Color.Green;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(97, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEnd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 373);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(786, 48);
            this.panel2.TabIndex = 0;
            // 
            // btnEnd
            // 
            this.btnEnd.Active = false;
            this.btnEnd.Activecolor = System.Drawing.Color.Red;
            this.btnEnd.BackColor = System.Drawing.Color.Red;
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnd.BorderRadius = 0;
            this.btnEnd.ButtonText = "End";
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnd.Iconimage")));
            this.btnEnd.Iconimage_right = null;
            this.btnEnd.Iconimage_right_Selected = null;
            this.btnEnd.Iconimage_Selected = null;
            this.btnEnd.IconMarginLeft = 0;
            this.btnEnd.IconMarginRight = 0;
            this.btnEnd.IconRightVisible = false;
            this.btnEnd.IconRightZoom = 0D;
            this.btnEnd.IconVisible = false;
            this.btnEnd.IconZoom = 90D;
            this.btnEnd.IsTab = false;
            this.btnEnd.Location = new System.Drawing.Point(684, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Normalcolor = System.Drawing.Color.Red;
            this.btnEnd.OnHovercolor = System.Drawing.Color.Red;
            this.btnEnd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnd.selected = false;
            this.btnEnd.Size = new System.Drawing.Size(97, 40);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnd.Textcolor = System.Drawing.Color.White;
            this.btnEnd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 369);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(786, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(671, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.55471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.44529F));
            this.tableLayoutPanel1.Controls.Add(this.nudHideWords, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudWordsSelect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudWordsFlash, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtWords, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nudHideWords
            // 
            this.nudHideWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHideWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHideWords.Location = new System.Drawing.Point(197, 283);
            this.nudHideWords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHideWords.Name = "nudHideWords";
            this.nudHideWords.Size = new System.Drawing.Size(585, 27);
            this.nudHideWords.TabIndex = 5;
            this.nudHideWords.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hide Words";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 209);
            this.label3.TabIndex = 2;
            this.label3.Text = "Words";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Words To Select";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Words to Flash";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudWordsSelect
            // 
            this.nudWordsSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudWordsSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWordsSelect.Location = new System.Drawing.Point(197, 4);
            this.nudWordsSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWordsSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWordsSelect.Name = "nudWordsSelect";
            this.nudWordsSelect.Size = new System.Drawing.Size(585, 27);
            this.nudWordsSelect.TabIndex = 1;
            this.nudWordsSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudWordsFlash
            // 
            this.nudWordsFlash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudWordsFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWordsFlash.Location = new System.Drawing.Point(197, 38);
            this.nudWordsFlash.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWordsFlash.Name = "nudWordsFlash";
            this.nudWordsFlash.Size = new System.Drawing.Size(585, 27);
            this.nudWordsFlash.TabIndex = 1;
            this.nudWordsFlash.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtWords
            // 
            this.txtWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords.Location = new System.Drawing.Point(197, 73);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(585, 203);
            this.txtWords.TabIndex = 3;
            this.txtWords.Text = "Enter Words Here";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Guest The Word";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHideWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordsFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudWordsSelect;
        private System.Windows.Forms.NumericUpDown nudWordsFlash;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtWords;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCurrentWords;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        private UBTStandardLibrary.UBTTextBox txtAnswer;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHideWords;
    }
}

