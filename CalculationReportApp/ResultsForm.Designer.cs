
namespace CalculationReportApp
{
    partial class ResultsForm
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
            this.ResultsdataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RkkCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppealsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.SortByRKKButton = new System.Windows.Forms.Button();
            this.SortByAppealsButton = new System.Windows.Forms.Button();
            this.SortByTotalAmountButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsdataGridView
            // 
            this.ResultsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Executor,
            this.RkkCount,
            this.AppealsCount,
            this.TotalAmount});
            this.ResultsdataGridView.Location = new System.Drawing.Point(12, 98);
            this.ResultsdataGridView.Name = "ResultsdataGridView";
            this.ResultsdataGridView.RowHeadersWidth = 51;
            this.ResultsdataGridView.RowTemplate.Height = 24;
            this.ResultsdataGridView.Size = new System.Drawing.Size(902, 367);
            this.ResultsdataGridView.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "№ п.п.";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // Executor
            // 
            this.Executor.HeaderText = "Ответственный исполнитель";
            this.Executor.MinimumWidth = 6;
            this.Executor.Name = "Executor";
            this.Executor.Width = 125;
            // 
            // RkkCount
            // 
            this.RkkCount.HeaderText = "Количество неисполненных входящих документов";
            this.RkkCount.MinimumWidth = 6;
            this.RkkCount.Name = "RkkCount";
            this.RkkCount.Width = 125;
            // 
            // AppealsCount
            // 
            this.AppealsCount.HeaderText = "Количество неисполненных письменных обращений граждан";
            this.AppealsCount.MinimumWidth = 6;
            this.AppealsCount.Name = "AppealsCount";
            this.AppealsCount.Width = 125;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Общее количество документов и обращений";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(22, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сортировка по фамилии ответственного исполнителя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SortByNameButton_Click);
            // 
            // SortByRKKButton
            // 
            this.SortByRKKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByRKKButton.Location = new System.Drawing.Point(273, 10);
            this.SortByRKKButton.Name = "SortByRKKButton";
            this.SortByRKKButton.Size = new System.Drawing.Size(191, 64);
            this.SortByRKKButton.TabIndex = 2;
            this.SortByRKKButton.Text = "Сортировка по количеству РКК";
            this.SortByRKKButton.UseVisualStyleBackColor = true;
            this.SortByRKKButton.Click += new System.EventHandler(this.SortByRKKButton_Click);
            // 
            // SortByAppealsButton
            // 
            this.SortByAppealsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByAppealsButton.Location = new System.Drawing.Point(501, 10);
            this.SortByAppealsButton.Name = "SortByAppealsButton";
            this.SortByAppealsButton.Size = new System.Drawing.Size(176, 64);
            this.SortByAppealsButton.TabIndex = 3;
            this.SortByAppealsButton.Text = "Сортировка по количеству обращений ";
            this.SortByAppealsButton.UseVisualStyleBackColor = true;
            this.SortByAppealsButton.Click += new System.EventHandler(this.SortByAppealsButton_Click);
            // 
            // SortByTotalAmountButton
            // 
            this.SortByTotalAmountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByTotalAmountButton.Location = new System.Drawing.Point(704, 10);
            this.SortByTotalAmountButton.Name = "SortByTotalAmountButton";
            this.SortByTotalAmountButton.Size = new System.Drawing.Size(210, 64);
            this.SortByTotalAmountButton.TabIndex = 4;
            this.SortByTotalAmountButton.Text = "Сортировка по общему количеству документов ";
            this.SortByTotalAmountButton.UseVisualStyleBackColor = true;
            this.SortByTotalAmountButton.Click += new System.EventHandler(this.SortByTotalAmountButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(386, 482);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 22);
            this.SearchTextBox.TabIndex = 5;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchbutton.Location = new System.Drawing.Point(302, 520);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(280, 47);
            this.Searchbutton.TabIndex = 6;
            this.Searchbutton.Text = "Поиск по фамилии исполнителя";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 594);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SortByTotalAmountButton);
            this.Controls.Add(this.SortByAppealsButton);
            this.Controls.Add(this.SortByRKKButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultsdataGridView);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultsdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RkkCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppealsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SortByRKKButton;
        private System.Windows.Forms.Button SortByAppealsButton;
        private System.Windows.Forms.Button SortByTotalAmountButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button Searchbutton;
    }
}