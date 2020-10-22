namespace DataBinding
{
    partial class FormRaceCarDriver
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWins = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.buttonAddWin = new System.Windows.Forms.Button();
            this.buttonDeleteDriver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMoveFirst = new System.Windows.Forms.Button();
            this.buttonMovePrev = new System.Windows.Forms.Button();
            this.buttonMoveNext = new System.Windows.Forms.Button();
            this.buttonMoveLast = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDrivers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 612);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.7026F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2974F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1076, 180);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Driver";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.30939F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.69061F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWins, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wins:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(116, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(349, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxWins
            // 
            this.textBoxWins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWins.Location = new System.Drawing.Point(116, 66);
            this.textBoxWins.Name = "textBoxWins";
            this.textBoxWins.Size = new System.Drawing.Size(349, 20);
            this.textBoxWins.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.buttonAddDriver, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonAddWin, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonDeleteDriver, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(116, 105);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(349, 47);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddDriver.Location = new System.Drawing.Point(3, 3);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(110, 41);
            this.buttonAddDriver.TabIndex = 7;
            this.buttonAddDriver.Text = "Add Driver";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // buttonAddWin
            // 
            this.buttonAddWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddWin.Location = new System.Drawing.Point(235, 3);
            this.buttonAddWin.Name = "buttonAddWin";
            this.buttonAddWin.Size = new System.Drawing.Size(111, 41);
            this.buttonAddWin.TabIndex = 5;
            this.buttonAddWin.Text = "Add Win";
            this.buttonAddWin.UseVisualStyleBackColor = true;
            this.buttonAddWin.Click += new System.EventHandler(this.ButtonAddWin_Click);
            // 
            // buttonDeleteDriver
            // 
            this.buttonDeleteDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteDriver.Location = new System.Drawing.Point(119, 3);
            this.buttonDeleteDriver.Name = "buttonDeleteDriver";
            this.buttonDeleteDriver.Size = new System.Drawing.Size(110, 41);
            this.buttonDeleteDriver.TabIndex = 6;
            this.buttonDeleteDriver.Text = "Delete Driver";
            this.buttonDeleteDriver.UseVisualStyleBackColor = true;
            this.buttonDeleteDriver.Click += new System.EventHandler(this.buttonDeleteDriver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(483, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.buttonMoveFirst, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonMovePrev, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonMoveNext, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonMoveLast, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelCount, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(584, 155);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonMoveFirst
            // 
            this.buttonMoveFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveFirst.Location = new System.Drawing.Point(3, 60);
            this.buttonMoveFirst.Name = "buttonMoveFirst";
            this.buttonMoveFirst.Size = new System.Drawing.Size(110, 35);
            this.buttonMoveFirst.TabIndex = 0;
            this.buttonMoveFirst.Text = "<<";
            this.buttonMoveFirst.UseVisualStyleBackColor = true;
            this.buttonMoveFirst.Click += new System.EventHandler(this.buttonMoveFirst_Click);
            // 
            // buttonMovePrev
            // 
            this.buttonMovePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMovePrev.Location = new System.Drawing.Point(119, 60);
            this.buttonMovePrev.Name = "buttonMovePrev";
            this.buttonMovePrev.Size = new System.Drawing.Size(110, 35);
            this.buttonMovePrev.TabIndex = 1;
            this.buttonMovePrev.Text = "<";
            this.buttonMovePrev.UseVisualStyleBackColor = true;
            this.buttonMovePrev.Click += new System.EventHandler(this.buttonMovePrev_Click);
            // 
            // buttonMoveNext
            // 
            this.buttonMoveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveNext.Location = new System.Drawing.Point(351, 60);
            this.buttonMoveNext.Name = "buttonMoveNext";
            this.buttonMoveNext.Size = new System.Drawing.Size(110, 35);
            this.buttonMoveNext.TabIndex = 2;
            this.buttonMoveNext.Text = ">";
            this.buttonMoveNext.UseVisualStyleBackColor = true;
            this.buttonMoveNext.Click += new System.EventHandler(this.buttonMoveNext_Click);
            // 
            // buttonMoveLast
            // 
            this.buttonMoveLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveLast.Location = new System.Drawing.Point(467, 60);
            this.buttonMoveLast.Name = "buttonMoveLast";
            this.buttonMoveLast.Size = new System.Drawing.Size(114, 35);
            this.buttonMoveLast.TabIndex = 3;
            this.buttonMoveLast.Text = ">>";
            this.buttonMoveLast.UseVisualStyleBackColor = true;
            this.buttonMoveLast.Click += new System.EventHandler(this.buttonMoveLast_Click);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(235, 71);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(110, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "label3";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDrivers);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1076, 428);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drivers list";
            // 
            // dataGridViewDrivers
            // 
            this.dataGridViewDrivers.AllowUserToAddRows = false;
            this.dataGridViewDrivers.AllowUserToResizeColumns = false;
            this.dataGridViewDrivers.AllowUserToResizeRows = false;
            this.dataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDrivers.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDrivers.MultiSelect = false;
            this.dataGridViewDrivers.Name = "dataGridViewDrivers";
            this.dataGridViewDrivers.RowHeadersVisible = false;
            this.dataGridViewDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrivers.Size = new System.Drawing.Size(1070, 409);
            this.dataGridViewDrivers.TabIndex = 0;
            // 
            // FormRaceCarDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 612);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormRaceCarDriver";
            this.Text = "Race Car Driver Management";
            this.Load += new System.EventHandler(this.FormRaceCarDriver_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWins;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonMoveFirst;
        private System.Windows.Forms.Button buttonMovePrev;
        private System.Windows.Forms.Button buttonMoveNext;
        private System.Windows.Forms.Button buttonMoveLast;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewDrivers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Button buttonAddWin;
        private System.Windows.Forms.Button buttonDeleteDriver;
    }
}

