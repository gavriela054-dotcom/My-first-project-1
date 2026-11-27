using System.Runtime.CompilerServices;
using UnityEngine;

public class suncirckl : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
      transform.Rotate (Vector3.right * Time.deltaTime * speed ); 
    }
}
