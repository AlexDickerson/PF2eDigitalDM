using Library;
using Library.Models;
using Microsoft.AspNetCore.Components;

namespace PF2eDigitalDM.Components.Pages
{
    public partial class Home(IBackend backend) : ComponentBase
    {
        List<Library.Models.Condition> conditions;

        protected override void OnInitialized()
        {
            conditions = backend.GetConditions();
        }
    }
}
