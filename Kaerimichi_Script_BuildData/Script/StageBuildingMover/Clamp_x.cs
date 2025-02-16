using UnityEngine;

public class Clamp_x : MonoBehaviour
{
    [Header("移動範囲")]
    [SerializeField] private float minPos_x;
    [SerializeField] private float maxPos_x;

   private void Update()
    {
        SetLimitPos_x();
    }

    private void SetLimitPos_x()
    {
        //Xについて移動範囲の制限を行う
        if(transform.position.x < minPos_x)
        {
            transform.position = new Vector3(minPos_x,
                                             transform.position.y,
                                             transform.position.z);
        }
        if(transform.position.x > maxPos_x)
        {
            transform.position = new Vector3(maxPos_x,
                                             transform.position.y,
                                             transform.position.z);
        }
    }
}
