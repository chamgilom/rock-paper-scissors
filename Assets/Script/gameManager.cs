using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    public Text Result;
    public Image computerchoice;
    public string[] choice;
    public Sprite rock;
    public Sprite scissor;
    public Sprite paper;

    public void Play(string mychoice)
    {
        string randomchoice = choice[Random.Range(0, choice.Length)];

        switch(randomchoice)
        {
            case "rock":
                switch(mychoice)
                {
                    case "rock":
                        Result.text = "비겼습니다.";
                        break;
                    case "scissor":
                        Result.text = "졌습니다.";
                        break;
                    case "paper":
                        Result.text = "이겼습니다.";
                        break;
                }
                computerchoice.sprite = rock;
                break;
            case "scissor":
                switch (mychoice)
                {
                    case "rock":
                        Result.text = "이겼습니다.";
                        break;
                    case "scissor":
                        Result.text = "비겼습니다.";
                        break;
                    case "paper":
                        Result.text = "졌습니다.";
                        break;
                }
                computerchoice.sprite = scissor;
                break;
            case "paper":
                switch (mychoice)
                {
                    case "rock":
                        Result.text = "졌습니다.";
                        break;
                    case "scissor":
                        Result.text = "이겼습니다.";
                        break;
                    case "paper":
                        Result.text = "비겼습니다.";
                        break;
                }
                computerchoice.sprite = paper;
                break;
        }
    }
    // Start is called before the first frame update

}
