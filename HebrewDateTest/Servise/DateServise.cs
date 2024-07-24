using HebrewDateTest.model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace HebrewDateTest.Servise
{
    internal static class DateService
    {
        private static readonly string _path = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Queries.xml"
        );
        public static void CreateXmlIfNotExist()
        {
            if (!File.Exists(_path))
            {
                XDocument document = XDocument.Parse(@"<Queries></Queries>");
                document.Save(_path);
            }
        }
        public static XElement ConvertDateToXElement(DateModel dateModel) =>
            new("Query",
                new XElement("Day", dateModel.Day),
                new XElement("DayMonth", dateModel.DayOfMonth),
                new XElement("Month", dateModel.Month),
                new XElement("Year", dateModel.Year),
                new XElement("Result", CalculationResult(dateModel))
            );
        public static void AddDate(DateModel dateModel)
        {
            XDocument docoment = XDocument.Load(_path);
            docoment.Descendants("Queries")
                .First()
                .Add(ConvertDateToXElement(dateModel));

            docoment.Save(_path);
        }
        
        public static string CalculationResult(DateModel dateModel)
        {
            string day = dateModel.Day switch
            {
                "ראשון" => "באחד לשבת",
                "שני" => "בשנים לשבת",
                "שלישי" => "בשלוש לשבת",
                "רביעי" => "ברביעי לשבת",
                "חמישי" => "בחמישה לשבת",
                "שישי" => "בשישה לשבת",
                _ => "שגיאה"
            };
            
            string dayOfMonth = dateModel.DayOfMonth switch
            {
                "1" => $"{dateModel.Month} יום אחד לירח",
                "2" => $"{dateModel.Month} יום שתיים לירח",
                "3" => "יום שלוש לירח",
                "4" => "יום ארבע לירח",
                "5" => "יום חמש לירח",
                "6" => "יום שש לירח",
                "7" => "יום שבע לירח",
                "8" => "יום שמונה לירח",
                "9" => "יום תשע לירח",
                "10" => "יום עשר לירח",
                "11" => "יום אחד עשר לירח",
                "12" => "יום שתיים עשר לירח",
                "13" => "יום שלוש עשר לירח",
                "14" => "יום ארבע עשר לירח",
                "15" => "יום חמש עשר לירח",
                "16" => "יום שש עשר לירח",
                "17" => "יום שבע עשר לירח",
                "18" => "יום שמונה עשר לירח",
                "19" => "יום תשע עשר לירח",
                "20" => "יום עשרים לירח",
                "21" => "יום עשרים ואחד לירח",
                "22" => "יום עשרים ושתיים לירח",
                "23" => "יום עשרים ושלוש לירח",
                "24" => "יום עשרים וארבע לירח",
                "25" => "יום עשרים וחמש לירח",
                "26" => "יום עשרים ושש לירח",
                "27" => "יום עשרים ושבע לירח",
                "28" => "יום עשרים ושמונה לירח",
                "29" => "יום עשרים ותשע לירח",
                "30" => $"{dateModel.Month} שהוא ראש חודש {dateModel.Month} יום שלושים לירח",
                _ => "שגיאה"
            };
            string blabla1 = "שנת חמשת אלפים ושבע מאות ו";
            string Year = dateModel.Year switch
            {
                "תשפ\"ד" => "שמנים וארבע",
                "תשפ\"ה" => "שמנים וחמישה",
                "תשפ\"ו" => "שמנים ושישה",
                "תשפ\"ז" => "שמנים ושבעה",
                "תשפ\"ח" => "בשמנים ושמונה",
                "תשפ\"ט" => "שמנים ותשעה",
                "תש\"צ" => "תשעים",
                "תשצ\"א" => "תשעים ואחת",
                "תשצ\"ב"=> "תשעים ושתים",
                "תשצ\"ג"=> "תשעים ושלושה",
                _ => "שגיאה"
            };
            string blabla2 = "לבריאת העולם";
            return $"{day} {dayOfMonth} {dateModel.Month} {blabla1}{Year} {blabla2}";
        }
    }
}
