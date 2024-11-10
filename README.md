
![Logo](https://raw.githubusercontent.com/goswinr/Fesher/main/Docs/logo128.png)
# Fesher

[![Fesher on nuget.org](https://img.shields.io/nuget/v/Fesher)](https://www.nuget.org/packages/Fesher/)
[![Build Status](https://github.com/goswinr/Fesher/actions/workflows/build.yml/badge.svg)](https://github.com/goswinr/Fesher/actions/workflows/build.yml)
![code size](https://img.shields.io/github/languages/code-size/goswinr/Fesher.svg)
[![license](https://img.shields.io/github/license/goswinr/Fesher)](LICENSE)


Fesher is a library for colorful console output in the F# scripting editor [Fesh](https://github.com/goswinr/Fesh)

It has two modules `Printfn` and `Printf` providing functions named by a color.\
Those functions work just like the `printfn` and `printf`.\
They will detect via reflection if they are running inside Fesh and print in the respective colors.\
If used outside of Fesh it will just fall back to `printfn` and `printf`.

The module `Fesher.AllColors` provides [all 280 named WPF colors](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.colors) as functions.

The function 'clearFeshLog()' will clear the Fesh log window.

### Usage

```fsharp
#r "nuget: Fescher"
open Fesher // for the 18 most common colors, clearFeshLog and setClipboard
//open Fesher.AllColors // for all 280 named WPF colors

clearFeshLog() //optionally clear log window
Printfn.red "The red answer is %s!" 42
```

![Screenshot](https://raw.githubusercontent.com/goswinr/Fesher/main/Docs/screen.png)


### License
[MIT](https://raw.githubusercontent.com/goswinr/Fesher/main/LICENSE.md)

### Changelog
see [CHANGELOG.md](https://github.com/goswinr/Fesher/blob/main/CHANGELOG.md)