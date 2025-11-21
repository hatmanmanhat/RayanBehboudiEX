using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(target.transform.localPosition.x, 
            target.transform.localPosition.y, -10);
    }
}
