using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BotManager : MonoBehaviour
{

    public const string BOT_TYPE = "bot";
    public const string HUMAN_TYPE = "human";


    public Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>()
    {
        { 
            BOT_TYPE, new List<string>
            {
                 "You have such talent! Check @feature.me – we're looking for creators like you!",
                "Hey, I noticed you love traveling. Your photos from Greece in your highlights look incredible!! Do you have any tips for someone planning their first trip there.",
                "Heyy I just stumbled upon your profile – you have such great vibes Want to get to know each other better? Message me",
                "Hey! I'm currently helping people turn just 100€ into over 2,000€ in just a few days Interested in a simple guide?",
                "Hi! I'm working with a brand that is looking for new influencers. You would be perfect! Message @glowbrand.reps",
                "Sorry to bother you, but I really need help. My dog is sick, and I have a donation link in my bio",
                "Your last post was really powerful. I can feel the message Message me – I'm curious about what else you're up to :)",
                "Hey, I just wanted to tell you how inspiring your content is. I'd love to see more from you! DM me if you want to chat.",
                "OMG you have to see this bit.ly/free-gift-now",
                "Strong vibe in your content  Have you ever considered becoming a brand ambassador? Check @liftelite.global",
                "Hey! We're looking for creative people for a creator network. Would that interest you? Message @inspire.teams",
                "I came across your profile and just wanted to say you're really talented! If you're ever interested in collaborating, feel free to reach out to me.",
                "Hey, I see you is very nice person. Your posts are so much beauty. Maybe we can work together, you interested? Let me know!",
                "Wow, you page is so cool. I have a good offer for you. I think you like it! Reply me when you free!",
                "Hey, I just wanted to tell you how inspiring your recent posts have been! You seem to have such a great perspective. If you ever feel like chatting or exchanging ideas, feel free to message me.",
                "I saw your post earlier about the new book you’re reading, and I’ve been thinking about it ever since. You really know how to engage with your audience! Do you have any advice for someone starting out?",
                "Just wanted to say, I really appreciate how you approach things on your profile. You’re one of the few creators who consistently posts content that actually makes me think about my own well-being.",
                "Hello beautiful. I'm new here... want to see my private pictures? lonelygirls.ru",
                "I'm new here... do you have any tips on how to make friends on Insta? You seem so sweet…",
                "Wow, you look amazing, where are you from?",
                "Are you online right now? I’d love to get to know you better",
                "I’m working on an online project and earning really well",
                "My mentor is currently looking for motivated people",
                "Sorry if this is weird, but you seem really nice",
                "I’m new on Instagram and looking for good conversations",
                "Do you prefer chatting here or on WhatsApp?",
                "I really like your smile in your photos",
                "Check this out link in my bio",
                "I think this is perfect for you, take a look",
                "I’m not very active here, message me on WhatsApp instead",
                "Let’s talk somewhere private, it’s easier",
                "Your account might be at risk, verify here now",
                "This offer expires today, act fast",
                "Only a few spots left, don’t wait",
                "Please confirm your info to continue",
                "You’ve been selected for a special reward",
                "Claim your bonus here before it’s gone",
                "You won something, just click to collect it",
                "Free access for a limited time",
                "Check link fast",
                "Send me message now",
                "I need you to help me",
                "Do not ignore this message",
                "If you receive this you are selected",
                "Congratulations random user",
            }
        },
        {   HUMAN_TYPE, new List<string>
            {
                "Hey, I noticed you love traveling. Your photos from Greece in your highlights look incredible!! Do you have any tips for someone planning their first trip there.",
                "Hey, I hope this isn’t weird—but you just give off such calm, good energy. Had to say hi ^^",
                "Your style is insane! I love the leather jacket and that outfit you’re wearing in the mirror selfie with the black skirt!! Do you have any go-to shops you’d recommend?",
                "Hey, I just randomly came across your profile and I think your photos are super cool! Do you shoot professionally or just as a hobby?",
                "Heyy, I was checking out your highlight about photography and I really like the vibe of your photos. I was wondering if you’d be up for a photoshoot sometime. I need some new Insta pics. How much would that cost?",
                "Hey! Your profile instantly caught my eye; it gives off such cool vibes and looks like you’ve been to some interesting places. Do you travel a lot for photography?",
                "Hiii!! I saw in your highlights that you do photography. I’m just starting out myself. Do you have any tips for a beginner?",
                "Heyy, I love the leather jacket you’re wearing in your profile picture. Do you mind me asking where it’s from?",
                "Heyy, I saw you’re into photography. Just wondering, what camera do you use, if you don’t mind me asking?",
                "Hey, just wanted to say, your profile looks amazing. You’ve really got an eye for aesthetics. Had to say it!",
                "Your pics make me wanna grab my camera and go outside! Do you have a favorite spot to shoot in your city?",
                "Random but true: your profile kinda motivated me to finally pick up my camera again.",
                "I’m curious – do you prefer taking photos of people or places?",
                "I swear every outfit you post looks like it's from Pinterest – where do you find your inspo?",
                "Okay this might be random, but what motivates you creatively? You seem super grounded.",
                "Your dog is way too cute!!! what’s their name",
                "Your photos make it look like you’ve been to some amazing places! Do you travel a lot?",
                "The vibe in your highlight about traveling is so peaceful. Do you prefer nature spots or cities?",
                "Your travel shots feel like stills from a movie! Are you someone who plans trips or just goes with the flow?",
                "Where was that forest photo in your highlights taken? That place looks unreal.",
                "Hey, I love the jacket you're wearing in your second-to-last picture and your profile picture. May I ask where you got its?",
                "Hi! I saw in your highlights that you take photos. I'm just getting started with photography. Do you have any tips for a beginner?",
                "Hey, I saw you taking pictures. What camera do you use, if I may ask??",
                "Your style is crazy! I love the leather jacket and the outfit you're wearing in the mirror photo with the black skirt! Do you have any shops you can recommend?",
                "Hey, I just stumbled across your profile.  I think your pictures are really cool! Do you take photos professionally or just as a hobby?",
                "Hey, I looked through your highlights with your photos and really like the vibe of your pictures. I wanted to ask if we could do a photo shoot sometime, because I need some new Instagram pictures. How much would that cost with you?",
                "Hey, I just wanted to say: your profile is really well done. You can see that you have an eye for aesthetics—I just wanted to get that off my chest.",
                "I really appreciate your positive vibes and motivational quotes—they always seem to pop up just when I need them most!",
                "Okay I’m not even sure how I found your page, but you seem like someone who actually has interesting thoughts. Hope that’s not too random.",
                "Your baking creations look delicious and make me want to try making something new in the kitchen this weekend.",
                "This might be out of the blue, but your vibe is just really calming and cool. Thought I’d message you.",
                "Your baking creations look so good, they're making me hungry just by  looking at them.",
                "You just seem really authentic, which is rare. Thought I’d message you instead of just thinking that.",
                "Your energy seems really calm and genuine. Felt like you might be someone cool to talk to.",
                "This is probably the most casual DM ever but—hi, you seem cool and I like your energy. What’s something that made you smile recently?",
            }
        }
    };

    [Header("Popup Settings")]
    [SerializeField] private GameObject popupTextPrefab;
    [SerializeField] private Color positiveColor = Color.green;
    [SerializeField] private Color negativeColor = Color.red;

    [SerializeField] private TextMeshProUGUI speechBubble;
    private string currentMessageType;

    private void Awake() { speechBubble = GetComponentInChildren<TextMeshProUGUI>(); }

    private void Start()
    {
        AssignRandomMessage();
        if (currentMessageType == BOT_TYPE) ScoreManager.Instance.AddMaxScore(1);
    }

    public void AssignRandomMessage()
    {
        bool isBotMessage = Random.value > 0.5f;
        currentMessageType = isBotMessage ? BOT_TYPE : HUMAN_TYPE;
        if (messages.ContainsKey(currentMessageType))
        {
            speechBubble.text = messages[currentMessageType][Random.Range(0, messages[currentMessageType].Count)];
        }
    }

    private void OnMouseDown()
    {
        if (PauseManager.Instance != null && PauseManager.Instance.IsPaused) return;

        if (currentMessageType == BOT_TYPE) { ScoreManager.Instance.AddScore(1); ShowPopup("+1", positiveColor); }
        else { ScoreManager.Instance.AddScore(-1); ShowPopup("-1", negativeColor); }
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerPassZone"))
        {
            if (currentMessageType == BOT_TYPE) { ScoreManager.Instance.AddScore(-1); ShowPopup("-1", negativeColor); }
            else { ScoreManager.Instance.AddScore(1); ShowPopup("+1", positiveColor); }
            gameObject.SetActive(false);
        }
    }

    private void ShowPopup(string text, Color color)
    {
        if (popupTextPrefab == null) return;
        Canvas canvas = Object.FindFirstObjectByType<Canvas>(); 
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position + Vector3.up);
        GameObject popup = Instantiate(popupTextPrefab, canvas.transform);
        popup.GetComponent<RectTransform>().position = screenPos;
        TextMeshProUGUI textMesh = popup.GetComponent<TextMeshProUGUI>();
        if (textMesh != null) { textMesh.text = text; textMesh.color = color; }
    }
}
