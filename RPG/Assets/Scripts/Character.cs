using UnityEngine;

public class Character
{
    Enums.AbilityScoreNames AbilityScoreNames;
    Enums.CharacterClass CharacterClass;
    Enums.CharacterType CharacterType;

    public struct AbilityScores
    {
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;

    }

    public AbilityScores score;
    public GameObject prefab;
    public string characterName;

    public Character(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, string name)
    {
        score.Strength = strength;
        score.Dexterity = dexterity;
        score.Constitution = constitution;
        score.Intelligence = intelligence;
        score.Wisdom = wisdom;
        score.Charisma = charisma;
        characterName = name;

    }    

    public int GetAbilityScoreBonus(Enums.AbilityScoreNames abilityName)
    {
        int mod = 0;

        if (abilityName == Enums.AbilityScoreNames.Strength)
        {
            if (score.Strength <= 2) { mod = -1; };
            if (score.Strength == 3 || score.Strength == 4) { mod = 0; };
            if (score.Strength == 5 || score.Strength == 6) { mod = 1; };
            if (score.Strength == 7 || score.Strength == 8) { mod = 2; };
            if (score.Strength >= 9) { mod = 3; };
        }

        if (abilityName == Enums.AbilityScoreNames.Dexterity)
        {
            if (score.Dexterity <= 2) { mod = -1; };
            if (score.Dexterity == 3 || score.Dexterity == 4) { mod = 0; };
            if (score.Dexterity == 5 || score.Dexterity == 6) { mod = 1; };
            if (score.Dexterity == 7 || score.Dexterity == 8) { mod = 2; };
            if (score.Dexterity >= 9) { mod = 3; };
        }

        if (abilityName == Enums.AbilityScoreNames.Constitution)
        {
            if (score.Constitution <= 2) { mod = -1; };
            if (score.Constitution == 3 || score.Constitution == 4) { mod = 0; };
            if (score.Constitution == 5 || score.Constitution == 6) { mod = 1; };
            if (score.Constitution == 7 || score.Constitution == 8) { mod = 2; };
            if (score.Constitution >= 9) { mod = 3; };
        }

        if (abilityName == Enums.AbilityScoreNames.Intelligence)
        {
            if (score.Intelligence <= 2) { mod = -1; };
            if (score.Intelligence == 3 || score.Intelligence == 4) { mod = 0; };
            if (score.Intelligence == 5 || score.Intelligence == 6) { mod = 1; };
            if (score.Intelligence == 7 || score.Intelligence == 8) { mod = 2; };
            if (score.Intelligence >= 9) { mod = 3; };
        }

        if (abilityName == Enums.AbilityScoreNames.Strength)
        {
            if (score.Wisdom <= 2) { mod = -1; };
            if (score.Wisdom == 3 || score.Wisdom == 4) { mod = 0; };
            if (score.Wisdom == 5 || score.Wisdom == 6) { mod = 1; };
            if (score.Wisdom == 7 || score.Wisdom == 8) { mod = 2; };
            if (score.Wisdom >= 9) { mod = 3; };
        }

        if (abilityName == Enums.AbilityScoreNames.Strength)
        {
            if (score.Charisma <= 2) { mod = -1; };
            if (score.Charisma == 3 || score.Charisma == 4) { mod = 0; };
            if (score.Charisma == 5 || score.Charisma == 6) { mod = 1; };
            if (score.Charisma == 7 || score.Charisma == 8) { mod = 2; };
            if (score.Charisma >= 9) { mod = 3; };
        }


        return mod;

    }

}
