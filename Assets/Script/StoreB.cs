using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreB : MonoBehaviour
{
    public SwipeUI swipe;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (swipe.currentPage == 0)
        {
            print("게임 스타트 버튼 비활성화");
            btn.gameObject.SetActive(false);
        }
        else
        {
            print("게임 스타트 버튼 활성화");
            btn.gameObject.SetActive(true);
        }
    }
}
