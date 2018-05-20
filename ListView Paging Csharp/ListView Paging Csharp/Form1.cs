using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ListView_Paging_Csharp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ki.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();

        public static int MaxObj, RowCount, ResidualNumber, LastPageNumber, PageNumber, Start = 0;
        public static int line, column;
        public static string[,] data;

        public void Datax()
        {
            line = listView1.Items.Count - 1;
            column = listView1.Columns.Count - 1;

            data = new string[line + 1, column + 1];

            for (int i = 0; i <= line; i++)
            {
                for (int w = 0; w <= column; w++)
                {
                    data[i, w] = listView1.Items[i].SubItems[w].Text;
                }
            }
        }

        void pagelist()
        {
            titleslist();
            int a = -1;
            if (RowCount != Start + ResidualNumber)
            {
                for (int i = Start; i < MaxObj + Start; i++)
                {
                    a++;
                    for (int w = 0; w <= column; w++)
                    {

                        if (w == 0)
                        {
                            listView1.Items.Add(data[i, w]);
                        }
                        else
                        {
                            listView1.Items[a].SubItems.Add(data[i, w]);
                        }
                    }
                }
            }
            else
            {
                for (int i = Start; i < Start + ResidualNumber; i++)
                {
                    a++;
                    for (int w = 0; w <= column; w++)
                    {

                        if (w == 0)
                        {
                            listView1.Items.Add(data[i, w]);
                        }
                        else
                        {
                            listView1.Items[a].SubItems.Add(data[i, w]);

                        }
                    }
                }
            }
        }

        void titleslist()
        {
            listView1.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("LastName");
            listView1.Columns.Add("Age");
        }

        void list()
        {

            connection.Close();
            connection.Open();
            titleslist();

            komut.Connection = connection;
            komut.CommandText = "SELECT * FROM ki";
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                int count = listView1.Items.Count;
                listView1.Items.Add(okuyucu["ID"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["Name"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["LastName"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["Age"].ToString());
            }

            RowCount = listView1.Items.Count;

            connection.Close();

            Datax();
        }

        void connect()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
                connection.Open();
            }
        }

        void ReadPageNumber()
        {
            if (ResidualNumber == 0 || RowCount <= MaxObj)
            {
                TextPageNumber.Text = PageNumber + " / " + LastPageNumber;
            }
            else
            {
                TextPageNumber.Text = PageNumber + " / " + (LastPageNumber + 1);
            }
        }

        private void FistPage_Click(object sender, EventArgs e)
        {
            PageNumber = 1;
            ReadPageNumber();
            Start = 0;
            Back.Enabled = false;
            FistPage.Enabled = false;
            Next.Enabled = true;
            LastPage.Enabled = true;
            pagelist();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            --PageNumber;
            ReadPageNumber();
            Start = Start - MaxObj;
            Next.Enabled = true;
            LastPage.Enabled = true;

            if (Start <= 0)
            {
                Start = 0;
                Back.Enabled = false;
                FistPage.Enabled = false;
            }
            pagelist();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            ++PageNumber;
            ReadPageNumber();
            Start = Start + MaxObj;
            Back.Enabled = true;
            FistPage.Enabled = true;

            if (Start >= RowCount || RowCount <= Start + MaxObj)
            {
                Next.Enabled = false;
                LastPage.Enabled = false;
            }
            pagelist();
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            if (ResidualNumber == 0)
            {
                Start = RowCount - MaxObj;
                PageNumber = LastPageNumber;
            }
            else
            {
                Start = RowCount - ResidualNumber;
                PageNumber = LastPageNumber + 1;
            }

            ReadPageNumber();

            Back.Enabled = true;
            FistPage.Enabled = true;
            Next.Enabled = false;
            LastPage.Enabled = false;
            pagelist();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            TextPageNumber.Text = "1 / 1";
            connect();
            list();
            connection.Close();
            Back.Enabled = true;
            FistPage.Enabled = true;
            Next.Enabled = true;
            LastPage.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            MaxObj = (int)numericUpDown1.Value;

            if (MaxObj >= RowCount)
            {
                numericUpDown1.Value = 0;
            }

            PageNumber = 1;
            Start = 0;
            if (MaxObj > 0)
            {
                LastPageNumber = RowCount / MaxObj;
                ResidualNumber = RowCount % MaxObj;
                ReadPageNumber();
                ShowAll.Enabled = true;
                Back.Enabled = false;
                FistPage.Enabled = false;
                Next.Enabled = true;
                LastPage.Enabled = true;
                pagelist();
            }
            else
            {
                ShowAll.Enabled = false;
                Back.Enabled = false;
                FistPage.Enabled = false;
                Next.Enabled = false;
                LastPage.Enabled = false;
                TextPageNumber.Text = "1 / 1";
                list();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                list();
                ShowAll.Enabled = false;
                Back.Enabled = false;
                FistPage.Enabled = false;
                Next.Enabled = false;
                LastPage.Enabled = false;
                TextPageNumber.Text = "1 / 1";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                Application.Exit();
            }
        }
    }
}