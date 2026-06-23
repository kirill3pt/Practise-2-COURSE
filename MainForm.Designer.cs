namespace APP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.BackColor = System.Drawing.Color.Ivory;
            this.btnCreate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(745, 244);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(157, 27);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать файл";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoad.BackColor = System.Drawing.Color.Ivory;
            this.btnLoad.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(745, 272);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 27);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить файл";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.Ivory;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(745, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить запись";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Ivory;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(745, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить запись";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSort.BackColor = System.Drawing.Color.Ivory;
            this.btnSort.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(745, 356);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(157, 27);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Отсортировать";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.Ivory;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(745, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnSum
            // 
            this.btnSum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSum.BackColor = System.Drawing.Color.Ivory;
            this.btnSum.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSum.Location = new System.Drawing.Point(745, 412);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(157, 27);
            this.btnSum.TabIndex = 11;
            this.btnSum.Text = "Суммирование (№1)";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.Ivory;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(745, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 27);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Редактировать";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEx1
            // 
            this.btnEx1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEx1.BackColor = System.Drawing.Color.Ivory;
            this.btnEx1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEx1.Location = new System.Drawing.Point(11, 244);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(157, 27);
            this.btnEx1.TabIndex = 23;
            this.btnEx1.Text = "Задание №1";
            this.btnEx1.UseVisualStyleBackColor = false;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEx2.BackColor = System.Drawing.Color.Ivory;
            this.btnEx2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEx2.Location = new System.Drawing.Point(12, 277);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(157, 27);
            this.btnEx2.TabIndex = 24;
            this.btnEx2.Text = "Задание №2";
            this.btnEx2.UseVisualStyleBackColor = false;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEx3.BackColor = System.Drawing.Color.Ivory;
            this.btnEx3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEx3.Location = new System.Drawing.Point(11, 310);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(157, 27);
            this.btnEx3.TabIndex = 25;
            this.btnEx3.Text = "Задание №3";
            this.btnEx3.UseVisualStyleBackColor = false;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(175, 244);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Грузооборот 2013";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(288, 222);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // btnChart
            // 
            this.btnChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChart.BackColor = System.Drawing.Color.Ivory;
            this.btnChart.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChart.Location = new System.Drawing.Point(12, 343);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(157, 27);
            this.btnChart.TabIndex = 27;
            this.btnChart.Text = "График";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.BackColor = System.Drawing.Color.Ivory;
            this.btnPrint.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.Location = new System.Drawing.Point(12, 376);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 27);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 513);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бережецкий К.Т., ФТФ, ИВТ-2. Задание на практику";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnChart;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnPrint;
    }
}

