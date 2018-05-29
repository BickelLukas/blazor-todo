using Microsoft.AspNetCore.Blazor.Browser.Rendering;

namespace BlazorTodo
{
    public class Program
    {
        static void Main(string[] args)
        {
            new BrowserRenderer().AddComponent<App>("app");
        }
    }
}
