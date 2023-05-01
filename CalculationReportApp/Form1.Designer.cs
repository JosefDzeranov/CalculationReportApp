
namespace CalculationReportApp
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
            this.appealsButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByRKKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByAppleasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByTotalAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rkkButton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.ShowResultsButton = new System.Windows.Forms.Button();
            this.CloseAPPButton = new System.Windows.Forms.Button();
            this.appealsLabel = new System.Windows.Forms.Label();
            this.rkkLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // appealsButton
            // 
            this.appealsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appealsButton.Location = new System.Drawing.Point(66, 50);
            this.appealsButton.Name = "appealsButton";
            this.appealsButton.Size = new System.Drawing.Size(155, 65);
            this.appealsButton.TabIndex = 3;
            this.appealsButton.Text = "Загрузить данные по обращениям";
            this.appealsButton.UseVisualStyleBackColor = true;
            this.appealsButton.Click += new System.EventHandler(this.appealsButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(707, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByNameToolStripMenuItem,
            this.SortByRKKToolStripMenuItem,
            this.SortByAppleasToolStripMenuItem,
            this.SortByTotalAmountToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.сортировкаToolStripMenuItem.Text = "Сохранение в файл с сортировкой";
            // 
            // SortByNameToolStripMenuItem
            // 
            this.SortByNameToolStripMenuItem.Name = "SortByNameToolStripMenuItem";
            this.SortByNameToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.SortByNameToolStripMenuItem.Text = "По фамилии ответственного исполнителя";
            this.SortByNameToolStripMenuItem.Click += new System.EventHandler(this.SortByNameToolStripMenuItem_Click_1);
            // 
            // SortByRKKToolStripMenuItem
            // 
            this.SortByRKKToolStripMenuItem.Name = "SortByRKKToolStripMenuItem";
            this.SortByRKKToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.SortByRKKToolStripMenuItem.Text = "По количеству РКК";
            this.SortByRKKToolStripMenuItem.Click += new System.EventHandler(this.SortByRKKToolStripMenuItem_Click_1);
            // 
            // SortByAppleasToolStripMenuItem
            // 
            this.SortByAppleasToolStripMenuItem.Name = "SortByAppleasToolStripMenuItem";
            this.SortByAppleasToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.SortByAppleasToolStripMenuItem.Text = "По количеству обращений ";
            this.SortByAppleasToolStripMenuItem.Click += new System.EventHandler(this.SortByAppleasToolStripMenuItem_Click_1);
            // 
            // SortByTotalAmountToolStripMenuItem
            // 
            this.SortByTotalAmountToolStripMenuItem.Name = "SortByTotalAmountToolStripMenuItem";
            this.SortByTotalAmountToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.SortByTotalAmountToolStripMenuItem.Text = "По общему количеству документов";
            this.SortByTotalAmountToolStripMenuItem.Click += new System.EventHandler(this.SortByTotalAmountToolStripMenuItem_Click_1);
            // 
            // rkkButton
            // 
            this.rkkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rkkButton.Location = new System.Drawing.Point(66, 164);
            this.rkkButton.Name = "rkkButton";
            this.rkkButton.Size = new System.Drawing.Size(155, 65);
            this.rkkButton.TabIndex = 4;
            this.rkkButton.Text = "Загрузить данные по РКК";
            this.rkkButton.UseVisualStyleBackColor = true;
            this.rkkButton.Click += new System.EventHandler(this.rkkButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // ShowResultsButton
            // 
            this.ShowResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowResultsButton.Location = new System.Drawing.Point(66, 280);
            this.ShowResultsButton.Name = "ShowResultsButton";
            this.ShowResultsButton.Size = new System.Drawing.Size(155, 65);
            this.ShowResultsButton.TabIndex = 7;
            this.ShowResultsButton.Text = "Отобразить результаты";
            this.ShowResultsButton.UseVisualStyleBackColor = true;
            this.ShowResultsButton.Click += new System.EventHandler(this.ShowResultsButton_Click);
            // 
            // CloseAPPButton
            // 
            this.CloseAPPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAPPButton.Location = new System.Drawing.Point(66, 402);
            this.CloseAPPButton.Name = "CloseAPPButton";
            this.CloseAPPButton.Size = new System.Drawing.Size(155, 65);
            this.CloseAPPButton.TabIndex = 8;
            this.CloseAPPButton.Text = "Закрыть приложение";
            this.CloseAPPButton.UseVisualStyleBackColor = true;
            this.CloseAPPButton.Click += new System.EventHandler(this.CloseAPPButton_Click);
            // 
            // appealsLabel
            // 
            this.appealsLabel.AutoSize = true;
            this.appealsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appealsLabel.Location = new System.Drawing.Point(292, 67);
            this.appealsLabel.Name = "appealsLabel";
            this.appealsLabel.Size = new System.Drawing.Size(0, 17);
            this.appealsLabel.TabIndex = 9;
            // 
            // rkkLabel
            // 
            this.rkkLabel.AutoSize = true;
            this.rkkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rkkLabel.Location = new System.Drawing.Point(292, 188);
            this.rkkLabel.Name = "rkkLabel";
            this.rkkLabel.Size = new System.Drawing.Size(0, 17);
            this.rkkLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 493);
            this.Controls.Add(this.rkkLabel);
            this.Controls.Add(this.appealsLabel);
            this.Controls.Add(this.CloseAPPButton);
            this.Controls.Add(this.ShowResultsButton);
            this.Controls.Add(this.rkkButton);
            this.Controls.Add(this.appealsButton);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculationReportApplication";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button appealsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button rkkButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button ShowResultsButton;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByRKKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByAppleasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByTotalAmountToolStripMenuItem;
        private System.Windows.Forms.Button CloseAPPButton;
        private System.Windows.Forms.Label appealsLabel;
        private System.Windows.Forms.Label rkkLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

