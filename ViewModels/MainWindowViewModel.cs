using System;
using System.Collections.Generic;
using BlogMvvmTwo.Models;

namespace BlogMvvmTwo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{ 
    public MainWindowViewModel()
    {
        MainMenuEntity = new() 
        { 
            Home = "Home", 
            About = "About", 
            MainTopicsList = new List<string> {"Main topic 1","Main topic 2", "Main topic 3"},
            Profile = "RSS"
        };
        
        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity() 
            {
                Article = "Article 1", 
                Text = " Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?<LineBreak />Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", 
                ImagePath = "happy.png",
                Tags = new List<string> {"Tags:  ", "Tag1", "Tag2", "Tag3"},
                Rate = "Rate this article 4/5"
            }
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque condimentum faucibus. Donec ac suscipit dolor. Etiam sit amet elit est. Morbi pretium placerat varius. Aliquam tempor ultricies vehicula. Cras et leo vestibulum, eleifend velit condimentum, blandit metus.", PublishTime = DateTime.Now },
            new() { Text = "Donec laoreet risus in erat scelerisque hendrerit sed a turpis. Donec justo felis, condimentum nec venenatis in, gravida sagittis diam. Sed eu urna quam. Donec gravida sem vitae sollicitudin dapibus. Phasellus aliquet ut magna nec egestas. Etiam consequat hendrerit odio id venenatis. Vestibulum semper varius dapibus.", PublishTime = DateTime.Now.AddDays(-1) }
        };
    }

    public MainEntity MainMenuEntity {get; set;}
    public List<BlogsEntity> BlogsEntities {get; set;}
    public List<NewsEntity> NewsEntities {get; set;}

    
}
