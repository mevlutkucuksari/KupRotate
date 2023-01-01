using UnityEngine;
using TMPro;

public class PlayerVector : MonoBehaviour
{
    public static PlayerVector playerVector;
    public TMP_Text x, y, z;
    private void Awake()
    {
        playerVector = this;
       
    }

}
