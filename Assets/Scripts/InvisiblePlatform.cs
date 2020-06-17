using UnityEngine;

public class InvisiblePlatform : MonoBehaviour
{
    private float _xPosition;
    private GameObject _player;
    private float _playersPosition;


    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        _playersPosition = _player.transform.position.x;      
        _xPosition = this.gameObject.transform.position.x;

        
        Debug.Log("Platform Position:" + _xPosition);
        Debug.Log("PLayers Position:" + _playersPosition);

        if (_playersPosition > _xPosition)
        {
            Debug.Log("Set visibility to true");

            // Make sprite visible    
            _xPosition = _playersPosition;
            // this.gameObject.SetActive(true);
        }
    }
}