using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using CustomRPC.Properties;

namespace CustomRPC
{
	// Token: 0x02000017 RID: 23
	public static class Utils
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00009423 File Offset: 0x00007623
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000942A File Offset: 0x0000762A
		private static List<Language> Languages { get; set; } = new List<Language>
		{
			new Language
			{
				Name = "مَصرى",
				EnglishName = "Arabic",
				Code = "ar",
				Translators = new Person[]
				{
					new Person
					{
						Name = "FiberAhmed",
						Url = "https://github.com/FiberAhmed"
					},
					new Person
					{
						Name = "ShadowlGamer"
					},
					new Person
					{
						Name = "karimawi"
					},
					new Person
					{
						Name = "Bo Raghad"
					}
				}
			},
			new Language
			{
				Name = "Български",
				EnglishName = "Bulgarian",
				Code = "bg",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Nikolay Shangov (aka 21)",
						Url = "https://discord.gg/hqvMaxBAew"
					},
					new Person
					{
						Name = "TheLocalSlavic"
					},
					new Person
					{
						Name = "EmeraldCeat",
						Url = "https://discord.gg/reformedcityrp"
					}
				}
			},
			new Language
			{
				Name = "বাংলা",
				EnglishName = "Bengali",
				Code = "bn",
				Translators = new Person[]
				{
					new Person
					{
						Name = "mrimran",
						Url = "https://github.com/mr-Imran"
					}
				}
			},
			new Language
			{
				Name = "Bosanski",
				EnglishName = "Bosnian",
				Code = "bs",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Trax"
					}
				}
			},
			new Language
			{
				Name = "Català",
				EnglishName = "Catalan",
				Code = "ca",
				Translators = new Person[]
				{
					Utils.DarlingChan,
					new Person
					{
						Name = "Alte87"
					}
				}
			},
			new Language
			{
				Name = "Čeština",
				EnglishName = "Czech",
				Code = "cs",
				Translators = new Person[]
				{
					new Person
					{
						Name = "JayJake",
						Url = "https://jayjake.eu/"
					},
					new Person
					{
						Name = "SunightMC"
					},
					new Person
					{
						Name = "Tobias"
					},
					new Person
					{
						Name = "MakoPog"
					}
				}
			},
			new Language
			{
				Name = "Dansk",
				EnglishName = "Danish",
				Code = "da",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Sebastian Hviid"
					},
					new Person
					{
						Name = "Tobias"
					},
					new Person
					{
						Name = "wimblim"
					},
					new Person
					{
						Name = "David"
					},
					new Person
					{
						Name = "Johansenbastian6"
					}
				}
			},
			new Language
			{
				Name = "Deutsch",
				EnglishName = "German",
				Code = "de",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Ypsol",
						Url = "https://www.youtube.com/channel/UCxGqMDnXnEyVt4yugLeBpgA"
					},
					new Person
					{
						Name = "ahmad"
					},
					Utils.MarcelGustin,
					Utils.Yoshi,
					new Person
					{
						Name = "binarynoise"
					},
					new Person
					{
						Name = "Felix",
						Url = "https://github.com/fbrettnich"
					},
					new Person
					{
						Name = "Tom"
					},
					Utils.iRetrozx
				}
			},
			new Language
			{
				Name = "Schwiizerdütsch",
				EnglishName = "Swiss German",
				Code = "de-ch",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Foolian",
						Url = "https://foolian.com/"
					},
					Utils.dragonGRaf
				}
			},
			new Language
			{
				Name = "Ελληνικά",
				EnglishName = "Greek",
				Code = "el",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Alex Grivas"
					},
					new Person
					{
						Name = "NetworkTips#0001",
						Url = "https://discord.gg/Qb8RPjH6sD"
					}
				}
			},
			new Language
			{
				Name = "English",
				Code = "en"
			},
			new Language
			{
				Name = "Español",
				EnglishName = "Spanish",
				Code = "es",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Vexot"
					},
					new Person
					{
						Name = "SirAmong"
					},
					new Person
					{
						Name = "Pablo"
					},
					Utils.DarlingChan,
					new Person
					{
						Name = "UncleGeek"
					},
					new Person
					{
						Name = "Luciousmc"
					},
					new Person
					{
						Name = "Alvaro203204"
					},
					new Person
					{
						Name = "Epic"
					}
				}
			},
			new Language
			{
				Name = "Eesti",
				EnglishName = "Estonian",
				Code = "et",
				Translators = new Person[]
				{
					new Person
					{
						Name = "z1",
						Url = "https://github.com/Erkkii"
					},
					new Person
					{
						Name = "Meelis"
					}
				}
			},
			new Language
			{
				Name = "فارسی",
				EnglishName = "Persian",
				Code = "fa",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Mohammad Mahdi",
						Url = "https://mo-mahdihh.ir/"
					}
				}
			},
			new Language
			{
				Name = "Suomi",
				EnglishName = "Finnish",
				Code = "fi",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Deluxeria"
					},
					new Person
					{
						Name = "Zunikuu"
					},
					new Person
					{
						Name = "jes",
						Url = "https://jesperiz.carrd.co/"
					},
					new Person
					{
						Name = "Super"
					}
				}
			},
			new Language
			{
				Name = "Filipino",
				EnglishName = "Filipino",
				Code = "fil",
				Translators = new Person[]
				{
					new Person
					{
						Name = "CtrlAltDelicious",
						Url = "https://www.youtube.com/c/CtrlAltDelicious_"
					},
					new Person
					{
						Name = "jericko"
					},
					new Person
					{
						Name = "Hachiki"
					}
				}
			},
			new Language
			{
				Name = "Français",
				EnglishName = "French",
				Code = "fr",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Nenaff"
					},
					new Person
					{
						Name = "RedNix"
					},
					new Person
					{
						Name = "VaporCorp"
					}
				}
			},
			new Language
			{
				Name = "עברית",
				EnglishName = "Hebrew",
				Code = "he",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Galaxy6430",
						Url = "https://www.youtube.com/channel/UC_cnrLEXfwsZoQxEsM95HXg"
					},
					new Person
					{
						Name = "Kahpot Vanilla",
						Url = "https://linktr.ee/KahpotVanilla"
					},
					new Person
					{
						Name = "Amit"
					}
				}
			},
			new Language
			{
				Name = "हिन्दी",
				EnglishName = "Hindi",
				Code = "hi",
				Translators = new Person[]
				{
					new Person
					{
						Name = "regex",
						Url = "https://github.com/REGEX777"
					},
					Utils.Julian,
					new Person
					{
						Name = "mochiron desu"
					}
				}
			},
			new Language
			{
				Name = "Hrvatski",
				EnglishName = "Croatian",
				Code = "hr",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Monika"
					},
					Utils.iRetrozx
				}
			},
			new Language
			{
				Name = "Magyar",
				EnglishName = "Hungarian",
				Code = "hu",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Balla Botond",
						Url = "https://github.com/BallaBotond"
					},
					new Person
					{
						Name = "Noxie"
					},
					new Person
					{
						Name = "BunDzsi"
					}
				}
			},
			new Language
			{
				Name = "Bahasa Indonesia",
				EnglishName = "Indonesian",
				Code = "id",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Hapnan"
					},
					new Person
					{
						Name = "Apolycious"
					},
					new Person
					{
						Name = "Bayu Sopwan",
						Url = "https://bayusopwan.github.io/"
					},
					new Person
					{
						Name = "xChellz"
					}
				}
			},
			new Language
			{
				Name = "Italiano",
				EnglishName = "Italian",
				Code = "it",
				Translators = new Person[]
				{
					new Person
					{
						Name = "DJD320"
					},
					new Person
					{
						Name = "Frin"
					},
					new Person
					{
						Name = "Bay"
					},
					Utils.Matthww,
					new Person
					{
						Name = "ItsMrCube",
						Url = "https://mrcube.dev/"
					},
					new Person
					{
						Name = "Patrick Canal"
					}
				}
			},
			new Language
			{
				Name = "日本語",
				EnglishName = "Japanese",
				Code = "ja",
				Translators = new Person[]
				{
					new Person
					{
						Name = "KABIKIRA000"
					}
				}
			},
			new Language
			{
				Name = "ქართული ენა",
				EnglishName = "Georgian",
				Code = "ka",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Turashviliguro",
						Url = "https://turashviliguro.github.io/daddyexe/"
					}
				}
			},
			new Language
			{
				Name = "한국어",
				EnglishName = "Korean",
				Code = "ko",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Yeongaori",
						Url = "https://github.com/yeongaori"
					}
				}
			},
			new Language
			{
				Name = "کوردی سۆرانی",
				EnglishName = "Central Kurdish",
				Code = "ku",
				Translators = new Person[]
				{
					new Person
					{
						Name = "SamTheNoob",
						Url = "https://linktr.ee/stn69"
					},
					new Person
					{
						Name = "JakeAnthrax420"
					}
				}
			},
			new Language
			{
				Name = "Lietuvių",
				EnglishName = "Lithuanian",
				Code = "lt",
				Translators = new Person[]
				{
					Utils.GreenRosie,
					new Person
					{
						Name = "Flix3ris"
					}
				}
			},
			new Language
			{
				Name = "Latviešu",
				EnglishName = "Latvian",
				Code = "lv",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Buckneraaron07"
					},
					new Person
					{
						Name = "Jaroslavs"
					}
				}
			},
			new Language
			{
				Name = "Македонски",
				EnglishName = "Macedonian",
				Code = "mk",
				Translators = new Person[]
				{
					Utils.falcon
				}
			},
			new Language
			{
				Name = "မြန်မာဘာသာ",
				EnglishName = "Burmese",
				Code = "my",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Bad Infer_#0069"
					},
					new Person
					{
						Name = "BBbear#7149"
					}
				}
			},
			new Language
			{
				Name = "Nederlands",
				EnglishName = "Dutch",
				Code = "nl",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Jeremyzijlemans",
						Url = "https://sionteam.com/"
					},
					new Person
					{
						Name = "Screitsma64"
					},
					new Person
					{
						Name = "sys-256",
						Url = "https://sys-256.me/"
					},
					new Person
					{
						Name = "DutchSlav"
					}
				}
			},
			new Language
			{
				Name = "Norsk",
				EnglishName = "Norwegian",
				Code = "no",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Sveinung"
					}
				}
			},
			new Language
			{
				Name = "Polski",
				EnglishName = "Polish",
				Code = "pl",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Lol1112345.lol12345"
					},
					new Person
					{
						Name = "Liso"
					},
					new Person
					{
						Name = "Piter"
					},
					new Person
					{
						Name = "Oscar"
					},
					Utils.MarcelGustin,
					Utils.TofixRs,
					new Person
					{
						Name = "KM127PL"
					}
				}
			},
			new Language
			{
				Name = "Português",
				EnglishName = "Portuguese",
				Code = "pt",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Verygafanhot"
					}
				}
			},
			new Language
			{
				Name = "Português",
				EnglishName = "Portuguese",
				Dialect = "BR",
				Code = "pt-br",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Vinicio Henrique (viniciotricolor)"
					},
					new Person
					{
						Name = "Slimakoi"
					},
					new Person
					{
						Name = "Felipe B. Pansani"
					},
					new Person
					{
						Name = "DeusDrizzyy"
					},
					new Person
					{
						Name = "Leo"
					}
				}
			},
			new Language
			{
				Name = "Limba română",
				EnglishName = "Romanian",
				Code = "ro",
				Translators = new Person[]
				{
					new Person
					{
						Name = "DiDYRO",
						Url = "https://www.youtube.com/channel/UCjij9nYlEyPl5aVYnJkvx2w"
					},
					new Person
					{
						Name = "Denisbolba"
					},
					new Person
					{
						Name = "KTSGod",
						Url = "https://ktsgod.carrd.co/"
					},
					new Person
					{
						Name = "Eddie",
						Url = "https://github.com/EdiRo"
					},
					Utils.Matthww,
					new Person
					{
						Name = "BlockBuzzters"
					}
				}
			},
			new Language
			{
				Name = "Русский",
				EnglishName = "Russian",
				Code = "ru",
				Translators = new Person[]
				{
					new Person
					{
						Name = "maximmax42",
						Url = "https://www.maximmax42.ru"
					}
				}
			},
			new Language
			{
				Name = "Slovenčina",
				EnglishName = "Slovak",
				Code = "sk",
				Translators = new Person[]
				{
					new Person
					{
						Name = "richi",
						Url = "https://e-z.bio/shelovesrichi"
					},
					new Person
					{
						Name = "Maros Mihalek"
					}
				}
			},
			new Language
			{
				Name = "Slovenščina",
				EnglishName = "Slovenian",
				Code = "sl",
				Translators = new Person[]
				{
					new Person
					{
						Name = "BMKoscak"
					}
				}
			},
			new Language
			{
				Name = "Српски",
				EnglishName = "Serbian",
				Code = "sr",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Vihaan"
					},
					new Person
					{
						Name = "ToShibaToShamara"
					},
					Utils.falcon,
					new Person
					{
						Name = "Veljko"
					}
				}
			},
			new Language
			{
				Name = "Svenska",
				EnglishName = "Swedish",
				Code = "sv",
				Translators = new Person[]
				{
					new Person
					{
						Name = "leadattic_",
						Url = "https://leadattic.leadattic953788.repl.co/"
					},
					new Person
					{
						Name = "Rose Liljensten"
					},
					new Person
					{
						Name = "James"
					}
				}
			},
			new Language
			{
				Name = "தமிழ்",
				EnglishName = "Tamil",
				Code = "ta",
				Translators = new Person[]
				{
					Utils.Julian
				}
			},
			new Language
			{
				Name = "ภาษาไทย",
				EnglishName = "Thai",
				Code = "th",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Squishee Freshy"
					},
					new Person
					{
						Name = "YuuabyssSSID"
					},
					new Person
					{
						Name = "SabbKor"
					},
					new Person
					{
						Name = "OHMKUB"
					}
				}
			},
			new Language
			{
				Name = "Türkçe",
				EnglishName = "Turkish",
				Code = "tr",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Ozan Akyüz"
					},
					new Person
					{
						Name = "josephisticated",
						Url = "https://github.com/josephisticated"
					}
				}
			},
			new Language
			{
				Name = "Українська",
				EnglishName = "Ukrainian",
				Code = "uk",
				Translators = new Person[]
				{
					new Person
					{
						Name = "MechaniX"
					},
					new Person
					{
						Name = "Dmitromintenko"
					}
				}
			},
			new Language
			{
				Name = "Tiếng Việt",
				EnglishName = "Vietnamese",
				Code = "vi",
				Translators = new Person[]
				{
					new Person
					{
						Name = "Mykm",
						Url = "https://github.com/yumiruuwu"
					},
					new Person
					{
						Name = "Phnthnhnm0612"
					},
					new Person
					{
						Name = "dsbachle"
					},
					new Person
					{
						Name = "Ayano"
					},
					new Person
					{
						Name = "03_Trần"
					}
				}
			},
			new Language
			{
				Name = "汉语",
				EnglishName = "Simplified Chinese",
				Code = "zh-hans",
				Translators = new Person[]
				{
					Utils.westxlu,
					new Person
					{
						Name = "Zjsun.ca"
					},
					new Person
					{
						Name = "zozocha"
					}
				}
			},
			new Language
			{
				Name = "漢語",
				EnglishName = "Traditional Chinese",
				Code = "zh-hant",
				Translators = new Person[]
				{
					Utils.westxlu
				}
			}
		};

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00009432 File Offset: 0x00007632
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00009439 File Offset: 0x00007639
		private static Dictionary<string, string> LanguageProgress { get; set; } = new Dictionary<string, string>();

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00009441 File Offset: 0x00007641
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00009448 File Offset: 0x00007648
		private static List<Supporter> Supporters { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00009450 File Offset: 0x00007650
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00009457 File Offset: 0x00007657
		private static List<NonMonetarySupporter> NonMonetarySupporters { get; set; }

		// Token: 0x060000B1 RID: 177 RVA: 0x00009460 File Offset: 0x00007660
		static Utils()
		{
			Utils.LanguageProgress["ar"] = "100";
			Utils.LanguageProgress["bn"] = "97.98";
			Utils.LanguageProgress["bs"] = "100";
			Utils.LanguageProgress["bg"] = "100";
			Utils.LanguageProgress["my"] = "94.95";
			Utils.LanguageProgress["ca"] = "100";
			Utils.LanguageProgress["zh-hans"] = "100";
			Utils.LanguageProgress["zh-hant"] = "100";
			Utils.LanguageProgress["hr"] = "100";
			Utils.LanguageProgress["cs"] = "100";
			Utils.LanguageProgress["da"] = "98.99";
			Utils.LanguageProgress["nl"] = "100";
			Utils.LanguageProgress["et"] = "100";
			Utils.LanguageProgress["fil"] = "100";
			Utils.LanguageProgress["fi"] = "100";
			Utils.LanguageProgress["fr"] = "100";
			Utils.LanguageProgress["ka"] = "100";
			Utils.LanguageProgress["de"] = "100";
			Utils.LanguageProgress["de-ch"] = "100";
			Utils.LanguageProgress["el"] = "100";
			Utils.LanguageProgress["he"] = "100";
			Utils.LanguageProgress["hi"] = "98.99";
			Utils.LanguageProgress["hu"] = "100";
			Utils.LanguageProgress["is"] = "11.11";
			Utils.LanguageProgress["id"] = "100";
			Utils.LanguageProgress["it"] = "100";
			Utils.LanguageProgress["ja"] = "100";
			Utils.LanguageProgress["ko"] = "100";
			Utils.LanguageProgress["ku"] = "100";
			Utils.LanguageProgress["lv"] = "100";
			Utils.LanguageProgress["lt"] = "100";
			Utils.LanguageProgress["mk"] = "100";
			Utils.LanguageProgress["ml"] = "38.38";
			Utils.LanguageProgress["no"] = "98.99";
			Utils.LanguageProgress["fa"] = "100";
			Utils.LanguageProgress["pl"] = "100";
			Utils.LanguageProgress["pt"] = "100";
			Utils.LanguageProgress["pt-br"] = "100";
			Utils.LanguageProgress["ro"] = "100";
			Utils.LanguageProgress["ru"] = "100";
			Utils.LanguageProgress["sr"] = "100";
			Utils.LanguageProgress["sk"] = "100";
			Utils.LanguageProgress["sl"] = "100";
			Utils.LanguageProgress["es"] = "100";
			Utils.LanguageProgress["sv"] = "100";
			Utils.LanguageProgress["ta"] = "97.98";
			Utils.LanguageProgress["th"] = "100";
			Utils.LanguageProgress["tr"] = "100";
			Utils.LanguageProgress["uk"] = "100";
			Utils.LanguageProgress["ur"] = "34.34";
			Utils.LanguageProgress["vi"] = "100";
			Utils.Supporters = new List<Supporter>
			{
				new Supporter
				{
					Name = "Grim",
					Url = "https://www.savethekiwi.nz/",
					USDAmount = "25.00",
					AltAmount = "0.0008328 BTC"
				},
				new Supporter(Utils.GreenRosie, "6.00", ""),
				new Supporter
				{
					Name = "Boefjim",
					Url = "https://boefjim.com/",
					USDAmount = "16.13",
					AltAmount = "1000 RUB"
				},
				new Supporter
				{
					Name = "Anonymous",
					USDAmount = "2.62",
					AltAmount = "0.00011304 BTC"
				},
				new Supporter
				{
					Name = "Eli404",
					Url = "https://linktr.ee/404femboy",
					USDAmount = "5.09",
					AltAmount = "5 EUR"
				},
				new Supporter(Utils.TofixRs, "0.45", "1 BAT"),
				new Supporter
				{
					Name = "kiwi",
					USDAmount = "50.69",
					AltAmount = "50 EUR"
				},
				new Supporter
				{
					Name = "Kushgo",
					Url = "https://opensea.io/collection/worldtowers",
					USDAmount = "5.00",
					AltAmount = "0.00313295 ETH"
				},
				new Supporter
				{
					Name = "Bilal_786",
					Url = "https://discord.gg/zabPuE78ne",
					USDAmount = "5.79",
					AltAmount = "5.80 EUR"
				},
				new Supporter(Utils.Yoshi, "3.28", "200.00 RUB"),
				new Supporter
				{
					Name = "Zag",
					Url = "https://zag.rip",
					USDAmount = "7.45",
					AltAmount = "431.55 RUB"
				},
				new Supporter(Utils.dragonGRaf, "30.00", "1949.00 RUB"),
				new Supporter
				{
					Name = "Josenrique AS",
					Url = "https://josenriqueas.com/referred/customrp/",
					USDAmount = "6.50",
					AltAmount = "417.00 RUB"
				},
				new Supporter
				{
					Name = "YJB",
					Url = "https://owo.yjb.gay/",
					USDAmount = "0.69",
					AltAmount = "41.00 RUB"
				},
				new Supporter
				{
					Name = "Jan",
					USDAmount = "1.49",
					AltAmount = "100.00 RUB"
				},
				new Supporter
				{
					Name = "CJPro25",
					USDAmount = "0.91",
					AltAmount = "63.00 RUB"
				},
				new Supporter
				{
					Name = "WEIRON GREIZER",
					USDAmount = "0.39",
					AltAmount = "27.66 RUB"
				},
				new Supporter
				{
					Name = "Death",
					USDAmount = "1.93",
					AltAmount = "142.00 RUB"
				},
				new Supporter
				{
					Name = "RÏÇH KËÊD",
					USDAmount = "2.10",
					AltAmount = "30.00 TRX"
				}
			};
			Utils.NonMonetarySupporters = new List<NonMonetarySupporter>
			{
				new NonMonetarySupporter
				{
					Name = "vouivre",
					Url = "https://twitter.com/vvouivre",
					DonationType = "A furry art",
					DonationUrl = "https://cdn.discordapp.com/attachments/1028632852969033839/1028632881179922522/unknown.png"
				}
			};
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		public static bool SaveSettings()
		{
			bool result;
			try
			{
				Settings.Default.Save();
				result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(Strings.errorSavingSettings + " " + ex.Message, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000BA28 File Offset: 0x00009C28
		public static void LanguagesSetup(ToolStripMenuItem translatorsParent, EventHandler translatorsHandler, ToolStripMenuItem languagesParent, EventHandler languagesHandler)
		{
			translatorsParent.DropDownItems.Clear();
			languagesParent.DropDownItems.RemoveByKey("sampleToolStripMenuItem");
			foreach (Language language in Utils.Languages)
			{
				string text = "";
				if (!string.IsNullOrEmpty(language.Dialect))
				{
					text = " (" + language.Dialect + ")";
				}
				languagesParent.DropDownItems.Add(new ToolStripMenuItem(language.Name + text, null, languagesHandler)
				{
					Tag = language.Code,
					ToolTipText = language.EnglishName + text
				});
				if (!(language.Code == "en"))
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(string.Concat(new string[]
					{
						language.Name,
						" (",
						language.EnglishName,
						")",
						text,
						" - ",
						Utils.LanguageProgress[language.Code],
						"%"
					}));
					foreach (Person person in language.Translators)
					{
						ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(person.Name, null, translatorsHandler);
						if (!string.IsNullOrEmpty(person.Url))
						{
							toolStripMenuItem2.Image = Resources.globe;
							toolStripMenuItem2.Tag = new ValueTuple<string, string>("translator", person.Url);
							toolStripMenuItem2.ToolTipText = person.Url;
						}
						toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
					}
					translatorsParent.DropDownItems.Add(toolStripMenuItem);
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000BC0C File Offset: 0x00009E0C
		public static void SupportersSetup(ToolStripMenuItem parent, EventHandler handler)
		{
			parent.DropDownItems.Clear();
			Utils.Supporters.Sort(delegate(Supporter x, Supporter y)
			{
				float value = float.Parse(x.USDAmount, CultureInfo.InvariantCulture);
				return float.Parse(y.USDAmount, CultureInfo.InvariantCulture).CompareTo(value);
			});
			foreach (Supporter supporter in Utils.Supporters)
			{
				string str = "";
				if (!string.IsNullOrEmpty(supporter.AltAmount))
				{
					str = " (" + supporter.AltAmount + ")";
				}
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(supporter.Name + " - $" + supporter.USDAmount + str, null, handler);
				if (!string.IsNullOrEmpty(supporter.Url))
				{
					toolStripMenuItem.Image = Resources.globe;
					toolStripMenuItem.Tag = new ValueTuple<string, string>("supporter", supporter.Url);
					toolStripMenuItem.ToolTipText = supporter.Url;
				}
				parent.DropDownItems.Add(toolStripMenuItem);
			}
			parent.DropDownItems.Add(new ToolStripSeparator());
			using (List<NonMonetarySupporter>.Enumerator enumerator2 = Utils.NonMonetarySupporters.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					NonMonetarySupporter nmSupporter = enumerator2.Current;
					ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(nmSupporter.Name + " - " + nmSupporter.DonationType, null, handler);
					if (!string.IsNullOrEmpty(nmSupporter.Url))
					{
						toolStripMenuItem2.Image = Resources.globe;
						toolStripMenuItem2.Tag = new ValueTuple<string, string>("non-monetary supporter", nmSupporter.Url);
						toolStripMenuItem2.ToolTipText = nmSupporter.Url;
					}
					if (!string.IsNullOrEmpty(nmSupporter.DonationUrl))
					{
						string @string = new ComponentResourceManager(typeof(MainForm)).GetString("openToolStripMenuItem.Text");
						toolStripMenuItem2.DropDownItems.Add(new ToolStripMenuItem(@string, null, delegate(object o, EventArgs e)
						{
							Process.Start(nmSupporter.DonationUrl);
						})
						{
							ToolTipText = nmSupporter.DonationUrl
						});
					}
					parent.DropDownItems.Add(toolStripMenuItem2);
				}
			}
		}

		// Token: 0x040000C3 RID: 195
		private static Person DarlingChan = new Person
		{
			Name = "Darling-Chan",
			Url = "https://meap.gg/"
		};

		// Token: 0x040000C4 RID: 196
		private static Person dragonGRaf = new Person
		{
			Name = "dragon GRaf",
			Url = "https://linktr.ee/dragongraf"
		};

		// Token: 0x040000C5 RID: 197
		private static Person falcon = new Person
		{
			Name = "falcon"
		};

		// Token: 0x040000C6 RID: 198
		private static Person GreenRosie = new Person
		{
			Name = "GreenRosie",
			Url = "https://www.twitch.tv/greenrosie"
		};

		// Token: 0x040000C7 RID: 199
		private static Person iRetrozx = new Person
		{
			Name = "iRetrozx#7283",
			Url = "https://posted.adalo.com/iretrozx"
		};

		// Token: 0x040000C8 RID: 200
		private static Person Julian = new Person
		{
			Name = "Julian",
			Url = "https://discord.com/oauth2/authorize?client_id=962323485772881950&scope=bot&permissions=8"
		};

		// Token: 0x040000C9 RID: 201
		private static Person MarcelGustin = new Person
		{
			Name = "Marcel Gustin",
			Url = "https://marcelgustin.de"
		};

		// Token: 0x040000CA RID: 202
		private static Person Matthww = new Person
		{
			Name = "Matthww"
		};

		// Token: 0x040000CB RID: 203
		private static Person TofixRs = new Person
		{
			Name = "Tofix.rs"
		};

		// Token: 0x040000CC RID: 204
		private static Person Yoshi = new Person
		{
			Name = "Yoshi"
		};

		// Token: 0x040000CD RID: 205
		private static Person westxlu = new Person
		{
			Name = "蘆筍 (aka westxlu)",
			Url = "https://linktr.ee/westxlu"
		};
	}
}
