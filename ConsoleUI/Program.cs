

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.DTOs;

CourseManager courseManager = new(new EfCourseDal());
CategoryManager categoryManager = new(new EfCategoryDal());
InstructorManager instructorManager = new(new EfInstructorDal());
CourseInstructorManager courseInstructorManager = new(new EfCourseInstructorDal());

Console.WriteLine("Helloooo");
//while (true)
//{
//    Console.WriteLine(" Çık  kurs   kategory   eğitmen  kursaEğitmen");
//    Console.WriteLine(" 0    1      2           3       4");
//    string current = Console.ReadLine().ToLower();
//    if (current == "1")
//    {
//        CustomerAdd(courseManager);
//        foreach (var course in courseManager.GetAll().Data)
//        {
//            Console.WriteLine("Kursun Adı: " + course.Name + " Kursun Fiyatı : " + course.Price);
//        }
//    }
//    if (current == "2")
//    {
//        CategoryAdd(categoryManager);
//        foreach (var category in categoryManager.GetAll().Data)
//        {
//            Console.WriteLine("Kategori Adı: " + category.Name + " Kategori açıklaması : " + category.Description);
//        }

//    }

//    if (current == "0")
//    {
//        break;
//    }
//    Console.Clear();
//}

//static void CustomerAdd(CourseManager courseManager)
//{
//    CourseDTO kurs3 = new CourseDTO();

//    Console.Write("Kursun İsmini Giriniz : ");
//    kurs3.Name = Console.ReadLine();
//    Console.Write("Kursun Fiyatını Giriniz (En az 10 olabilir.): ");
//    kurs3.Price = decimal.Parse(Console.ReadLine());
//    Console.Write("Kategori giriniz : ");
//    kurs3.CategoryId = int.Parse(Console.ReadLine());
//    Console.Write("Kurs Açıklaması Giriniz : ");
//    kurs3.Description = Console.ReadLine();

//    courseManager.Add(kurs3);
//}
//static void CategoryAdd(CategoryManager categoryManager)
//{
//    Category category = new Category();

//    Console.Write("Kategori İsmini Giriniz : ");
//    category.Name = Console.ReadLine();
//    Console.Write("Kategory Açıklaması Giriniz : ");
//    category.Description = Console.ReadLine();

//    categoryManager.Add(category);
//}
//static void CustomerAdd(CourseManager courseManager)
//{
//    Course kurs3 = new Course();

//    Console.Write("Kursun İsmini Giriniz : ");
//    kurs3.Name = Console.ReadLine();
//    Console.Write("Kursun Fiyatını Giriniz (En az 10 olabilir.): ");
//    kurs3.Price = decimal.Parse(Console.ReadLine());
//    Console.Write("Kategori giriniz : ");
//    kurs3.CategoryId = int.Parse(Console.ReadLine());
//    Console.Write("Kurs Açıklaması Giriniz : ");
//    kurs3.Description = Console.ReadLine();

//    courseManager.Add(kurs3);
//}