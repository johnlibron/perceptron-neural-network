namespace Perceptron
{
    partial class FormPerceptron
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.cboBoxLetters = new System.Windows.Forms.ComboBox();
            this.radioBtnCharacterType = new System.Windows.Forms.RadioButton();
            this.radioBtnCharacter = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(38, 35);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(173, 218);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanel_CellPaint);
            this.tableLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_MouseClick);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(235, 220);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(84, 33);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.BtnTrain_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(235, 35);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(84, 33);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(235, 82);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResult.Location = new System.Drawing.Point(350, 35);
            this.txtBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.Size = new System.Drawing.Size(197, 34);
            this.txtBoxResult.TabIndex = 5;
            this.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboBoxLetters
            // 
            this.cboBoxLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxLetters.FormattingEnabled = true;
            this.cboBoxLetters.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cboBoxLetters.Location = new System.Drawing.Point(350, 82);
            this.cboBoxLetters.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxLetters.Name = "cboBoxLetters";
            this.cboBoxLetters.Size = new System.Drawing.Size(67, 24);
            this.cboBoxLetters.TabIndex = 6;
            this.cboBoxLetters.SelectedIndexChanged += new System.EventHandler(this.CboBoxLetters_SelectedIndexChanged);
            // 
            // radioBtnCharacterType
            // 
            this.radioBtnCharacterType.AutoSize = true;
            this.radioBtnCharacterType.Checked = true;
            this.radioBtnCharacterType.Location = new System.Drawing.Point(428, 82);
            this.radioBtnCharacterType.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnCharacterType.Name = "radioBtnCharacterType";
            this.radioBtnCharacterType.Size = new System.Drawing.Size(127, 21);
            this.radioBtnCharacterType.TabIndex = 8;
            this.radioBtnCharacterType.TabStop = true;
            this.radioBtnCharacterType.Text = "Character Type";
            this.radioBtnCharacterType.UseVisualStyleBackColor = true;
            this.radioBtnCharacterType.Click += new System.EventHandler(this.RadioBtnCharacterType_Click);
            // 
            // radioBtnCharacter
            // 
            this.radioBtnCharacter.AutoSize = true;
            this.radioBtnCharacter.Location = new System.Drawing.Point(428, 107);
            this.radioBtnCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnCharacter.Name = "radioBtnCharacter";
            this.radioBtnCharacter.Size = new System.Drawing.Size(91, 21);
            this.radioBtnCharacter.TabIndex = 9;
            this.radioBtnCharacter.Text = "Character";
            this.radioBtnCharacter.UseVisualStyleBackColor = true;
            this.radioBtnCharacter.Click += new System.EventHandler(this.RadioBtnCharacter_Click);
            // 
            // FormPerceptron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(583, 302);
            this.Controls.Add(this.radioBtnCharacter);
            this.Controls.Add(this.radioBtnCharacterType);
            this.Controls.Add(this.cboBoxLetters);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPerceptron";
            this.Text = "Perceptron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.ComboBox cboBoxLetters;
        private System.Windows.Forms.RadioButton radioBtnCharacterType;
        private System.Windows.Forms.RadioButton radioBtnCharacter;
    }
}

