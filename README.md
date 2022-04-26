# SMMOB
The probably only reliable Simple-MMO Bot out there. Kept private for our own enjoyment.

### Update: Decided to release a few private projects of mine, including this one, because I have no need for them anymore.
This isn't a great codebase. Nor the latest version I have. You can improve this by a lot. Microsofts ML.NET got a memory leak in itself that I tried to deal with. It still remains. So switching to Python or another C# solution should be considered.

The model trained the longer I used the bot, because I gathered more and more images over time. **Don't trust the captcha solver (!!!)**, as it could be outdated. Also I am pretty sure I don't have everything. Because there were candy canes and stuff.

This game uses heuristics to detect wether you are a bot. Failing the captcha multiple times can and probably will result in a ban as well. They do IP Ban you and track all of your devices, as well as game accounts. Made a fortune during last years Halloween Event causing an inflation and got punished for that. I had my fun with this game until that point and decided to quit.

Suggestions for people that found interest in this project:
- Instead of inlining javascript inside strings, add javascript files to the project solution that you read all text of and assign to a string afterward. The Visual Studio IDE supports that file type. That way it's easier to read and manage your javascript that you inject into the browser.
- Don't download the captcha images but find a more creative approach on gathering it (taking a screenshot of the browser or something). Downloading it could be a detection vector and probably is.

# TODO
- [x] Bypass Captcha
- [x] Auto Step
- [x] Auto Fight 
- [ ] Auto Farm
-- Code for it exists but has to be fixed
- [ ] Auto Battle
- [ ] Auto Quest
- [ ] Auto Job
- [ ] Log Stats
- [ ] Auto Sell
- [ ] Auto Collect
- [ ] Client-side rewrite (Multiple Selection in inventory)
- [ ] Discord Bot
- [ ] Day/Night Cycle
- [ ] Stop/Continue Bot Sessions
- [ ] Clean Code
