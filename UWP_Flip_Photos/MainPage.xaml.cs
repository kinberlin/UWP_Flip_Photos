using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Flip_Photos
{
    public class MyItem
    {
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
    }
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<MyItem> listImages = new List<MyItem>();
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            InitImage();
            flipView.ItemsSource = listImages;
        }

        private void InitImage()
        {
            listImages.Add(new MyItem() { ImageName = "Porc Roti", ImagePath = "Assets/image1.jpg" });
            listImages.Add(new MyItem() { ImageName = "Brochette de Boeuf", ImagePath = "Assets/image2.jpg" });
            listImages.Add(new MyItem() { ImageName = "Barbecue de Poulet", ImagePath = "Assets/image3.jpg" });
        }
    }
}
