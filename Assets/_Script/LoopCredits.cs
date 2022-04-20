using UnityEngine;

public class LoopCredits : MonoBehaviour
{
    [SerializeField] private float speedScroll = default;
    [SerializeField] public GameObject _textMove = default;
    [SerializeField] public float _inicioPositionText = default;
    [SerializeField] public float _positionMax = default;

    private void Update()
    {
        if (_textMove.transform.position.y <= _positionMax)
        {
            transform.Translate(Vector2.up * speedScroll * Time.deltaTime);
        }
    }
    private void Start()
    {
        PointInitialText();
    }

    private void PointInitialText()
    {
         _inicioPositionText = _textMove.transform.localPosition.y;
    }
}
