﻿using System;
using UnityEngine;

// Allows this class to be serialized.
[Serializable]
public class Character
{
    // If you haven't seen this #region thing before, it simply allows us to collapse the code grouped into regions, so it's easier to see in the IDE.
    #region Variables and Enums
    // The name of this character.
    [SerializeField] private string _characterName;
    // The type of this character.
    [SerializeField] private Enum_CharacterType _characterType;
    // The class of this character.
    [SerializeField] private Enum_CharacterClass _characterClass;
    // A reference for the gameobject this character is attached to.
    [SerializeField] private GameObject _classPrefab;

    // The ability scores for this character.
    [SerializeField] private AbilityScore _abilityScore;     //not serializable

    //This is h how you access enums from a class
    //Note: The enum must be public inorder to access it from another class

    //private PublicEnum.Enum1 enum1;
    //private PublicEnum.Enum2 enum2;
    //private PublicEnum.Enum3 enum3;

    //enum1 = PublicEnum.Enum1.Value1;
    //enum2 = PublicEnum.Enum2.Value2;
    //enum3 = PublicEnum.Enum3.Value3;
    // And the #endregion is what defines the end of a collapsable region.
    #endregion

    #region Properties
    //Shorthand properties
    // Public getter and setter methods for all of our variables and enums declared above.
    public string CharacterName { get => _characterName; set => _characterName = value; }
    public Enum_CharacterType CharacterType { get => _characterType; set => _characterType = value; }
    public Enum_CharacterClass CharacterClass { get => _characterClass; set => _characterClass = value; }
    public AbilityScore AbilityScore { get => _abilityScore; set => _abilityScore = value; }
    public GameObject ClassPrefab { get => _classPrefab; set => _classPrefab = value; }

    //The properties above but not shorthanded
    //public string ExpandedCharacterName
    //{
    //    get
    //    {
    //        return _characterName;
    //    }
    //    set
    //    {
    //        _characterName = value;
    //    }
    //}
    #endregion

    #region Constructors
    //Using c# global variables underscore prefix convention
    // Public constructor for a new Character.
    public Character(string characterName, Enum_CharacterType characterType,
        Enum_CharacterClass characterClass, AbilityScore abilityScore, GameObject classPrefab)
    {
        _characterName  = characterName;
        _characterType  = characterType;
        _characterClass = characterClass;
        _abilityScore   = abilityScore;
        _classPrefab    = classPrefab;
    }

    //Using this convention
    //public Character(string characterName, Enum_CharacterType characterType,
    //    Enum_CharacterClass characterClass, AbilityScore abilityScore, GameObject classPrefab)
    //{
    //    this.characterName  = characterName;
    //    this.characterType  = characterType;
    //    this.characterClass = character
    //    this.abilityScore   = abilityScore;
    //    this.classPrefab    = classPrefab;
    //}
    #endregion

    public override string ToString()
    {
        return $"Character Name: {_characterName}," +
            $" Character Type: {_characterType}," +
            $" Character Class: {_characterClass}," +
            $" Ability Score: {_abilityScore}," +
            $" Class Prefab: {_classPrefab}";
    }
}