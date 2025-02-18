namespace AzNBPRates
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxYear = new TextBox();
            comboBoxMonth = new ComboBox();
            buttonCurrentRates = new Button();
            buttonArchivedRates = new Button();
            dataGridViewRates = new DataGridView();
            Year = new Label();
            Month = new Label();
            ArchivePanel = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRates).BeginInit();
            ArchivePanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(61, 47);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(125, 27);
            textBoxYear.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(295, 46);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(151, 28);
            comboBoxMonth.TabIndex = 1;
            // 
            // buttonCurrentRates
            // 
            buttonCurrentRates.Location = new Point(201, 149);
            buttonCurrentRates.Name = "buttonCurrentRates";
            buttonCurrentRates.Size = new Size(94, 29);
            buttonCurrentRates.TabIndex = 2;
            buttonCurrentRates.Text = "Obecne";
            buttonCurrentRates.UseVisualStyleBackColor = true;
            buttonCurrentRates.Click += buttonCurrentRates_Click;
            // 
            // buttonArchivedRates
            // 
            buttonArchivedRates.Location = new Point(181, 85);
            buttonArchivedRates.Name = "buttonArchivedRates";
            buttonArchivedRates.Size = new Size(94, 29);
            buttonArchivedRates.TabIndex = 3;
            buttonArchivedRates.Text = "Archiwalne";
            buttonArchivedRates.UseVisualStyleBackColor = true;
            buttonArchivedRates.Click += buttonArchivedRates_Click;
            // 
            // dataGridViewRates
            // 
            dataGridViewRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRates.Location = new Point(20, 195);
            dataGridViewRates.Name = "dataGridViewRates";
            dataGridViewRates.RowHeadersWidth = 51;
            dataGridViewRates.Size = new Size(446, 188);
            dataGridViewRates.TabIndex = 4;
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(18, 49);
            Year.Name = "Year";
            Year.Size = new Size(34, 20);
            Year.TabIndex = 5;
            Year.Text = "Rok";
            // 
            // Month
            // 
            Month.AutoSize = true;
            Month.Location = new Point(237, 50);
            Month.Name = "Month";
            Month.Size = new Size(59, 20);
            Month.TabIndex = 6;
            Month.Text = "Miesiąc";
            // 
            // ArchivePanel
            // 
            ArchivePanel.BackColor = Color.Transparent;
            ArchivePanel.Controls.Add(comboBoxMonth);
            ArchivePanel.Controls.Add(Month);
            ArchivePanel.Controls.Add(textBoxYear);
            ArchivePanel.Controls.Add(Year);
            ArchivePanel.Controls.Add(buttonArchivedRates);
            ArchivePanel.Location = new Point(20, 12);
            ArchivePanel.Name = "ArchivePanel";
            ArchivePanel.Size = new Size(461, 131);
            ArchivePanel.TabIndex = 7;
            ArchivePanel.TabStop = false;
            ArchivePanel.Text = "Dane Archiwalne";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ArchivePanel);
            Controls.Add(dataGridViewRates);
            Controls.Add(buttonCurrentRates);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRates).EndInit();
            ArchivePanel.ResumeLayout(false);
            ArchivePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxYear;
        private ComboBox comboBoxMonth;
        private Button buttonCurrentRates;
        private Button buttonArchivedRates;
        private DataGridView dataGridViewRates;
        private Label Year;
        private Label Month;
        private GroupBox ArchivePanel;
    }
}
