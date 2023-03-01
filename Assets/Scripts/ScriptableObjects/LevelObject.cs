using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Level", menuName = "Level")]
public class LevelObject : ScriptableObject
{
    public string displayName;
    public string sceneName;
    public bool unlocked = false;
}
