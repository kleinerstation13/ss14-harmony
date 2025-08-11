using Content.Server._Harmony.StationEvents.Events;
using Content.Server.StationEvents.Events;

namespace Content.Server._Harmony.StationEvents.Components;

[RegisterComponent, Access(typeof(EmptyRule))]
public sealed partial class EmptyRuleComponent : Component
{
}
