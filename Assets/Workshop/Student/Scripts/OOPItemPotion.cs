using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity
{
    /*public string Name;
    public int positionX;
    public int positionY;
    public OOPMapGenerator mapGenerator;*/
    public int healPoint;
    public bool isBonus;
    public void Start()
    {
        
    }
    public override void Hit()
    {
        mapGenerator.player.Heal(healPoint);
        Destroy(gameObject);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
    }
}