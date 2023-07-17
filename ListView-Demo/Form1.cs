using ListView_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListView_Demo
{
    public partial class Form1 : Form
    {

       static List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();

            listViewStudent.View = View.Details;
            // Allow the user to edit item text.
            listViewStudent.LabelEdit = true;
            // Allow the user to rearrange columns.
          //  listViewStudent.AllowColumnReorder = true;
            // Display check boxes.
            listViewStudent.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listViewStudent.FullRowSelect = true;
            // Display grid lines.
            listViewStudent.GridLines = true;
            // Sort the items in the list in ascending order.
           // listViewStudent.Sorting = SortOrder.Ascending;
            listViewStudent.Columns.Add("Index", -2, HorizontalAlignment.Left);
            listViewStudent.Columns.Add("StudentCode", -2, HorizontalAlignment.Left);
            listViewStudent.Columns.Add("StudentName", -2, HorizontalAlignment.Left);
            listViewStudent.Columns.Add("Address", -2, HorizontalAlignment.Center);
            listViewStudent.Columns.Add("Phone", -2, HorizontalAlignment.Center);
            listViewStudent.Columns.Add("GPA", -2, HorizontalAlignment.Center);
            listViewStudent.Columns.Add("Status", -2, HorizontalAlignment.Center);
            listViewStudent.Columns.Add("Gender", -2, HorizontalAlignment.Center);
            listViewStudent.Columns.Add("BirthDay", -2, HorizontalAlignment.Center);
            listViewStudent.Columns.Add("Class", -2, HorizontalAlignment.Center);
            listViewStudent.Columns.Add("Major", -2, HorizontalAlignment.Center);

            // Khoi tao doi tuong List Student 

            for(int i = 0; i < 10; i++)
            {
                // Them 10 Student vao studentList 
                Student student = new Student();
                student.Index = i+1;
                student.StudentCode = "BH001";
                student.StudentName = "Nguyen Tuan Manh";
                student.Address = "Ha Noi";
                student.Phone = "0945312678";
                student.GPA = 8.0;
                student.Status = 1;
                student.Gender = true;
                student.BirthDay = "2004-06-12";
                student.Class = "SE06012";
                student.Major = "Computer Science";

                students.Add(student);

            }

            foreach (Student s in students)
            {
                listViewStudent.Items.Add(
               new ListViewItem(new[] {
                   s.Index+"", 
                   s.StudentCode+"", 
                   s.StudentName+"", 
                   s.Address+"",
                   s.Phone,s.GPA+"",
                   s.Status+"",
                   s.Gender+"",
                   s.BirthDay+"",
                   s.Class+"",
                   s.Major }));
            }

           


            // this.Controls.Add(listViewStudent);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewStudent.FocusedItem.Index;
            students.RemoveAt(index);

            listViewStudent.Items.Clear();

            foreach (Student s in students)
            {
                listViewStudent.Items.Add(
               new ListViewItem(new[] {
                   s.Index+"",
                   s.StudentCode+"",
                   s.StudentName+"",
                   s.Address+"",
                   s.Phone,s.GPA+"",
                   s.Status+"",
                   s.Gender+"",
                   s.BirthDay+"",
                   s.Class+"",
                   s.Major }));
            }
            listViewStudent.Refresh();
            
           // MessageBox.Show(index + "");


            // int index = listViewStudent.SelectedItems.IndexOf(selectedItems);

        }
    }
}
