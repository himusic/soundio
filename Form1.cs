using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Hotkey hk = new Hotkey();

        public Form1()
        {
            InitializeComponent();

            InitTmp();

            hk.KeyCode = Keys.A;
            hk.Windows = true;
            hk.Pressed += visible;

            if (!hk.GetCanRegister(this))
            {
                MessageBox.Show("Whoops, looks like attempts to register will fail " +
                                  "or throw an exception, show error to user");
            }
            else
            {
                hk.Register(this);
            }
        }

        private void visible(object sender, HandledEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        ~Form1()
        {
            if (hk.Registered)
                hk.Unregister();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            listView1.Items.Clear();

            //listView1.Items.AddRange(tmp.Where(i => i[1].StartsWith(textBox1.Text)).Select(c => new ListViewItem(c[0])).ToArray());
            for (int i = 0; i < 1000; i++)
            {
                if (list[i].SubItems[0].Text.Contains(textBox1.Text))
                    listView1.Items.Add(list[i]);
                if (list[i].SubItems[1].Text.Contains(textBox1.Text))
                    listView1.Items.Add(list[i]);
                if (list[i].SubItems[2].Text.Contains(textBox1.Text))
                    listView1.Items.Add(list[i]);
                if (list[i].SubItems[3].Text.Contains(textBox1.Text))
                    listView1.Items.Add(list[i]);
            }

            //if (textBox1.Text.Length == 5)
            //    {
            //        listView1.Items[1].Selected = true;
            //    listView1.Select();
            //    }
        }

        /// category | logical | physical | friend_l | parent_l | seq | weight | add_time
        private List<ListViewItem> list = new List<ListViewItem>();

        private void InitTmp()
        {
            for (int i = 0; i < 1000; i++)
            {
                ListViewItem lvi = new ListViewItem("c" + i);
                lvi.SubItems.Add("l" + i);
                lvi.SubItems.Add("p" + i);
                lvi.SubItems.Add("" + i);
                list.Add(lvi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                listView1.Items.AddRange(list.ToArray());
        }
    }
}