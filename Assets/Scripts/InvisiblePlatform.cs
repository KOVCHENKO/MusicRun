using UnityEngine;

public class InvisiblePlatform : MonoBehaviour
{
    // Platform positions
    private float _xPosition;
    private float _yPosition;
    
    private GameObject _player;
    private float _playersPosition;
    private float _playerJumpingPosition;
    
    private Vector3 _localScale;


    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        _playersPosition = _player.transform.position.x;
        _playerJumpingPosition = _player.transform.position.y;
        
        _xPosition = gameObject.transform.position.x;
        _yPosition = gameObject.transform.position.y;

        if (_playersPosition > _xPosition)
        {
            Debug.Log("Set invisible platform visibility to true");
            this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.x, 1, 1);
        }
        
        if (_playerJumpingPosition > _yPosition && _playersPosition > _xPosition - 1f)
        {
            Debug.Log("Set invisible platform visibility to true");
            this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.x, 1, 1);
        }
    }
}