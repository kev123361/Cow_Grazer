using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicSlider : MonoBehaviour {
	public GameController gc;

    private Slider slider;
    public GameObject grass;
    public Canvas canvas;
    public GameObject cow;
    public GameObject addMoneyText;

    public GameObject marveloustext;
    public GameObject goodtext;
    public GameObject bootext;
    public GameObject greattext;
    public GameObject perfecttext;

    private float t;
    private bool alternate;
    private float hiddenEatProgress = 0f;
    private Animator anim;
    public GameObject xkey;
    public GameObject zkey;
	// Use this for initialization
	void Start () {
        slider = this.GetComponent<Slider>();
        anim = cow.GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
        switch (gc.eatingRate) {
            case (0):
                xkey.SetActive(true);
                if (Input.GetKeyDown(KeyCode.X))
                {
                    slider.value += .05f;
                }
                if (slider.value == 1f)
                {
                    GrassEaten();
                }
                break;
            case (1):
                xkey.SetActive(true);
                zkey.SetActive(true);
                if (Input.GetKeyDown(KeyCode.X) && alternate)
                {
                    slider.value += .1f;
                    alternate = !alternate;
                } else if (Input.GetKeyDown(KeyCode.Z) && !alternate)
                {
                    slider.value += .1f;
                    alternate = !alternate;
                }
                if (slider.value == 1f)
                {
                    GrassEaten();
                }
                break;
            case (2):
                xkey.SetActive(true);
                if (Input.GetKeyDown(KeyCode.X))
                {
                    if (slider.value > .35f && slider.value < .65f)
                    {
                        hiddenEatProgress += .25f;
                        Instantiate(marveloustext, canvas.transform);
                    }
                    else if (slider.value > .2f && slider.value < .8f)
                    {
                        hiddenEatProgress += .15f;
                        Instantiate(goodtext, canvas.transform);
                    }
                    else
                    {
                        hiddenEatProgress += .05f;
                        Instantiate(bootext, canvas.transform);
                    }

                }
                if (alternate)
                {
                    slider.value = Mathf.Lerp(slider.value, 1f, t);
                } else
                {
                    slider.value = Mathf.Lerp(slider.value, 0f, t);
                }
                if (slider.value == 1f)
                {
                    alternate = false;
                    t = 0f;
                }
                if (slider.value <= .000001f)
                {
                    alternate = true;
                    t = 0f;
                }

             
                if (hiddenEatProgress >= 1f)
                {
                    GrassEaten();
                }

                t += Time.deltaTime * .6f;
                break;
            case (3):
                xkey.SetActive(true);
                if (Input.GetKey(KeyCode.X))
                {
                    slider.value = Mathf.Lerp(slider.value, slider.value + .5f, Time.deltaTime);
                }
                if (slider.value == 1f)
                {
                    int rand = Random.Range(1, 5);
                    switch (rand)
                    {
                        case (1):
                            Instantiate(marveloustext, canvas.transform);
                            break;
                        case (2):
                            Instantiate(goodtext, canvas.transform);
                            break;
                        case (3):
                            Instantiate(perfecttext, canvas.transform);
                            break;
                        case (4):
                            Instantiate(greattext, canvas.transform);
                            break;
                    }
                    GrassEaten();
                }
                break;
            case (4):
                xkey.SetActive(true);
                if (Input.GetKey(KeyCode.X))
                {
                    slider.value = Mathf.Lerp(slider.value, slider.value + 1.2f, Time.deltaTime);
                }
                if (slider.value == 1f)
                {
                    int rand = Random.Range(1, 5);
                    switch (rand)
                    {
                        case (1):
                            Instantiate(marveloustext, canvas.transform);
                            break;
                        case (2):
                            Instantiate(goodtext, canvas.transform);
                            break;
                        case (3):
                            Instantiate(perfecttext, canvas.transform);
                            break;
                        case (4):
                            Instantiate(greattext, canvas.transform);
                            break;
                    }
                    GrassEaten();
                }
                break;
            case (5):
                xkey.SetActive(true);
                if (Input.GetKeyDown(KeyCode.X))
                {
                    int rand = Random.Range(1, 5);
                    switch (rand)
                    {
                        case (1):
                            Instantiate(marveloustext, canvas.transform);
                            break;
                        case (2):
                            Instantiate(goodtext, canvas.transform);
                            break;
                        case (3):
                            Instantiate(perfecttext, canvas.transform);
                            break;
                        case (4):
                            Instantiate(greattext, canvas.transform);
                            break;
                    }
                    GrassEaten();
                }
                break;
        }
	}

    public void GrassEaten()
    {
        xkey.SetActive(false);
        zkey.SetActive(false);
        grass.transform.position = new Vector2(Random.Range(-10f, -15f), grass.transform.position.y);
        anim.SetTrigger("raisehead");
        anim.SetBool("loweringhead", false);
        slider.value = 0f;
        hiddenEatProgress = 0f;
        
        gameObject.SetActive(false);
        int moneyAmount = gc.increaseMoney();
        GameObject moneyText = Instantiate(addMoneyText, canvas.transform);
        moneyText.GetComponent<Text>().text = "$" + moneyAmount;
    }
}
