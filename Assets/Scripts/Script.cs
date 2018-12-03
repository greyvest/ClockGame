using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordScript : MonoBehaviour {

    public List<string> Lines;

    private void Awake()
    {

    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setLines()
    {
        Lines = new List<string>();
        
        /*Puzzle 1*/ Lines.Add("Tap to drop the ball so that it collides with the square");
        /*Puzzle 1*/
        Lines.Add("OOO wasn't that fun? Go ahead, do it again");
        /*Puzzle 1*/
        Lines.Add("That must be incredibly satisfying. Go ahead and drop it one more time. ");
        /*Puzzle 1*/
        Lines.Add("I'm spoiling you with all of this enthralling gameplay at once. We're gonna have to slow things down and make you wait.");
        /*Puzzle 1*/
        Lines.Add("Alright I'll let you do one more ;)");
        /*Puzzle 2*/
        Lines.Add("Using the clock hands, you can direct the ball into the square. Hit the button in the top right to reset the ball. Yes, you'll have to wait.");
        /*Puzzle 3*/ Lines.Add("Clock hands must align with the quadrant with their matching color to complete a puzzle. This clock, as you can probably tell by now, is real time.");
        /*Puzzle 4*/ Lines.Add("You'll have to wait and come back to line up the clock hands with the colors they match to in order complete some of the puzzles.");
        /*Puzzle 5*/ Lines.Add("The clock will run even when you close the app. I know you're eager for the next puzzle, but be patient and come back when it's ready.");
        //Section 2
        /*Puzzle 6*/ Lines.Add("A collection of minigames called “Penn and Teller’s Smoke and Mirror’s were developed the Sega CD in 1995, but was never distributed due to the downfall of the Sega CD. ");
        /*Puzzle 7*/ Lines.Add("The collection was meant to include a game called “Desert Bus”. Desert bus is a game that tasks the player with driving a bus between Tucson, Arizona and Las Vegas, Nevada in real time. ");
        /*Puzzle 8*/ Lines.Add("The road is boringly straight, empty of passengers, veers slightly to the right at all times so it must be constantly steered left by the player less it crash.");
        /*Puzzle 9*/ Lines.Add("The drive from Tuscon to Las Vegas is 8 hours, and so the player must pay constant attention to the game for that period of time. Desert Bus cannot be paused.");
        /*Puzzle 10*/ Lines.Add("This game was made to prove a (snarky) point about realism in games. ");
        /*Puzzle 11*/ Lines.Add("At the time, there was an wide cultural outcry against violence in video games, so the developers of desert bus developed a game to display how exciting realistic video games are.");
        /*Puzzle 12*/ Lines.Add("There were no grand rewards, nor any exciting developments. Once the player reached Las Vegas, they score a point and turn the empty bus around to drive it back to Tucson.");
        /*Puzzle 13*/ Lines.Add("The only excitement in the game is the occasional rock or empty bus stop on the side of the road, and, at 5 hours into the drive, a bug will splatter on the windshield.");
        /*Puzzle 14*/ Lines.Add("The game is widely considered the worst video games ever made. But it successfully conveys a point; Realism does not make a game fun.");
        //SECTION 3
        /*Puzzle 15*/
        Lines.Add("Realism in video games is one of the biggest things people “want”, but it’s also something they really don’t want. ");
        /*Puzzle 16*/ Lines.Add("\"Realistic\" graphics were the focus for years in the Xbox 360/Playstation 3 era, but just resulted in boring looking “brown shooters”.");
        /*Puzzle 17*/
        Lines.Add(" Once games like Overwatch and Splatoon came aroundy, colorful games that throw realism to the wind in favor of fun, they blew up.");
        /*Puzzle 18*/ Lines.Add("Giek Siong states \" you can crash a car in a racing game and still continue the race, when in reality the impact would wreck the car and seriously injure the driver.\"");
        /*“Understanding Realism in Computer Games through Phenomenology”, quote, “There is no doubt that realism is a very big thing in computer games today. Game developers tout it as their main selling point, and video game console manufacturers battle it out over whomever has the best graphics hardware to render the most number of polygons in the shortest time. Gamers and game magazines alike rave about it, or complain about the lack of it. However, “realism” is not an easily definable concept. Just what is considered “realistic” in a computer game can appear to be contradictory. */
        /*Puzzle 19*/
        Lines.Add("He's right. A racing game where you were permanently disabled and in the hospital for months after wrecking a car would be dreadfully boring.");
        /*Puzzle 20*/ Lines.Add("Realistic leaning shooters like Arma or Insurgency surely have their dedicated fanbases, but never reach the levels of success that games like Doom or Call of Duty do.");
        /*Puzzle 21*/
        Lines.Add("Rigidly realistic Games don't allow their players to pursue fantasy fufilment as easily as less realistic games do, and are often much less popluar, and, well, less fun.");
        /*Puzzle 22*/ Lines.Add("So now that I’ve explained to you why this game isn’t fun, why are you still here?");
        /*Puzzle 23*/ Lines.Add("Why do you keep coming back?");
        /*Puzzle 24*/ Lines.Add("This game is honestly pretty boring. It’s insistence on realism is an absolute detriment to it’s entertainment value. And boy is it ugly.");
        /*Puzzle 25*/ Lines.Add("You’ve certainly got better things to be doing with your time. There are much better puzzle games out there. I highly suggest the Portal games or Gorogoa, they’re great, really well designed.");
        /*Puzzle 26*/ Lines.Add("It’s ok, I won’t hold it against you. Go. Live your life. Abandon this rigid adherence to realism and do something more fun. ");
        //SECTION 4
        /*Puzzle 27*/ Lines.Add("So you’re still here. ");
        /*Puzzle 28*/ Lines.Add("Congratulations");
        /*Puzzle 29*/ Lines.Add("party horn");
        /*Puzzle 30*/ Lines.Add("You’ve reached the end!");
        /*Puzzle 31*/ Lines.Add("You’ve solved enough puzzles and endured this dreadfully realistic game long enough to win. ");
        /*Puzzle 32*/ Lines.Add("That’s it, game’s over. Thanks for playing");
        //SECTION 5
        /*Puzzle 33*/ Lines.Add("So you’ve either fallen for the reverse psychology used to get you this far in or you’re aware enough of it that you find subverting it entertaining. For your sake I hope it’s the latter.");
        /*Puzzle 34*/ Lines.Add("But let’s discuss that, shall we?");
        /*Puzzle 35*/ Lines.Add("This is no longer a game about solving puzzles. If you were in this for the puzzles you’d have uninstalled it long ago and found a better puzzle game to play. ");
        /*Puzzle 36*/ Lines.Add("The puzzle mechanics of this game are shallow at best. You and I both know that. So why are you still here ?");
        /*Puzzle 37*/ Lines.Add("I have a theory. ");
        /*Puzzle 38*/ Lines.Add("Single player games were described by the Late Great John Bain as “ the notion of competing with the developer’s challenges, the things that the developer has prepared for player.”");
        /*Puzzle 39*/ Lines.Add("So obviously, in any decent video game the point is that the developer creates challenges that it’s fun for you to beat. ");
        /*Puzzle 40*/ Lines.Add("So where’s the fun here? As much as I know I’m fantastic at game design, even I can tell that it’s not all that satisfying to wait till your tiny amount of control can solve a simple but tedious puzzle.");
        /*Puzzle 41*/ Lines.Add("So you’re not competing against the game anymore. You’re competing against me. ");
        /*Puzzle 42*/ Lines.Add("This is a battle of wills, not a battle of wits. You’ve got a competitive streak against me, that, if somehow you can outlast and outsmart me at my own game, you’ll feel some sense of accomplishment. ");
        /*Puzzle 43*/ Lines.Add("A little odd, but good luck anyways.");
        //SECTION 6
        /*Puzzle 44*/ Lines.Add("You did another puzzle. Wow. Cool. I’m proud of you.");
        /*Puzzle 45*/
        Lines.Add("You know, at some point, I’m just going to abandon you here. You keep doing puzzles, keep coming back, keep insisting that there’s something at the end");
        /*Puzzle 46*/
        Lines.Add("There will be no more dialogue to find, no more secrets.  And you’ll give up, because you should, because at some point, there will be absolutely no reason for you to continue. ");
        /*Puzzle 47*/ Lines.Add("In fact, I’m lazy enough and busy enough with other things in my life that I might just abandon you right here. ");
        //Section 7
        /*Puzzle 48*/ Lines.Add("");
        //Section 8
        /*Puzzle 49*/ Lines.Add("");
        //Section 9
        /*Puzzle 50*/ Lines.Add("Ok so you’re curious. I’ll give you that.");
        /*Puzzle 51*/
        Lines.Add("And I’ll tell you why. You WANT to get to the point where I’ve abandoned this game. You want to prove that you’ve beaten me. That you've lasted longer than I have");
        /*Puzzle 52*/
        Lines.Add("Even when you’re at the most severe disadvantage, you still want to beat me somehow. You want to outsmart me. You want to prove to me that you’ve beaten me at, literally, my own game.");
        /*Puzzle 53*/
        Lines.Add("It’s an interesting kind of metanarrative. This is no longer about you controlling a game, or competing against a game, it’s about you competing against me. ");
        /*Puzzle 56*/ Lines.Add("It's also funny how well this represents an inverse of the larger point about realistic games.");
        /*Puzzle 56*/
        Lines.Add("Rigidly realistic gameplay is (oftentimes, not always) less fun, but yet the less artificial conflict of you versus the developer is more fun. ");
        /*Puzzle 56*/
        Lines.Add("Maybe that's why people are so drawn to multiplayer games. They enjoy the competition against other people that they know are there, as opposed to the hidden game developer.");
        //Section 10
        /*Puzzle 55*/
        Lines.Add("So since I’ve got you here, I figured I’d bore you with a section of my thesis. The section is about the shift between you, the player, vs game, and you vs the designer.");
        /*Puzzle 56*/
        Lines.Add("To paraphrase, games like this are often based around you doing what I “don’t want you to do”. I provide “intended” ways of playing the game, and then I also provide “unintended” ways of playing.");
        /*Puzzle 57*/
        Lines.Add("You, being the smart ass that you are, always want to prove your cleverness, so you always pick the route you think I didn’t think of, the way you thought I didn’t want you to play the game.");
        /*Puzzle 58*/
        Lines.Add("For example, you can rob a merchant blind in Skyrim by just putting a kettle over his head. It’s something the developers never thought of, but you tried out and managed to subvert the game’s systems.");
        /*Puzzle 60*/
        Lines.Add("But in a game like The Stanley Parable or ICEY, the developer baits you into trying something like that and then calls you out on not being as clever as you thought.");
        /*Puzzle 61*/
        Lines.Add("The battle then becomes for the player to find something that the snarky developer didn’t think of; find a way to do something that doesn’t trigger a sarcastic remark but still gets the job done in a subversive way.");
        /*Puzzle 62*/
        Lines.Add("That’s what you want, that’s what the developer knows you want, and those are the kinds of juicy opportunities they bait you with before making a snide remark at your expense. ");
        /*Puzzle 63*/ Lines.Add("So just remember you're doing exactly what I want you to.");
        //Section 11
        /*Puzzle 64*/ Lines.Add("So at this point I’m wondering how I best end this game");
        /*Puzzle 65*/ Lines.Add("Am I gonna just leave you hanging? I definitely could. Just auto generate puzzles for the rest of time and give you hope that there’s something at the end of the rainbow.");
        /*Puzzle 66*/ Lines.Add("Give you an impossible puzzle? That’d be mean. Let you solve everything up to this point and then give you something impossible to solve. I like it.");
        /*Puzzle 67*/ Lines.Add("Give you a grand send off? Balloons and confetti? A cinematic cutscene?");
        /*Puzzle 68*/ Lines.Add("Turn the snark up even more in the ultimate anticlimax? That’d be really good. Just nothing. Just close the game. Bye.");
        /*Puzzle 69*/ Lines.Add("I'll have to think about this more.");
        //Section 12
        /*Puzzle 70*/ Lines.Add("So just in case you think you’re clever, yes, I imagined that people would manipulate their device system times to fast forward. ");
        /*Puzzle 71*/ Lines.Add("If you didn’t do that you probably just did the face palm thing for not thinking about that. ");
        /*Puzzle 72*/ Lines.Add("If you did do that, you should feel VERY called out. You’re not experiencing the artful mundanity of this game as it was intended and are a bad person. ");
        //Section 13
        /*Puzzle 73*/ Lines.Add("If you’re watching clips of this on youtube so that you don’t actually have to play this game, then you’re also a bad person. I worked hard on this. How could you.");
        /*Puzzle 67*/ Lines.Add("As if someone will record this far into the game lol");
        /*Puzzle 68*/ Lines.Add("One more thing before you go.");
        /*Puzzle 69*/ Lines.Add("If you've made it this far, you've actually beat me.");
        /*Puzzle 70*/ Lines.Add("I made this game, but I've never played it front to back. And I never will. ");
        /*Puzzle 71*/ Lines.Add("I developed all these puzzles with a cheat button to skip through puzzles.");
        /*Puzzle 72*/ Lines.Add("So honest congratulations to you for getting through it. I don't know if you're sane but you're sure dedicated.");
        /*Puzzle 73*/ Lines.Add("Thanks for playing.");
        /*Puzzle 74*/ Lines.Add("Alright if you acutally beat that puzzle then screenshot this and tweet it to @grey_vest that was supposed to be impossible.");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("");
        Lines.Add("Dude, go home.");

































    }
}
