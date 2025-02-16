using Library.Models;
using Microsoft.AspNetCore.Components;

namespace PF2eDigitalDM.Components.Elements
{
    public partial class ConditionsGrid : ComponentBase
    {
        [Parameter]
        public List<Library.Models.Condition> Conditions { get; set; } = default!;
    }
}
