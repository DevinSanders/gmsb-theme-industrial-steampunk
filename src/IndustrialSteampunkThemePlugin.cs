using System.Collections.Generic;
using SoundBoard.PluginApi;

namespace IndustrialSteampunkThemePlugin;

/// <summary>
/// Industrial &amp; Steampunk theme pack — two selectable palettes for
/// steampunk RPG sessions. Each appears as its own entry in the host's
/// theme dropdown, prefixed with the pack name ("Industrial &amp;
/// Steampunk: The Inventor's Desk", "Industrial &amp; Steampunk: Smog
/// &amp; Aether").
///
/// <list type="bullet">
///   <item><b>The Inventor's Desk</b> (brass &amp; blueprint) — drafting
///   schematics on a wooden desk covered in gears. Light kraft-paper
///   browns, warm tans, and muted canvas surfaces; deep navy primary
///   (the blueprint-ink colour), polished copper secondary.</item>
///   <item><b>Smog &amp; Aether</b> (soot &amp; arcane) — a smog-choked
///   factory running on magical energy. Riveted dark iron, soot gray,
///   and tarnished steel surfaces; glowing gauge-needle amber primary,
///   volatile arcane violet secondary.</item>
/// </list>
///
/// <para>Each palette is a flat set of colours; the host has no Dark/Light toggle.</para>
/// </summary>
public sealed class IndustrialSteampunkThemePlugin : IThemePlugin
{
    public string Id => "theme.industrial-steampunk";
    public string Name => "Industrial & Steampunk";
    public string Version => PluginVersion.OfAssembly(typeof(IndustrialSteampunkThemePlugin));
    public string Author => "Devin Sanders";
    public string Description => "Two Industrial & Steampunk palettes: The Inventor's Desk (brass & blueprint) and Smog & Aether (soot & arcane).";

    public void Initialize(IPluginContext context) { }
    public void Shutdown() { }

    public IEnumerable<ThemePalette> GetPalettes() => new[]
    {
        new ThemePalette("inventors-desk", "The Inventor's Desk",
            new[] { "avares://IndustrialSteampunkThemePlugin/Themes/InventorsDesk.axaml" }),
        new ThemePalette("smog-and-aether", "Smog & Aether",
            new[] { "avares://IndustrialSteampunkThemePlugin/Themes/SmogAndAether.axaml" }),
    };
}
