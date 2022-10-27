//Brandon Le
//10-26-22
//Mini Challenge 8 - Reverse It
//Web API project that will have 2 different endpoints. One for reversing a string and one for reversing an int. Both have data validation so an error message will pop up when you enter the incorrect variable type. There is also an instructions page at the /minich8 URL. So it makes it a little easier for people to go to the two different end points. URLs also provided in the error messages for easy routing.
//Peer Review: Noah Bague - the program looks nice there was not any flaws/errors code works properly i aprrove of the code. the links from the error codes were a good addition.

using Microsoft.AspNetCore.Mvc;

namespace MiniCh8ReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh8Controller : ControllerBase
{
    public string Instructions()
    {
        return "Hi there! Let's reverse some numbers today!\n Use the following URL: https://localhost:7221/minich8/reversenum/\n Then you can add whatever numbers you want after the reversenum/ and I'll reverse it for you!\n If you're lazy you can try my URL: https://localhost:7221/minich8/reversenum/123456789\n\n Bored of numbers? Use this link to reverse some words!\n https://localhost:7221/minich8/reverseword/\n If you want an example you can use my name at https://localhost:7221/minich8/reverseword/Brandon\n\n **Don't forget to check the localhost number!**";
    }

    [HttpGet]
    [Route("ReverseNum/{userInput}")]
    public string ReverseNum(string userInput)
    {
        int validNum = 0;
        bool canParse;
        string reversedOutput ="";

    canParse = Int32.TryParse(userInput, out validNum);
    if (canParse == false)
    {
        return "INVALID ENTRY! Please enter numbers! If you want to enter words go to this URL:\n https://localhost:7221/minich8/reverseword/\n Then enter in the word you choose after reverseword/";
    }

    for (int i = userInput.Length - 1; i >= 0; i--)
    {
        reversedOutput = reversedOutput + userInput[i];
    }
        return reversedOutput;
    }


    [HttpGet]
    [Route("ReverseWord/{userInput}")]
    public string ReverseWord(string userInput)
    {
        int validNum = 0;
        bool canParse;
        string reversedOutput ="";

        canParse = Int32.TryParse(userInput, out validNum);
        if (canParse == true)
        {
            return "INVALID ENTRY! I thought you were tired of numbers? Enter a word! If you want to enter numbers go to this URL:\n https://localhost:7221/minich8/reversenum/\n Then enter in the number you choose after reversenum/";
        }
        for (int i = userInput.Length - 1; i>= 0; i--)
        {
            reversedOutput = reversedOutput + userInput[i];
        }
        return reversedOutput;
    }

}
