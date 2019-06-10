using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VrtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointDownHandler
{
    private Image bgImg;
    private Image JoystickImage;
    private Vector3 inputVector;

    private void Start(){
        bgImg = GetComponent<Image>();
        JoystickImage = trnsform.GetChild(0).GetComponent<Image>();
    }
    public virtual void OnDarg(PointerEventData ped) {
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform, ped.Position, ped.pressEventCamera, out pos)){
            Debug.log("Hey i...");
        }
    }
    public virtual void OnPointerDown(PointerEventData ped) {
        
    }
    public virtual void OnPointerUp(PointerEventData ped) {
        
    }
}
