using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Media.Imaging;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PictureLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public static ObservableCollection<Picture> allPicsList;


        public MainPage()
        {
            MaximizeWindowOnLoad();
            this.InitializeComponent();

            allPicsList = new ObservableCollection<Picture>();

            //DataContext = this;
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.DataContext = await Helper.GetAllPictures();
        }

        private static void MaximizeWindowOnLoad()
        {

            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.Maximized;

        }


        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Albums_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;

        }

        private async void AddPicture_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;

            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".png");

            var fileList = await openPicker.PickMultipleFilesAsync();
            if (fileList != null)
            {
                foreach (var file in fileList)
                {
                    var stream = await file.CopyAsync(storageFolder,file.Name, NameCollisionOption.GenerateUniqueName);
                    //var image = new BitmapImage();
                    //image.SetSource(stream);
                    //yourimagelist.Add(image);
                    allPicsList.Add(
                        new Picture
                        {
                            albumName = "",
                            dateAdded = file.DateCreated.LocalDateTime,
                            path = file.Path,
                            picName = file.Name
                        }
                        );
                }
            }
            else
            {
                //  
            }

        }

        private async void AddAlbum_Click(object sender, RoutedEventArgs e)
        {
            //if (!AddAlbumContentDialog.IsOpen) { AddAlbumPopup.IsOpen = true; }

            var btn = sender as Button;
            var result = await AddAlbumContentDialog.ShowAsync();
            
        }



        private void AppBarToggleButton_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }


        private async void AddAlbumContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            try
            {
                var appFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync(txtAlbumName.Text, CreationCollisionOption.FailIfExists);

            }
            catch (Exception )
            {
               
                args.Cancel = true;
                txtError.Text = "Album Name Already Exists!";
            }
        }

        private void ItemsGridView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Here I'm calculating the number of columns I want based on
            // the width of the page
            var columns = Math.Ceiling(ActualWidth / 300);
            ((ItemsWrapGrid)itemsGridView.ItemsPanelRoot).ItemWidth = e.NewSize.Width / columns;
        }
    }
}
