using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace koloro.Utils
{
    public class ImageUtils
    {
        public static async Task FilterImage(IJSRuntime js, string name)
        {
            await js.InvokeAsync<object>("saveAsFile", name + ".png");
        }
    }
}
