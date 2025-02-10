
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModelsBookShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();

            db.Employees.Add(new Employee { Lastname = "Gaynutdinov", Firstname = "Radmir", Patronymic = "Rustemovich", Login = "Radmir", Password = "Rassword" });

            ImageService imageService = new ImageService();
            imageService.AddImagesFromFolder("C:\\Users\\Pelmen\\Desktop\\ModelsBookShop\\images");
            lv.ItemsSource = db.Books.ToList();
            db.SaveChanges();
        }

        public class ImageService
        {
            ApplicationContext db = new ApplicationContext();
            public void AddImagesFromFolder(string folderPath)
            {
                var imageFiles = Directory.GetFiles(folderPath);
                var existingImages = db.Books.ToList();

                foreach (var filePath in imageFiles)
                {
                    var fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);
                    var existingImage = existingImages.FirstOrDefault(img => img.Name.ToUpper().Contains(fileName.ToUpper()));

                    if (existingImage != null)
                    {
                        byte[] imageData = File.ReadAllBytes(filePath);
                        existingImage.Photo = imageData;
                    }
                }   
                db.SaveChanges();
            }
        }

    }
}