using UnityEngine;
public class Player : MonoBehaviour
{
    public static Player Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        transform.Rotate(90*Time.deltaTime,90*Time.deltaTime,90*Time.deltaTime);
        
        //dogru yazıyor fakat player rotation  ile gösterildiği gibi yazmadı örneğin -24 ü 336 olarak yazıyor. -li yazmıyor.
        PlayerVector.playerVector.x.text = transform.eulerAngles.x.ToString();
        PlayerVector.playerVector.y.text = transform.eulerAngles.y.ToString();
        PlayerVector.playerVector.z.text = transform.eulerAngles.z.ToString(); 
        
    }
}
