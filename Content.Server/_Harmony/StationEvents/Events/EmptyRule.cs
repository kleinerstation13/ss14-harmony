using Content.Server.StationEvents.Components;
using Content.Server.StationEvents.Events;
using Content.Shared.GameTicking.Components;

namespace Content.Server._Harmony.StationEvents.Events;

public sealed class EmptyRule : StationEventSystem<Components.EmptyRuleComponent>
{
    protected override void Started(EntityUid uid, Components.EmptyRuleComponent comp, GameRuleComponent gameRule, GameRuleStartedEvent args)
    {
        base.Started(uid, comp, gameRule, args);
    }
}
