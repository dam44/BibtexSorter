using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibtexSorter
{
    public partial class MainForm : Form
    {
        private List<Reference> references;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            String file = tb_file.Text;
            if (String.IsNullOrWhiteSpace(file))
            {
                return;
            }
            if (!File.Exists(file))
            {
                return;
            }
            tb_export.Text = file;
            String content = File.ReadAllText(file);
            parseFile(content);
        }

        private void parseFile(String content)
        {
            references = new List<Reference>();
            Regex yourRegex = new Regex(@"(?<=})[^}]*(?=@)");
            string result = yourRegex.Replace(content, "");
            String[] temp = result.Replace("}@", "}|||123|||@").Split(new string[] { "|||123|||" }, StringSplitOptions.None);
            for (int i = 0; i < temp.Length; i++)
            {
                references.Add(new Reference(temp[i]));
            }
            lb_refs.DataSource = references;
            lb_refs.FormattingEnabled = false;
            lb_refs.AllowDrop = true;
        }

        private void lb_refs_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.lb_refs.SelectedItem == null) return;
            this.lb_refs.DoDragDrop(this.lb_refs.SelectedItem, DragDropEffects.Move);
        }

        private void lb_refs_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lb_refs_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lb_refs.PointToClient(new Point(e.X, e.Y));
            int index = this.lb_refs.IndexFromPoint(point);
            if (index < 0) index = this.lb_refs.Items.Count - 1;
            object data = e.Data.GetData(typeof(Reference));
            this.references.Remove((Reference)data);
            this.references.Insert(index, (Reference)data);
            this.lb_refs.DataSource = null;
            this.lb_refs.DataSource = this.references;
            this.lb_refs.SetSelected(index, true);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (references == null)
            {
                return;
            }
            String file = tb_export.Text;
            if (String.IsNullOrWhiteSpace(file))
            {
                return;
            }
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                for (int i = 0; i < references.Count; i++)
                {
                    outputFile.WriteLine(references[i].reference);
                }
            }
        }
    }
}


/*
            this.lb_refs.MouseDown += this.lb_refs_MouseDown;
            this.lb_refs.DragDrop += this.lb_refs_DragDrop;
            this.lb_refs.DragOver += this.lb_refs_DragOver;
*/