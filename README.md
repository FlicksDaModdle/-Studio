# -Studio
Check out the [original AssetStudio project](https://github.com/Perfare/AssetStudio) for more information.
_____________________________________________________________________________________________________________________________
New Discord Server: 

Join [here](68 74 74 70 73 3a 2f 2f 64 69 73 63 6f 72 64 2e 67 67 2f 4a 41 65 42 35 6a 47 64 63 6e) for more discussions, questions, suggestions and feedback.
_____________________________________________________________________________________________________________________________

This is the release of `-Studio`, Modded AssetStudio that should work on:
```
4e 75 6d 62 65 72 20 31 3a 20 47 65 6e 73 68 69 6e 20 49 6d 70 61 63 74 0a 4e 75 6d 62 65 72 20 32 3a 20 48 6f 6e 6b 61 69 20 49 6d 70 61 63 74 20 33 72 64 0a 4e 75 6d 62 65 72 20 33 3a 20 48 6f 6e 6b 61 69 20 49 6d 70 61 63 74 20 53 74 61 72 20 52 61 69 6c 0a 4e 75 6d 62 65 72 20 34 3a 20 54 65 61 72 73 20 6f 66 20 54 68 65 6d 69 73
These are game options in the studio.
```

Note: Requires Internet connection to fetch asset_index jsons.
_____________________________________________________________________________________________________________________________

Some features are:
```
- Change selected Game by using "Option -> Specify Game".
- Integration with "Radioegor146" repo to load asset_index through "Options -> Specify AI version".
- Exportable Assets (not all of them) with XOR/JSON support for "47 65 6e 73 68 69 6eOwnerBinData"
- Togglable debug console.
- Container/filename recovery for Assets.
- Build AssetMap, An asset list of assets inside game files.
- Build CABMap/AssetMap through CLI (with supported `Unity Type` and `Regex` filters).
- Export assets through CLI (with supported `Unity Type` and `Regex` filters and grouping).
```
_____________________________________________________________________________________________________________________________
How to use:

```
1. Build CABMap (Misc. -> Build CABMap).
2. Load files.
```
_____________________________________________________________________________________________________________________________
CLI Version:
```
Description:

Usage:
  AssetStudioCLI <input_path> <output_path> [options]

Arguments:
  <input_path>   Input file/folder.
  <output_path>  Output folder.

Options:
  --silent                                                Hide log messages.
  --type <Texture2D|Sprite|etc..>                         Specify unity class type(s)
  --filter <filter>                                       Specify regex filter(s).
  --game <BH3|GI|SR|TOT> (REQUIRED)                       Specify Game.
  --map_op <AssetMap|Both|CABMap|None>                    Specify which map to build. [default: None]
  --map_type <JSON|XML>                                   AssetMap output type. [default: XML]
  --map_name <map_name>                                   Specify AssetMap file name.
  --group_assets_type <ByContainer|BySource|ByType|None>  Specify how exported assets should be grouped. [default: 0]
  --no_asset_bundle                                       Exclude AssetBundle from AssetMap/Export.
  --no_index_object                                       Exclude IndexObject/MiHoYoBinData from AssetMap/Export.
  --xor_key <xor_key>                                     XOR key to decrypt MiHoYoBinData.
  --ai_file <ai_file>                                     Specify asset_index json file path (to recover GI containers).
  --version                                               Show version information
  -?, -h, --help                                          Show help and usage information
```
_____________________________________________________________________________________________________________________________
NOTES:
```
- in case of any "MeshRenderer/SkinnedMeshRenderer" errors, make sure to enable "Disable Renderer" option in "Export Options" before loading assets.
- in case of need to export models/animators without fetching all animations, make sure to enable "Ignore Controller Anim" option in "Options -> Export Options" before loading assets.
```
_____________________________________________________________________________________________________________________________
Special Thank to:
- Perfare: Original author.
- Khang06: [genshinblkstuff](https://github.com/khang06/genshinblkstuff) for blk/mhy0 extraction.
- Radioegor146: [gi-asset-indexes](https://github.com/radioegor146/gi-asset-indexes) for recovered/updated asset_index's.
- Ds5678: [AssetRipper](https://github.com/AssetRipper/AssetRipper)[[discord](https://discord.gg/XqXa53W2Yh) at `#mihoyo` channel] for information about Asset Formats & Parsing.
