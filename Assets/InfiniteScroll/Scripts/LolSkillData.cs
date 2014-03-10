using UnityEngine;
using System.Collections;

/// <summary>
/// Demo Data, LOL Skill Data Array.
/// </summary>
public class LolSkillData{
	public static string[,] dic = new string[,]{
{"00101", "Disintegrate", "Annie"}
,{"00102", "Incinerate", "Annie"}
,{"00103", "Molten Shield", "Annie"}
,{"00104", "Summon: Tibbers", "Annie"}
,{"00105", "Pyromania", "Annie"}
,{"00201", "Undertow", "Olaf"}
,{"00202", "Vicious Strikes", "Olaf"}
,{"00203", "Reckless Swing", "Olaf"}
,{"00204", "Ragnarok", "Olaf"}
,{"00205", "Berserker Rage", "Olaf"}
,{"00301", "Resolute Smite", "Galio"}
,{"00302", "Bulwark", "Galio"}
,{"00303", "Righteous Gust", "Galio"}
,{"00304", "Idol of Durand", "Galio"}
,{"00305", "Runic Skin", "Galio"}
,{"00401", "Wild Cards", "Twisted Fate"}
,{"00402", "Pick A Card", "Twisted Fate"}
,{"00403", "Stacked Deck", "Twisted Fate"}
,{"00404", "Destiny", "Twisted Fate"}
,{"00405", "Loaded Dice", "Twisted Fate"}
,{"00501", "Three Talon Strike", "Xin Zhao"}
,{"00502", "Battle Cry", "Xin Zhao"}
,{"00503", "Audacious Charge", "Xin Zhao"}
,{"00504", "Crescent Sweep", "Xin Zhao"}
,{"00505", "Challenge", "Xin Zhao"}
,{"00601", "Acid Hunter", "Urgot"}
,{"00602", "Terror Capacitor", "Urgot"}
,{"00603", "Noxian Corrosive Charge", "Urgot"}
,{"00604", "Hyper-Kinetic Position Reverser", "Urgot"}
,{"00605", "Zaun-Touched Bolt Augmenter", "Urgot"}
,{"00701", "Sigil of Silence", "LeBlanc"}
,{"00702", "Distortion", "LeBlanc"}
,{"00703", "Ethereal Chains", "LeBlanc"}
,{"00704", "Mimic", "LeBlanc"}
,{"00705", "Mirror Image", "LeBlanc"}
,{"00801", "Transfusion", "Vladimir"}
,{"00802", "Sanguine Pool", "Vladimir"}
,{"00803", "Tides of Blood", "Vladimir"}
,{"00804", "Hemoplague", "Vladimir"}
,{"00805", "Crimson Pact", "Vladimir"}
,{"00901", "Terrify", "Fiddlesticks"}
,{"00902", "Drain", "Fiddlesticks"}
,{"00903", "Dark Wind", "Fiddlesticks"}
,{"00904", "Crowstorm", "Fiddlesticks"}
,{"00905", "Dread", "Fiddlesticks"}
,{"01001", "Reckoning", "Kayle"}
,{"01002", "Divine Blessing", "Kayle"}
,{"01003", "Righteous Fury", "Kayle"}
,{"01004", "Intervention", "Kayle"}
,{"01005", "Holy Fervor", "Kayle"}
,{"01101", "Alpha Strike", "Master Yi"}
,{"01102", "Meditate", "Master Yi"}
,{"01103", "Wuju Style", "Master Yi"}
,{"01104", "Highlander", "Master Yi"}
,{"01105", "Double Strike", "Master Yi"}
,{"01201", "Pulverize", "Alistar"}
,{"01202", "Headbutt", "Alistar"}
,{"01203", "Triumphant Roar", "Alistar"}
,{"01204", "Unbreakable Will", "Alistar"}
,{"01205", "Trample", "Alistar"}
,{"01301", "Overload", "Ryze"}
,{"01302", "Rune Prison", "Ryze"}
,{"01303", "Spell Flux", "Ryze"}
,{"01304", "Desperate Power", "Ryze"}
,{"01305", "Arcane Mastery", "Ryze"}
,{"01401", "Cryptic Gaze", "Sion"}
,{"01402", "Death's Caress", "Sion"}
,{"01403", "Enrage", "Sion"}
,{"01404", "Cannibalism", "Sion"}
,{"01405", "Feel No Pain", "Sion"}
,{"01501", "Boomerang Blade", "Sivir"}
,{"01502", "Ricochet", "Sivir"}
,{"01503", "Spell Shield", "Sivir"}
,{"01504", "On The Hunt", "Sivir"}
,{"01505", "Fleet of Foot", "Sivir"}
,{"01601", "Starcall", "Soraka"}
,{"01602", "Astral Blessing", "Soraka"}
,{"01603", "Infuse", "Soraka"}
,{"01604", "Wish", "Soraka"}
,{"01605", "Consecration", "Soraka"}
,{"01701", "Blinding Dart", "Teemo"}
,{"01702", "Move Quick", "Teemo"}
,{"01703", "Toxic Shot", "Teemo"}
,{"01704", "Noxious Trap", "Teemo"}
,{"01705", "Camouflage", "Teemo"}
,{"01801", "Rapid Fire", "Tristana"}
,{"01802", "Rocket Jump", "Tristana"}
,{"01803", "Explosive Shot", "Tristana"}
,{"01804", "Buster Shot", "Tristana"}
,{"01805", "Draw a Bead", "Tristana"}
,{"01901", "Hungering Strike", "Warwick"}
,{"01902", "Hunters Call", "Warwick"}
,{"01903", "Blood Scent", "Warwick"}
,{"01904", "Infinite Duress", "Warwick"}
,{"01905", "Eternal Thirst", "Warwick"}
,{"02001", "Consume", "Nunu"}
,{"02002", "Blood Boil", "Nunu"}
,{"02003", "Ice Blast", "Nunu"}
,{"02004", "Absolute Zero", "Nunu"}
,{"02005", "Visionary", "Nunu"}
,{"02101", "Double Up", "Miss Fortune"}
,{"02102", "Impure Shots", "Miss Fortune"}
,{"02103", "Make It Rain", "Miss Fortune"}
,{"02104", "Bullet Time", "Miss Fortune"}
,{"02105", "Strut", "Miss Fortune"}
,{"02201", "Frost Shot", "Ashe"}
,{"02202", "Volley", "Ashe"}
,{"02203", "Hawkshot", "Ashe"}
,{"02204", "Enchanted Crystal Arrow", "Ashe"}
,{"02205", "Focus", "Ashe"}
,{"02301", "Bloodlust", "Tryndamere"}
,{"02302", "Mocking Shout", "Tryndamere"}
,{"02303", "Spinning Slash", "Tryndamere"}
,{"02304", "Undying Rage", "Tryndamere"}
,{"02305", "Battle Fury", "Tryndamere"}
,{"02401", "Leap Strike", "Jax"}
,{"02402", "Empower", "Jax"}
,{"02403", "Counter Strike", "Jax"}
,{"02404", "Grandmaster's Might", "Jax"}
,{"02405", "Relentless Assault", "Jax"}
,{"02501", "Dark Binding", "Morgana"}
,{"02502", "Tormented Soil", "Morgana"}
,{"02503", "Black Shield", "Morgana"}
,{"02504", "Soul Shackles", "Morgana"}
,{"02505", "Soul Siphon", "Morgana"}
,{"02601", "Time Bomb", "Zilean"}
,{"02602", "Rewind", "Zilean"}
,{"02603", "Time Warp", "Zilean"}
,{"02604", "Chronoshift", "Zilean"}
,{"02605", "Heightened Learning", "Zilean"}
,{"02701", "Poison Trail", "Singed"}
,{"02702", "Mega Adhesive", "Singed"}
,{"02703", "Fling", "Singed"}
,{"02704", "Insanity Potion", "Singed"}
,{"02705", "Empowered Bulwark", "Singed"}
,{"02801", "Hate Spike", "Evelynn"}
,{"02802", "Dark Frenzy", "Evelynn"}
,{"02803", "Ravage", "Evelynn"}
,{"02804", "Agony's Embrace", "Evelynn"}
,{"02805", "Shadow Walk", "Evelynn"}
,{"02901", "Ambush", "Twitch"}
,{"02902", "Venom Cask", "Twitch"}
,{"02903", "Expunge", "Twitch"}
,{"02904", "Spray and Pray", "Twitch"}
,{"02905", "Deadly Venom", "Twitch"}
,{"03001", "Lay Waste", "Karthus"}
,{"03002", "Wall of Pain", "Karthus"}
,{"03003", "Defile", "Karthus"}
,{"03004", "Requiem", "Karthus"}
,{"03005", "Death Defied", "Karthus"}
,{"03101", "Rupture", "Cho'Gath"}
,{"03102", "Feral Scream", "Cho'Gath"}
,{"03103", "Vorpal Spikes", "Cho'Gath"}
,{"03104", "Feast", "Cho'Gath"}
,{"03105", "Carnivore", "Cho'Gath"}
,{"03201", "Bandage Toss", "Amumu"}
,{"03202", "Despair", "Amumu"}
,{"03203", "Tantrum", "Amumu"}
,{"03204", "Curse of the Sad Mummy", "Amumu"}
,{"03205", "Cursed Touch", "Amumu"}
,{"03301", "Powerball", "Rammus"}
,{"03302", "Defensive Ball Curl", "Rammus"}
,{"03303", "Puncturing Taunt", "Rammus"}
,{"03304", "Tremors", "Rammus"}
,{"03305", "Spiked Shell", "Rammus"}
,{"03401", "Flash Frost", "Anivia"}
,{"03402", "Crystallize", "Anivia"}
,{"03403", "Frostbite", "Anivia"}
,{"03404", "Glacial Storm", "Anivia"}
,{"03405", "Rebirth", "Anivia"}
,{"03501", "Deceive", "Shaco"}
,{"03502", "Jack In The Box", "Shaco"}
,{"03503", "Two-Shiv Poison", "Shaco"}
,{"03504", "Hallucinate", "Shaco"}
,{"03505", "Backstab", "Shaco"}
,{"03601", "Infected Cleaver", "Dr. Mundo"}
,{"03602", "Burning Agony", "Dr. Mundo"}
,{"03603", "Masochism", "Dr. Mundo"}
,{"03604", "Sadism", "Dr. Mundo"}
,{"03605", "Adrenaline Rush", "Dr. Mundo"}
,{"03701", "Hymn of Valor", "Sona"}
,{"03702", "Aria of Perseverance", "Sona"}
,{"03703", "Song of Celerity", "Sona"}
,{"03704", "Crescendo", "Sona"}
,{"03705", "Power Chord", "Sona"}
,{"03801", "Null Sphere", "Kassadin"}
,{"03802", "Nether Blade", "Kassadin"}
,{"03803", "Force Pulse", "Kassadin"}
,{"03804", "Riftwalk", "Kassadin"}
,{"03805", "Void Stone", "Kassadin"}
,{"03901", "Bladesurge", "Irelia"}
,{"03902", "Hiten Style", "Irelia"}
,{"03903", "Equilibrium Strike", "Irelia"}
,{"03904", "Transcendent Blades", "Irelia"}
,{"03905", "Ionian Fervor", "Irelia"}
,{"04001", "Howling Gale", "Janna"}
,{"04002", "Zephyr", "Janna"}
,{"04003", "Eye Of The Storm", "Janna"}
,{"04004", "Monsoon", "Janna"}
,{"04005", "Tailwind", "Janna"}
,{"04101", "Parrrley", "Gangplank"}
,{"04102", "Remove Scurvy", "Gangplank"}
,{"04103", "Raise Morale", "Gangplank"}
,{"04104", "Cannon Barrage", "Gangplank"}
,{"04105", "Grog-Soaked Blade", "Gangplank"}
,{"04201", "Phosphorus Bomb", "Corki"}
,{"04202", "Valkyrie", "Corki"}
,{"04203", "Gatling Gun", "Corki"}
,{"04204", "Missile Barrage", "Corki"}
,{"04205", "Hextech Shrapnel Shells", "Corki"}
,{"04301", "Heavenly Wave", "Karma"}
,{"04302", "Spirit Bond", "Karma"}
,{"04303", "Soul Shield", "Karma"}
,{"04304", "Mantra", "Karma"}
,{"04305", "Inner Flame", "Karma"}
,{"04401", "Imbue", "Taric"}
,{"04402", "Shatter", "Taric"}
,{"04403", "Dazzle", "Taric"}
,{"04404", "Radiance", "Taric"}
,{"04405", "Gemcraft", "Taric"}
,{"04501", "Baleful Strike", "Veigar"}
,{"04502", "Dark Matter", "Veigar"}
,{"04503", "Event Horizon", "Veigar"}
,{"04504", "Primordial Burst", "Veigar"}
,{"04505", "Equilibrium", "Veigar"}
,{"04801", "Rabid Bite", "Trundle"}
,{"04802", "Contaminate", "Trundle"}
,{"04803", "Pillar of Filth", "Trundle"}
,{"04804", "Agony", "Trundle"}
,{"04805", "Decompose", "Trundle"}
,{"05001", "Decrepify", "Swain"}
,{"05002", "Nevermove", "Swain"}
,{"05003", "Torment", "Swain"}
,{"05004", "Ravenous Flock", "Swain"}
,{"05005", "Carrion Renewal", "Swain"}
,{"05101", "Piltover Peacemaker", "Caitlyn"}
,{"05102", "Yordle Snap Trap", "Caitlyn"}
,{"05103", "90 Caliber Net", "Caitlyn"}
,{"05104", "Ace in the Hole", "Caitlyn"}
,{"05105", "Headshot", "Caitlyn"}
,{"05301", "Rocket Grab", "Blitzcrank"}
,{"05302", "Overdrive", "Blitzcrank"}
,{"05303", "Power Fist", "Blitzcrank"}
,{"05304", "Static Field", "Blitzcrank"}
,{"05305", "Mana Barrier", "Blitzcrank"}
,{"05401", "Seismic Shard", "Malphite"}
,{"05402", "Brutal Strikes", "Malphite"}
,{"05403", "Ground Slam", "Malphite"}
,{"05404", "Unstoppable Force", "Malphite"}
,{"05405", "Granite Shield", "Malphite"}
,{"05501", "Bouncing Blades", "Katarina"}
,{"05502", "Sinister Steel", "Katarina"}
,{"05503", "Shunpo", "Katarina"}
,{"05504", "Death Lotus", "Katarina"}
,{"05505", "Voracity", "Katarina"}
,{"05602", "Shroud of Darkness", "Nocturne"}
,{"05603", "Unspeakable Horror", "Nocturne"}
,{"05604", "Paranoia", "Nocturne"}
,{"05605", "Umbra Blades", "Nocturne"}
,{"05701", "Arcane Smash", "Maokai"}
,{"05702", "Twisted Advance", "Maokai"}
,{"05703", "Sapling Toss", "Maokai"}
,{"05704", "Vengeful Maelstrom", "Maokai"}
,{"05705", "Sap Magic", "Maokai"}
,{"05801", "Cull the Meek", "Renekton"}
,{"05802", "Ruthless Predator", "Renekton"}
,{"05803", "Slice and Dice", "Renekton"}
,{"05804", "Dominus", "Renekton"}
,{"05805", "Reign of Anger", "Renekton"}
,{"05901", "Dragon Strike", "Jarvan IV"}
,{"05902", "Golden Aegis", "Jarvan IV"}
,{"05903", "Demacian Standard", "Jarvan IV"}
,{"05904", "Cataclysm", "Jarvan IV"}
,{"05905", "Martial Cadence", "Jarvan IV"}
,{"06001", "Neurotoxin / Venomous Bite", "Elise"}
,{"06002", "Volatile Spiderling / Skittering Frenzy", "Elise"}
,{"06003", "Cocoon / Rappel", "Elise"}
,{"06004", "Spider Form", "Elise"}
,{"06005", "Spider Swarm", "Elise"}
,{"06101", "Command: Attack", "Orianna"}
,{"06102", "Command: Dissonance", "Orianna"}
,{"06103", "Command: Protect", "Orianna"}
,{"06104", "Command: Shockwave", "Orianna"}
,{"06105", "Clockwork Windup", "Orianna"}
,{"06201", "Crushing Blow", "Wukong"}
,{"06202", "Decoy", "Wukong"}
,{"06203", "Nimbus Strike", "Wukong"}
,{"06204", "Cyclone", "Wukong"}
,{"06205", "Stone Skin", "Wukong"}
,{"06301", "Sear", "Brand"}
,{"06302", "Pillar of Flame", "Brand"}
,{"06303", "Conflagration", "Brand"}
,{"06304", "Pyroclasm", "Brand"}
,{"06305", "Blaze", "Brand"}
,{"06401", "Sonic Wave / Resonating Strike", "Lee Sin"}
,{"06402", "Safeguard / Iron Will", "Lee Sin"}
,{"06403", "Tempest / Cripple", "Lee Sin"}
,{"06404", "Dragon's Rage", "Lee Sin"}
,{"06405", "Flurry", "Lee Sin"}
,{"06701", "Tumble", "Vayne"}
,{"06702", "Silver Bolts", "Vayne"}
,{"06703", "Condemn", "Vayne"}
,{"06704", "Final Hour", "Vayne"}
,{"06705", "Night Hunter", "Vayne"}
,{"06801", "Flamespitter", "Rumble"}
,{"06802", "Scrap Shield", "Rumble"}
,{"06803", "Electro Harpoon", "Rumble"}
,{"06804", "The Equalizer", "Rumble"}
,{"06805", "Junkyard Titan", "Rumble"}
,{"06901", "Noxious Blast", "Cassiopeia"}
,{"06902", "Miasma", "Cassiopeia"}
,{"06903", "Twin Fang", "Cassiopeia"}
,{"06904", "Petrifying Gaze", "Cassiopeia"}
,{"06905", "Deadly Cadence", "Cassiopeia"}
,{"07201", "Crystal Slash", "Skarner"}
,{"07202", "Crystalline Exoskeleton", "Skarner"}
,{"07203", "Fracture", "Skarner"}
,{"07204", "Impale", "Skarner"}
,{"07205", "Energize", "Skarner"}
,{"07401", "H-28G Evolution Turret", "Heimerdinger"}
,{"07402", "Hextech Micro-Rockets", "Heimerdinger"}
,{"07403", "CH-1 Concussion Grenade", "Heimerdinger"}
,{"07404", "UPGRADE!!!", "Heimerdinger"}
,{"07405", "Techmaturgical Repair Bots", "Heimerdinger"}
,{"07501", "Siphoning Strike", "Nasus"}
,{"07502", "Wither", "Nasus"}
,{"07503", "Spirit Fire", "Nasus"}
,{"07504", "Fury of the Sands", "Nasus"}
,{"07505", "Soul Eater", "Nasus"}
,{"07601", "Javelin Toss / Takedown", "Nidalee"}
,{"07602", "Bushwhack / Pounce", "Nidalee"}
,{"07603", "Primal Surge / Swipe", "Nidalee"}
,{"07604", "Aspect Of The Cougar", "Nidalee"}
,{"07605", "Prowl", "Nidalee"}
,{"07701", "Tiger Stance", "Udyr"}
,{"07702", "Turtle Stance", "Udyr"}
,{"07703", "Bear Stance", "Udyr"}
,{"07704", "Phoenix Stance", "Udyr"}
,{"07705", "Monkey's Agility", "Udyr"}
,{"07801", "Devastating Blow", "Poppy"}
,{"07802", "Paragon of Demacia", "Poppy"}
,{"07803", "Heroic Charge", "Poppy"}
,{"07804", "Diplomatic Immunity", "Poppy"}
,{"07805", "Valiant Fighter", "Poppy"}
,{"07901", "Barrel Roll", "Gragas"}
,{"07902", "Drunken Rage", "Gragas"}
,{"07903", "Body Slam", "Gragas"}
,{"07904", "Explosive Cask", "Gragas"}
,{"07905", "Happy Hour", "Gragas"}
,{"08001", "Spear Shot", "Pantheon"}
,{"08002", "Aegis of Zeonia", "Pantheon"}
,{"08003", "Heartseeker Strike", "Pantheon"}
,{"08004", "Grand Skyfall", "Pantheon"}
,{"08005", "Aegis Protection", "Pantheon"}
,{"08101", "Mystic Shot", "Ezreal"}
,{"08102", "Essence Flux", "Ezreal"}
,{"08103", "Arcane Shift", "Ezreal"}
,{"08104", "Trueshot Barrage", "Ezreal"}
,{"08105", "Rising Spell Force", "Ezreal"}
,{"08201", "Mace of Spades", "Mordekaiser"}
,{"08202", "Creeping Death", "Mordekaiser"}
,{"08203", "Siphon of Destruction", "Mordekaiser"}
,{"08204", "Children of the Grave", "Mordekaiser"}
,{"08205", "Iron Man", "Mordekaiser"}
,{"08301", "Omen of War", "Yorick"}
,{"08302", "Omen of Pestilence", "Yorick"}
,{"08303", "Omen of Famine", "Yorick"}
,{"08304", "Omen of Death", "Yorick"}
,{"08305", "Unholy Covenant", "Yorick"}
,{"08401", "Mark of the Assassin", "Akali"}
,{"08402", "Twilight Shroud", "Akali"}
,{"08403", "Crescent Slash", "Akali"}
,{"08404", "Shadow Dance", "Akali"}
,{"08405", "Twin Disciplines", "Akali"}
,{"08501", "Thundering Shuriken", "Kennen"}
,{"08502", "Electrical Surge", "Kennen"}
,{"08503", "Lightning Rush", "Kennen"}
,{"08504", "Slicing Maelstrom", "Kennen"}
,{"08505", "Mark of the Storm", "Kennen"}
,{"08601", "Decisive Strike", "Garen"}
,{"08602", "Courage", "Garen"}
,{"08603", "Judgment", "Garen"}
,{"08604", "Demacian Justice", "Garen"}
,{"08605", "Perseverance", "Garen"}
,{"08901", "Shield of Daybreak", "Leona"}
,{"08902", "Eclipse", "Leona"}
,{"08903", "Zenith Blade", "Leona"}
,{"08904", "Solar Flare", "Leona"}
,{"08905", "Sunlight", "Leona"}
,{"09001", "Call of the Void", "Malzahar"}
,{"09002", "Null Zone", "Malzahar"}
,{"09003", "Malefic Visions", "Malzahar"}
,{"09004", "Nether Grasp", "Malzahar"}
,{"09005", "Summon Voidling", "Malzahar"}
,{"09101", "Noxian Diplomacy", "Talon"}
,{"09102", "Rake", "Talon"}
,{"09103", "Cutthroat", "Talon"}
,{"09104", "Shadow Assault", "Talon"}
,{"09105", "Mercy", "Talon"}
,{"09201", "Broken Wings", "Riven"}
,{"09202", "Ki Burst", "Riven"}
,{"09203", "Valor", "Riven"}
,{"09204", "Blade of the Exile", "Riven"}
,{"09205", "Runic Blade", "Riven"}
,{"09601", "Caustic Spittle", "Kog'Maw"}
,{"09602", "Bio-Arcane Barrage", "Kog'Maw"}
,{"09603", "Void Ooze", "Kog'Maw"}
,{"09604", "Living Artillery", "Kog'Maw"}
,{"09605", "Icathian Surprise", "Kog'Maw"}
,{"09801", "Vorpal Blade", "Shen"}
,{"09802", "Feint", "Shen"}
,{"09803", "Shadow Dash", "Shen"}
,{"09804", "Stand United", "Shen"}
,{"09805", "Ki Strike", "Shen"}
,{"09901", "Light Binding", "Lux"}
,{"09902", "Prismatic Barrier", "Lux"}
,{"09903", "Lucent Singularity", "Lux"}
,{"09904", "Final Spark", "Lux"}
,{"09905", "Illumination", "Lux"}
,{"10101", "Arcanopulse", "Xerath"}
,{"10102", "Locus of Power", "Xerath"}
,{"10103", "Mage Chains", "Xerath"}
,{"10104", "Arcane Barrage", "Xerath"}
,{"10105", "Ascended Form", "Xerath"}
,{"10201", "Twin Bite", "Shyvana"}
,{"10202", "Burnout", "Shyvana"}
,{"10203", "Flame Breath", "Shyvana"}
,{"10204", "Dragon's Descent", "Shyvana"}
,{"10205", "Fury of the Dragonborn", "Shyvana"}
,{"10301", "Orb of Deception", "Ahri"}
,{"10302", "Fox-Fire", "Ahri"}
,{"10303", "Charm", "Ahri"}
,{"10304", "Spirit Rush", "Ahri"}
,{"10305", "Essence Theft", "Ahri"}
,{"10401", "Buckshot", "Graves"}
,{"10402", "Smoke Screen", "Graves"}
,{"10403", "Quickdraw", "Graves"}
,{"10404", "Collateral Damage", "Graves"}
,{"10405", "True Grit", "Graves"}
,{"10501", "Urchin Strike", "Fizz"}
,{"10502", "Seastone Trident", "Fizz"}
,{"10503", "Playful / Trickster", "Fizz"}
,{"10504", "Chum the Waters", "Fizz"}
,{"10505", "Nimble Fighter", "Fizz"}
,{"10601", "Rolling Thunder", "Volibear"}
,{"10602", "Frenzy", "Volibear"}
,{"10603", "Majestic Roar", "Volibear"}
,{"10604", "Thunder Claws", "Volibear"}
,{"10605", "Chosen of the Storm", "Volibear"}
,{"10701", "Savagery", "Rengar"}
,{"10702", "Battle Roar", "Rengar"}
,{"10703", "Bola Strike", "Rengar"}
,{"10704", "Thrill of the Hunt", "Rengar"}
,{"10705", "Unseen Predator", "Rengar"}
,{"11001", "Piercing Arrow", "Varus"}
,{"11002", "Blighted Quiver", "Varus"}
,{"11003", "Hail of Arrows", "Varus"}
,{"11004", "Chain of Corruption", "Varus"}
,{"11005", "Living Vengeance", "Varus"}
,{"11101", "Dredge Line", "Nautilus"}
,{"11102", "Titan's Wrath", "Nautilus"}
,{"11103", "Riptide", "Nautilus"}
,{"11104", "Depth Charge", "Nautilus"}
,{"11105", "Staggering Blow", "Nautilus"}
,{"11201", "Power Transfer", "Viktor"}
,{"11202", "Gravity Field", "Viktor"}
,{"11203", "Death Ray", "Viktor"}
,{"11204", "Chaos Storm", "Viktor"}
,{"11205", "Evolving Technology", "Viktor"}
,{"11301", "Arctic Assault", "Sejuani"}
,{"11302", "Northern Winds", "Sejuani"}
,{"11303", "Permafrost", "Sejuani"}
,{"11304", "Glacial Prison", "Sejuani"}
,{"11305", "Frost", "Sejuani"}
,{"11401", "Lunge", "Fiora"}
,{"11402", "Riposte", "Fiora"}
,{"11403", "Burst of Speed", "Fiora"}
,{"11404", "Blade Waltz", "Fiora"}
,{"11405", "Duelist", "Fiora"}
,{"11501", "Bouncing Bomb", "Ziggs"}
,{"11502", "Satchel Charge", "Ziggs"}
,{"11503", "Hexplosive Minefield", "Ziggs"}
,{"11504", "Mega Inferno Bomb", "Ziggs"}
,{"11505", "Short Fuse", "Ziggs"}
,{"11701", "Glitterlance", "Lulu"}
,{"11702", "Whimsy", "Lulu"}
,{"11703", "Help, Pix!", "Lulu"}
,{"11704", "Wild Growth", "Lulu"}
,{"11705", "Pix, Faerie Companion", "Lulu"}
,{"11901", "Spinning Axe", "Draven"}
,{"11902", "Blood Rush", "Draven"}
,{"11903", "Stand Aside", "Draven"}
,{"11904", "Whirling Death", "Draven"}
,{"11905", "Wicked Blades", "Draven"}
,{"12001", "Rampage", "Hecarim"}
,{"12002", "Spirit of Dread", "Hecarim"}
,{"12003", "Devastating Charge", "Hecarim"}
,{"12004", "Onslaught of Shadows", "Hecarim"}
,{"12005", "Warpath", "Hecarim"}
,{"12101", "Taste Their Fear", "Kha'Zix"}
,{"12102", "Void Spike", "Kha'Zix"}
,{"12103", "Leap", "Kha'Zix"}
,{"12104", "Void Assault", "Kha'Zix"}
,{"12105", "Unseen Threat", "Kha'Zix"}
,{"12201", "Decimate", "Darius"}
,{"12202", "Crippling Strike", "Darius"}
,{"12203", "Apprehend", "Darius"}
,{"12204", "Noxian Guillotine", "Darius"}
,{"12205", "Hemorrhage", "Darius"}
,{"12601", "To the Skies! / Shock Blast", "Jayce"}
,{"12603", "Lightning Field / Hyper Charge", "Jayce"}
,{"12604", "Hyper Charge", "Jayce"}
,{"12605", "Thundering Blow / Acceleration Gate", "Jayce"}
,{"12606", "Acceleration Gate", "Jayce"}
,{"12607", "Mercury Cannon", "Jayce"}
,{"12608", "Mercury Hammer", "Jayce"}
,{"12609", "Hextech Capacitor", "Jayce"}
,{"13101", "Crescent Strike", "Diana"}
,{"13102", "Pale Cascade", "Diana"}
,{"13103", "Moonfall", "Diana"}
,{"13104", "Lunar Rush", "Diana"}
,{"13105", "Moonsilver Blade", "Diana"}
,{"13401", "Dark Sphere", "Syndra"}
,{"13402", "Force of Will", "Syndra"}
,{"13403", "Scatter the Weak", "Syndra"}
,{"13404", "Unleashed Power", "Syndra"}
,{"13405", "Transcendent", "Syndra"}
,{"14301", "Deadly Bloom", "Zyra"}
,{"14302", "Rampant Growth", "Zyra"}
,{"14303", "Grasping Roots", "Zyra"}
,{"14304", "Stranglethorns", "Zyra"}
,{"14305", "Rise of the Thorns", "Zyra"}
	};
}
