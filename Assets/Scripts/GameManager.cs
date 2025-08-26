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
        //Аасимар
        [SerializeField] TMP_Dropdown dropdownRace1;
        [SerializeField] GameObject[] chooseBlocks1;
        int currentPurpose = 0;
        //Гном
        [SerializeField] TMP_Dropdown dropdownRace2;
        [SerializeField] TMP_Dropdown dropdownRace2_1;
        [SerializeField] GameObject[] chooseBlocks2;
        int currentGenus = 0;
        int currentSpellCharacteristic = 0;
        //Голиаф
        [SerializeField] TMP_Dropdown dropdownRace3;
        [SerializeField] GameObject[] chooseBlocks3;
        int currentLegacy = 0;
        //Дварф
        //Драконорождённый
        [SerializeField] TMP_Dropdown dropdownRace5;
        int currentLegacyDragon = 0;
        //Орк
        //Полурослик
        //Тифлинг
        [SerializeField] TMP_Dropdown dropdownRace8;
        [SerializeField] TMP_Dropdown dropdownRace8_1;
        [SerializeField] GameObject[] chooseBlocks8;
        int currentLegacyBeast = 0;
        int currentSpellCharacteristic2 = 0;
        //Человек
        [SerializeField] TMP_Dropdown dropdownRace9;
        [SerializeField] GameObject[] chooseBlocks9;
        [SerializeField] TMP_Dropdown dropdownRace9_1;
        [SerializeField] GameObject[] chooseBlocks9_1;
        [SerializeField] TMP_Dropdown dropdownRace9_2_1;
        [SerializeField] GameObject[] chooseBlocks9_2_1;
        [SerializeField] TMP_Dropdown dropdownRace9_2_2;
        [SerializeField] GameObject[] chooseBlocks9_2_2;
        [SerializeField] TMP_Dropdown dropdownRace9_2_3;
        [SerializeField] GameObject[] chooseBlocks9_2_3;

        [SerializeField] GameObject[] chooseBlocksTools;
        [SerializeField] TMP_Dropdown dropdownRace9_3_1;
        [SerializeField] TMP_Dropdown dropdownRace9_3_2;
        [SerializeField] TMP_Dropdown dropdownRace9_3_3;

        [SerializeField] GameObject[] chooseBlocksSkilled;
        [SerializeField] TMP_Dropdown dropdownRace9SkilledSkill_1;
        [SerializeField] TMP_Dropdown dropdownRace9SkilledSkill_2;
        [SerializeField] TMP_Dropdown dropdownRace9SkilledSkill_3;
        [SerializeField] TMP_Dropdown dropdownRace9SkilledTool_1;
        [SerializeField] TMP_Dropdown dropdownRace9SkilledTool_2;
        [SerializeField] TMP_Dropdown dropdownRace9SkilledTool_3;
        [SerializeField] GameObject[] chooseBlocks9SkilledSkill_1;
        [SerializeField] GameObject[] chooseBlocks9SkilledSkill_2;
        [SerializeField] GameObject[] chooseBlocks9SkilledSkill_3;
        [SerializeField] GameObject[] chooseBlocks9SkilledTool_1;
        [SerializeField] GameObject[] chooseBlocks9SkilledTool_2;
        [SerializeField] GameObject[] chooseBlocks9SkilledTool_3;
        int currentSkill = 0;
        int currentTraitDescent = 0;
        int currentTool1 = 0;
        int currentTool2 = 0;
        int currentTool3 = 0;
        int currentMusicTool1 = 0;
        int currentMusicTool2 = 0;
        int currentMusicTool3 = 0;

        int currentSkilledSkill1 = 0;
        int currentSkilledSkill2 = 0;
        int currentSkilledSkill3 = 0;
        int currentSkilledTool1 = 0;
        int currentSkilledTool2 = 0;
        int currentSkilledTool3 = 0;
        //Эльф
        [SerializeField] TMP_Dropdown dropdownRace10;
        [SerializeField] TMP_Dropdown dropdownRace10_1;
        [SerializeField] GameObject[] chooseBlocks10;
        [SerializeField] TMP_Dropdown dropdownRace10_2;
        [SerializeField] GameObject[] chooseBlocks10_2;
        int currentGenus2 = 0;
        int currentSpellCharacteristic3 = 0;
        int currentSkillElf = 0;

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
        
        //Аасимар
        public void ChoosePurpose()
        {
            currentPurpose = dropdownRace1.value;
            foreach (var cur in chooseBlocks1)
            {
                cur.SetActive(false);
            }
            if (currentPurpose == 0) return;
            chooseBlocks1[currentPurpose - 1].SetActive(true);
        }
        //Гном
        public void ChooseGenus()
        {
            currentGenus = dropdownRace2.value;
            foreach (var cur in chooseBlocks2)
            {
                cur.SetActive(false);
            }
            if (currentGenus == 0) return;
            chooseBlocks2[currentGenus - 1].SetActive(true);
        }
        public void ChooseSpellCharGnome()
        {
            currentSpellCharacteristic = dropdownRace2_1.value;
        }
        //Голиаф
        public void ChooseLegacy()
        {
            currentLegacy = dropdownRace3.value;
            foreach (var cur in chooseBlocks3)
            {
                cur.SetActive(false);
            }
            if (currentLegacy == 0) return;
            chooseBlocks3[currentLegacy - 1].SetActive(true);
        }
        //Драконорождённый
        public void ChooseLegacyDragon()
        {
            currentLegacyDragon = dropdownRace5.value;
        }
        //Тифлинг
        public void ChooseLegacyBeast()
        {
            currentLegacyBeast = dropdownRace8.value;
            foreach (var cur in chooseBlocks8)
            {
                cur.SetActive(false);
            }
            if (currentLegacyBeast == 0) return;
            chooseBlocks8[currentLegacyBeast - 1].SetActive(true);
        }
        public void ChooseSpellCharTifling()
        {
            currentSpellCharacteristic2 = dropdownRace8_1.value;
        }
        //Человек
        public void ChooseSkill()
        {
            currentSkill = dropdownRace9.value;
            foreach (var cur in chooseBlocks9)
            {
                cur.SetActive(false);
            }
            if (currentSkill == 0) return;
            chooseBlocks9[currentSkill - 1].SetActive(true);
        }
        public void ChooseTraitDescent()
        {
            currentTraitDescent = dropdownRace9_1.value;
            foreach (var cur in chooseBlocks9_1)
            {
                cur.SetActive(false);
            }
            foreach (var cur2 in chooseBlocksTools)
            {
                cur2.SetActive(false);
            }
            foreach (var cur3 in chooseBlocksSkilled)
            {
                cur3.SetActive(false);
            }
        if (currentTraitDescent == 0) return;
            chooseBlocks9_1[currentTraitDescent - 1].SetActive(true);
            if (currentTraitDescent == 6)
            {
                foreach (var cur3 in chooseBlocksTools)
                {
                    cur3.SetActive(true);
                }
            }
            if (currentTraitDescent == 9)
            {
                foreach (var cur3 in chooseBlocksSkilled)
                {
                    cur3.SetActive(true);
                }
            }
    }
        public void ChooseTool1()
        {
            currentTool1 = dropdownRace9_2_1.value;
            foreach (var cur in chooseBlocks9_2_1)
            {
                cur.SetActive(false);
            }
            if (currentTool1 == 0) return;
            chooseBlocks9_2_1[currentTool1 - 1].SetActive(true);
        }
        public void ChooseTool2()
        {
            currentTool2 = dropdownRace9_2_2.value;
            foreach (var cur in chooseBlocks9_2_2)
            {
                cur.SetActive(false);
            }
            if (currentTool2 == 0) return;
            chooseBlocks9_2_2[currentTool2 - 1].SetActive(true);
        }
        public void ChooseTool3()
        {
            currentTool3 = dropdownRace9_2_3.value;
            foreach (var cur in chooseBlocks9_2_3)
            {
                cur.SetActive(false);
            }
            if (currentTool3 == 0) return;
            chooseBlocks9_2_3[currentTool3 - 1].SetActive(true);
        }
        public void ChooseMusicTool1()
        {
            currentMusicTool1 = dropdownRace9_3_1.value;
        }
        public void ChooseMusicTool2()
        {
            currentMusicTool2 = dropdownRace9_3_2.value;
        }
        public void ChooseMusicTool3()
        {
            currentMusicTool3 = dropdownRace9_3_3.value;
        }
        public void ChooseSkilledSkill1()
        {
            currentSkilledSkill1 = dropdownRace9SkilledSkill_1.value;
            foreach (var cur in chooseBlocks9SkilledSkill_1)
            {
                cur.SetActive(false);
            }
            if (currentSkilledSkill1 > 0)
            {
                currentSkilledTool1 = 0;
                foreach (var cur in chooseBlocks9SkilledTool_1)
                {
                    cur.SetActive(false);
                }
                dropdownRace9SkilledTool_1.value = 0;
                chooseBlocks9SkilledSkill_1[currentSkilledSkill1 - 1].SetActive(true);
            }
        }
        public void ChooseSkilledTool1()
        {
            currentSkilledTool1 = dropdownRace9SkilledTool_1.value;
            foreach (var cur in chooseBlocks9SkilledTool_1)
            {
                cur.SetActive(false);
            }
            if (currentSkilledTool1 > 0)
            {
                currentSkilledSkill1 = 0;
                foreach (var cur in chooseBlocks9SkilledSkill_1)
                {
                    cur.SetActive(false);
                }
                dropdownRace9SkilledSkill_1.value = 0;
                chooseBlocks9SkilledTool_1[currentSkilledTool1 - 1].SetActive(true);
            }
        }
        public void ChooseSkilledSkill2()
        {
            currentSkilledSkill2 = dropdownRace9SkilledSkill_2.value;
            foreach (var cur in chooseBlocks9SkilledSkill_2)
            {
                cur.SetActive(false);
            }
            if (currentSkilledSkill2 > 0)
            {
                currentSkilledTool2 = 0;
                foreach (var cur in chooseBlocks9SkilledTool_2)
                {
                    cur.SetActive(false);
                }
                dropdownRace9SkilledTool_2.value = 0;
                chooseBlocks9SkilledSkill_2[currentSkilledSkill2 - 1].SetActive(true);
            }
        }
        public void ChooseSkilledTool2()
        {
            currentSkilledTool2 = dropdownRace9SkilledTool_2.value;
            foreach (var cur in chooseBlocks9SkilledTool_2)
            {
                cur.SetActive(false);
            }
            if (currentSkilledTool2 > 0)
            {
                currentSkilledSkill2 = 0;
                foreach (var cur in chooseBlocks9SkilledSkill_2)
                {
                    cur.SetActive(false);
                }
                dropdownRace9SkilledSkill_2.value = 0;
                chooseBlocks9SkilledTool_2[currentSkilledTool2 - 1].SetActive(true);
            }
        }
        public void ChooseSkilledSkill3()
        {
            currentSkilledSkill3 = dropdownRace9SkilledSkill_3.value;
            foreach (var cur in chooseBlocks9SkilledSkill_3)
            {
                cur.SetActive(false);
            }
            if (currentSkilledSkill3 > 0)
            {
                currentSkilledTool3 = 0;
                foreach (var cur in chooseBlocks9SkilledTool_3)
                {
                    cur.SetActive(false);
                }
                dropdownRace9SkilledTool_3.value = 0;
                chooseBlocks9SkilledSkill_3[currentSkilledSkill3 - 1].SetActive(true);
            }
        }
        public void ChooseSkilledTool3()
        {
            currentSkilledTool3 = dropdownRace9SkilledTool_3.value;
            foreach (var cur in chooseBlocks9SkilledTool_3)
            {
                cur.SetActive(false);
            }
            if (currentSkilledTool3 > 0)
            {
                currentSkilledSkill3 = 0;
                foreach (var cur in chooseBlocks9SkilledSkill_3)
                {
                    cur.SetActive(false);
                }
                dropdownRace9SkilledSkill_3.value = 0;
                chooseBlocks9SkilledTool_3[currentSkilledTool3 - 1].SetActive(true);
            }
        }
        //Эльф
        public void ChooseGenusElf()
        {
            currentGenus2 = dropdownRace10.value;
            foreach (var cur in chooseBlocks10)
            {
                cur.SetActive(false);
            }
            if (currentGenus2 == 0) return;
            chooseBlocks10[currentGenus2 - 1].SetActive(true);
        }
        public void ChooseSpellCharElf()
        {
            currentSpellCharacteristic3 = dropdownRace10_1.value;
        }
        public void ChooseSkillElf()
        {
            currentSkillElf = dropdownRace10_2.value;
            foreach (var cur in chooseBlocks10_2)
            {
                cur.SetActive(false);
            }
            if (currentSkillElf == 0) return;
            chooseBlocks10_2[currentSkillElf - 1].SetActive(true);
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
