# Getting Started Wizard

[Home](/docs/wiz/readme.md) > [Windows](pickide_Windows.md) > [Other](picktest_Windows_Other.md) > xUnit

## Add NuGet packages

Add the following packages to the test project:

snippet: xUnit-nugets

## Implicit Usings

include: implicit-usings

## Includes/Excludes

include: include-exclude


## Line Endings

include: line-endings


## DiffEngineTray

Install [DiffEngineTray](https://github.com/VerifyTests/DiffEngine/blob/main/docs/tray.md)

DiffEngineTray sits in the Windows tray. It monitors pending changes in snapshots, and provides a mechanism for accepting or rejecting those changes.

```
dotnet tool install -g DiffEngineTray
```

This is optional, but recommended. Also consider enabling [Run at startup](https://github.com/VerifyTests/DiffEngine/blob/main/docs/tray.md#run-at-startup).

## DiffPlex

The text comparison behavior of Verify is pluggable. The default behaviour, on failure, is to output both the received
and the verified contents as part of the exception. This can be noisy when verifying large strings.

[Verify.DiffPlex](https://github.com/VerifyTests/Verify.DiffPlex) changes the text compare result to highlighting text differences inline.

This is optional, but recommended.


### Add the NuGet

```
<PackageReference Include="Verify.DiffPlex" Version="*" />
```


### Enable

```
[ModuleInitializer]
public static void Initialize() =>
    VerifyDiffPlex.Initialize();
```

## Diff Tool

Verify supports many [Diff Tools](https://github.com/VerifyTests/DiffEngine/blob/main/docs/diff-tool.md#supported-tools) for comparing received to verified.
While IDEs are supported, due to their MDI nature, using a different Diff Tool is recommended.

Tool supported by Windows:

 * [BeyondCompare](https://www.scootersoftware.com)
 * [P4Merge](https://www.perforce.com/products/helix-core-apps/merge-diff-tool-p4merge)
 * [DeltaWalker](https://www.deltawalker.com/)
 * [WinMerge](https://winmerge.org/)
 * [DiffMerge](https://www.sourcegear.com/diffmerge/)
 * [TortoiseGitMerge](https://tortoisegit.org/docs/tortoisegitmerge/)
 * [TortoiseGitIDiff](https://tortoisegit.org/docs/tortoisegitmerge/)
 * [TortoiseMerge](https://tortoisesvn.net/TortoiseMerge.html)
 * [TortoiseIDiff](https://tortoisesvn.net/TortoiseIDiff.html)
 * [KDiff3](https://github.com/KDE/kdiff3)
 * [Guiffy](https://www.guiffy.com/)
 * [ExamDiff](https://www.prestosoft.com/edp_examdiffpro.asp)
 * [Diffinity](https://truehumandesign.se/s_diffinity.php)
 * [Vim](https://www.vim.org/)
 * [Neovim](https://neovim.io/)
 * [AraxisMerge](https://www.araxis.com/merge)
 * [Meld](https://meldmerge.org/)
 * [SublimeMerge](https://www.sublimemerge.com/)
 * [CodeCompare](https://www.devart.com/codecompare/)
 * [VisualStudioCode](https://code.visualstudio.com)