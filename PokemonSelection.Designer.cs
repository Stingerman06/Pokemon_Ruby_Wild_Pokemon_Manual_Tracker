namespace Basic_Tracker
{
    partial class PokemonSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Pokemon that appears\r\nhere from the following list.";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "???",
            "001 - Bulbasaur",
            "002 - Ivysaur",
            "003 - Venusaur",
            "004 - Charmander",
            "005 - Charmeleon",
            "006 - Charizard",
            "007 - Squirtle",
            "008 - Wartortle",
            "009 - Blastoise",
            "010 - Caterpie",
            "011 - Metapod",
            "012 - Butterfree",
            "013 - Weedle",
            "014 - Kakuna",
            "015 - Beedrill",
            "016 - Pidgey",
            "017 - Pidgeotto",
            "018 - Pidgeot",
            "019 - Rattata",
            "020 - Raticate",
            "021 - Spearow",
            "022 - Fearow",
            "023 - Ekans",
            "024 - Arbok",
            "025 - Pikachu",
            "026 - Raichu",
            "027 - Sandshrew",
            "028 - Sandslash",
            "029 - Nidoran(F)",
            "030 - Nidorina",
            "031 - Nidoqueen",
            "032 - Nidoran(M)",
            "033 - Nidorino",
            "034 - Nidoking",
            "035 - Clefairy",
            "036 - Clefable",
            "037 - Vulpix",
            "038 - Ninetails",
            "039 - Jigglypuff",
            "040 - Wigglytuff",
            "041 - Zubat",
            "042 - Golbat",
            "043 - Oddish",
            "044 - Gloom",
            "045 - Vileplume",
            "046 - Paras",
            "047 - Parasect",
            "048 - Venonat",
            "049 - Venomoth",
            "050 - Diglett",
            "051 - Dugtrio",
            "052 - Meowth",
            "053 - Persian",
            "054 - Psyduck",
            "055 - Golduck",
            "056 - Mankey",
            "057 - Primeape",
            "058 - Gowlithe",
            "059 - Arcanine",
            "060 - Poliwag",
            "061 - Poliwhirl",
            "062 - Poliwrath",
            "063 - Abra",
            "064 - Kadabra",
            "065 - Alakazam",
            "066 - Machop",
            "067 - Machoke",
            "068 - Machamp",
            "069 - Bellsprout",
            "070 - Weepinbell",
            "071 - Victribel",
            "072 - Tentacool",
            "073 - Tentacruel",
            "074 - Geodude",
            "075 - Graveler",
            "076 - Golem",
            "077 - Ponyta",
            "078 - Rapidash",
            "079 - Slowpoke",
            "080 - Slowbro",
            "081 - Magnemite",
            "082 - Magneton",
            "083 - Farfetch\'d",
            "084 - Doduo",
            "085 - Dodrio",
            "086 - Seel",
            "087 - Dewgong",
            "088 - Grimer",
            "089 - Muk",
            "090 - Shellder",
            "091 - Cloyster",
            "092 - Gastly",
            "093 - Haunter",
            "094 - Gengar",
            "095 - Onix",
            "096 - Drowzee",
            "097 - Hypno",
            "098 - Krabby",
            "099 - Kingler",
            "100 - Voltorb",
            "101 - Electrode",
            "102 - Exeggcute",
            "103 - Exeggutor",
            "104 - Cubone",
            "105 - Marowak",
            "106 - Hitmonlee",
            "107 - Hitmonchan",
            "108 - Lickitung",
            "109 - Koffing",
            "110 - Wheezing",
            "111 - Rhyhorn",
            "112 - Rhydon",
            "113 - Chansey",
            "114 - Tangela",
            "115 - Kangaskhan",
            "116 - Horsea",
            "117 - Seadra",
            "118 - Goldeen",
            "119 - Seaking",
            "120 - Staryu",
            "121 - Starmie",
            "122 - Mr. Mime",
            "123 - Scyther",
            "124 - Jynx",
            "125 - Electabuzz",
            "126 - Magmar",
            "127 - Pinsir",
            "128 - Tauros",
            "129 - Magikarp",
            "130 - Gyarados",
            "131 - Lapras",
            "132 - Ditto",
            "133 - Eevee",
            "134 - Vaporeon",
            "135 - Jolteon",
            "136 - Flareon",
            "137 - Porygon",
            "138 - Omanyte",
            "139 - Omastar",
            "140 - Kabuto",
            "141 - Kabutops",
            "142 - Aerodactyl",
            "143 - Snorlax",
            "144 - Articuno",
            "145 - Zapdos",
            "146 - Moltres",
            "147 - Dratini",
            "148 - Dragonair",
            "149 - Dragonite",
            "150 - Mewtwo",
            "151 - Mew",
            "152 - Chikorita",
            "153 - Bayleef",
            "154 - Meganium",
            "155 - Cyndaquil",
            "156 - Quilava",
            "157 - Typhlosion",
            "158 - Totodile",
            "159 - Croconaw",
            "160 - Feraligatr",
            "161 - Sentret",
            "162 - Furret",
            "163 - Hoothoot",
            "164 - Noctowl",
            "165 - Ledyba",
            "166 - Ledian",
            "167 - Spinarak",
            "168 - Ariados",
            "169 - Crobat",
            "170 - Chinchou",
            "171 - Lanturn",
            "172 - Pichu",
            "173 - Cleffa",
            "174 - Igglybuff",
            "175 - Togepi",
            "176 - Togetic",
            "177 - Natu",
            "178 - Xatu",
            "179 - Mareep",
            "180 - Flaafy",
            "181 - Ampharos",
            "182 - Bellossom",
            "183 - Marill",
            "184 - Azumarill",
            "185 - Sudowoodo",
            "186 - Politoed",
            "187 - Hoppip",
            "188 - Skiploom",
            "189 - Jumpluff",
            "190 - Aipom",
            "191 - Sunkern",
            "192 - Sunflora",
            "193 - Yanma",
            "194 - Wooper",
            "195 - Quagsire",
            "196 - Espeon",
            "197 - Umbreon",
            "198 - Murkrow",
            "199 - Slowking",
            "200 - Misdreavus",
            "201 - Unknown",
            "202 - Wobbuffet",
            "203 - Girafarig",
            "204 - Pineco",
            "205 - Forretress",
            "206 - Dunsparce",
            "207 - Gligar",
            "208 - Steelix",
            "209 - Snubbull",
            "210 - Granbull",
            "211 - Quilfish",
            "212 - Scizor",
            "213 - Shuckle",
            "214 - Heracross",
            "215 - Sneasel",
            "216 - Teddiursa",
            "217 - Ursaring",
            "218 - Slugma",
            "219 - Magcargo",
            "220 - Swinub",
            "221 - Piloswine",
            "222 - Corsola",
            "223 - Remoraid",
            "224 - Octillery",
            "225 - Delibird",
            "226 - Mantine",
            "227 - Skarmory",
            "228 - Houndour",
            "229 - Houndoom",
            "230 - Kingdra",
            "231 - Phanpy",
            "232 - Donphan",
            "233 - Porygon2",
            "234 - Stantler",
            "235 - Smeargle",
            "236 - Tyrogue",
            "237 - Hitmontop",
            "238 - Smoochum",
            "239 - Elekid",
            "240 - Magby",
            "241 - Miltank",
            "242 - Blissey",
            "243 - Raikou",
            "244 - Entei",
            "245 - Suicune",
            "246 - Larvitar",
            "247 - Pupitar",
            "248 - Tyranitar",
            "249 - Lugia",
            "250 - Ho-oh",
            "251 - Celebi",
            "252 - Treeko",
            "253 - Grovyle",
            "254 - Sceptile",
            "255 - Torchic",
            "256 - Combusken",
            "257 - Blaziken",
            "258 - Mudkip",
            "259 - Marshtomp",
            "260 - Swampert",
            "261 - Poochyena",
            "262 - Mightyena",
            "263 - Zigzagoon",
            "264 - Linoone",
            "265 - Wurmple",
            "266 - Silcoon",
            "267 - Beautifly",
            "268 - Cascoon",
            "269 - Dustox",
            "270 - Lotad",
            "271 - Lombre",
            "272 - Ludicolo",
            "273 - Seedot",
            "274 - Nuzleaf",
            "275 - Shiftree",
            "276 - Tailow",
            "277 - Swellow",
            "278 - Wingull",
            "279 - Pelipper",
            "280 - Ralts",
            "281 - Kirlia",
            "282 - Gardevoir",
            "283 - Surskit",
            "284 - Masquerain",
            "285 - Shroomish",
            "286 - Breloom",
            "287 - Slakoth",
            "288 - Vigoroth",
            "289 - Slaking",
            "290 - Nincada",
            "291 - Ninjask",
            "292 - Shedinja",
            "293 - Whismur",
            "294 - Loudred",
            "295 - Exploud",
            "296 - Makuhita",
            "297 - Hariyama",
            "298 - Azurill",
            "299 - Nosepass",
            "300 - Skitty",
            "301 - Delcatty",
            "302 - Sableye",
            "303 - Mawhile",
            "304 - Aron",
            "305 - Lairon",
            "306 - Aggron",
            "307 - Meditite",
            "308 - Medicham",
            "309 - Electrike",
            "310 - Manetric",
            "311 - Plusle",
            "312 - Minun",
            "313 - Volbeat",
            "314 - Illumise",
            "315 - Roselia",
            "316 - Gulpin",
            "317 - Swalot",
            "318 - Carvanha",
            "319 - Sharpedo",
            "320 - Wailmer",
            "321 - Wailord",
            "322 - Numel",
            "323 - Camerupt",
            "324 - Tokoal",
            "325 - Spoink",
            "326 - Grumpig",
            "327 - Spinda",
            "328 - Trapinch",
            "329 - Vibrava",
            "330 - Flygon",
            "331 - Cacnea",
            "332 - Cacturne",
            "333 - Swablu",
            "334 - Altaria",
            "335 - Zangoose",
            "336 - Seviper",
            "337 - Lunatone",
            "338 - Solrock",
            "339 - Barboach",
            "340 - Whiscash",
            "341 - Corphish",
            "342 - Crawdaunt",
            "343 - Baltoy",
            "344 - Claydol",
            "345 - Lileep",
            "346 - Cradily",
            "347 - Anorith",
            "348 - Armaldo",
            "349 - Feebas",
            "350 - Milotic",
            "351 - Castform",
            "352 - Keckleon",
            "353 - Shuppet",
            "354 - Banette",
            "355 - Duskull",
            "356 - Dusclops",
            "357 - Tropius",
            "358 - Chimecho",
            "359 - Absol",
            "360 - Wynaut",
            "361 - Snorunt",
            "362 - Glalie",
            "363 - Spheal",
            "364 - Sealeo",
            "365 - Walrein",
            "366 - Clamperl",
            "367 - Huntail",
            "368 - Gorebyss",
            "369 - Relicanth",
            "370 - Luvdisc",
            "371 - Bagon",
            "372 - Shellgon",
            "373 - Salamence",
            "374 - Beldum",
            "375 - Metang",
            "376 - Metagross",
            "377 - Regirock",
            "378 - Regice",
            "379 - Registeel",
            "380 - Latias",
            "381 - Latios",
            "382 - Kyogre",
            "383 - Groudon",
            "384 - Rayquaza",
            "385 - Jirachi",
            "386 - Deoxys"});
            this.comboBox1.Location = new System.Drawing.Point(93, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // PokemonSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 149);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PokemonSelection";
            this.Text = "Select a Pokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}