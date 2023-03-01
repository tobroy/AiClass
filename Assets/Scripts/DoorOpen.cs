using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    
    public float WaitTime = 3f;
    public float Speed = 5f;
    public Vector3 PositionDelta = Vector3.zero;

    private Vector3 _openPosition;
    private Vector3 _closePosition;
    

    // Start is called before the first frame update
    void Start()
    {
        _openPosition = _closePosition + PositionDelta;
        _closePosition = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _openPosition, Speed * Time.deltaTime);
    }

    IEnumerator OpenClose()
    {
        yield return new WaitForSeconds(WaitTime);

        
    }
}
