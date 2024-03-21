using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishManager : MonoBehaviour
{
    public FishStat fishs;
    List<FishStat> fishlist = new List<FishStat>();

    public void SetFishList(string Name, int Hunger, bool Canbuy, int Cost)
    {
        fishs.name = Name;
        fishs.hunger = Hunger;
        fishs.canbuy = Canbuy;
        fishs.cost = Cost;

        fishlist.Add(fishs);
    }
    public string ReturnName(int number)
    {
        string ret = fishlist[number].name;
        return ret;
    }

    public int ReturnCost(int number)
    {
        int ret = fishlist[number].cost;
        return ret;
    }

    public int ReturnHunger(int number)
    {
        int ret = fishlist[number].hunger;
        return ret;
    }


}
