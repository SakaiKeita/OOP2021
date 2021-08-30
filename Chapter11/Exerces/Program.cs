using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exerces {
    class Program {
        static void Main(string[] args) {

            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("--------");

            Exercise1_2(file);
            Console.WriteLine("--------");

            Exercise1_3(file);
            Console.WriteLine("--------");

            Exercise1_4(file);
            Console.WriteLine("--------");


        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
         .Select(x => new {
             Name = x.Element("name").Value,
             Teammembers = x.Element("teammembers").Value
         });
            foreach(var sports in xelements) {

                Console.WriteLine("{0}{1}", sports.Name, sports.Teammembers);

            }

        }





        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new {
                Firstplayed = x.Element("firstplayed").Value,
                Name = x.Element("name").Attribute("kanji").Value
            }).OrderBy(x => int.Parse(x.Firstplayed));

            foreach(var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Firstplayed);

            }
        }
            private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Value,
                Teammembers = x.Element("teammembers").Value

            })
             .OrderByDescending(x => int.Parse(x.Teammembers)).First();
            Console.WriteLine("{0}", sports.Name);
            }

        private static void Exercise1_4(string file) {
            //var xdoc = XDocument.Load("Sample.xml");
            var newfile = "sports.xml";
            
            
           
            var element = new XElement("Sample.xml", new XElement("name", "サッカー", new XElement("kanji", "蹴玉")),
            new XElement("teammembers", "11"), new XElement("firstplayed", "1948"));


            var xdoc = XDocument.Load("Sample.xml");

            xdoc.Save("sports.xml", SaveOptions.DisableFormatting);

            xdoc.Root.Add(element);
        }
}
}