#r "nuget: FsEx"
open System
open FsEx

module Colors =
    open System
    open System.Drawing

    //returns square distance
    let diffSq(c1:Color) (c2:Color) =
        let r = int64 c1.R - int64 c2.R
        let g = int64 c1.G - int64 c2.G
        let b = int64 c1.B - int64 c2.B
        r*r + g*g + b*b

    let diff(c1:Color) (c2:Color) =
        diffSq c1 c2
        |> float
        |> sqrt
        |> round
        |> int

    let darker i (c:Color)=
        let r = int c.R
        let g = int c.G
        let b = int c.B
        Color.FromArgb(max 0 (r-i),max 0 (g-i), max 0 (b-i))

    let brighter i (c:Color)=
        let r = int c.R
        let g = int c.G
        let b = int c.B
        Color.FromArgb(min 255 (r+i),min 255 (g+i), min 255 (b+i))


    let  namedColors =
        [|
        Color.AliceBlue
        Color.AntiqueWhite
        Color.Aqua
        Color.Aquamarine
        Color.Azure
        Color.Beige
        Color.Bisque
        Color.Black
        Color.BlanchedAlmond
        Color.Blue
        Color.BlueViolet
        Color.Brown
        Color.BurlyWood
        Color.CadetBlue
        Color.Chartreuse
        Color.Chocolate
        Color.Coral
        Color.CornflowerBlue
        Color.Cornsilk
        Color.Crimson
        Color.Cyan
        Color.DarkBlue
        Color.DarkCyan
        Color.DarkGoldenrod
        Color.DarkGray
        Color.DarkGreen
        Color.DarkKhaki
        Color.DarkMagenta
        Color.DarkOliveGreen
        Color.DarkOrange
        Color.DarkOrchid
        Color.DarkRed
        Color.DarkSalmon
        Color.DarkSeaGreen
        Color.DarkSlateBlue
        Color.DarkSlateGray
        Color.DarkTurquoise
        Color.DarkViolet
        Color.DeepPink
        Color.DeepSkyBlue
        Color.DimGray
        Color.DodgerBlue
        Color.Firebrick
        Color.FloralWhite
        Color.ForestGreen
        Color.Fuchsia
        Color.Gainsboro
        Color.GhostWhite
        Color.Gold
        Color.Goldenrod
        Color.Gray
        Color.Green
        Color.GreenYellow
        Color.Honeydew
        Color.HotPink
        Color.IndianRed
        Color.Indigo
        Color.Ivory
        Color.Khaki
        Color.Lavender
        Color.LavenderBlush
        Color.LawnGreen
        Color.LemonChiffon
        Color.LightBlue
        Color.LightCoral
        Color.LightCyan
        Color.LightGoldenrodYellow
        Color.LightGray
        Color.LightGreen
        Color.LightPink
        Color.LightSalmon
        Color.LightSeaGreen
        Color.LightSkyBlue
        Color.LightSlateGray
        Color.LightSteelBlue
        Color.LightYellow
        Color.Lime
        Color.LimeGreen
        Color.Linen
        Color.Magenta
        Color.Maroon
        Color.MediumAquamarine
        Color.MediumBlue
        Color.MediumOrchid
        Color.MediumPurple
        Color.MediumSeaGreen
        Color.MediumSlateBlue
        Color.MediumSpringGreen
        Color.MediumTurquoise
        Color.MediumVioletRed
        Color.MidnightBlue
        Color.MintCream
        Color.MistyRose
        Color.Moccasin
        Color.NavajoWhite
        Color.Navy
        Color.OldLace
        Color.Olive
        Color.OliveDrab
        Color.Orange
        Color.OrangeRed
        Color.Orchid
        Color.PaleGoldenrod
        Color.PaleGreen
        Color.PaleTurquoise
        Color.PaleVioletRed
        Color.PapayaWhip
        Color.PeachPuff
        Color.Peru
        Color.Pink
        Color.Plum
        Color.PowderBlue
        Color.Purple
        Color.Red
        Color.RosyBrown
        Color.RoyalBlue
        Color.SaddleBrown
        Color.Salmon
        Color.SandyBrown
        Color.SeaGreen
        Color.SeaShell
        Color.Sienna
        Color.Silver
        Color.SkyBlue
        Color.SlateBlue
        Color.SlateGray
        Color.Snow
        Color.SpringGreen
        Color.SteelBlue
        Color.Tan
        Color.Teal
        Color.Thistle
        Color.Tomato
        Color.Turquoise
        Color.Violet
        Color.Wheat
        Color.White
        Color.WhiteSmoke
        Color.Yellow
        Color.YellowGreen
        |]


    let findClosestNamed(c:Color) =
        namedColors |> Array.minBy(diffSq c)


    let printAll() =
        for i, c in Seq.indexed namedColors do
            let r = int c.R
            let g = int c.G
            let b = int c.B
            let t = $"███████████ {c.Name}"|> String.padRight 30 |> String.truncate 30
            Printf.color r g b $"{t}"

            let d20 = darker 20 c
            let r = int d20.R
            let g = int d20.G
            let b = int d20.B
            let t = $"███████████ {c.Name} {r}-{g}-{b}"|> String.padRight 42|> String.truncate 42
            Printf.color r g b $"{t}"

            let d40 = darker 40 c
            let r = int d40.R
            let g = int d40.G
            let b = int d40.B
            let t = $"███████████ {c.Name}"|> String.padRight 30|> String.truncate 30
            Printf.color r g b $"{t}"

            let d80 = darker 80 c
            let r = int d80.R
            let g = int d80.G
            let b = int d80.B
            let t = $"███████████ {c.Name} {r}-{g}-{b}"
            Printfn.color r g b $"{t}"



            //if i%3=0 then Printfn.color r g b $"{t}" else Printf.color r g b $"{t}"



clearFeshLog()
Colors.printAll()












