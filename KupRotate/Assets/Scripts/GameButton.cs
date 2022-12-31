using System.Collections;
using UnityEngine;

public class GameButton : MonoBehaviour
{

    public bool isHit;
    public Vector3 playerVector3;
    public void OnClick()
    {
        playerVector3.x = Player.Instance.transform.rotation.eulerAngles.x;
        playerVector3.y = Player.Instance.transform.rotation.eulerAngles.y;
        playerVector3.z = Player.Instance.transform.rotation.eulerAngles.z;
        
        Debug.Log("onClick");
        
        if (Mathf.Abs(playerVector3.x)<=32 && Mathf.Abs(playerVector3.x)>= -21  && !isHit)
        {
                isHit = true;
                StartCoroutine(ResetHit());
                Counter.counter.IncreaseCounter();
                Debug.Log(" x ");
            
        }
        if (Mathf.Abs(playerVector3.y)<=109 && Mathf.Abs(playerVector3.y)>=80  && !isHit)
        {
                isHit = true;
                StartCoroutine(ResetHit());
                Counter.counter.IncreaseCounter();
                Debug.Log(" y ");
        }
        if (Mathf.Abs(playerVector3.x)<=120 && Mathf.Abs(playerVector3.x)>=70  && !isHit)
        {
                isHit = true;
                StartCoroutine(ResetHit());
                Counter.counter.IncreaseCounter();
                Debug.Log(" z ");
        }
    }

    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(1.0f);
        isHit = false;
    }



}
