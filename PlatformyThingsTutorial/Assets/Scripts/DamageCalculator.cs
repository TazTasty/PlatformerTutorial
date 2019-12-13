using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SimpleFunction();
        int dmg = DamageCalc(15, 3);

    }
    void SimpleFunction()
    {
        Debug.Log("Hello there!");
    }

    public int DamageCalc(int damage, int armor)
    {
        Debug.Log("You deal" + (damage - armor) + "damage");
        return damage - armor;
    }
}
