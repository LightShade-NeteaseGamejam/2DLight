using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [TextArea(3, 3)]
    public string[] sentences;
    //who is talking
    public string name;
}
