using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace tugas_week_5
{
    public partial class Form1 : Form
    {
        DataTable tabel1 = new DataTable();
        DataTable tabel2 = new DataTable();
        DataTable filter = new DataTable();
        int counter = 0;
        int x = 6;
        string sambung = "";
        int c = 0;
        int n = 0;
        string id = "";
        int edit;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DGV_left_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tabel 1
            tabel1.Columns.Add("ID Product");
            tabel1.Columns.Add("Nama Product");
            tabel1.Columns.Add("Harga");
            tabel1.Columns.Add("Stock");
            tabel1.Columns.Add("ID Category");
            tabel1.Rows.Add("J001", "jas hitam","100000", "30", "C1");
            tabel1.Rows.Add("J002", "jeans pink", "200000", "20", "C2");
            tabel1.Rows.Add("H001", "hoodie pink", "300000", "50", "C4");
            tabel1.Rows.Add("C001", "celana pendek", "50000", "60", "C3");
            tabel1.Rows.Add("C002", "celana dalam", "20000", "70", "C3");
            tabel1.Rows.Add("K001", "kalung perak", "2000000", "40", "C5");
            tabel1.Rows.Add("B001", "baju polos", "30000", "100", "C6");
            tabel1.Rows.Add("B002", "baju batik", "50000", "60", "C6");
            DGV_left.DataSource = tabel1;
            // tabel 2
            tabel2.Columns.Add("ID Category");
            tabel2.Columns.Add("Nama Category");
            tabel2.Rows.Add("C1", "jas");
            tabel2.Rows.Add("C2", "jeans");
            tabel2.Rows.Add("C3", "celana");
            tabel2.Rows.Add("C4", "hoodie");
            tabel2.Rows.Add("C5", "aksesoris");
            tabel2.Rows.Add("C6", "baju");
            DGV_right.DataSource = tabel2;
            // c box filter
            cbox_filter.Items.Add("jas");
            cbox_filter.Items.Add("jeans");
            cbox_filter.Items.Add("celana");
            cbox_filter.Items.Add("hoodie");
            cbox_filter.Items.Add("aksesoris");
            cbox_filter.Items.Add("baju");
            // c box category
            cbox_cat.Items.Add("jas");
            cbox_cat.Items.Add("jeans");
            cbox_cat.Items.Add("celana");
            cbox_cat.Items.Add("hoddie");
            cbox_cat.Items.Add("aksesoris");
            cbox_cat.Items.Add("baju");
            filter = tabel1.Copy();
        }

        private void but_filter_Click(object sender, EventArgs e)
        {
            cbox_filter.Enabled = false;
            cbox_filter.Enabled = true;   
        }

        private void but_all_Click(object sender, EventArgs e)
        {
            cbox_filter.Enabled = false;
            DGV_left.DataSource = tabel1;
        }

        private void cbox_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter.Rows.Clear();
            foreach(DataRow a in tabel2.Rows)
            {
                if( a[1] == cbox_filter.SelectedItem.ToString())
                {
                    foreach(DataRow b in tabel1.Rows)
                    {
                        if (a[0] == b[4])
                        {
                            filter.Rows.Add(b[0], b[1], b[2], b[3], b[4]);
                        }
                    }
                }
            }
            DGV_left.DataSource = filter;
        }

        private void but_addcat_Click(object sender, EventArgs e)
        {
            
            if(tbox_name.Text == "")
            {
                MessageBox.Show("invalid input");
            }
            else
            {
                foreach(DataRow c in tabel2.Rows)
                {
                    
                    if(tbox_name.Text == c[1].ToString())
                    {
                        counter++;
                    }
                }
                if(counter == 1)
                {
                    MessageBox.Show("invalid input");
                }

                else
                {
                    x++;
                    tabel2.Rows.Add(("C" + x) , tbox_name.Text);
                    cbox_filter.Items.Add(tbox_name.Text);
                    cbox_cat.Items.Add(tbox_name.Text);
                }
            }
        }

        private void but_rcat_Click(object sender, EventArgs e)
        {
            cbox_filter.Items.Remove(DGV_right.SelectedCells[1].Value.ToString());
            cbox_cat.Items.Remove(DGV_right.SelectedCells[1].Value.ToString());
            for (int x = tabel1.Rows.Count - 1; x >= 0; x--)
            {
                if (tabel1.Rows[x][4].ToString() == DGV_right.SelectedCells[0].Value.ToString())
                {
                    tabel1.Rows.RemoveAt(x);
                }
            }
            if (DGV_right.SelectedCells[0].Value.ToString().Substring(1) == x.ToString())
            {
                x--;
            }
            foreach (DataRow a in tabel2.Rows)
            {
                if (a[1].ToString() == DGV_right.SelectedCells[1].Value.ToString())
                {
                    tabel2.Rows.Remove(a);
                    break;
                }   
            }
            
        }

        private void but_rpro_Click(object sender, EventArgs e)
        {
            foreach (DataRow a in tabel1.Rows)
            {
                if (a[1].ToString() == DGV_left.SelectedCells[1].Value.ToString())
                {
                    tabel1.Rows.Remove(a);
                    break;
                }

            }
        }

        private void but_editpro_Click(object sender, EventArgs e)
        {
            edit = DGV_left.SelectedRows[0].Index;
            if (tbox_stock.Text == "0")
            {
                tabel1.Rows.RemoveAt(edit);
            }
            else
            {
                tabel1.Rows[edit][1] = tbox_nama.Text;
                tabel1.Rows[edit][2] = tbox_harga.Text;
                tabel1.Rows[edit][3] = tbox_stock.Text;
                foreach (DataRow a in tabel2.Rows)
                {
                    if (a[1].ToString() == DGV_right.SelectedCells[1].Value.ToString())
                    {
                        tabel1.Rows[edit][4] = a[0].ToString();
                        break;
                    }
                }

                n = 0;
                foreach (DataRow a in tabel1.Rows)
                {
                    if (tbox_nama.Text[0].ToString().ToUpper() == a[0].ToString()[0].ToString())
                    {
                        c = Convert.ToInt32(a[0].ToString().Substring(1));
                        if (c >= n)
                        {
                            n = c;
                        }
                    }
                }
                n++;
                id = tbox_nama.Text[0].ToString().ToUpper();
                for (int i = n.ToString().Length; i < 3; i++)
                {
                    id += "0";
                }
                id += Convert.ToString(n);
                tabel1.Rows[edit][0] = id;
                


            }
        }

        private void DGV_left_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbox_nama.Text = DGV_left.SelectedCells[1].Value.ToString();
            tbox_harga.Text = DGV_left.SelectedCells[2].Value.ToString();
            tbox_stock.Text = DGV_left.SelectedCells[3].Value.ToString();
            foreach (DataRow a in tabel2.Rows)
            {
                if (DGV_left.SelectedCells[4].Value.ToString() == a[0].ToString())
                {
                    cbox_cat.Text = a[1].ToString();
                    break;
                }
            }
        }

        private void but_addpro_Click(object sender, EventArgs e)
        {
            foreach (DataRow a in tabel2.Rows)
            {
                if(cbox_cat.Text == a[1].ToString())
                {
                    sambung = a[0].ToString();
                }
            }
            foreach (DataRow a in tabel1.Rows)
            {
                if (tbox_nama.Text[0].ToString().ToUpper() == a[0].ToString()[0].ToString())
                {
                    c = Convert.ToInt32(a[0].ToString().Substring(1));
                    if (c >= n)
                    {
                        n = c;
                    }
                }
            }
            n ++;
             id = tbox_nama.Text[0].ToString().ToUpper();
            for (int i = n.ToString().Length; i < 3; i++)
            {
                id += "0";
            }
            id += Convert.ToString(n);
            tabel1.Rows.Add(id, tbox_nama.Text, tbox_harga.Text, tbox_stock.Text, sambung);
        }
    }
}

