# gmsb-theme-industrial-steampunk

Industrial & Steampunk theme pack for [Game Master Sound Board](https://github.com/DevinSanders/game-master-soundboard).

Two selectable palettes for steampunk RPG sessions. Each appears as its own entry in the host's theme dropdown.

| Palette             | Vibe                                              | Primary accent             | Secondary accent           |
|---------------------|---------------------------------------------------|-----------------------------|-----------------------------|
| The Inventor's Desk | Drafting schematics on a wooden desk full of gears. | Blueprint navy #1F3A5C     | Polished copper #B87333    |
| Smog & Aether       | A smog-choked factory running on magical energy.  | Gauge-needle amber #D9A038 | Arcane violet #8A4DD5      |

**The Inventor's Desk** (brass & blueprint) — Light kraft-paper surfaces with warm tan and muted canvas. Blueprint-ink navy primary, polished copper secondary, oxidized-bronze muted text. For workshop / drafting / downtime scenes.

**Smog & Aether** (soot & arcane) — Riveted dark iron and soot-gray surfaces. Glowing gauge-needle amber primary (warm magic light through the smog), volatile arcane violet for the dangerous-arcane status indicators. For factory-floor / action scenes.

## Install

**Paid plugin.** The source is open here for reference, but the pre-built
binary is distributed pay-what-you-want on itch.io:

**→ https://dsand64.itch.io/gmsb-theme-industrial-steampunk**

Download the `.zip` from that page and drop it onto **Settings → Plugin
Manager** in Game Master Sound Board. Themes activate live — no restart needed; pick the palette under **Settings → Appearance → Theme**.

## Build

```powershell
dotnet build src/IndustrialSteampunkThemePlugin.csproj
pwsh scripts/package.ps1
# → dist/github.DevinSanders-theme.industrial-steampunk-1.0.0.zip
```

## Plugin manifest

| Field     | Value                                       |
|-----------|---------------------------------------------|
| publisher | `github.DevinSanders`                       |
| id        | `theme.industrial-steampunk`                |
| entryDll  | `IndustrialSteampunkThemePlugin.dll`        |
| isTheme   | `true`                                      |

## License

Released under the [MIT License](LICENSE). Original colour design for this pack.
