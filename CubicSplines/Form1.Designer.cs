namespace CubicSplines
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.functionsTab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splinesTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.задачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.randomValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.functionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).BeginInit();
            this.splinesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.functionsTab);
            this.tabControl.Controls.Add(this.splinesTab);
            this.tabControl.Location = new System.Drawing.Point(12, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1171, 611);
            this.tabControl.TabIndex = 0;
            // 
            // functionsTab
            // 
            this.functionsTab.BackColor = System.Drawing.SystemColors.Control;
            this.functionsTab.Controls.Add(this.chart1);
            this.functionsTab.Controls.Add(this.dataGridView);
            this.functionsTab.Location = new System.Drawing.Point(4, 24);
            this.functionsTab.Name = "functionsTab";
            this.functionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.functionsTab.Size = new System.Drawing.Size(1163, 583);
            this.functionsTab.TabIndex = 0;
            this.functionsTab.Text = "Функция";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(323, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(834, 544);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.Column1, this.Column2});
            this.dataGridView.Location = new System.Drawing.Point(18, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 58;
            this.dataGridView.Size = new System.Drawing.Size(283, 544);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "x";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "f(x)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // splinesTab
            // 
            this.splinesTab.BackColor = System.Drawing.SystemColors.Control;
            this.splinesTab.Controls.Add(this.dataGridView2);
            this.splinesTab.Location = new System.Drawing.Point(4, 24);
            this.splinesTab.Name = "splinesTab";
            this.splinesTab.Padding = new System.Windows.Forms.Padding(3);
            this.splinesTab.Size = new System.Drawing.Size(736, 381);
            this.splinesTab.TabIndex = 1;
            this.splinesTab.Text = "Сплайны";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 58;
            this.dataGridView2.Size = new System.Drawing.Size(538, 287);
            this.dataGridView2.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.задачаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1192, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // задачаToolStripMenuItem
            // 
            this.задачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.readToolStripMenu, this.randomValuesToolStripMenuItem, this.SaveValuesToolStripMenuItem});
            this.задачаToolStripMenuItem.Name = "задачаToolStripMenuItem";
            this.задачаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.задачаToolStripMenuItem.Text = "Задача";
            // 
            // readToolStripMenu
            // 
            this.readToolStripMenu.Name = "readToolStripMenu";
            this.readToolStripMenu.Size = new System.Drawing.Size(290, 22);
            this.readToolStripMenu.Text = "Прочитать значения из файла";
            this.readToolStripMenu.Click += new System.EventHandler(this.ReadToolStripMenu_Click);
            // 
            // randomValuesToolStripMenuItem
            // 
            this.randomValuesToolStripMenuItem.Name = "randomValuesToolStripMenuItem";
            this.randomValuesToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.randomValuesToolStripMenuItem.Text = "Случайные значения";
            this.randomValuesToolStripMenuItem.Click += new System.EventHandler(this.RandomValuesToolStripMenu_Click);
            // 
            // SaveValuesToolStripMenuItem
            // 
            this.SaveValuesToolStripMenuItem.Name = "SaveValuesToolStripMenuItem";
            this.SaveValuesToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.SaveValuesToolStripMenuItem.Text = "Сохранить значения для задачи в файл";
            this.SaveValuesToolStripMenuItem.Click += new System.EventHandler(this.SaveValuesToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 653);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Интерполяция сеточной функции кубическими сплайнами";
            this.tabControl.ResumeLayout(false);
            this.functionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).EndInit();
            this.splinesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem задачаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage splinesTab;
        private System.Windows.Forms.TabPage functionsTab;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomValuesToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

