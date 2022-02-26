using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace autoclickTMTmine
{
 
    class ListPointer
    {
        private List<Point> listPoint = null;
        public long Length = 0;
        public ListPointer()
        {
            OpenFile();
            
            if(listPoint != null)
            {
                Length = listPoint.Count;
                return;
            }
            else
            {
                listPoint = new List<Point>();
                Length = 0;
            }

            
        }

        public void AddPoint(Point pointNew)
        {
            listPoint.Add(pointNew);
            Length = listPoint.Count;
            SaveToFile();
        }
        public void RemoveP(int id)
        {
            Point point = listPoint.Find(x => x.ID == id);
            listPoint.Remove(point);
            Length = listPoint.Count;
            SaveToFile();
        }

        public void Edit(int id, Point p)
        {
            int index = listPoint.FindLastIndex(x => x.ID == id);
            listPoint[index] = p;
            SaveToFile();
        }
        public void RemoveAll()
        {
            listPoint.Clear();
            Length = listPoint.Count;
            SaveToFile();
        }

        private void SaveToFile()
        {
            string rootPath = Application.StartupPath;
            string serializationFile = Path.Combine(rootPath, "point.txt");

            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, listPoint);
            }
        }


        public bool OpenFile()
        {
            string rootPath = Application.StartupPath;
            string serializationFile = Path.Combine(rootPath, "point.txt");
         
            if (!File.Exists(serializationFile)) File.Copy(Path.Combine(rootPath, @"Def\FileDat\point.txt"), serializationFile);

            if (new FileInfo(serializationFile).Length == 0) return false;
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();

                listPoint = (List<Point>)bformatter.Deserialize(stream);
            }
            
            
            return true;
        }
        public List<Point> GetAll()
        {
            return listPoint;
        }

        
    }
}
