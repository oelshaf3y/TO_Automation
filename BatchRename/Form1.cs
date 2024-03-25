
using System.Text;

namespace BatchRename
{
    public partial class Form1 : Form
    {
        public string Directory { get; set; }
        public string[] files { get; set; }
        StringBuilder stringBuilder { get; set; } = new StringBuilder();
        public Form1()
        {

            InitializeComponent();


            //MessageBox.Show(stringBuilder.ToString());
        }

        private void GetFiles(string fil)
        {
            int a = 0;
            for (int i = 0; i < files.Length; i++)
            {
                string name = files[i].Split('\\').Last();
                if (fil != null)
                {
                    if (!name.ToLower().Contains(fil)) continue;
                }
                CheckBox cb = new CheckBox();
                cb.Name = name;
                cb.Text = name;
                cb.Location = new Point(0, a * 30);
                cb.Width = name.Length * 10;
                panel1.Controls.Add(cb);
                a++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GetFiles(textBox1.Text.ToLower());
        }

        private void button6_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            if (Dialog.ShowDialog() == DialogResult.Cancel) return;
            Directory = Dialog.SelectedPath;

            files = System.IO.Directory.GetFiles(Directory);
            panel1.Controls.Clear();
            GetFiles(textBox1.Text.ToLower());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GetFiles(textBox1.Text.ToLower());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in panel1.Controls)
            {
                cb.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in panel1.Controls)
            {
                cb.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string findWhat = textBox2.Text;
            string replaceWith = textBox3.Text;
            string prefix = textBox4.Text;
            string suffix = textBox5.Text;
            string extension;
            foreach (CheckBox cb in panel1.Controls)
            {
                if (cb.Checked)
                {
                    string oldName = cb.Text;
                    extension = oldName.Split('.').Last();
                    string newName = oldName;
                    if (findWhat.Length > 0)
                    {
                        newName = oldName.Replace(findWhat, replaceWith);

                    }
                    if (suffix.Length > 0)
                    {
                        newName = newName.Replace("." + extension, suffix + "." + extension);
                    }
                    if (prefix.Length > 0)
                    {
                        newName = prefix + newName;
                    }
                    if (checkBox1.Checked) stringBuilder.AppendLine(newName);
                    string oldPath = Path.Combine(Directory, oldName);
                    string newPath = Path.Combine(Directory, newName);
                    System.IO.File.Move(oldPath, newPath);
                }
            }

            files = System.IO.Directory.GetFiles(Directory);
            panel1.Controls.Clear();
            GetFiles(textBox1.Text.ToLower());
            if (checkBox1.Checked) Clipboard.SetText(stringBuilder.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
