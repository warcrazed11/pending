using Content.Shared.Chemistry.Components;
using Robust.Shared.GameStates;

namespace Content.Shared.FootPrint;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FootPrintComponent : Component
{
    [AutoNetworkedField, ViewVariables]
    public EntityUid PrintOwner;

    [DataField]
    public string SolutionName = "step";

    [DataField, ViewVariables]
    public Entity<SolutionComponent>? Solution;

    /// <summary>
    /// Set when the footprint's alpha has already been reduced because a weed exists on its tile.
    /// Prevents stacking the dim effect each time a weed spreads onto the same tile.
    /// </summary>
    [ViewVariables]
    public bool DimmedByWeeds;
}
