using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed 
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Viverra nam libero justo laoreet sit amet cursus sit. Duis at consectetur lorem donec massa sapien. Urna cursus eget nunc scelerisque. Mauris augue neque gravida in fermentum et. Nibh praesent tristique magna sit. Et netus et malesuada fames ac turpis egestas maecenas. Integer feugiat scelerisque varius morbi enim nunc faucibus a pellentesque. Blandit volutpat maecenas volutpat blandit aliquam etiam erat. Auctor augue mauris augue neque gravida in fermentum. Quam lacus suspendisse faucibus interdum posuere lorem. Id nibh tortor id aliquet lectus proin nibh nisl. Viverra nam libero justo laoreet sit. Mattis molestie a iaculis at erat pellentesque adipiscing commodo elit. Urna cursus eget nunc scelerisque viverra mauris. Commodo odio aenean sed adipiscing diam donec adipiscing tristique. Congue mauris rhoncus aenean vel elit scelerisque mauris pellentesque pulvinar. Id aliquet lectus proin nibh. Sollicitudin nibh sit amet commodo nulla facilisi nullam vehicula ipsum. Elementum pulvinar etiam non quam lacus suspendisse faucibus interdum posuere.",
                        Date = DateTime.Now.AddDays(-10)
                        },
                    new Post {
                        Title = "Second Post",
                        Body = "Eget felis eget nunc lobortis. Enim blandit volutpat maecenas volutpat blandit. Rhoncus est pellentesque elit ullamcorper dignissim. Nunc non blandit massa enim nec dui nunc mattis. Leo duis ut diam quam nulla porttitor massa id neque. Consequat mauris nunc congue nisi vitae suscipit tellus mauris a. Tortor condimentum lacinia quis vel eros. Leo vel fringilla est ullamcorper eget. Eros in cursus turpis massa tincidunt dui. Odio eu feugiat pretium nibh ipsum consequat nisl vel. Facilisis sed odio morbi quis commodo odio aenean. Consequat nisl vel pretium lectus quam id leo in vitae. Ullamcorper sit amet risus nullam eget felis eget. Ut lectus arcu bibendum at varius vel pharetra vel. Id cursus metus aliquam eleifend. Ut faucibus pulvinar elementum integer enim neque. Sollicitudin ac orci phasellus egestas tellus rutrum tellus pellentesque eu.",
                        Date = DateTime.Now.AddDays(-7)
                        },
                    new Post {
                        Title = "Third post",
                        Body = "Egestas diam in arcu cursus. Dui vivamus arcu felis bibendum ut. Lectus arcu bibendum at varius vel pharetra vel turpis nunc. Orci ac auctor augue mauris augue neque gravida in fermentum. Blandit libero volutpat sed cras ornare arcu. Elementum eu facilisis sed odio. Lectus magna fringilla urna porttitor rhoncus dolor. Pulvinar mattis nunc sed blandit. Nunc faucibus a pellentesque sit amet porttitor eget. Morbi quis commodo odio aenean sed adipiscing diam donec. Placerat orci nulla pellentesque dignissim enim. Euismod nisi porta lorem mollis aliquam ut porttitor leo a. Ullamcorper a lacus vestibulum sed arcu non odio euismod.",
                        Date = DateTime.Now.AddDays(-4)
                        }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}