using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour {

    [SerializeField]
    private Text _text;

    [SerializeField]
    private float _textPause;

    public enum State
    {
        Hidden,
        Appearing,
        Crawling,
        Waiting,
        Disappearing
    }

    private State _state;
    private Animator _animator;
    private int _textLength;
    private float _timer;
    private string _displayText;
    
    void Awake()
    {
        _state = State.Hidden;
        _animator = GetComponent<Animator>();
    }
    
    public void Appear (string str)
    {
        //Do something.
        _state = State.Appearing;
        _animator.Play("Appear");
        _displayText = str;
        _text.text = " ";
    }

    public void OnAppearFinish ()
    {
        // //Do something.
        _state = State.Crawling;
        _animator.Play("Visible");
        _timer = _textPause;
        _textLength = 0;
    }

    public void Disappear ()
    {
        //Do something.
        _state = State.Disappearing;
        _animator.Play("Disappear");
    }

    public void OnDisappearFinish ()
    {
        //Do something.
        _state = State.Hidden;
        _animator.Play("Hidden");

    }



    // Update is called once per frame
    void Update () {
	    switch (_state)
        {
            case State.Crawling:
                _timer -= Time.deltaTime;
                if(_timer <= 0)
                {
                    ++_textLength;
                    _text.text = _displayText.Substring(0, _textLength);
                }
                if (_textLength >= _displayText.Length)
                {
                    _state = State.Waiting;
                }
                break;
            case State.Waiting:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Disappear();
                   
                }
                break;

            case State.Hidden:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Appear("Hello");
                }
                break;



            default:
                break;


        }
	}
}
