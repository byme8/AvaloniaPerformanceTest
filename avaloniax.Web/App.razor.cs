using Avalonia.Web.Blazor;

namespace avaloniax.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<avaloniax.App>()
            .SetupWithSingleViewLifetime();
    }
}