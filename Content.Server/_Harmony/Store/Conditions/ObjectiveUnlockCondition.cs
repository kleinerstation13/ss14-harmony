using Content.Server._Harmony.Objectives.Systems;
using Content.Shared.Mind;
using Content.Shared.Store;

namespace Content.Server._Harmony.Store.Conditions;

/// <summary>
/// Requires that the buyer have an objective that unlocks this listing.
/// </summary>
public sealed partial class ObjectiveUnlockCondition : ListingCondition
{
    public override bool Condition(ListingConditionArgs args)
    {
        var minds = args.EntityManager.System<SharedMindSystem>();
        if (!minds.TryGetMind(args.Buyer, out _, out var mind))
            return false;

        var unlocker = args.EntityManager.System<StoreUnlockerSystem>();
        return unlocker.IsUnlocked(mind, args.Listing.ID);
    }
}
