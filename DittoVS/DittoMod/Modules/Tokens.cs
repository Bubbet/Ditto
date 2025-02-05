﻿using R2API;
using System;

namespace DittoMod.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region Ditto
            string prefix = DittoPlugin.developerPrefix + "_DITTO_BODY_";

            string desc = "Ditto can transform into any character/monster<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Ditto copies every stat besides regen, armor and movespeed. The transformation will have 10% of its Max HP + Ditto's Max HP" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Use Ditto's equipment to transform back to ditto. It can also drop naturally" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Ditto's secondary and utility skills are items that when activated give buffs that are carried over when transformed as well" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Aim to increase your HP as he has low base HP" + Environment.NewLine + Environment.NewLine;



            string outro = "..and so it left, ever evolving.";
            string outroFailure = "Ditto has Fainted.";

            LanguageAPI.Add(prefix + "NAME", "Ditto");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "The Transform Pokémon");
            LanguageAPI.Add(prefix + "LORE", "Pokemon #132. Normal Type. Altering every cell in its body, Ditto can transform into a perfect copy of many different Pokémon.");
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Shiny");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Ability");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "Ditto comes with an equipment that transform yourself into a ditto.<style=cIsUtility> Ditto has a double jump. He can sprint in any direction.</style>");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_NAME", "Struggle");
            LanguageAPI.Add(prefix + "PRIMARY_DESCRIPTION", $"<style=cIsDamage>Agile.</style> Struggle around, dealing <style=cIsDamage>{100f * StaticValues.struggleDamageCoefficient}%</style>" + " multiple times.");
            #endregion

            #region Items
            LanguageAPI.Add(prefix + "CHOICEBAND_NAME", "Choice Band");
            LanguageAPI.Add(prefix + "CHOICEBAND_DESCRIPTION", $"Equip a Choice Band, granting <style=cIsDamage>{100f * (StaticValues.choicebandboost - 1f)}%</style>" + " attackspeed</style>.");
            LanguageAPI.Add(prefix + "CHOICESCARF_NAME", "Choice Scarf");
            LanguageAPI.Add(prefix + "CHOICESCARF_DESCRIPTION", $"Equip a Choice Scarf, granting <style=cIsDamage>{100f * (StaticValues.choicescarfboost - 1f)}%</style>" + " movespeed</style>.");
            LanguageAPI.Add(prefix + "CHOICESPECS_NAME", "Choice Specs");
            LanguageAPI.Add(prefix + "CHOICESPECS_DESCRIPTION", $"Equip a Choice Specs, granting <style=cIsDamage>{100f * (StaticValues.choicespecsboost - 1f)}%</style>" + " damage</style>.");
            LanguageAPI.Add(prefix + "LEFTOVERS_NAME", "Leftovers");
            LanguageAPI.Add(prefix + "LEFTOVERS_DESCRIPTION", $"Equip a Leftovers, granting " + Helpers.Passive($"{100f * (StaticValues.leftoversregen)}% of your max health regen") + " per second</style>.");
            LanguageAPI.Add(prefix + "ROCKYHELMET_NAME", "Rocky Helmet");
            LanguageAPI.Add(prefix + "ROCKYHELMET_DESCRIPTION", $"Equip a Rocky Helmet, dealing <style=cIsDamage>{100f * StaticValues.rockyhelmetreflect}% damage</style>" + " to attackers</style>.");
            LanguageAPI.Add(prefix + "SCOPELENS_NAME", "Scope Lens");
            LanguageAPI.Add(prefix + "SCOPELENS_DESCRIPTION", $"Equip a Scope Lens, granting <style=cIsDamage>{StaticValues.scopelensboost}%</style>" + " critical hit chance</style>.");
            LanguageAPI.Add(prefix + "SHELLBELL_NAME", "Shell Bell");
            LanguageAPI.Add(prefix + "SHELLBELL_DESCRIPTION", $"Equip a Shell Bell, granting <style=cIsDamage>{100f * (StaticValues.shellbelllifesteal)}%</style>" + " lifesteal</style>.");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_NAME", "Transform");
            LanguageAPI.Add(prefix + "SPECIAL_DESCRIPTION", $"Transform into the character you're looking at.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Ditto: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Ditto, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Ditto: Mastery");
            #endregion
            #endregion


        }
    }
}
