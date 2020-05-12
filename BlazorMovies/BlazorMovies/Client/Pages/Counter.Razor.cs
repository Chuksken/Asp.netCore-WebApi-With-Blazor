
//using BlazorMovies.Shared.Entity;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMovies.Client.Shared.MainLayout;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {

        private int currentCount = 0;


        [JSInvokable]
        public void  IncrementCount()
        {
            currentCount++;


        }
    }
}











































//using BlazorMovies.Shared.Entity;
//using Microsoft.AspNetCore.Components;
//using Microsoft.JSInterop;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using static BlazorMovies.Client.Shared.MainLayout;

//namespace BlazorMovies.Client.Pages
//{
//    public partial class Counter
//    {
//        [Inject] SingletonService singleton { get; set; }
//        [Inject] TransientService transient{ get; set; }
//        [Inject] IJSRuntime js { get; set; }
//        [CascadingParameter] public AppState AppState { get; set; }
//        //[CascadingParameter(Name = "Size")] public string Size { get; set; }


//        private List<Movies> movies;
//        protected override void OnInitialized()
//        {
//            movies = new List<Movies>()
//{
//            new Movies(){Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2)},
//             new Movies(){Title = "Avenger", ReleaseDate = new DateTime(2016, 11, 23)},
//              new Movies(){Title = "Mongo", ReleaseDate = new DateTime(2010, 7, 16)},
//        };
//            //string man(string value) => value.ToUpper();
//            // Movies spiderman = new Movies()
//            //{
//            //Title = "Spider Man: Far From Home",
//            //ReleaseDate = new DateTime(2019, 7, 2)
//            //};
//        }
//        private int currentCount = 0;
//        private static int currentCountSatatic = 0;

//        [JSInvokable]
//        public async Task  IncrementCount()
//        {
//            currentCount++;

//            singleton.Value = currentCount;
//            transient.Value = currentCount;
//            currentCountSatatic++;
//           await js.InvokeVoidAsync("dotnetStaticInvocation");
//        }

//        private async Task IncrementCountJavaScript()
//        {
//            await js.InvokeVoidAsync("dotnetInstanceInvocation",
//                DotNetObjectReference.Create(this));
//        }
//        [JSInvokable]
//        public static Task<int> GetCurrentCount()
//        {
//            return Task.FromResult(currentCountSatatic);
//        }
//    }
//}
