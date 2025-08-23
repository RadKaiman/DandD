using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] public Race[] races;
    [SerializeField] public ClassChar[] classes;
    [SerializeField] public Origin[] origins;
    [SerializeField] public Weapon[] weapons;
    [SerializeField] public Armor[] armors;

    //Расы переменные
    int currentRace = 0;
    [SerializeField] TMP_Dropdown dropdownRaces;
    [SerializeField] GameObject[] scrollViews;

    private void Start()
    {
        for(int i = 1; i <= races.Length; i++)
        {
            dropdownRaces.options[i].text = races[i-1].name;
        }
        
    }

    //Расы функции
    public void ChooseRace()
    {
        currentRace = dropdownRaces.value;
        foreach (var cur in scrollViews)
        {
            cur.SetActive(false);
        }
        if (currentRace == 0) return;
        scrollViews[currentRace-1].SetActive(true);
    }
}

public enum Characteristics
{
    Strength,
    Agility,
    Endurance,
    Intelligence,
    Wisdom,
    Charisma
}

[System.Serializable]
public class Race
{
    public string name;
}

[System.Serializable]
public class ClassChar
{
    public string name;
}

[System.Serializable]
public class Origin
{
    public string name;
}

[System.Serializable]
public class Weapon
{
    public string name;
}

[System.Serializable]
public class Armor
{
    public string name;
}
