![Logo](https://raw.githubusercontent.com/goswinr/Fesher/main/Doc/logo128.png)
# Fesher

[![Fesher on fuget.org](https://www.fuget.org/packages/Fesher/badge.svg)](https://www.fuget.org/packages/Fesher)
![code size](https://img.shields.io/github/languages/code-size/goswinr/Fesher.svg)
[![license](https://img.shields.io/github/license/goswinr/Fesher)](LICENSE)


Fesher is a library for colorful console output in the F# scripting editor [Fesh](https://github.com/goswinr/Fesh)

It has two modules `Printfn` and `Printf` providing functions named by a color.
Those functions work just like the `printfn` and `printf`.
They will detect via reflection if they are running inside Fesh and print in the respective colors.
If used outside of Fesh it will just fall back to `printfn` and `printf`.

The module `Fesher.AllColors` provides [all 280 named WPF colors](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.colors) as functions.

The function 'clearFeshLog()' will clear the Fesh log window.

### Usage

```fsharp
open Fesher // for the 18 most common colors
//open Fesher.AllColors // for all 280 named WPF colors

Printfn.red "The red answer is %s!" 42
```

![Screenshot](https://raw.githubusercontent.com/goswinr/Fesher/main/Doc/screen.png)

[See full API documentation on fuget.org](https://www.fuget.org/packages/Fesher)

### License
[MIT](https://raw.githubusercontent.com/goswinr/Fesher/main/LICENSE.md)

### Changelog
`0.2.0`
- added `Printfn.randomColor`

`0.1.0`
- ported from FsEx