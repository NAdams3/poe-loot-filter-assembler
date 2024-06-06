using app.Models;

namespace app.Services
{
    public class RolesService
    {
        public static readonly Rule[] BorderRules = new Rule[] {
            new Rule { 
                Name = "Chromatic",
                Conditions = new string[] {"SocketGroup RGB"},
                Effects = new string[] {"SetBorderColor 0 202 177"},
                IsStandalone = true,
            },
            new Rule {
                Name = "Quality",
                Conditions = new string[] {"Quality > 0"},
                Effects = new string[] {"SetBorderColor 255 255 255"},
                IsStandalone = false,
            },
        }

        public static readonly Rule[] FontRules = new Rule[] {
            new Rule {
                Name = "6 Sockets",
                Conditions = new string[] {"Sockets = 6"},
                Effects = new string[] {
                    "PlayEffect Brown",
                    "MinimapIcon 0 Brown Circle",
                    "SetFontSize 45",
                },
                IsStandalone = true,
            },
            new Rule { 
                Name = "6 Linked Sockets",
                Conditions = new string[] {"LinkedSockets = 6"},
                Effects = new string[] {
                    "PlayEffect Purple",
                    "MinimapIcon 0 Purple Circle",
                    "SetFontSize 45",
                },
                IsStandalone = true,
            },
            new Rule {
                Name = "5 Linked Sockets",
                Conditions = new string[] {"LinkedSockets = 5"},
                Effects = new string[] {
                    "PlayEffect Yellow",
                    "MinimapIcon 0 Yellow Circle",
                    "SetFontSize 45",
                },
                IsStandalone = true,
            },
            new Rule { 
                Name = "4 Linked Sockets",
                Conditions = new string[] {"LinkedSockets = 4"},
                Effects = new string[] {"SetFontSize 35"},
                IsStandalone = true,
            },
            new Rule {
                Name = "3 Links is Max Links",
                Conditions = new string [] {
                    "Class Sceptre Claw 'One Hand' Shield Wand Dagger",
                    "LinkedSockets = 3",
                },
                Effects = new string[] {"SetFontSize 35"},
                IsStandalone = true,
            },
            new Rule {
                Name = "3 Links Before 4 Links Available",
                Conditions = new string[] {
                    "ItemLevel < 25",
                    "LinkedSocets = 3",
                },
                Effects = new string[] {"SetFontSize 35"},
                IsStandalone = true,
            },
        }

        public static readonly Rule[] ColorRules = new Rule[] {
            new Rule {
                Name = "Unique",
                Conditions = new string[] {"Rarity > Rare"},
                Effects = new string[] {
                    "SetBackgroundColor 255 255 255",
                    "SetTextColor" 0 0 0",
                },
                IsStandalone = true,
            },
            new Rule {
                Name = "Rare",
                Conditions = new string[] {"Rarity = Rare"},
                Effects = new string[] {
                    "SetBackgroundColor 255 243 109",
                    "SetTextColor 0 0 0",
                },
                IsStandalone = true,
            },
            new Rule { 
                Name = "Magic",
                Conditions = new string[] {"Rarity = Magic"},
                Effects = new string[] {
                    "SetBackgroundColor 0 127 191",
                    "SetTextColor 0 0 0",
                },
                IsStandalone = false,
            },
        }

        public static string ProcessRules() {

            StringBuilder stringBuilder = new StringBuilder();

            foreach( var fontRule in FontRules ) {
                foreach( var colorRule in ColorRules ) {
                    foreach( var borderRule in BorderRules ) {
                        stringBuilder.AppendLine(fontRule.Name);
                        stringBuilder.AppendLine(colorRule.Name);
                        stringBuilder.AppendLine(borderRule.Name);
                    }
                }
                stringBuilder.AppendLine()
            }

            return stringBuilder.ToString();

        }

    }
}

