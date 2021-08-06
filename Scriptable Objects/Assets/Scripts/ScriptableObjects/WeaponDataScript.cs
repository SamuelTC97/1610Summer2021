using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WeaponData", menuName = "Weapon Data", order = 51)]
public class WeaponDataScript: ScriptableObject
{
    [SerializeField]
    public string weaponName;

    [SerializeField]
    public string description;
   
    [SerializeField]
    public Sprite icon;
    
    [SerializeField]
    public int attackDamage;
 
    [SerializeField] 
    public int attackSpeed;
    
    [SerializeField] 
    public int attackRange;
}
