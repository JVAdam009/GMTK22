using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public CharacterBase character;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image artworkImage;

    public TextMeshProUGUI agility;
    public TextMeshProUGUI intelligence;
    public TextMeshProUGUI strength;
    public string characterClass;
    public string characterStatus;

    void Start()
    {
        nameText.text = character.Name;
        descriptionText.text = character.Text;
        artworkImage = character.Artwork;
        characterClass = character.Type;
        characterStatus = character.Status.ToString();
        agility.text = character.Abilities.Where(x => x.Type.Name == "Agility").Count().ToString();
        intelligence.text = character.Abilities.Where(x => x.Type.Name == "Intelligence").Count().ToString();
        strength.text = character.Abilities.Where(x => x.Type.Name == "Strength").Count().ToString();
    }
}
