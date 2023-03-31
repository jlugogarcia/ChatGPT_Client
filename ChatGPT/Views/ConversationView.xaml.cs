using ChatGPT.ViewModels;

namespace ChatGPT.Views;

public partial class ConversationView : ContentPage
{
    public ConversationView(ConversationViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;

        vm.CollectionView = myCollectionView;
        vm.ConversationView = mainPage;
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        //call CurrentCommand from the ConversationModel class
        ((ConversationViewModel)BindingContext).CurrentCommand.Execute(sender);        
    }
}