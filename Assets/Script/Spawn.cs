using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform target;
    
    public void SpawnObject(GameObject obj)
    {
        Instantiate(obj, target.position, Quaternion.identity);
    }
}
