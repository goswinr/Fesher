namespace Fesher

open System

module internal ColorUtil =

    let clamp01 x =
        if x < 0.0 then 0.0
        elif x > 1.0 then 1.0
        else x


    let Rand =
        let now = DateTime.Now
        let seed = now.TimeOfDay
        new Random(int <| seed.TotalMilliseconds * 0.012543) // random seed different than other modules

    let mutable lastHue = 0.0

    let mutable lumUp = false

    /// Generates a Random color with high saturation probability, excluding yellow colors
    /// These are ideal for layer color in Rhino3d CAD app
    /// Using golden-ratio-loop subsequent colors will have very distinct hues
    let rec randomForRhino () =
        lastHue <- lastHue + 0.6180334 // golden angle conjugate
        lastHue <- lastHue % 1.0 // loop it between 0.0 and 1.0
        let mutable s = Rand.NextDouble()
        s <- s*s*s*s  //  0.0 - 1.0 increases the probability that the number is small( )
        s <- s*0.7    //  0.0 - 0.7 make sure it is less than 0.6
        s <- 1.1 - s  //  1.1 - 0.6
        s <- clamp01 s //  1.0 - 0.6
        let mutable l = Rand.NextDouble()
        l <- l * l     //  0.0 - 1.0 increases the probability that the number is small( )
        l <- l * 0.35 * s   //  0.0 - 0.25 , and scale down with saturation too
        l <- if lumUp then lumUp<-false;  0.5+l*1.1 else lumUp<-true ;  0.5-l //alternate luminance up or down,  mor on the bright side
        if l > 0.3 && lastHue > 0.10 && lastHue < 0.22 then  // exclude yellow unless dark
            randomForRhino()
        else
            lastHue, s, l


    /// Given Hue, Saturation, Luminance in range of 0.0 to 1.0, returns a FsEx.Color
    /// Will fail with ArgumentOutOfRangeException on too small or too big values,
    /// but up to a tolerance of 0.001 values will be clamped to 0 or 1.
    let fromHSL (hue:float, saturation:float, luminance:float) =
        // from http://stackoverflow.com/questions/2942/hsl-in-net
        // or http://bobpowell.net/RGBHSB.aspx
        let H = clamp01 hue
        let S = clamp01 saturation
        let L = clamp01 luminance
        let v = if L <= 0.5 then L * (1.0 + S) else L + S - L * S
        let r,g,b =
            if v > 0.001 then
                let m = L + L - v
                let sv = (v - m) / v
                let h = H * 5.999999 // so sextant never actually becomes 6
                let sextant = int h
                let fract = h - float sextant
                let vsf = v * sv * fract
                let mid1 = m + vsf
                let mid2 = v - vsf
                match sextant with
                    | 0 -> v,   mid1,    m
                    | 1 -> mid2,   v,    m
                    | 2 -> m,      v, mid1
                    | 3 -> m,   mid2,    v
                    | 4 -> mid1,   m,    v
                    | 5 -> v,      m, mid2
                    | x -> failwithf "Fesher.ColorUtil.FromHSL: Error in internal HLS Transform, sextant is %d at Hue=%g, Saturation=%g, Luminance=%g" x H S L
            else
                L,L,L // default to gray value
        (int(round(255.* r)) ,  int(round(255.* g)) , int(round(255.* b)) )

    let random() =
        let h,s,l = randomForRhino()
        fromHSL (h,s,l)

/// This will provide the functions:
/// print, printFull, printWithHighlight, clearFeshLog
[<AutoOpen>] // to have print functions at end of module auto opened
module AutoOpenPrint =

    let private notNull x =
        match x with
        | null -> false
        | _ -> true


    /// Exposes functionality like print and clear of the Fesh Editor, when Fesher is loaded there
    type internal Fesh private () = // no public constructor

        /// Red green blue text
        static let mutable printColor : int-> int -> int -> string -> unit = //changed via reflection below from Fesh
            fun _ _ _ s -> Console.Write s

        /// Red green blue text
        static let mutable printNewLineColor : int-> int -> int -> string -> unit = //changed via reflection below from Fesh
            fun _ _ _ s -> Console.WriteLine s

        static let mutable clear : unit -> unit = // changed via reflection below from Fesh
            fun () -> ()

        static let mutable initIsPending = true

        static let init()=
            initIsPending <- false
            let allAss = AppDomain.CurrentDomain.GetAssemblies()

            let assemblyFesh =  allAss |> Seq.tryFind (fun a -> a.GetName().Name = "Fesh")

            match assemblyFesh with
            | Some feshAssembly ->
                try
                    let printModule = feshAssembly.GetType("Fesh.Model.IFeshLogModule")
                    if notNull printModule then
                        let pc = printModule.GetProperty("printColor" ).GetValue(feshAssembly)
                        if notNull pc then
                            let pct = pc :?>  int-> int -> int -> string -> unit
                            printColor   <- pct
                        let pnc = printModule.GetProperty("printnColor").GetValue(feshAssembly)
                        if notNull pnc then
                            let pct = pnc :?> int-> int -> int -> string -> unit
                            printNewLineColor   <- pct
                        let cl = printModule.GetProperty("clear").GetValue(feshAssembly)
                        if notNull cl then
                            let clt = cl :?> unit -> unit
                            clear   <- clt
                with ex ->
                    eprintfn "The Fesh was found but setting up color printing failed. The Error was: %A" ex

            |None -> ()
                //eprintfn "Failed to get Fesh.Model.IFeshLog.printnColor via Reflection, If you are not using the Fesh F# Editor this message is normal."
                //eprintfn "The print and Printfn functions using color will just print to Console.Out."
                //eprintfn "The ignored Error was: %A" ex

                //eprintfn "Only found:"
                //AppDomain.CurrentDomain.GetAssemblies()
                //|> Seq.map (fun a -> a.GetName().Name )
                //|> Seq.sortBy string
                //|> Seq.iter (eprintfn "%s" )


        static member PrintColor r g b s =
            if initIsPending then init() // to delay reflection calls to latest possible moment
            printColor r g b s

        static member PrintLineColor r g b s =
            if initIsPending then init() // to delay reflection calls to latest possible moment
            printNewLineColor r g b s

        static member Clear () =
            if initIsPending then init() // to delay reflection calls to latest possible moment
            clear()


    /// Highlights every occurrence of the given word in the color of first three integers (red, green, blue)
    /// and the rest of the line in next three integers.
    /// Adds a line return at end.
    let printWithHighlightColor wR wG wB fR fG fB (word:string) (fullLine:string)=
        if String.IsNullOrWhiteSpace word then
            Fesh.PrintLineColor fR fG fB (fullLine)// adds line return
        else
            let rec loop (fromIdx:int) =
                match fullLine.IndexOf(word, fromIdx, StringComparison.Ordinal) with
                | -1 -> Fesh.PrintLineColor fR fG fB (fullLine.Substring(fromIdx))// adds line return
                | i  ->
                    let beforeLen = i - fromIdx
                    if beforeLen > 0 then Fesh.PrintColor fR fG fB (fullLine.Substring(fromIdx,beforeLen))

                    if i + word.Length = fullLine.Length then
                        Fesh.PrintLineColor wR wG wB (fullLine.Substring(i,word.Length)) // adds line return
                    else
                        Fesh.PrintColor wR wG wB (fullLine.Substring(i,word.Length)) // no line return
                        loop (i + word.Length)
            loop 0

    /// Highlights every occurrence of the given Regex in the color of first three integers (red, green, blue)
    /// and the rest of the line in next three integers.
    /// Adds a line return at end.
    let printWithHighlightColorRegex wR wG wB fR fG fB (re:Text.RegularExpressions.Regex) (fullLine:string)=
        if isNull re then
            Fesh.PrintLineColor fR fG fB (fullLine)// adds line return
        else
            let rec loop (fromIdx:int) =
                let m =  re.Match(fullLine, fromIdx)
                if m.Success then
                    let i = m.Index
                    let length = m.Length
                    let beforeLen =  i - fromIdx
                    if beforeLen > 0 then Fesh.PrintColor fR fG fB (fullLine.Substring(fromIdx,beforeLen))

                    if i + length = fullLine.Length then
                        Fesh.PrintLineColor wR wG wB (fullLine.Substring(i,length)) // adds line return
                    else
                        Fesh.PrintColor wR wG wB (fullLine.Substring(i,length)) // no line return
                        loop (i + length)
                else
                    Fesh.PrintLineColor fR fG fB (fullLine.Substring(fromIdx))// adds line return

            loop 0


    /// Tries to printf with colors if running inside Fesh Editor.
    /// Highlights the given word in red in the line to print in gray.
    /// Adds a line return at end.
    let printWithHighlight (word:string) (fullLine:string)=
        printWithHighlightColor 240 0 0 180 180 180 word fullLine


    /// Tries to clears the Fesh Log View, if it can be found via reflection in loaded assemblies.
    /// Else does nothing.
    /// Can be called from any thread.
    let clearFeshLog() = Fesh.Clear()

    [<Obsolete("Renamed to clearFeshLog")>]
    let clearSeffLog() = Fesh.Clear()



/// Tries to printf with colors if running inside Fesh Editor.
/// Else just normal printf
/// Does NOT add a new line at end.
module Printf =

    /// Print with rgb colors if running in Fesh Editor. Else just normal printf
    /// red -> green -> blue -> string -> unit
    let color red green blue msg = Printf.kprintf (fun s -> Fesh.PrintColor red green blue s)  msg


    /// Like printf but in Light Green if used in Fesh Editor. Does not add a new line at end.
    let lightGreen msg = Printf.kprintf (fun s -> Fesh.PrintColor 110 255 110 s)  msg

    /// Like printf but in Green if used in Fesh Editor. Does not add a new line at end.
    let green msg = Printf.kprintf (fun s -> Fesh.PrintColor 0 190 0 s)  msg

    /// Like printf but in Dark Green if used in Fesh Editor. Does not add a new line at end.
    let darkGreen msg = Printf.kprintf (fun s -> Fesh.PrintColor 0 100 0 s)  msg

    /// Like printf but in Light Red if used in Fesh Editor. Does not add a new line at end.
    let lightRed msg = Printf.kprintf (fun s -> Fesh.PrintColor 255 180 190 s)  msg

    /// Like printf but in Red if used in Fesh Editor. Does not add a new line at end.
    let red msg = Printf.kprintf (fun s -> Fesh.PrintColor 220 0 0 s)  msg

    /// Like printf but in Dark Red if used in Fesh Editor. Does not add a new line at end.
    let darkRed msg = Printf.kprintf (fun s -> Fesh.PrintColor 180 0 0 s)  msg

    /// Like printf but in Light Blue if in from Fesh Editor. Does not add a new line at end.
    let lightBlue msg = Printf.kprintf (fun s -> Fesh.PrintColor 170 210 230 s)  msg

    /// Like printf but in Blue if used in Fesh Editor. Does not add a new line at end.
    let blue msg = Printf.kprintf (fun s -> Fesh.PrintColor 0 0 220 s)  msg

    /// Like printf but in Yellow if used in Fesh Editor.  Does not add a new line at end.
    let yellow msg = Printf.kprintf (fun s -> Fesh.PrintColor 235 220 0 s)  msg

    /// Like printf but in Gray if used in Fesh Editor. Does not add a new line at end.
    let lightGray msg = Printf.kprintf (fun s -> Fesh.PrintColor 210 210 210 s)  msg

    /// Like printf but in Gray if used in Fesh Editor. Does not add a new line at end.
    let gray msg = Printf.kprintf (fun s -> Fesh.PrintColor 160 160 160 s)  msg

    /// Like printf but in Dark Gray if used in Fesh Editor. Does not add a new line at end.
    let darkGray msg = Printf.kprintf (fun s -> Fesh.PrintColor 100 100 100 s)  msg

    /// Like printf but in Orchid purple if used in Fesh Editor. Does not add a new line at end.
    let orchid msg = Printf.kprintf (fun s -> Fesh.PrintColor 218 112 214 s)  msg

    /// Like printf but in Purple if used in Fesh Editor. Does not add a new line at end.
    let purple msg = Printf.kprintf (fun s -> Fesh.PrintColor 128 0 128 s)  msg

    /// Like printf but in Orange if used in Fesh Editor. Does not add a new line at end.
    let orange msg = Printf.kprintf (fun s -> Fesh.PrintColor 255 140 0 s)  msg

    /// Like printf but in Cyan if used in Fesh Editor. Does not add a new line at end.
    let cyan msg = Printf.kprintf (fun s -> Fesh.PrintColor 0 150 150 s)  msg

    /// Like printf but in Random Color if used in Fesh Editor. Does not add a new line at end.
    /// Very light, white and yellow colors are excluded
    /// The colors used by subsequent calls to this functions will have very distinct hues.
    /// This is achieved by using a golden-ratio-loop and an internal cache of the last generated color.
    [<Obsolete("renamed to Printf.randomColor")>]
    let colorRnd msg =
        let r,g,b = ColorUtil.random()
        Printf.kprintf (fun s -> Fesh.PrintColor r g b s)  msg

    /// Like printf but in Random Color if used in Fesh Editor. Does not add a new line at end.
    /// Very light, white and yellow colors are excluded
    /// The colors used by subsequent calls to this functions will have very distinct hues.
    /// This is achieved by using a golden-ratio-loop and an internal cache of the last generated color.
    let randomColor msg =
        let r,g,b = ColorUtil.random()
        Printf.kprintf (fun s -> Fesh.PrintColor r g b s)  msg


/// Tries to printfn with colors if running in Fesh Editor.
/// Else just normal printf
/// Adds a new line at end.
module Printfn =

    /// Print with rgb colors if running in Fesh Editor. Else just normal printf
    /// red -> green -> blue -> string -> unit
    let color red green blue msg = Printf.kprintf (fun s -> Fesh.PrintLineColor red green blue s)  msg

    /// Like printfn but in Light Green if used in Fesh Editor. Adds a new line at end.
    let lightGreen msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 110 255 110 s)  msg

    /// Like printfn but in Green if used in Fesh Editor. Adds a new line at end.
    let green msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 190 0 s)  msg

    /// Like printfn but in Dark Green if used in Fesh Editor. Adds a new line at end.
    let darkGreen msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 100 0 s)  msg

    /// Like printfn but in Light Red if used in Fesh Editor. Adds a new line at end.
    let lightRed msg = Printf.kprintf (fun s -> Fesh.PrintLineColor  255 180 190 s)  msg

    /// Like printfn but in Red if used in Fesh Editor. Adds a new line at end.
    let red msg =  Printf.kprintf (fun s -> Fesh.PrintLineColor 220 0 0 s)  msg

    /// Like printfn but in Dark Red if used in Fesh Editor. Adds a new line at end.
    let darkRed msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 180 0 0 s)  msg

    /// Like printfn but in Light Blue if in from Fesh Editor. Adds a new line at end.
    let lightBlue msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 170 210 230 s)  msg

    /// Like printfn but in Blue if used in Fesh Editor. Adds a new line at end.
    let blue msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 0 220 s)  msg

    /// Like printfn but in Yellow if used in Fesh Editor. Adds a new line at end.
    let yellow msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 235 220 0 s)  msg

    /// Like printfn but in Dark Gray if used in Fesh Editor. Adds a new line at end.
    let darkGray msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 100 100 100 s)  msg

    /// Like printfn but in Gray if used in Fesh Editor. Adds a new line at end.
    let gray msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 160 160 160 s)  msg

    /// Like printfn but in Gray if used in Fesh Editor. Adds a new line at end.
    let lightGray msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 210 210 210 s)  msg

    /// Like printfn but in Orchid (light Purple) if used in Fesh Editor. Adds a new line at end.
    let orchid msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 218 112 214  s)  msg

    /// Like printfn but in Purple if used in Fesh Editor. Adds a new line at end.
    let purple msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 128 0 128 s)  msg

    /// Like printfn but in Orange if used in Fesh Editor. Adds a new line at end.
    let orange msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 140 0 s)  msg

    /// Like printfn but in Cyan if used in Fesh Editor. Adds a new line at end.
    let cyan msg = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 150 150 s)  msg

    /// Like printfn but in random Color if used in Fesh Editor. Adds a new line at end.
    /// Very light, white and yellow colors are excluded
    /// The colors used by subsequent calls to this functions will have very distinct hues.
    /// This is achieved by using a golden-ratio-loop and an internal cache of the last generated color.
    [<Obsolete("renamed to Printfn.randomColor")>]
    let colorRnd msg =
        let r,g,b = ColorUtil.random()
        Printf.kprintf (fun s -> Fesh.PrintLineColor r g b s)  msg

    /// Like printfn but in random Color if used in Fesh Editor. Adds a new line at end.
    /// Very light, white and yellow colors are excluded
    /// The colors used by subsequent calls to this functions will have very distinct hues.
    /// This is achieved by using a golden-ratio-loop and an internal cache of the last generated color.
    let randomColor msg =
        let r,g,b = ColorUtil.random()
        Printf.kprintf (fun s -> Fesh.PrintLineColor r g b s)  msg