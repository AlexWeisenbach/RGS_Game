using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour {

    //SerializeField allows private variables to appear in the Unity Inspector.
    [SerializeField]
    private Text _text;

    [SerializeField]
    private float _textPause;

    //Declare different states to trigger animations for the box.
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
        //Instantiate box in hidden state and import the animator in.
        _state = State.Hidden;
        _animator = GetComponent<Animator>();
    }
    
    public void Appear (string str)
    {
        //Changes state, plays the appear animation, then displays str.
        _state = State.Appearing;
        _animator.Play("Appear");
        _displayText = str;
        //Reset dialogue box so old text no longer appears.
        _text.text = " ";
    }

    public void OnAppearFinish ()
    {
        //Changes state, plays a static animation so box remains on screen, sets timer for text crawling.
        _state = State.Crawling;
        _animator.Play("Visible");
        _timer = _textPause;
        _textLength = 0;
    }

    public void Disappear ()
    {
        //Changes state, makes box leave screen.
        _state = State.Disappearing;
        _animator.Play("Disappear");
        transform.parent.gameObject.SetActive(false);
    }

    public void OnDisappearFinish ()
    {
        //Changes state, returns to static animation off-screen.
        _state = State.Hidden;
        _animator.Play("Hidden");

    }



    // Update is called once per frame
    void Update () {
        //Switch to create different functions in different states.
	    switch (_state)
        {
            //Animate a text crawl using a timer that was previously set to _textLength.
            //From there, text is displayed a letter at a time until all text is on-screen.
            //_textPause can be changed in the inspector to make text crawl at different speeds.
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
            //Once text is done crawling, player can press space to remove dialogue box from screen.
            case State.Waiting:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    Disappear();
                   
                }
                break;
            //If key is pressed, display text. Edit the argument to account for interactable argument or ray-casting.
            case State.Hidden:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    Appear("Hello");
                }
                break;



            default:
                break;


        }
	}
}
