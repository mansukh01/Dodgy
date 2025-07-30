using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0.01f;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0.01f;

       void Start()
    {
         
    }

        void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
