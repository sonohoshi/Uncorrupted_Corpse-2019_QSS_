using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public static Joystick Instance { private set; get; }

    private Image bgImg;
    private Image JoystickImg;
    private Vector3 inputVector;
    private Vector3 NormalattackVector;
    
    void Awake()
    {
        Instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        bgImg = GetComponent<Image>();
        JoystickImg = transform.GetChild(0).GetComponent<Image>();
        NormalattackVector.x = 0.0f;
        NormalattackVector.y = 1.0f;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Debug.Log("Joystick >>> OnDrag()");
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform,ped.position,ped.pressEventCamera,out pos))
        {
            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x); // 조이스틱백그라운드 이미지에 대한 위치에 따라 값을 저장함.
            pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);

            inputVector = new Vector3(pos.x * 2, pos.y * 2, 0); // 조이스틱 상하좌우로 움직일 때 pos의 x값과 y값을 벡터값으로 바꿔줌.
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;
            // Joystick가 중심으로부터 벗어난 값에 따른 방향을 처리해주기 위한 정규화
            JoystickImg.rectTransform.anchoredPosition = new Vector3(inputVector.x * (bgImg.rectTransform.sizeDelta.x / 3)
                                                                    , inputVector.y * (bgImg.rectTransform.sizeDelta.y / 3));
            // JoystickIMG 이동시키는 작업
        }
    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped); // 조이스틱을 누르고 있을 때 실행됨
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        NormalattackVector = inputVector; // 떼기 직전의 마지막 바라보고 있던 방향의 벡터값을 공격용으로 리턴하기 위하여
        Debug.Log(NormalattackVector.x);
        Debug.Log(NormalattackVector.y);
        inputVector = Vector3.zero; // 조이스틱에서 손을 뗄 경우, 벡터값을 초기화 해줌
        JoystickImg.rectTransform.anchoredPosition = Vector3.zero;
    }
    public float GetHorizontalValue()
    {
        return inputVector.x; // 플레이어컨트롤러와 상호작용을 하기 위하여
    }
    public float GetVerticalValue()
    {
        return inputVector.y;
    }
    public float attackHorizontalValue() // 어택과 상호작용을 하기 위하여
    {
        return NormalattackVector.x;
    }
    public float attackVerticalValue()
    {
        return NormalattackVector.y;
    }
}
