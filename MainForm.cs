using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APP
{
    public partial class Form1 : Form
    {
        private CSV service = new CSV();
        private int printIndex = 0;


        public Form1()
        {
            InitializeComponent();
            InitGrid();
            chart1.Visible = false;
        }

        // 1. инициализация таблицы
        private void InitGrid()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("c1", "Транспорт");
            dataGridView1.Columns.Add("c2", "Грузооборот 2011");
            dataGridView1.Columns.Add("c3", "Грузооборот 2013");
            dataGridView1.Columns.Add("c4", "Грузооборот 2015");
            dataGridView1.Columns.Add("c5", "Пассажирооборот 2013");
            dataGridView1.Columns.Add("c6", "Пассажирооборот 2017");
            dataGridView1.Columns.Add("c7", "Пассажирооборот 2018");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Font = new Font("Bahnschrift SemiCondensed", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift SemiCondensed", 11, FontStyle.Bold);
        }

        // 2. обновление таблицы
        private void RefreshGrid()
        {
            try
            {
                dataGridView1.Rows.Clear();

                foreach (var r in service.GetData())
                {
                    dataGridView1.Rows.Add(
                        r.Transport,
                        r.Cargo2011,
                        r.Cargo2013,
                        r.Cargo2015,
                        r.Passenger2013,
                        r.Passenger2017,
                        r.Passenger2018
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки таблицы:\n" + ex.Message);
            }
        }

        // 3. создание файла
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                service.CreateFile("data.csv");
                service.LoadFile("data.csv");
                RefreshGrid();

                MessageBox.Show("Файл создан", "Создание файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания файла:\n" + ex.Message);
            }
        }

        // 4. загрузка файла
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                service.LoadFile("data.csv");
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки:\n" + ex.Message);
            }
        }

        // 5. добавление записи
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTransport.Text))
                {
                    MessageBox.Show("Введите транспорт");
                    return;
                }

                service.AddRecord(new TransportRecord
                {
                    Transport = txtTransport.Text,
                    Cargo2011 = double.Parse(txtCargo2011.Text),
                    Cargo2013 = double.Parse(txtCargo2013.Text),
                    Cargo2015 = double.Parse(txtCargo2015.Text),
                    Passenger2013 = double.Parse(txtPassenger2013.Text),
                    Passenger2017 = double.Parse(txtPassenger2017.Text),
                    Passenger2018 = double.Parse(txtPassenger2018.Text)
                });

                service.SaveFile();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления:\n" + ex.Message);
            }
        }

        // 6. удаление строки
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Строка не выбрана");
                    return;
                }

                service.DeleteRecord(dataGridView1.CurrentRow.Index);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления:\n" + ex.Message);
            }
        }

        // 7. удаление выбранных строк
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            try
            {
                var indexes = dataGridView1.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(r => r.Index)
                    .ToList();

                service.DeleteRecords(indexes);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления:\n" + ex.Message);
            }
        }

        // 8. обновление записи
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Не выбрана строка");
                    return;
                }

                service.UpdateRecord(dataGridView1.CurrentRow.Index, new TransportRecord
                {
                    Transport = txtTransport.Text,
                    Cargo2011 = double.Parse(txtCargo2011.Text),
                    Cargo2013 = double.Parse(txtCargo2013.Text),
                    Cargo2015 = double.Parse(txtCargo2015.Text),
                    Passenger2013 = double.Parse(txtPassenger2013.Text),
                    Passenger2017 = double.Parse(txtPassenger2017.Text),
                    Passenger2018 = double.Parse(txtPassenger2018.Text)
                });

                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления:\n" + ex.Message);
            }
        }

        // 9. сортировка
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                service.SortByCargo2011();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сортировки:\n" + ex.Message);
            }
        }

        // 10. сумма
        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                double sum = service.SumCargo2013();

                MessageBox.Show(
                    $"Сумма грузооборота 2013: {sum}",
                    "Сумма значений",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка расчёта суммы:\n" + ex.Message);
            }
        }

        // 11. сохранение
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                service.SaveFile();
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения:\n" + ex.Message);
            }
        }

        // 12. EX1
        private void btnEx1_Click(object sender, EventArgs e)
        {
            try
            {
                var r = service.Ex1();

                if (r == null)
                {
                    MessageBox.Show("Нет данных", "EX1");
                    return;
                }

                MessageBox.Show(
                    r.ToString(),
                    "Максимальный грузооборот 2011",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 13. EX2
        private void btnEx2_Click(object sender, EventArgs e)
        {
            try
            {
                var result = service.Ex2();

                if (result == null || result.Count == 0)
                {
                    MessageBox.Show("Нет данных", "EX2");
                    return;
                }

                MessageBox.Show(
                    string.Join(Environment.NewLine, result),
                    "Пассажирооборот 2018 > 15",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 14. EX3
        private void btnEx3_Click(object sender, EventArgs e)
        {
            try
            {
                var result = service.Ex3();

                if (result == null || result.Count == 0)
                {
                    MessageBox.Show("Нет данных", "EX3");
                    return;
                }

                MessageBox.Show(
                    string.Join(Environment.NewLine, result),
                    "Пассажирооборот < 40%",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 15. график
        private void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Visible = true;
                chart1.Series.Clear();

                var series = new Series
                {
                    ChartType = SeriesChartType.Column
                };

                foreach (var item in service.Chart())
                    series.Points.AddXY(item.Key, item.Value);

                chart1.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка графика:\n" + ex.Message);
            }
        }

        // 16. печать
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                var data = service.GetData();

                if (data == null || data.Count == 0)
                {
                    e.Graphics.DrawString(
                        "Нет данных",
                        new Font("Courier New", 12),
                        Brushes.Black,
                        e.MarginBounds.Left,
                        e.MarginBounds.Top
                    );
                    return;
                }

                Font font = new Font("Courier New", 10);
                Font headerFont = new Font("Courier New", 10, FontStyle.Bold);

                float lineHeight = font.GetHeight(e.Graphics);

                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                string header =
                    "Транспорт | Груз.2011 | Груз.2013 | Груз.2015 | Пасс.2013 | Пасс.2017 | Пасс.2018";

                e.Graphics.DrawString(header, headerFont, Brushes.Black, x, y);
                y += lineHeight * 2;

                while (printIndex < data.Count)
                {
                    var r = data[printIndex];

                    string line =
                        $"{r.Transport} | {r.Cargo2011} | {r.Cargo2013} | {r.Cargo2015} | {r.Passenger2013} | {r.Passenger2017} | {r.Passenger2018}";

                    e.Graphics.DrawString(line, font, Brushes.Black, x, y);

                    y += lineHeight;
                    printIndex++;

                    if (y > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                e.HasMorePages = false;
                printIndex = 0;
            }
            catch
            {
                e.HasMorePages = false;
                printIndex = 0;
            }
        }

        // 17. запуск печати
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printIndex = 0;

                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += printDocument1_PrintPage;

                PrintDialog dialog = new PrintDialog
                {
                    Document = printDoc
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                    printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка печати:\n" + ex.Message);
            }
        }
    }
}