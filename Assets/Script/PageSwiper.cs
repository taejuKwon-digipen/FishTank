using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PageSwiper : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 PanelLocation;
    public float percentThreshold = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        PanelLocation = transform.position;
    }
  
    public void OnDrag(PointerEventData data)
    {
        float gap = data.pressPosition.x - data.position.x;
        transform.position = PanelLocation - new Vector3(gap, 0, 0);
    }
 
    public void OnEndDrag(PointerEventData data)
    {
        float percentage = (data.pressPosition.x - data.position.x) / Screen.width;

        if(Mathf.Abs(percentage) >= percentThreshold)
        {
            Vector3 newLocation = PanelLocation;
            if(percentage > 0)
            {
                newLocation += new Vector3(-Screen.width, 0, 0);
            }
            else if(percentage < 0){ 
                newLocation += new Vector3(Screen.width, 0, 0);
            }
            transform.position = newLocation;
            PanelLocation = newLocation;
        }else
        {
            transform.position = PanelLocation;
        }
       // PanelLocation = transform.position;
    }
}
