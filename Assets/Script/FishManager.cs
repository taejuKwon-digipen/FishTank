using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FishStatusInfo
{
    public string Name = "";
    public int Cost;
    public bool CanBuy = false;
    public bool Have = false;
}
/*public class FishStats
{
    [SerializeField]
    private int hunger;
    private int pain;

    public void GetStats()
    {
        return hunger;
    }
}*/

[System.Serializable]
public class FishManager : MonoBehaviour
{
     List<FishStatusInfo> FishList = new List<FishStatusInfo>();

   public void setFishList( string name, int cost, bool canbuy, bool have)
    {
         FishStatusInfo Fishinfo = new FishStatusInfo();
         Fishinfo.Name = name;
         Fishinfo.Cost = cost;
         Fishinfo.CanBuy = canbuy;
         Fishinfo.Have = have;
        FishList.Add(Fishinfo);
    }

    public void deleteFishList(int indextoremove)
    {
        FishList.RemoveAt(indextoremove);
    } 
    // FishStatusInfo Fishinfo = new FishStatusInfo()

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
