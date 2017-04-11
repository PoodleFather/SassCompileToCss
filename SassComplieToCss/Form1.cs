using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SassComplieToCss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var sassFiles = Directory.GetFiles(Path.Combine(sassDir.Text,"default"), "cmn-*.sass")
                        .Union(Directory.GetFiles(Path.Combine(sassDir.Text, "default"), "skin-*.sass")).ToList();

            sassFiles.ForEach(filePath => ProcessStartWaitForExit(filePath));
        }

        private void ProcessStartWaitForExit(string sourceSassFilePath)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = Path.Combine(RubyDir.Text , "ruby.exe");
                process.StartInfo.Arguments = $"\"{Path.Combine(RubyDir.Text, "sass")} \" --sourcemap=none \"{sourceSassFilePath}\" \"{GetCssFilePath(sourceSassFilePath)}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.Start();
                process.WaitForExit();
            }
        }

        private string GetCssFilePath(string filePath)
        {
            return Path.Combine(cssDir.Text, $"{Path.GetFileNameWithoutExtension(filePath)}.css");
        }
    }
}
