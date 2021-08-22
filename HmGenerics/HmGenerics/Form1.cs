using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HmGenerics
{
    public partial class Form1 : Form
    {
        ReadOnlycolletion<student> studentmaganament = new ReadOnlycolletion<student>();
        Colletction<int> intlist = new Colletction<int>();
        Colletction<double> doublelist = new Colletction<double>();
        Colletction<char> charlist = new Colletction<char>();
        Colletction<string> stringlist = new Colletction<string>();
        GenericId<Teacher> Teachermofa = new GenericId<Teacher>();
        GenericId<stuclass> stumofa = new GenericId<stuclass>();
        Teacher teaching = new Teacher();
        stuclass classer = new stuclass();
        Targilhaharon targil = new Targilhaharon();
        public Form1()
        {
            InitializeComponent();
        }

        private void FindById_Click(object sender, EventArgs e)
        {
           StudentName.Text= studentmaganament.findById(int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentmaganament.AddToList(new student());
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentmaganament.StopReadOnly();
        }

        private void typebox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void varibaletypebotton_Click(object sender, EventArgs e)
        {
            try
            {
                typebox1.Text = intlist.GetType(int.Parse(typebox2.Text));
            }
            catch
            {
                try
                {
                    typebox1.Text = doublelist.GetType(int.Parse(typebox2.Text));

                }
                catch
                {
                   try
                    {
                        typebox1.Text = stringlist.GetType(typebox2.Text);
                    }
                    catch
                    {
                        typebox1.Text = charlist.GetType(char.Parse(typebox2.Text));
                    }
                }
            }
        }


        private void addnewteacher_Click(object sender, EventArgs e)
        {
            if (textboxup.Text == teaching.ToString())
            {
                Teachermofa.Add(new Teacher());
            }
            else if (textboxup.Text == classer.ToString())

            {
                stumofa.Add(new stuclass());
            }
            else
            {
                textboxup.Text = "Wrong Kapara";
            }
        }
        private void findteacher_Click(object sender, EventArgs e)
        {
            typeBoxx.Text= Teachermofa.findById(textboxdow.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            typeBoxx.Text = stumofa.findById(textboxdow.Text);
        }

        private void GiveType_Click(object sender, EventArgs e)
        {
            textBoxlast1.Text = targil.printname();
            textBoxlast2.Text = targil.ToString();
        }
    }
}
