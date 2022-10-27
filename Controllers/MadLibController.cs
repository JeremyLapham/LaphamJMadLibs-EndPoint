//Jeremy Lapham
//10-25-22
//Mad Libs Endpoint
//This program will have the user put in whatever words they want they need 14 words to compelete the story
//Peer Review: N. HARRISON : CODE IS SUPER FLUSH!  SO MUCH WORK FOR SO LITTLE LINES, VERY IMPRESSIVE. CREATIVE STORY, OVERALL GREAT WORK!!!

using Microsoft.AspNetCore.Mvc;

namespace LaphamJMadLibs_EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("MadLib/{word1}/{word2}/{word3}/{word4}/{word5}/{word6}/{word7}/{word8}/{word9}/{word10}/{word11}/{word12}/{word13}/{word14}")]

    public string MadLib(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10, string word11, string word12, string word13, string word14)
    {
        return $"This is a game of Mad Libs \n Here is the story with your words in it: \n It is a {word1} Halloween night. I have my {word2} costume on and I step outside to begin my {word3} eveing of trick or treating. I {word4} down the street and {word5} up to the first door. \"{word6} or treat\" I said as the door began to open. \"{word7} or treat?\" a {word8} said on the other side of the door. \"What does that mean?\" \"It means if you don't give me a treat I'll have to {word9} a {word10} on you. \"{word11}\" he said as he {word12} {word13} out the door and {word14} down the street. I guess he played a trick on me!";
    }
}
