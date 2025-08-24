namespace Pathoschild.Stardew.TractorMod.Framework;

/// <summary>The type of sound effects to play while on the tractor.</summary>
internal enum FuelModeType
{
    /// <summary>Disable all fuel consumption.</summary>
    Disabled,

    /// <summary>Consume fuel per valid action (like tool use).</summary>
    PerAction,

    /// <summary>Consume fuel per tile traveled.</summary>
    PerTravel
}
