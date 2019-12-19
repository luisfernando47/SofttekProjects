using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShoesAppFileWatcher
{
    public partial class Form1 : Form
    {
        string Path = @"C:\Users\Curso\source\repos\ShoesAppWatcher\ShoesAppFileWatcher\ArchivosXML";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileSystemWatcher1.Path = Path;
            GetFile();
        }
        private void GetFile()
        {
            string[] lst = Directory.GetFiles(Path);
            txtReport.Text = "";
            foreach (var archivo in lst)
            {
                txtReport.Text += archivo + Environment.NewLine;
            }
        }
        //evento cuando cambia un xml
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            
            GetFile();
           
        }
        //evento cuando se renombra un xml
        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            GetFile();
            //update a la bd
          
        }
        //evento cuando se crea un xml
        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            //insert a la bd
        }
        //evento cuando se elimina un xml
        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            //delete a la bd
        }
    }
}
