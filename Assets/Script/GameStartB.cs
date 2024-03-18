using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartB : MonoBehaviour
{
    // Start is called before the first frame update

    public SwipeUI swipe;
    public Button btn;

    void Start()
    {
        btn.gameObject.SetActive(true);
        //GetComponent<Button>().interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (swipe.currentPage == 0)
        {
            print("게임 스타트 버튼 활성화");
            btn.gameObject.SetActive(true);
        }
        else
        {
            print("게임 스타트 버튼 비활성화");
            btn.gameObject.SetActive(false);
        }
    }
}

