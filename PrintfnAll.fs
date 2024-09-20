// this file is generated with via 'code gen.fsx'
namespace Fesher


module AllColors =

    /// Tries to printf with colors if running inside Fesh Editor.
    /// Else just normal printf
    /// Does NOT add a new line at end.
    module Printf =

        /// Like printf, but colored AliceBlue (red:240 green:248 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let aliceBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 240 248 255 s) text

        /// Like printf, but colored AntiqueWhite (red:250 green:235 blue:215) if used in Fesh Editor. Does not add a new line at end.
        let antiqueWhite text = Printf.kprintf (fun s -> Fesh.PrintColor 250 235 215 s) text

        /// Like printf, but colored Aqua (red:0 green:255 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let aqua text = Printf.kprintf (fun s -> Fesh.PrintColor 0 255 255 s) text

        /// Like printf, but colored Aquamarine (red:127 green:255 blue:212) if used in Fesh Editor. Does not add a new line at end.
        let aquamarine text = Printf.kprintf (fun s -> Fesh.PrintColor 127 255 212 s) text

        /// Like printf, but colored Azure (red:240 green:255 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let azure text = Printf.kprintf (fun s -> Fesh.PrintColor 240 255 255 s) text

        /// Like printf, but colored Beige (red:245 green:245 blue:220) if used in Fesh Editor. Does not add a new line at end.
        let beige text = Printf.kprintf (fun s -> Fesh.PrintColor 245 245 220 s) text

        /// Like printf, but colored Bisque (red:255 green:228 blue:196) if used in Fesh Editor. Does not add a new line at end.
        let bisque text = Printf.kprintf (fun s -> Fesh.PrintColor 255 228 196 s) text

        /// Like printf, but colored Black (red:0 green:0 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let black text = Printf.kprintf (fun s -> Fesh.PrintColor 0 0 0 s) text

        /// Like printf, but colored BlanchedAlmond (red:255 green:235 blue:205) if used in Fesh Editor. Does not add a new line at end.
        let blanchedAlmond text = Printf.kprintf (fun s -> Fesh.PrintColor 255 235 205 s) text

        /// Like printf, but colored Blue (red:0 green:0 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let blue text = Printf.kprintf (fun s -> Fesh.PrintColor 0 0 255 s) text

        /// Like printf, but colored BlueViolet (red:138 green:43 blue:226) if used in Fesh Editor. Does not add a new line at end.
        let blueViolet text = Printf.kprintf (fun s -> Fesh.PrintColor 138 43 226 s) text

        /// Like printf, but colored Brown (red:165 green:42 blue:42) if used in Fesh Editor. Does not add a new line at end.
        let brown text = Printf.kprintf (fun s -> Fesh.PrintColor 165 42 42 s) text

        /// Like printf, but colored BurlyWood (red:222 green:184 blue:135) if used in Fesh Editor. Does not add a new line at end.
        let burlyWood text = Printf.kprintf (fun s -> Fesh.PrintColor 222 184 135 s) text

        /// Like printf, but colored CadetBlue (red:95 green:158 blue:160) if used in Fesh Editor. Does not add a new line at end.
        let cadetBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 95 158 160 s) text

        /// Like printf, but colored Chartreuse (red:127 green:255 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let chartreuse text = Printf.kprintf (fun s -> Fesh.PrintColor 127 255 0 s) text

        /// Like printf, but colored Chocolate (red:210 green:105 blue:30) if used in Fesh Editor. Does not add a new line at end.
        let chocolate text = Printf.kprintf (fun s -> Fesh.PrintColor 210 105 30 s) text

        /// Like printf, but colored Coral (red:255 green:127 blue:80) if used in Fesh Editor. Does not add a new line at end.
        let coral text = Printf.kprintf (fun s -> Fesh.PrintColor 255 127 80 s) text

        /// Like printf, but colored CornflowerBlue (red:100 green:149 blue:237) if used in Fesh Editor. Does not add a new line at end.
        let cornflowerBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 100 149 237 s) text

        /// Like printf, but colored Cornsilk (red:255 green:248 blue:220) if used in Fesh Editor. Does not add a new line at end.
        let cornsilk text = Printf.kprintf (fun s -> Fesh.PrintColor 255 248 220 s) text

        /// Like printf, but colored Crimson (red:220 green:20 blue:60) if used in Fesh Editor. Does not add a new line at end.
        let crimson text = Printf.kprintf (fun s -> Fesh.PrintColor 220 20 60 s) text

        /// Like printf, but colored Cyan (red:0 green:255 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let cyan text = Printf.kprintf (fun s -> Fesh.PrintColor 0 255 255 s) text

        /// Like printf, but colored DarkBlue (red:0 green:0 blue:139) if used in Fesh Editor. Does not add a new line at end.
        let darkBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 0 0 139 s) text

        /// Like printf, but colored DarkCyan (red:0 green:139 blue:139) if used in Fesh Editor. Does not add a new line at end.
        let darkCyan text = Printf.kprintf (fun s -> Fesh.PrintColor 0 139 139 s) text

        /// Like printf, but colored DarkGoldenrod (red:184 green:134 blue:11) if used in Fesh Editor. Does not add a new line at end.
        let darkGoldenrod text = Printf.kprintf (fun s -> Fesh.PrintColor 184 134 11 s) text

        /// Like printf, but colored DarkGray (red:169 green:169 blue:169) if used in Fesh Editor. Does not add a new line at end.
        let darkGray text = Printf.kprintf (fun s -> Fesh.PrintColor 169 169 169 s) text

        /// Like printf, but colored DarkGreen (red:0 green:100 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let darkGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 0 100 0 s) text

        /// Like printf, but colored DarkKhaki (red:189 green:183 blue:107) if used in Fesh Editor. Does not add a new line at end.
        let darkKhaki text = Printf.kprintf (fun s -> Fesh.PrintColor 189 183 107 s) text

        /// Like printf, but colored DarkMagenta (red:139 green:0 blue:139) if used in Fesh Editor. Does not add a new line at end.
        let darkMagenta text = Printf.kprintf (fun s -> Fesh.PrintColor 139 0 139 s) text

        /// Like printf, but colored DarkOliveGreen (red:85 green:107 blue:47) if used in Fesh Editor. Does not add a new line at end.
        let darkOliveGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 85 107 47 s) text

        /// Like printf, but colored DarkOrange (red:255 green:140 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let darkOrange text = Printf.kprintf (fun s -> Fesh.PrintColor 255 140 0 s) text

        /// Like printf, but colored DarkOrchid (red:153 green:50 blue:204) if used in Fesh Editor. Does not add a new line at end.
        let darkOrchid text = Printf.kprintf (fun s -> Fesh.PrintColor 153 50 204 s) text

        /// Like printf, but colored DarkRed (red:139 green:0 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let darkRed text = Printf.kprintf (fun s -> Fesh.PrintColor 139 0 0 s) text

        /// Like printf, but colored DarkSalmon (red:233 green:150 blue:122) if used in Fesh Editor. Does not add a new line at end.
        let darkSalmon text = Printf.kprintf (fun s -> Fesh.PrintColor 233 150 122 s) text

        /// Like printf, but colored DarkSeaGreen (red:143 green:188 blue:143) if used in Fesh Editor. Does not add a new line at end.
        let darkSeaGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 143 188 143 s) text

        /// Like printf, but colored DarkSlateBlue (red:72 green:61 blue:139) if used in Fesh Editor. Does not add a new line at end.
        let darkSlateBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 72 61 139 s) text

        /// Like printf, but colored DarkSlateGray (red:47 green:79 blue:79) if used in Fesh Editor. Does not add a new line at end.
        let darkSlateGray text = Printf.kprintf (fun s -> Fesh.PrintColor 47 79 79 s) text

        /// Like printf, but colored DarkTurquoise (red:0 green:206 blue:209) if used in Fesh Editor. Does not add a new line at end.
        let darkTurquoise text = Printf.kprintf (fun s -> Fesh.PrintColor 0 206 209 s) text

        /// Like printf, but colored DarkViolet (red:148 green:0 blue:211) if used in Fesh Editor. Does not add a new line at end.
        let darkViolet text = Printf.kprintf (fun s -> Fesh.PrintColor 148 0 211 s) text

        /// Like printf, but colored DeepPink (red:255 green:20 blue:147) if used in Fesh Editor. Does not add a new line at end.
        let deepPink text = Printf.kprintf (fun s -> Fesh.PrintColor 255 20 147 s) text

        /// Like printf, but colored DeepSkyBlue (red:0 green:191 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let deepSkyBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 0 191 255 s) text

        /// Like printf, but colored DimGray (red:105 green:105 blue:105) if used in Fesh Editor. Does not add a new line at end.
        let dimGray text = Printf.kprintf (fun s -> Fesh.PrintColor 105 105 105 s) text

        /// Like printf, but colored DodgerBlue (red:30 green:144 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let dodgerBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 30 144 255 s) text

        /// Like printf, but colored Firebrick (red:178 green:34 blue:34) if used in Fesh Editor. Does not add a new line at end.
        let firebrick text = Printf.kprintf (fun s -> Fesh.PrintColor 178 34 34 s) text

        /// Like printf, but colored FloralWhite (red:255 green:250 blue:240) if used in Fesh Editor. Does not add a new line at end.
        let floralWhite text = Printf.kprintf (fun s -> Fesh.PrintColor 255 250 240 s) text

        /// Like printf, but colored ForestGreen (red:34 green:139 blue:34) if used in Fesh Editor. Does not add a new line at end.
        let forestGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 34 139 34 s) text

        /// Like printf, but colored Fuchsia (red:255 green:0 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let fuchsia text = Printf.kprintf (fun s -> Fesh.PrintColor 255 0 255 s) text

        /// Like printf, but colored Gainsboro (red:220 green:220 blue:220) if used in Fesh Editor. Does not add a new line at end.
        let gainsboro text = Printf.kprintf (fun s -> Fesh.PrintColor 220 220 220 s) text

        /// Like printf, but colored GhostWhite (red:248 green:248 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let ghostWhite text = Printf.kprintf (fun s -> Fesh.PrintColor 248 248 255 s) text

        /// Like printf, but colored Gold (red:255 green:215 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let gold text = Printf.kprintf (fun s -> Fesh.PrintColor 255 215 0 s) text

        /// Like printf, but colored Goldenrod (red:218 green:165 blue:32) if used in Fesh Editor. Does not add a new line at end.
        let goldenrod text = Printf.kprintf (fun s -> Fesh.PrintColor 218 165 32 s) text

        /// Like printf, but colored Gray (red:128 green:128 blue:128) if used in Fesh Editor. Does not add a new line at end.
        let gray text = Printf.kprintf (fun s -> Fesh.PrintColor 128 128 128 s) text

        /// Like printf, but colored Green (red:0 green:128 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let green text = Printf.kprintf (fun s -> Fesh.PrintColor 0 128 0 s) text

        /// Like printf, but colored GreenYellow (red:173 green:255 blue:47) if used in Fesh Editor. Does not add a new line at end.
        let greenYellow text = Printf.kprintf (fun s -> Fesh.PrintColor 173 255 47 s) text

        /// Like printf, but colored Honeydew (red:240 green:255 blue:240) if used in Fesh Editor. Does not add a new line at end.
        let honeydew text = Printf.kprintf (fun s -> Fesh.PrintColor 240 255 240 s) text

        /// Like printf, but colored HotPink (red:255 green:105 blue:180) if used in Fesh Editor. Does not add a new line at end.
        let hotPink text = Printf.kprintf (fun s -> Fesh.PrintColor 255 105 180 s) text

        /// Like printf, but colored IndianRed (red:205 green:92 blue:92) if used in Fesh Editor. Does not add a new line at end.
        let indianRed text = Printf.kprintf (fun s -> Fesh.PrintColor 205 92 92 s) text

        /// Like printf, but colored Indigo (red:75 green:0 blue:130) if used in Fesh Editor. Does not add a new line at end.
        let indigo text = Printf.kprintf (fun s -> Fesh.PrintColor 75 0 130 s) text

        /// Like printf, but colored Ivory (red:255 green:255 blue:240) if used in Fesh Editor. Does not add a new line at end.
        let ivory text = Printf.kprintf (fun s -> Fesh.PrintColor 255 255 240 s) text

        /// Like printf, but colored Khaki (red:240 green:230 blue:140) if used in Fesh Editor. Does not add a new line at end.
        let khaki text = Printf.kprintf (fun s -> Fesh.PrintColor 240 230 140 s) text

        /// Like printf, but colored Lavender (red:230 green:230 blue:250) if used in Fesh Editor. Does not add a new line at end.
        let lavender text = Printf.kprintf (fun s -> Fesh.PrintColor 230 230 250 s) text

        /// Like printf, but colored LavenderBlush (red:255 green:240 blue:245) if used in Fesh Editor. Does not add a new line at end.
        let lavenderBlush text = Printf.kprintf (fun s -> Fesh.PrintColor 255 240 245 s) text

        /// Like printf, but colored LawnGreen (red:124 green:252 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let lawnGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 124 252 0 s) text

        /// Like printf, but colored LemonChiffon (red:255 green:250 blue:205) if used in Fesh Editor. Does not add a new line at end.
        let lemonChiffon text = Printf.kprintf (fun s -> Fesh.PrintColor 255 250 205 s) text

        /// Like printf, but colored LightBlue (red:173 green:216 blue:230) if used in Fesh Editor. Does not add a new line at end.
        let lightBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 173 216 230 s) text

        /// Like printf, but colored LightCoral (red:240 green:128 blue:128) if used in Fesh Editor. Does not add a new line at end.
        let lightCoral text = Printf.kprintf (fun s -> Fesh.PrintColor 240 128 128 s) text

        /// Like printf, but colored LightCyan (red:224 green:255 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let lightCyan text = Printf.kprintf (fun s -> Fesh.PrintColor 224 255 255 s) text

        /// Like printf, but colored LightGoldenrodYellow (red:250 green:250 blue:210) if used in Fesh Editor. Does not add a new line at end.
        let lightGoldenrodYellow text = Printf.kprintf (fun s -> Fesh.PrintColor 250 250 210 s) text

        /// Like printf, but colored LightGray (red:211 green:211 blue:211) if used in Fesh Editor. Does not add a new line at end.
        let lightGray text = Printf.kprintf (fun s -> Fesh.PrintColor 211 211 211 s) text

        /// Like printf, but colored LightGreen (red:144 green:238 blue:144) if used in Fesh Editor. Does not add a new line at end.
        let lightGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 144 238 144 s) text

        /// Like printf, but colored LightPink (red:255 green:182 blue:193) if used in Fesh Editor. Does not add a new line at end.
        let lightPink text = Printf.kprintf (fun s -> Fesh.PrintColor 255 182 193 s) text

        /// Like printf, but colored LightSalmon (red:255 green:160 blue:122) if used in Fesh Editor. Does not add a new line at end.
        let lightSalmon text = Printf.kprintf (fun s -> Fesh.PrintColor 255 160 122 s) text

        /// Like printf, but colored LightSeaGreen (red:32 green:178 blue:170) if used in Fesh Editor. Does not add a new line at end.
        let lightSeaGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 32 178 170 s) text

        /// Like printf, but colored LightSkyBlue (red:135 green:206 blue:250) if used in Fesh Editor. Does not add a new line at end.
        let lightSkyBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 135 206 250 s) text

        /// Like printf, but colored LightSlateGray (red:119 green:136 blue:153) if used in Fesh Editor. Does not add a new line at end.
        let lightSlateGray text = Printf.kprintf (fun s -> Fesh.PrintColor 119 136 153 s) text

        /// Like printf, but colored LightSteelBlue (red:176 green:196 blue:222) if used in Fesh Editor. Does not add a new line at end.
        let lightSteelBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 176 196 222 s) text

        /// Like printf, but colored LightYellow (red:255 green:255 blue:224) if used in Fesh Editor. Does not add a new line at end.
        let lightYellow text = Printf.kprintf (fun s -> Fesh.PrintColor 255 255 224 s) text

        /// Like printf, but colored Lime (red:0 green:255 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let lime text = Printf.kprintf (fun s -> Fesh.PrintColor 0 255 0 s) text

        /// Like printf, but colored LimeGreen (red:50 green:205 blue:50) if used in Fesh Editor. Does not add a new line at end.
        let limeGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 50 205 50 s) text

        /// Like printf, but colored Linen (red:250 green:240 blue:230) if used in Fesh Editor. Does not add a new line at end.
        let linen text = Printf.kprintf (fun s -> Fesh.PrintColor 250 240 230 s) text

        /// Like printf, but colored Magenta (red:255 green:0 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let magenta text = Printf.kprintf (fun s -> Fesh.PrintColor 255 0 255 s) text

        /// Like printf, but colored Maroon (red:128 green:0 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let maroon text = Printf.kprintf (fun s -> Fesh.PrintColor 128 0 0 s) text

        /// Like printf, but colored MediumAquamarine (red:102 green:205 blue:170) if used in Fesh Editor. Does not add a new line at end.
        let mediumAquamarine text = Printf.kprintf (fun s -> Fesh.PrintColor 102 205 170 s) text

        /// Like printf, but colored MediumBlue (red:0 green:0 blue:205) if used in Fesh Editor. Does not add a new line at end.
        let mediumBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 0 0 205 s) text

        /// Like printf, but colored MediumOrchid (red:186 green:85 blue:211) if used in Fesh Editor. Does not add a new line at end.
        let mediumOrchid text = Printf.kprintf (fun s -> Fesh.PrintColor 186 85 211 s) text

        /// Like printf, but colored MediumPurple (red:147 green:112 blue:219) if used in Fesh Editor. Does not add a new line at end.
        let mediumPurple text = Printf.kprintf (fun s -> Fesh.PrintColor 147 112 219 s) text

        /// Like printf, but colored MediumSeaGreen (red:60 green:179 blue:113) if used in Fesh Editor. Does not add a new line at end.
        let mediumSeaGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 60 179 113 s) text

        /// Like printf, but colored MediumSlateBlue (red:123 green:104 blue:238) if used in Fesh Editor. Does not add a new line at end.
        let mediumSlateBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 123 104 238 s) text

        /// Like printf, but colored MediumSpringGreen (red:0 green:250 blue:154) if used in Fesh Editor. Does not add a new line at end.
        let mediumSpringGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 0 250 154 s) text

        /// Like printf, but colored MediumTurquoise (red:72 green:209 blue:204) if used in Fesh Editor. Does not add a new line at end.
        let mediumTurquoise text = Printf.kprintf (fun s -> Fesh.PrintColor 72 209 204 s) text

        /// Like printf, but colored MediumVioletRed (red:199 green:21 blue:133) if used in Fesh Editor. Does not add a new line at end.
        let mediumVioletRed text = Printf.kprintf (fun s -> Fesh.PrintColor 199 21 133 s) text

        /// Like printf, but colored MidnightBlue (red:25 green:25 blue:112) if used in Fesh Editor. Does not add a new line at end.
        let midnightBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 25 25 112 s) text

        /// Like printf, but colored MintCream (red:245 green:255 blue:250) if used in Fesh Editor. Does not add a new line at end.
        let mintCream text = Printf.kprintf (fun s -> Fesh.PrintColor 245 255 250 s) text

        /// Like printf, but colored MistyRose (red:255 green:228 blue:225) if used in Fesh Editor. Does not add a new line at end.
        let mistyRose text = Printf.kprintf (fun s -> Fesh.PrintColor 255 228 225 s) text

        /// Like printf, but colored Moccasin (red:255 green:228 blue:181) if used in Fesh Editor. Does not add a new line at end.
        let moccasin text = Printf.kprintf (fun s -> Fesh.PrintColor 255 228 181 s) text

        /// Like printf, but colored NavajoWhite (red:255 green:222 blue:173) if used in Fesh Editor. Does not add a new line at end.
        let navajoWhite text = Printf.kprintf (fun s -> Fesh.PrintColor 255 222 173 s) text

        /// Like printf, but colored Navy (red:0 green:0 blue:128) if used in Fesh Editor. Does not add a new line at end.
        let navy text = Printf.kprintf (fun s -> Fesh.PrintColor 0 0 128 s) text

        /// Like printf, but colored OldLace (red:253 green:245 blue:230) if used in Fesh Editor. Does not add a new line at end.
        let oldLace text = Printf.kprintf (fun s -> Fesh.PrintColor 253 245 230 s) text

        /// Like printf, but colored Olive (red:128 green:128 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let olive text = Printf.kprintf (fun s -> Fesh.PrintColor 128 128 0 s) text

        /// Like printf, but colored OliveDrab (red:107 green:142 blue:35) if used in Fesh Editor. Does not add a new line at end.
        let oliveDrab text = Printf.kprintf (fun s -> Fesh.PrintColor 107 142 35 s) text

        /// Like printf, but colored Orange (red:255 green:165 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let orange text = Printf.kprintf (fun s -> Fesh.PrintColor 255 165 0 s) text

        /// Like printf, but colored OrangeRed (red:255 green:69 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let orangeRed text = Printf.kprintf (fun s -> Fesh.PrintColor 255 69 0 s) text

        /// Like printf, but colored Orchid (red:218 green:112 blue:214) if used in Fesh Editor. Does not add a new line at end.
        let orchid text = Printf.kprintf (fun s -> Fesh.PrintColor 218 112 214 s) text

        /// Like printf, but colored PaleGoldenrod (red:238 green:232 blue:170) if used in Fesh Editor. Does not add a new line at end.
        let paleGoldenrod text = Printf.kprintf (fun s -> Fesh.PrintColor 238 232 170 s) text

        /// Like printf, but colored PaleGreen (red:152 green:251 blue:152) if used in Fesh Editor. Does not add a new line at end.
        let paleGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 152 251 152 s) text

        /// Like printf, but colored PaleTurquoise (red:175 green:238 blue:238) if used in Fesh Editor. Does not add a new line at end.
        let paleTurquoise text = Printf.kprintf (fun s -> Fesh.PrintColor 175 238 238 s) text

        /// Like printf, but colored PaleVioletRed (red:219 green:112 blue:147) if used in Fesh Editor. Does not add a new line at end.
        let paleVioletRed text = Printf.kprintf (fun s -> Fesh.PrintColor 219 112 147 s) text

        /// Like printf, but colored PapayaWhip (red:255 green:239 blue:213) if used in Fesh Editor. Does not add a new line at end.
        let papayaWhip text = Printf.kprintf (fun s -> Fesh.PrintColor 255 239 213 s) text

        /// Like printf, but colored PeachPuff (red:255 green:218 blue:185) if used in Fesh Editor. Does not add a new line at end.
        let peachPuff text = Printf.kprintf (fun s -> Fesh.PrintColor 255 218 185 s) text

        /// Like printf, but colored Peru (red:205 green:133 blue:63) if used in Fesh Editor. Does not add a new line at end.
        let peru text = Printf.kprintf (fun s -> Fesh.PrintColor 205 133 63 s) text

        /// Like printf, but colored Pink (red:255 green:192 blue:203) if used in Fesh Editor. Does not add a new line at end.
        let pink text = Printf.kprintf (fun s -> Fesh.PrintColor 255 192 203 s) text

        /// Like printf, but colored Plum (red:221 green:160 blue:221) if used in Fesh Editor. Does not add a new line at end.
        let plum text = Printf.kprintf (fun s -> Fesh.PrintColor 221 160 221 s) text

        /// Like printf, but colored PowderBlue (red:176 green:224 blue:230) if used in Fesh Editor. Does not add a new line at end.
        let powderBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 176 224 230 s) text

        /// Like printf, but colored Purple (red:128 green:0 blue:128) if used in Fesh Editor. Does not add a new line at end.
        let purple text = Printf.kprintf (fun s -> Fesh.PrintColor 128 0 128 s) text

        /// Like printf, but colored Red (red:255 green:0 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let red text = Printf.kprintf (fun s -> Fesh.PrintColor 255 0 0 s) text

        /// Like printf, but colored RosyBrown (red:188 green:143 blue:143) if used in Fesh Editor. Does not add a new line at end.
        let rosyBrown text = Printf.kprintf (fun s -> Fesh.PrintColor 188 143 143 s) text

        /// Like printf, but colored RoyalBlue (red:65 green:105 blue:225) if used in Fesh Editor. Does not add a new line at end.
        let royalBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 65 105 225 s) text

        /// Like printf, but colored SaddleBrown (red:139 green:69 blue:19) if used in Fesh Editor. Does not add a new line at end.
        let saddleBrown text = Printf.kprintf (fun s -> Fesh.PrintColor 139 69 19 s) text

        /// Like printf, but colored Salmon (red:250 green:128 blue:114) if used in Fesh Editor. Does not add a new line at end.
        let salmon text = Printf.kprintf (fun s -> Fesh.PrintColor 250 128 114 s) text

        /// Like printf, but colored SandyBrown (red:244 green:164 blue:96) if used in Fesh Editor. Does not add a new line at end.
        let sandyBrown text = Printf.kprintf (fun s -> Fesh.PrintColor 244 164 96 s) text

        /// Like printf, but colored SeaGreen (red:46 green:139 blue:87) if used in Fesh Editor. Does not add a new line at end.
        let seaGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 46 139 87 s) text

        /// Like printf, but colored SeaShell (red:255 green:245 blue:238) if used in Fesh Editor. Does not add a new line at end.
        let seaShell text = Printf.kprintf (fun s -> Fesh.PrintColor 255 245 238 s) text

        /// Like printf, but colored Sienna (red:160 green:82 blue:45) if used in Fesh Editor. Does not add a new line at end.
        let sienna text = Printf.kprintf (fun s -> Fesh.PrintColor 160 82 45 s) text

        /// Like printf, but colored Silver (red:192 green:192 blue:192) if used in Fesh Editor. Does not add a new line at end.
        let silver text = Printf.kprintf (fun s -> Fesh.PrintColor 192 192 192 s) text

        /// Like printf, but colored SkyBlue (red:135 green:206 blue:235) if used in Fesh Editor. Does not add a new line at end.
        let skyBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 135 206 235 s) text

        /// Like printf, but colored SlateBlue (red:106 green:90 blue:205) if used in Fesh Editor. Does not add a new line at end.
        let slateBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 106 90 205 s) text

        /// Like printf, but colored SlateGray (red:112 green:128 blue:144) if used in Fesh Editor. Does not add a new line at end.
        let slateGray text = Printf.kprintf (fun s -> Fesh.PrintColor 112 128 144 s) text

        /// Like printf, but colored Snow (red:255 green:250 blue:250) if used in Fesh Editor. Does not add a new line at end.
        let snow text = Printf.kprintf (fun s -> Fesh.PrintColor 255 250 250 s) text

        /// Like printf, but colored SpringGreen (red:0 green:255 blue:127) if used in Fesh Editor. Does not add a new line at end.
        let springGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 0 255 127 s) text

        /// Like printf, but colored SteelBlue (red:70 green:130 blue:180) if used in Fesh Editor. Does not add a new line at end.
        let steelBlue text = Printf.kprintf (fun s -> Fesh.PrintColor 70 130 180 s) text

        /// Like printf, but colored Tan (red:210 green:180 blue:140) if used in Fesh Editor. Does not add a new line at end.
        let tan text = Printf.kprintf (fun s -> Fesh.PrintColor 210 180 140 s) text

        /// Like printf, but colored Teal (red:0 green:128 blue:128) if used in Fesh Editor. Does not add a new line at end.
        let teal text = Printf.kprintf (fun s -> Fesh.PrintColor 0 128 128 s) text

        /// Like printf, but colored Thistle (red:216 green:191 blue:216) if used in Fesh Editor. Does not add a new line at end.
        let thistle text = Printf.kprintf (fun s -> Fesh.PrintColor 216 191 216 s) text

        /// Like printf, but colored Tomato (red:255 green:99 blue:71) if used in Fesh Editor. Does not add a new line at end.
        let tomato text = Printf.kprintf (fun s -> Fesh.PrintColor 255 99 71 s) text

        /// Like printf, but colored Turquoise (red:64 green:224 blue:208) if used in Fesh Editor. Does not add a new line at end.
        let turquoise text = Printf.kprintf (fun s -> Fesh.PrintColor 64 224 208 s) text

        /// Like printf, but colored Violet (red:238 green:130 blue:238) if used in Fesh Editor. Does not add a new line at end.
        let violet text = Printf.kprintf (fun s -> Fesh.PrintColor 238 130 238 s) text

        /// Like printf, but colored Wheat (red:245 green:222 blue:179) if used in Fesh Editor. Does not add a new line at end.
        let wheat text = Printf.kprintf (fun s -> Fesh.PrintColor 245 222 179 s) text

        /// Like printf, but colored White (red:255 green:255 blue:255) if used in Fesh Editor. Does not add a new line at end.
        let white text = Printf.kprintf (fun s -> Fesh.PrintColor 255 255 255 s) text

        /// Like printf, but colored WhiteSmoke (red:245 green:245 blue:245) if used in Fesh Editor. Does not add a new line at end.
        let whiteSmoke text = Printf.kprintf (fun s -> Fesh.PrintColor 245 245 245 s) text

        /// Like printf, but colored Yellow (red:255 green:255 blue:0) if used in Fesh Editor. Does not add a new line at end.
        let yellow text = Printf.kprintf (fun s -> Fesh.PrintColor 255 255 0 s) text

        /// Like printf, but colored YellowGreen (red:154 green:205 blue:50) if used in Fesh Editor. Does not add a new line at end.
        let yellowGreen text = Printf.kprintf (fun s -> Fesh.PrintColor 154 205 50 s) text


    /// Tries to printfn with colors if running in Fesh Editor.
    /// Else just normal printf
    /// Adds a new line at end.
    module Printfn =

        /// Like printfn, but colored AliceBlue (red:240 green:248 blue:255) if used in Fesh Editor. Adds a new line at end.
        let aliceBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 240 248 255 s) text

        /// Like printfn, but colored AntiqueWhite (red:250 green:235 blue:215) if used in Fesh Editor. Adds a new line at end.
        let antiqueWhite text = Printf.kprintf (fun s -> Fesh.PrintLineColor 250 235 215 s) text

        /// Like printfn, but colored Aqua (red:0 green:255 blue:255) if used in Fesh Editor. Adds a new line at end.
        let aqua text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 255 255 s) text

        /// Like printfn, but colored Aquamarine (red:127 green:255 blue:212) if used in Fesh Editor. Adds a new line at end.
        let aquamarine text = Printf.kprintf (fun s -> Fesh.PrintLineColor 127 255 212 s) text

        /// Like printfn, but colored Azure (red:240 green:255 blue:255) if used in Fesh Editor. Adds a new line at end.
        let azure text = Printf.kprintf (fun s -> Fesh.PrintLineColor 240 255 255 s) text

        /// Like printfn, but colored Beige (red:245 green:245 blue:220) if used in Fesh Editor. Adds a new line at end.
        let beige text = Printf.kprintf (fun s -> Fesh.PrintLineColor 245 245 220 s) text

        /// Like printfn, but colored Bisque (red:255 green:228 blue:196) if used in Fesh Editor. Adds a new line at end.
        let bisque text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 228 196 s) text

        /// Like printfn, but colored Black (red:0 green:0 blue:0) if used in Fesh Editor. Adds a new line at end.
        let black text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 0 0 s) text

        /// Like printfn, but colored BlanchedAlmond (red:255 green:235 blue:205) if used in Fesh Editor. Adds a new line at end.
        let blanchedAlmond text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 235 205 s) text

        /// Like printfn, but colored Blue (red:0 green:0 blue:255) if used in Fesh Editor. Adds a new line at end.
        let blue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 0 255 s) text

        /// Like printfn, but colored BlueViolet (red:138 green:43 blue:226) if used in Fesh Editor. Adds a new line at end.
        let blueViolet text = Printf.kprintf (fun s -> Fesh.PrintLineColor 138 43 226 s) text

        /// Like printfn, but colored Brown (red:165 green:42 blue:42) if used in Fesh Editor. Adds a new line at end.
        let brown text = Printf.kprintf (fun s -> Fesh.PrintLineColor 165 42 42 s) text

        /// Like printfn, but colored BurlyWood (red:222 green:184 blue:135) if used in Fesh Editor. Adds a new line at end.
        let burlyWood text = Printf.kprintf (fun s -> Fesh.PrintLineColor 222 184 135 s) text

        /// Like printfn, but colored CadetBlue (red:95 green:158 blue:160) if used in Fesh Editor. Adds a new line at end.
        let cadetBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 95 158 160 s) text

        /// Like printfn, but colored Chartreuse (red:127 green:255 blue:0) if used in Fesh Editor. Adds a new line at end.
        let chartreuse text = Printf.kprintf (fun s -> Fesh.PrintLineColor 127 255 0 s) text

        /// Like printfn, but colored Chocolate (red:210 green:105 blue:30) if used in Fesh Editor. Adds a new line at end.
        let chocolate text = Printf.kprintf (fun s -> Fesh.PrintLineColor 210 105 30 s) text

        /// Like printfn, but colored Coral (red:255 green:127 blue:80) if used in Fesh Editor. Adds a new line at end.
        let coral text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 127 80 s) text

        /// Like printfn, but colored CornflowerBlue (red:100 green:149 blue:237) if used in Fesh Editor. Adds a new line at end.
        let cornflowerBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 100 149 237 s) text

        /// Like printfn, but colored Cornsilk (red:255 green:248 blue:220) if used in Fesh Editor. Adds a new line at end.
        let cornsilk text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 248 220 s) text

        /// Like printfn, but colored Crimson (red:220 green:20 blue:60) if used in Fesh Editor. Adds a new line at end.
        let crimson text = Printf.kprintf (fun s -> Fesh.PrintLineColor 220 20 60 s) text

        /// Like printfn, but colored Cyan (red:0 green:255 blue:255) if used in Fesh Editor. Adds a new line at end.
        let cyan text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 255 255 s) text

        /// Like printfn, but colored DarkBlue (red:0 green:0 blue:139) if used in Fesh Editor. Adds a new line at end.
        let darkBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 0 139 s) text

        /// Like printfn, but colored DarkCyan (red:0 green:139 blue:139) if used in Fesh Editor. Adds a new line at end.
        let darkCyan text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 139 139 s) text

        /// Like printfn, but colored DarkGoldenrod (red:184 green:134 blue:11) if used in Fesh Editor. Adds a new line at end.
        let darkGoldenrod text = Printf.kprintf (fun s -> Fesh.PrintLineColor 184 134 11 s) text

        /// Like printfn, but colored DarkGray (red:169 green:169 blue:169) if used in Fesh Editor. Adds a new line at end.
        let darkGray text = Printf.kprintf (fun s -> Fesh.PrintLineColor 169 169 169 s) text

        /// Like printfn, but colored DarkGreen (red:0 green:100 blue:0) if used in Fesh Editor. Adds a new line at end.
        let darkGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 100 0 s) text

        /// Like printfn, but colored DarkKhaki (red:189 green:183 blue:107) if used in Fesh Editor. Adds a new line at end.
        let darkKhaki text = Printf.kprintf (fun s -> Fesh.PrintLineColor 189 183 107 s) text

        /// Like printfn, but colored DarkMagenta (red:139 green:0 blue:139) if used in Fesh Editor. Adds a new line at end.
        let darkMagenta text = Printf.kprintf (fun s -> Fesh.PrintLineColor 139 0 139 s) text

        /// Like printfn, but colored DarkOliveGreen (red:85 green:107 blue:47) if used in Fesh Editor. Adds a new line at end.
        let darkOliveGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 85 107 47 s) text

        /// Like printfn, but colored DarkOrange (red:255 green:140 blue:0) if used in Fesh Editor. Adds a new line at end.
        let darkOrange text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 140 0 s) text

        /// Like printfn, but colored DarkOrchid (red:153 green:50 blue:204) if used in Fesh Editor. Adds a new line at end.
        let darkOrchid text = Printf.kprintf (fun s -> Fesh.PrintLineColor 153 50 204 s) text

        /// Like printfn, but colored DarkRed (red:139 green:0 blue:0) if used in Fesh Editor. Adds a new line at end.
        let darkRed text = Printf.kprintf (fun s -> Fesh.PrintLineColor 139 0 0 s) text

        /// Like printfn, but colored DarkSalmon (red:233 green:150 blue:122) if used in Fesh Editor. Adds a new line at end.
        let darkSalmon text = Printf.kprintf (fun s -> Fesh.PrintLineColor 233 150 122 s) text

        /// Like printfn, but colored DarkSeaGreen (red:143 green:188 blue:143) if used in Fesh Editor. Adds a new line at end.
        let darkSeaGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 143 188 143 s) text

        /// Like printfn, but colored DarkSlateBlue (red:72 green:61 blue:139) if used in Fesh Editor. Adds a new line at end.
        let darkSlateBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 72 61 139 s) text

        /// Like printfn, but colored DarkSlateGray (red:47 green:79 blue:79) if used in Fesh Editor. Adds a new line at end.
        let darkSlateGray text = Printf.kprintf (fun s -> Fesh.PrintLineColor 47 79 79 s) text

        /// Like printfn, but colored DarkTurquoise (red:0 green:206 blue:209) if used in Fesh Editor. Adds a new line at end.
        let darkTurquoise text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 206 209 s) text

        /// Like printfn, but colored DarkViolet (red:148 green:0 blue:211) if used in Fesh Editor. Adds a new line at end.
        let darkViolet text = Printf.kprintf (fun s -> Fesh.PrintLineColor 148 0 211 s) text

        /// Like printfn, but colored DeepPink (red:255 green:20 blue:147) if used in Fesh Editor. Adds a new line at end.
        let deepPink text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 20 147 s) text

        /// Like printfn, but colored DeepSkyBlue (red:0 green:191 blue:255) if used in Fesh Editor. Adds a new line at end.
        let deepSkyBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 191 255 s) text

        /// Like printfn, but colored DimGray (red:105 green:105 blue:105) if used in Fesh Editor. Adds a new line at end.
        let dimGray text = Printf.kprintf (fun s -> Fesh.PrintLineColor 105 105 105 s) text

        /// Like printfn, but colored DodgerBlue (red:30 green:144 blue:255) if used in Fesh Editor. Adds a new line at end.
        let dodgerBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 30 144 255 s) text

        /// Like printfn, but colored Firebrick (red:178 green:34 blue:34) if used in Fesh Editor. Adds a new line at end.
        let firebrick text = Printf.kprintf (fun s -> Fesh.PrintLineColor 178 34 34 s) text

        /// Like printfn, but colored FloralWhite (red:255 green:250 blue:240) if used in Fesh Editor. Adds a new line at end.
        let floralWhite text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 250 240 s) text

        /// Like printfn, but colored ForestGreen (red:34 green:139 blue:34) if used in Fesh Editor. Adds a new line at end.
        let forestGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 34 139 34 s) text

        /// Like printfn, but colored Fuchsia (red:255 green:0 blue:255) if used in Fesh Editor. Adds a new line at end.
        let fuchsia text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 0 255 s) text

        /// Like printfn, but colored Gainsboro (red:220 green:220 blue:220) if used in Fesh Editor. Adds a new line at end.
        let gainsboro text = Printf.kprintf (fun s -> Fesh.PrintLineColor 220 220 220 s) text

        /// Like printfn, but colored GhostWhite (red:248 green:248 blue:255) if used in Fesh Editor. Adds a new line at end.
        let ghostWhite text = Printf.kprintf (fun s -> Fesh.PrintLineColor 248 248 255 s) text

        /// Like printfn, but colored Gold (red:255 green:215 blue:0) if used in Fesh Editor. Adds a new line at end.
        let gold text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 215 0 s) text

        /// Like printfn, but colored Goldenrod (red:218 green:165 blue:32) if used in Fesh Editor. Adds a new line at end.
        let goldenrod text = Printf.kprintf (fun s -> Fesh.PrintLineColor 218 165 32 s) text

        /// Like printfn, but colored Gray (red:128 green:128 blue:128) if used in Fesh Editor. Adds a new line at end.
        let gray text = Printf.kprintf (fun s -> Fesh.PrintLineColor 128 128 128 s) text

        /// Like printfn, but colored Green (red:0 green:128 blue:0) if used in Fesh Editor. Adds a new line at end.
        let green text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 128 0 s) text

        /// Like printfn, but colored GreenYellow (red:173 green:255 blue:47) if used in Fesh Editor. Adds a new line at end.
        let greenYellow text = Printf.kprintf (fun s -> Fesh.PrintLineColor 173 255 47 s) text

        /// Like printfn, but colored Honeydew (red:240 green:255 blue:240) if used in Fesh Editor. Adds a new line at end.
        let honeydew text = Printf.kprintf (fun s -> Fesh.PrintLineColor 240 255 240 s) text

        /// Like printfn, but colored HotPink (red:255 green:105 blue:180) if used in Fesh Editor. Adds a new line at end.
        let hotPink text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 105 180 s) text

        /// Like printfn, but colored IndianRed (red:205 green:92 blue:92) if used in Fesh Editor. Adds a new line at end.
        let indianRed text = Printf.kprintf (fun s -> Fesh.PrintLineColor 205 92 92 s) text

        /// Like printfn, but colored Indigo (red:75 green:0 blue:130) if used in Fesh Editor. Adds a new line at end.
        let indigo text = Printf.kprintf (fun s -> Fesh.PrintLineColor 75 0 130 s) text

        /// Like printfn, but colored Ivory (red:255 green:255 blue:240) if used in Fesh Editor. Adds a new line at end.
        let ivory text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 255 240 s) text

        /// Like printfn, but colored Khaki (red:240 green:230 blue:140) if used in Fesh Editor. Adds a new line at end.
        let khaki text = Printf.kprintf (fun s -> Fesh.PrintLineColor 240 230 140 s) text

        /// Like printfn, but colored Lavender (red:230 green:230 blue:250) if used in Fesh Editor. Adds a new line at end.
        let lavender text = Printf.kprintf (fun s -> Fesh.PrintLineColor 230 230 250 s) text

        /// Like printfn, but colored LavenderBlush (red:255 green:240 blue:245) if used in Fesh Editor. Adds a new line at end.
        let lavenderBlush text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 240 245 s) text

        /// Like printfn, but colored LawnGreen (red:124 green:252 blue:0) if used in Fesh Editor. Adds a new line at end.
        let lawnGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 124 252 0 s) text

        /// Like printfn, but colored LemonChiffon (red:255 green:250 blue:205) if used in Fesh Editor. Adds a new line at end.
        let lemonChiffon text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 250 205 s) text

        /// Like printfn, but colored LightBlue (red:173 green:216 blue:230) if used in Fesh Editor. Adds a new line at end.
        let lightBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 173 216 230 s) text

        /// Like printfn, but colored LightCoral (red:240 green:128 blue:128) if used in Fesh Editor. Adds a new line at end.
        let lightCoral text = Printf.kprintf (fun s -> Fesh.PrintLineColor 240 128 128 s) text

        /// Like printfn, but colored LightCyan (red:224 green:255 blue:255) if used in Fesh Editor. Adds a new line at end.
        let lightCyan text = Printf.kprintf (fun s -> Fesh.PrintLineColor 224 255 255 s) text

        /// Like printfn, but colored LightGoldenrodYellow (red:250 green:250 blue:210) if used in Fesh Editor. Adds a new line at end.
        let lightGoldenrodYellow text = Printf.kprintf (fun s -> Fesh.PrintLineColor 250 250 210 s) text

        /// Like printfn, but colored LightGray (red:211 green:211 blue:211) if used in Fesh Editor. Adds a new line at end.
        let lightGray text = Printf.kprintf (fun s -> Fesh.PrintLineColor 211 211 211 s) text

        /// Like printfn, but colored LightGreen (red:144 green:238 blue:144) if used in Fesh Editor. Adds a new line at end.
        let lightGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 144 238 144 s) text

        /// Like printfn, but colored LightPink (red:255 green:182 blue:193) if used in Fesh Editor. Adds a new line at end.
        let lightPink text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 182 193 s) text

        /// Like printfn, but colored LightSalmon (red:255 green:160 blue:122) if used in Fesh Editor. Adds a new line at end.
        let lightSalmon text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 160 122 s) text

        /// Like printfn, but colored LightSeaGreen (red:32 green:178 blue:170) if used in Fesh Editor. Adds a new line at end.
        let lightSeaGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 32 178 170 s) text

        /// Like printfn, but colored LightSkyBlue (red:135 green:206 blue:250) if used in Fesh Editor. Adds a new line at end.
        let lightSkyBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 135 206 250 s) text

        /// Like printfn, but colored LightSlateGray (red:119 green:136 blue:153) if used in Fesh Editor. Adds a new line at end.
        let lightSlateGray text = Printf.kprintf (fun s -> Fesh.PrintLineColor 119 136 153 s) text

        /// Like printfn, but colored LightSteelBlue (red:176 green:196 blue:222) if used in Fesh Editor. Adds a new line at end.
        let lightSteelBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 176 196 222 s) text

        /// Like printfn, but colored LightYellow (red:255 green:255 blue:224) if used in Fesh Editor. Adds a new line at end.
        let lightYellow text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 255 224 s) text

        /// Like printfn, but colored Lime (red:0 green:255 blue:0) if used in Fesh Editor. Adds a new line at end.
        let lime text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 255 0 s) text

        /// Like printfn, but colored LimeGreen (red:50 green:205 blue:50) if used in Fesh Editor. Adds a new line at end.
        let limeGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 50 205 50 s) text

        /// Like printfn, but colored Linen (red:250 green:240 blue:230) if used in Fesh Editor. Adds a new line at end.
        let linen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 250 240 230 s) text

        /// Like printfn, but colored Magenta (red:255 green:0 blue:255) if used in Fesh Editor. Adds a new line at end.
        let magenta text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 0 255 s) text

        /// Like printfn, but colored Maroon (red:128 green:0 blue:0) if used in Fesh Editor. Adds a new line at end.
        let maroon text = Printf.kprintf (fun s -> Fesh.PrintLineColor 128 0 0 s) text

        /// Like printfn, but colored MediumAquamarine (red:102 green:205 blue:170) if used in Fesh Editor. Adds a new line at end.
        let mediumAquamarine text = Printf.kprintf (fun s -> Fesh.PrintLineColor 102 205 170 s) text

        /// Like printfn, but colored MediumBlue (red:0 green:0 blue:205) if used in Fesh Editor. Adds a new line at end.
        let mediumBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 0 205 s) text

        /// Like printfn, but colored MediumOrchid (red:186 green:85 blue:211) if used in Fesh Editor. Adds a new line at end.
        let mediumOrchid text = Printf.kprintf (fun s -> Fesh.PrintLineColor 186 85 211 s) text

        /// Like printfn, but colored MediumPurple (red:147 green:112 blue:219) if used in Fesh Editor. Adds a new line at end.
        let mediumPurple text = Printf.kprintf (fun s -> Fesh.PrintLineColor 147 112 219 s) text

        /// Like printfn, but colored MediumSeaGreen (red:60 green:179 blue:113) if used in Fesh Editor. Adds a new line at end.
        let mediumSeaGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 60 179 113 s) text

        /// Like printfn, but colored MediumSlateBlue (red:123 green:104 blue:238) if used in Fesh Editor. Adds a new line at end.
        let mediumSlateBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 123 104 238 s) text

        /// Like printfn, but colored MediumSpringGreen (red:0 green:250 blue:154) if used in Fesh Editor. Adds a new line at end.
        let mediumSpringGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 250 154 s) text

        /// Like printfn, but colored MediumTurquoise (red:72 green:209 blue:204) if used in Fesh Editor. Adds a new line at end.
        let mediumTurquoise text = Printf.kprintf (fun s -> Fesh.PrintLineColor 72 209 204 s) text

        /// Like printfn, but colored MediumVioletRed (red:199 green:21 blue:133) if used in Fesh Editor. Adds a new line at end.
        let mediumVioletRed text = Printf.kprintf (fun s -> Fesh.PrintLineColor 199 21 133 s) text

        /// Like printfn, but colored MidnightBlue (red:25 green:25 blue:112) if used in Fesh Editor. Adds a new line at end.
        let midnightBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 25 25 112 s) text

        /// Like printfn, but colored MintCream (red:245 green:255 blue:250) if used in Fesh Editor. Adds a new line at end.
        let mintCream text = Printf.kprintf (fun s -> Fesh.PrintLineColor 245 255 250 s) text

        /// Like printfn, but colored MistyRose (red:255 green:228 blue:225) if used in Fesh Editor. Adds a new line at end.
        let mistyRose text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 228 225 s) text

        /// Like printfn, but colored Moccasin (red:255 green:228 blue:181) if used in Fesh Editor. Adds a new line at end.
        let moccasin text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 228 181 s) text

        /// Like printfn, but colored NavajoWhite (red:255 green:222 blue:173) if used in Fesh Editor. Adds a new line at end.
        let navajoWhite text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 222 173 s) text

        /// Like printfn, but colored Navy (red:0 green:0 blue:128) if used in Fesh Editor. Adds a new line at end.
        let navy text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 0 128 s) text

        /// Like printfn, but colored OldLace (red:253 green:245 blue:230) if used in Fesh Editor. Adds a new line at end.
        let oldLace text = Printf.kprintf (fun s -> Fesh.PrintLineColor 253 245 230 s) text

        /// Like printfn, but colored Olive (red:128 green:128 blue:0) if used in Fesh Editor. Adds a new line at end.
        let olive text = Printf.kprintf (fun s -> Fesh.PrintLineColor 128 128 0 s) text

        /// Like printfn, but colored OliveDrab (red:107 green:142 blue:35) if used in Fesh Editor. Adds a new line at end.
        let oliveDrab text = Printf.kprintf (fun s -> Fesh.PrintLineColor 107 142 35 s) text

        /// Like printfn, but colored Orange (red:255 green:165 blue:0) if used in Fesh Editor. Adds a new line at end.
        let orange text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 165 0 s) text

        /// Like printfn, but colored OrangeRed (red:255 green:69 blue:0) if used in Fesh Editor. Adds a new line at end.
        let orangeRed text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 69 0 s) text

        /// Like printfn, but colored Orchid (red:218 green:112 blue:214) if used in Fesh Editor. Adds a new line at end.
        let orchid text = Printf.kprintf (fun s -> Fesh.PrintLineColor 218 112 214 s) text

        /// Like printfn, but colored PaleGoldenrod (red:238 green:232 blue:170) if used in Fesh Editor. Adds a new line at end.
        let paleGoldenrod text = Printf.kprintf (fun s -> Fesh.PrintLineColor 238 232 170 s) text

        /// Like printfn, but colored PaleGreen (red:152 green:251 blue:152) if used in Fesh Editor. Adds a new line at end.
        let paleGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 152 251 152 s) text

        /// Like printfn, but colored PaleTurquoise (red:175 green:238 blue:238) if used in Fesh Editor. Adds a new line at end.
        let paleTurquoise text = Printf.kprintf (fun s -> Fesh.PrintLineColor 175 238 238 s) text

        /// Like printfn, but colored PaleVioletRed (red:219 green:112 blue:147) if used in Fesh Editor. Adds a new line at end.
        let paleVioletRed text = Printf.kprintf (fun s -> Fesh.PrintLineColor 219 112 147 s) text

        /// Like printfn, but colored PapayaWhip (red:255 green:239 blue:213) if used in Fesh Editor. Adds a new line at end.
        let papayaWhip text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 239 213 s) text

        /// Like printfn, but colored PeachPuff (red:255 green:218 blue:185) if used in Fesh Editor. Adds a new line at end.
        let peachPuff text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 218 185 s) text

        /// Like printfn, but colored Peru (red:205 green:133 blue:63) if used in Fesh Editor. Adds a new line at end.
        let peru text = Printf.kprintf (fun s -> Fesh.PrintLineColor 205 133 63 s) text

        /// Like printfn, but colored Pink (red:255 green:192 blue:203) if used in Fesh Editor. Adds a new line at end.
        let pink text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 192 203 s) text

        /// Like printfn, but colored Plum (red:221 green:160 blue:221) if used in Fesh Editor. Adds a new line at end.
        let plum text = Printf.kprintf (fun s -> Fesh.PrintLineColor 221 160 221 s) text

        /// Like printfn, but colored PowderBlue (red:176 green:224 blue:230) if used in Fesh Editor. Adds a new line at end.
        let powderBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 176 224 230 s) text

        /// Like printfn, but colored Purple (red:128 green:0 blue:128) if used in Fesh Editor. Adds a new line at end.
        let purple text = Printf.kprintf (fun s -> Fesh.PrintLineColor 128 0 128 s) text

        /// Like printfn, but colored Red (red:255 green:0 blue:0) if used in Fesh Editor. Adds a new line at end.
        let red text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 0 0 s) text

        /// Like printfn, but colored RosyBrown (red:188 green:143 blue:143) if used in Fesh Editor. Adds a new line at end.
        let rosyBrown text = Printf.kprintf (fun s -> Fesh.PrintLineColor 188 143 143 s) text

        /// Like printfn, but colored RoyalBlue (red:65 green:105 blue:225) if used in Fesh Editor. Adds a new line at end.
        let royalBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 65 105 225 s) text

        /// Like printfn, but colored SaddleBrown (red:139 green:69 blue:19) if used in Fesh Editor. Adds a new line at end.
        let saddleBrown text = Printf.kprintf (fun s -> Fesh.PrintLineColor 139 69 19 s) text

        /// Like printfn, but colored Salmon (red:250 green:128 blue:114) if used in Fesh Editor. Adds a new line at end.
        let salmon text = Printf.kprintf (fun s -> Fesh.PrintLineColor 250 128 114 s) text

        /// Like printfn, but colored SandyBrown (red:244 green:164 blue:96) if used in Fesh Editor. Adds a new line at end.
        let sandyBrown text = Printf.kprintf (fun s -> Fesh.PrintLineColor 244 164 96 s) text

        /// Like printfn, but colored SeaGreen (red:46 green:139 blue:87) if used in Fesh Editor. Adds a new line at end.
        let seaGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 46 139 87 s) text

        /// Like printfn, but colored SeaShell (red:255 green:245 blue:238) if used in Fesh Editor. Adds a new line at end.
        let seaShell text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 245 238 s) text

        /// Like printfn, but colored Sienna (red:160 green:82 blue:45) if used in Fesh Editor. Adds a new line at end.
        let sienna text = Printf.kprintf (fun s -> Fesh.PrintLineColor 160 82 45 s) text

        /// Like printfn, but colored Silver (red:192 green:192 blue:192) if used in Fesh Editor. Adds a new line at end.
        let silver text = Printf.kprintf (fun s -> Fesh.PrintLineColor 192 192 192 s) text

        /// Like printfn, but colored SkyBlue (red:135 green:206 blue:235) if used in Fesh Editor. Adds a new line at end.
        let skyBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 135 206 235 s) text

        /// Like printfn, but colored SlateBlue (red:106 green:90 blue:205) if used in Fesh Editor. Adds a new line at end.
        let slateBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 106 90 205 s) text

        /// Like printfn, but colored SlateGray (red:112 green:128 blue:144) if used in Fesh Editor. Adds a new line at end.
        let slateGray text = Printf.kprintf (fun s -> Fesh.PrintLineColor 112 128 144 s) text

        /// Like printfn, but colored Snow (red:255 green:250 blue:250) if used in Fesh Editor. Adds a new line at end.
        let snow text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 250 250 s) text

        /// Like printfn, but colored SpringGreen (red:0 green:255 blue:127) if used in Fesh Editor. Adds a new line at end.
        let springGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 255 127 s) text

        /// Like printfn, but colored SteelBlue (red:70 green:130 blue:180) if used in Fesh Editor. Adds a new line at end.
        let steelBlue text = Printf.kprintf (fun s -> Fesh.PrintLineColor 70 130 180 s) text

        /// Like printfn, but colored Tan (red:210 green:180 blue:140) if used in Fesh Editor. Adds a new line at end.
        let tan text = Printf.kprintf (fun s -> Fesh.PrintLineColor 210 180 140 s) text

        /// Like printfn, but colored Teal (red:0 green:128 blue:128) if used in Fesh Editor. Adds a new line at end.
        let teal text = Printf.kprintf (fun s -> Fesh.PrintLineColor 0 128 128 s) text

        /// Like printfn, but colored Thistle (red:216 green:191 blue:216) if used in Fesh Editor. Adds a new line at end.
        let thistle text = Printf.kprintf (fun s -> Fesh.PrintLineColor 216 191 216 s) text

        /// Like printfn, but colored Tomato (red:255 green:99 blue:71) if used in Fesh Editor. Adds a new line at end.
        let tomato text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 99 71 s) text

        /// Like printfn, but colored Turquoise (red:64 green:224 blue:208) if used in Fesh Editor. Adds a new line at end.
        let turquoise text = Printf.kprintf (fun s -> Fesh.PrintLineColor 64 224 208 s) text

        /// Like printfn, but colored Violet (red:238 green:130 blue:238) if used in Fesh Editor. Adds a new line at end.
        let violet text = Printf.kprintf (fun s -> Fesh.PrintLineColor 238 130 238 s) text

        /// Like printfn, but colored Wheat (red:245 green:222 blue:179) if used in Fesh Editor. Adds a new line at end.
        let wheat text = Printf.kprintf (fun s -> Fesh.PrintLineColor 245 222 179 s) text

        /// Like printfn, but colored White (red:255 green:255 blue:255) if used in Fesh Editor. Adds a new line at end.
        let white text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 255 255 s) text

        /// Like printfn, but colored WhiteSmoke (red:245 green:245 blue:245) if used in Fesh Editor. Adds a new line at end.
        let whiteSmoke text = Printf.kprintf (fun s -> Fesh.PrintLineColor 245 245 245 s) text

        /// Like printfn, but colored Yellow (red:255 green:255 blue:0) if used in Fesh Editor. Adds a new line at end.
        let yellow text = Printf.kprintf (fun s -> Fesh.PrintLineColor 255 255 0 s) text

        /// Like printfn, but colored YellowGreen (red:154 green:205 blue:50) if used in Fesh Editor. Adds a new line at end.
        let yellowGreen text = Printf.kprintf (fun s -> Fesh.PrintLineColor 154 205 50 s) text
