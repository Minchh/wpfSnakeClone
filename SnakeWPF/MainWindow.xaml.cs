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

namespace SnakeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int _rows = 15, _cols = 15;
        private readonly Image[,] _gridImages;

        public MainWindow()
        {
            InitializeComponent();
            _gridImages = SetupGrid();

        }

        private Image[,] SetupGrid()
        {
            Image[,] images = new Image[_rows, _cols];
            GameGrid.Rows = _rows;
            GameGrid.Columns = _cols;

            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    Image image = new Image
                    {
                        Source = Images.Empty
                    };

                    images[r, c] = image;
                    GameGrid.Children.Add(image);
                }
            }

            return images;
        }
    }
}