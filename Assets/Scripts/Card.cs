using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    #region Attributes

    private string name; // Card name
    private Sprite icon; // Sprite icon for board apperence
    private int level; // The level of difficulty/category
    private int points; // The amount of points you get for completing the project
    private List<string> resources; // A list of skill cards required to finish the project
    private List<string> requiredFacilities; // A list of already finished projects that have to be in place to build this one
    private string desc;// Description/info about how to build the card
    #endregion


}
