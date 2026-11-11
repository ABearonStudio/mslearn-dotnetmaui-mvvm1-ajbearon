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
        await Navigation.PushAsync(new Views.MovieDetailPage());
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        SwipeItem swipeItem = (SwipeItem)sender;
        ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)swipeItem.BindingContext;
        App.MainViewModel.DeleteMovie(movie);
    }
}