namespace Pathoschild.Stardew.TractorMod.Framework.Config;

/// <summary>Configuration for the watering can attachment.</summary>
internal class WateringCanConfig
{
    /// <summary>Whether to enable the attachment.</summary>
    public bool Enable { get; set; } = true;

    /// <summary>Water consumption when watering plants. Only applicable if <see cref="ModConfig.FuelMode"/> is set to <see cref="FuelModeType.PerAction"/></summary>
    public float FuelWater { get; set; } = 0.25f;
}
