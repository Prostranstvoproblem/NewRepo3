using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;

namespace ink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingList<AirFlow> data1 = new BindingList<AirFlow>();
        BindingList<Volume> data2 = new BindingList<Volume>();
        public void DGRefresh1()
        {
            data1.Clear();
            using (ApplicationContext db = new ApplicationContext())
            {
                var infolist = db.AirFlows.FromSqlRaw("SELECT * FROM airflow").ToList();
                for (int i = 0; i < infolist.Count(); i++)
                {
                    data1.Add(infolist[i]);
                    dataGridView1.DataSource = data1;
                }
            }
        }

        public void DGRefresh2()
        {
            data2.Clear();
            using (ApplicationContext db = new ApplicationContext())
            {
                var infolist = db.Volumes.FromSqlRaw("SELECT * FROM volume").ToList();
                for (int i = 0; i < infolist.Count(); i++)
                {
                    data2.Add(infolist[i]);
                    dataGridView2.DataSource = data2;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    AirFlow a = new AirFlow(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));

                    db.AirFlows.Add(a);
                    db.SaveChanges();
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    DGRefresh2();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                DGRefresh1();
            }

            if (tabControl1.SelectedIndex == 1)
            {
                DGRefresh2();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data1;
            dataGridView2.DataSource = data2;
            DGRefresh1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    if (dataGridView2.CurrentRow != null)
                    {
                        AirFlow a = new AirFlow(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value), Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value));

                        db.AirFlows.Remove(a);
                        db.SaveChanges();
                        DGRefresh2();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    if (dataGridView2.CurrentRow != null)
                    {
                        AirFlow a = new AirFlow(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));

                        db.AirFlows.Update(a);
                        db.SaveChanges();
                        DGRefresh2();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                AirFlow[] airFlows = new AirFlow[100];
                Random random = new Random();
                using (ApplicationContext db = new ApplicationContext())
                {
                    for (int i = 0; i < airFlows.Length; i++)
                    {
                        airFlows[i] = new AirFlow(i + 1, random.Next(1, 7), random.Next(1, 30), random.Next(1, 30));
                    }
                    for (int i = 0; i < airFlows.Count(); i++)
                    {
                        db.AirFlows.Add(airFlows[i]);
                        db.SaveChanges();
                    }
                }
                DGRefresh1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data2.Clear();
            using (ApplicationContext db = new ApplicationContext())
            {
                var infolist = db.Volumes.FromSqlRaw("SELECT * FROM volume").OrderBy(r => r.volume).ToList();
                for (int i = 0; i < infolist.Count(); i++)
                {
                    data2.Add(infolist[i]);
                    dataGridView2.DataSource = data2;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    AirFlow[] airFlows = new AirFlow[100];
                    for (int i = 0; i < airFlows.Length; i++)
                    {
                        airFlows[i] = new AirFlow(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                    }
                    db.AirFlows.RemoveRange(airFlows);
                    db.SaveChanges();

                }
                DGRefresh1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}