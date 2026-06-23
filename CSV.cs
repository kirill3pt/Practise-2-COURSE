using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace APP
{
    internal class CSV
    {
        private List<TransportRecord> data = new List<TransportRecord>();
        private string filePath;

        private const string HEADER = "Transport;Cargo2011;Cargo2013;Cargo2015;Passenger2013;Passenger2017;Passenger2018";

        // 1. создание файла
        public void CreateFile(string path)
        {
            filePath = path;
            File.WriteAllText(filePath, HEADER + "\n");
            data.Clear();
        }

        // 2. загрузка файла
        public void LoadFile(string path)
        {
            filePath = path;

            if (!File.Exists(filePath))
                return;

            data.Clear();

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines.Skip(1))
            {
                if (TransportRecord.TryParse(line, out var record))
                    data.Add(record);
            }
        }

        // 3. сохранение файла
        public void SaveFile()
        {
            if (string.IsNullOrEmpty(filePath))
                return;

            File.WriteAllLines(filePath,
                new[] { HEADER }.Concat(data.Select(d => d.ToCsv())));
        }

        // 4. получение данных
        public List<TransportRecord> GetData()
        {
            return data;
        }

        // 5. добавление записи
        public void AddRecord(TransportRecord record)
        {
            if (record != null)
                data.Add(record);
        }

        // 6. удаление
        public void DeleteRecord(int index)
        {
            if (index >= 0 && index < data.Count)
                data.RemoveAt(index);
        }

        // 7. обновление
        public void UpdateRecord(int index, TransportRecord record)
        {
            if (index >= 0 && index < data.Count && record != null)
                data[index] = record;
        }

        // 8. сортировка
        public void SortByCargo2011()
        {
            data = data.OrderBy(x => x.Cargo2011).ToList();
        }

        // 9. сумма
        public double SumCargo2013()
        {
            return data.Sum(x => x.Cargo2013);
        }

        // 10. ex1
        public TransportRecord Ex1()
        {
            return data.OrderByDescending(x => x.Cargo2011).FirstOrDefault();
        }

        // 11. ex2
        public List<TransportRecord> Ex2()
        {
            return data.Where(x => x.Passenger2018 > 15).ToList();
        }

        // 12. ex3
        public List<TransportRecord> Ex3()
        {
            return data.Where(x =>
                x.Passenger2013 < 40 ||
                x.Passenger2017 < 40 ||
                x.Passenger2018 < 40
            ).ToList();
        }

        // 13. удаление нескольких
        public void DeleteRecords(List<int> indexes)
        {
            foreach (var i in indexes.OrderByDescending(x => x))
                if (i >= 0 && i < data.Count)
                    data.RemoveAt(i);
        }

        // 14. график
        public Dictionary<string, double> Chart()
        {
            return data.ToDictionary(x => x.Transport, x => x.Cargo2013);
        }
    }
}