using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class TransportRecord
    {
        public string Transport { get; set; }

        public double Cargo2011 { get; set; }
        public double Cargo2013 { get; set; }
        public double Cargo2015 { get; set; }

        public double Passenger2013 { get; set; }
        public double Passenger2017 { get; set; }
        public double Passenger2018 { get; set; }

        public string ToCsv()
        {
            return $"{Transport};{Cargo2011};{Cargo2013};{Cargo2015};{Passenger2013};{Passenger2017};{Passenger2018}";
        }
        public override string ToString()
        {
            return $"{Transport} | {Cargo2011} | {Cargo2013} | {Cargo2015} | {Passenger2013} | {Passenger2017} | {Passenger2018}";
        }

        public static bool TryParse(string line, out TransportRecord record)
        {
            record = null;

            var parts = line.Split(';');
            if (parts.Length != 7)
                return false;

            if (!double.TryParse(parts[1], out var c2011)) return false;
            if (!double.TryParse(parts[2], out var c2013)) return false;
            if (!double.TryParse(parts[3], out var c2015)) return false;
            if (!double.TryParse(parts[4], out var p2013)) return false;
            if (!double.TryParse(parts[5], out var p2017)) return false;
            if (!double.TryParse(parts[6], out var p2018)) return false;

            record = new TransportRecord
            {
                Transport = parts[0],
                Cargo2011 = c2011,
                Cargo2013 = c2013,
                Cargo2015 = c2015,
                Passenger2013 = p2013,
                Passenger2017 = p2017,
                Passenger2018 = p2018
            };

            return true;
        }
    }
}
