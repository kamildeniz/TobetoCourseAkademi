using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CourseManager courseManager = new(new EfCourseDal());
            dataGridView1.DataSource = courseManager.GetAll();
        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new(new EfCategoryDal());
            dataGridView1.DataSource = categoryManager.GetAll();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            InstructorManager instructorManager = new(new EfInstructorDal());
            dataGridView1.DataSource = instructorManager.GetAll();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseManager courseManager = new(new EfCourseDal());
            dataGridView1.DataSource = courseManager.GetAll();
        }
    }
}