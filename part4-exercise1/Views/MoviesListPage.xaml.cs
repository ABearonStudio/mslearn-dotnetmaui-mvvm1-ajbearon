namespace MovieCatalog.Views;

public partial class MoviesListPage : ContentPage
{
    public MoviesListPage()
    {
        InitializeComponent();
    }

    private async void CollectionView_SelectionChanged(
        object sender,
        SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is ViewModels.MovieViewModel movie)
        {
            MoviesCollectionView.SelectedItem = null;
            await Navigation.PushAsync(new MovieDetailPage(movie));
        }
    }

    private void SwipeItem_DeleteClicked(object sender, EventArgs e)
    {
        if (sender is SwipeItem { BindingContext: ViewModels.MovieViewModel movie })
        {
            App.MainViewModel?.DeleteMovie(movie);
        }
    }
}
