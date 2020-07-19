using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInit : MonoBehaviour
{
    private void Awake()
    {
        //PlayerPrefs.DeleteAll();

        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform levelObject = transform.GetChild(i);
            var objectName = levelObject.name;
            objectName = objectName.TrimStart('1').Replace("(", "").Replace(")", "");
            if (int.TryParse(objectName, out int levelNumber))
            {
                var level = levelObject.GetComponent<Level>();
                level.LevelNumber = levelNumber + 1;
                level.Locked = GameState.LevelReached < level.LevelNumber;
                level.Stars = GameState.GetLevelStars(level.LevelNumber);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
