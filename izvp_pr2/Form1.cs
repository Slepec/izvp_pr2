using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izvp_pr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString() + "\n" + DateTime.Now.DayOfWeek;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString() +"\n"+ DateTime.Now.DayOfWeek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = richTextBox1.Text;
            List<string> list = new List<string>(txt.Split(' '));
            int maxL = list[0].Length;
            int maxID = 0;
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].Length>maxL)
                {
                    maxL = list[i].Length;
                    maxID = i;
                }
            }
            label2.Text = "Найдовше прізвище: " + list[maxID]+"("+maxL+")";
            list.Sort();
            txt = "";
            foreach(string text in list)
            {
                txt += text+" ";
            }
            richTextBox2.Text = txt;
        }
        List<Student> list = new List<Student>();
        private void button2_Click(object sender, EventArgs e)
        {
            Student st = new Student(textBox1.Text, new int[] {Convert.ToInt32( numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value),
            Convert.ToInt32( numericUpDown3.Value),Convert.ToInt32( numericUpDown4.Value)});
            list.Add(st);
            dgvStudents.Rows.Add(textBox1.Text, numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value);
            textBox1.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            foreach(Student s in list)
            {
                Boolean check = true;
                foreach(int g in s.Grades)
                {
                    if(g<4)
                    {
                        check = false;
                    }
                }
                if(check)
                {
                    dgv2.Rows.Add(s.Name, s.Grades[0], s.Grades[1], s.Grades[2], s.Grades[3]);
                }
            }
        }
        List<Residents> listR = new List<Residents>();
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            listR.Add(new Residents(textBox2.Text,textBox3.Text,dateTimePicker1.Value));
            dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, dateTimePicker1.Value.Day+"."+dateTimePicker1.Value.Month+"."+dateTimePicker1.Value.Year);
            Console.WriteLine(date);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            dataGridView2.Rows.Clear();
            foreach(Residents r in listR)
            {
                Console.WriteLine();
                if (DateTime.Now.Year- r.Birth.Year >= 18)
                {
                    dataGridView2.Rows.Add(r.Name, r.Address, r.Birth.Day+"."+r.Birth.Month+"."+ r.Birth.Year);
                }
            }
        }
    }
}
