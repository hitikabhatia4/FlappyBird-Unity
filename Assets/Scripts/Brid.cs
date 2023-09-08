
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Brid : MonoBehaviour
{
    
    Vector3 startingPos;
    private Vector2 directiontoIntialPos;
    private float directionToIntialPosForce;
    private bool BirdWasThrown;

    float TimeSinceLaunch;

    AudioSource source;

    public AudioClip TensionClip;
    public AudioClip LaunchClip;

    

    private void Awake()
    {
        startingPos = transform.position;
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, startingPos);

        if (transform.position.x <= -40 
            || transform.position.y <= -17
            || transform.position.y >= 14
            || transform.position.x >= 40
            || TimeSinceLaunch>=10f)
            
        {
            string currentLoadScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("TryAgain");

        }
        if(BirdWasThrown== true && 
            GetComponent<Rigidbody2D>().velocity.magnitude < 10f)
        {
            TimeSinceLaunch += Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            string currentLoadScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentLoadScene);
        }


    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.blue;
        GetComponent<LineRenderer>().enabled = true;
        source.clip = TensionClip;
        source.Play();
    }
    private void OnMouseUp()
    {
        BirdWasThrown = true;

        GetComponent<SpriteRenderer>().color = Color.white;
        directiontoIntialPos = startingPos - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directiontoIntialPos * 300);

        GetComponent<Rigidbody2D>().gravityScale = 1;

        GetComponent<LineRenderer>().enabled = false;
        source.clip = TensionClip;
        source.Play();


    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y, 0);
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("banana"))
        {
            Destroy(other.gameObject);
        }

        StartCoroutine(example());




    }

    IEnumerator example()
    {
        yield return new WaitForSecondsRealtime(20f);
    }
}
