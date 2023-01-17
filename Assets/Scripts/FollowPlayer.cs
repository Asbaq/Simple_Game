using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    Vector3 offset; 
    
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
