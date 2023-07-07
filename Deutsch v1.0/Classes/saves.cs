using deutsch_code;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Deutsch_v1._0.Classes
{
    internal class saves
    {
        private int id;
        private string name;
        private bool dtoe;
        private string path;
        private int from;
        private int to;

        public void loadSave(int id)
        {
            String line;
            try
            {
                line = File.ReadLines(@"..\..\..\Save files\saves.txt").Skip(id - 1).Take(1).First();
                string[] aline = line.Split();
                name = aline[1];
                if (aline[2] == "dtoe")dtoe = true;
                else dtoe = false;
                path = aline[3];
                from = int.Parse(aline[4]);
                to = int.Parse(aline[5]);
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
        }
        public void newSave()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(@"..\..\..\Save files\saves.txt");
                id = 1;
                line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    id++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            line = id + "\t" + name + "\t" +  "dtoe" + "\t" + path + "\t" + from + "\t" + to;
            try
            {
                File.AppendAllText(@"..\..\..\Save files\saves.txt", Environment.NewLine + line);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }

        }

        public int numOfSaves()
        {
            string line;
            int num = 0;
            try
            {
                StreamReader sr = new StreamReader(@"..\..\..\Save files\saves.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    num++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            return num;
        }

        //public string[] savesList()
        //{
        //    string line;
        //    try
        //    {
        //        StreamReader sr = new StreamReader(@"..\..\..\Save files\saves.txt");
        //        id = 1;
        //        line = sr.ReadLine();
        //        while (line != null)
        //        {
        //            line = sr.ReadLine();
        //            id++;
        //        }
        //        sr.Close();
        //        StreamReader srr = new StreamReader(@"..\..\..\Save files\saves.txt");
        //        string[] list = new string[id - 1];
        //        int i = 0;
        //        line = srr.ReadLine();
        //        list[i] = line.Split()[1];
        //        while (line != null)
        //        {
        //            i++;
        //            line = srr.ReadLine();
        //            list[i] = line.Split()[1];
        //        }

        //        srr.Close();
        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        Debug.WriteLine("Exception: " + e.Message);
        //        string[] error = { "error" };
        //        return error;
        //    }
        //}

        public string getName() { return name; }
        public bool isDtoe() { return dtoe; }
        public string getPath() { return path; }
        public int getFrom() { return from; }
        public int getTo() { return to; }
        public void setName(string name) { this.name = name;}
        public void setPath(string path) { this.path = path;}
        public void setFrom(int from) { this.from = from; }
        public void setTo(int to) { this.to = to;}
        public void setDtoe(bool dtoe) { this.dtoe = dtoe;}


    }
}
