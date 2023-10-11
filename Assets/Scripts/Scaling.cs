using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private readonly Vector3 _maxScale = new Vector3(2, 2, 2);
    
    public void Update()
    {
        if(transform.localScale.x < _maxScale.x)
        {
            transform.localScale += new Vector3(_scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime);
        }
    }
}
