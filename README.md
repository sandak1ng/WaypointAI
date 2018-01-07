# WaypointAI

# WaypointAI

Final Tech Demo: https://youtu.be/ZLiBTlMZj1A

***Please ignore the folder "Waypoints/WaypointAI - added new stage with new technique used"*** - I tried to delete this but I couldn't for some reason...

For my project I decided to create a waypoint path finder, this was my task and my goal:
Waypoint Pathfinder - One or more agents navigating a space using a waypoint graph.  Stretch goal: automatically generate links between hand-placed waypoints. (Harder still is placing the waypoints automatically.)

I created three progress scenes and also created a video progression for them three as I felt it would be a waste not to document my progress and how I came about my final tech demo scene, one and three which uses Unity's navigation mesh and the second scene only using checkpoints to move the agent, the reason I created three scenes was because I wanted to explore the different techniques to go about moving an agent from one place to another smoothly, so far there is no user input to my first and second demo's all you need to do is run the program and you will see the agent move around automatically, my third progress demo and my final demo for submission has some controls which are listed below.

Video Progress Link:  https://youtu.be/NBPyXLjsntM

In my first scene, I am using navigation mesh which didn't require a lot of code, I simply declared a transform variable and then used "GetComponent< NavMeshAgent>" to update the position of the agent on every frame and that was it, I learnt that there's not much you need to code as Unity does it all for you, the unity navigation GUI was very helpful in helping me distinguish what was obstacles and what was walk-able terrain, I got a lot of help from the Unity documentation, everything I needed was basically described on there[1] I think there are many benefits to using nav meshes and I couldn't really find a lot of cons to it, even if you are not technically gifted in coding you are able to create amazing and intelligent AI movement using nav mesh. 

In my second scene, I am using waypoints/checkpoints that once the agent passes through it then moves onto the next checkpoint, I didn't use much code to achieve this but I was able to produce an effective AI movement although the downsides to this - it becomes a bit predictable after a while which can be okay depending on what you are trying to achieve. I am using transform again to update the position of the agent on every frame, a feature I wasn't able to achieve on this scene was the addition of raycasting, I wanted to create a line of sight AI that reacts to obstacles as well as the checkpoints.

In my third scene, I wanted to investigate how the dynamic mesh works so to help me I followed a youtube tutorial for this which can be found here[2]. It is more of an extension of the first I wanted to test multiple agents at a time. I used the built in nav mesh of unity and created multiple agents travelling to a destination set by me. I also added gates to test the dynamic nav mesh.
Controls for the third demo: 

"Space Bar" = Move Gate 1 (Closest to you)

"L" = Move Gate 2 (Furthest from you)

My final tech demo involves a combination of everything I learnt from before, I got the idea from a tutorial that I watched on youtube[2], I created a player which can interact with the nav mesh and you can move around using the mouse buttons I used raycasting for this[3], the idea behind this was for the player to become a movable object and make the red enemy agents repath however I wasn't able to achieve this, you will notice there are two .exe's for the final demo, the reason for this was to allow you to see what was going on in the scene without the camera attached to the player.

Controls for the final demo for submission:

Using mouse to click to your destination

I believe nav meshes are very efficient because they are simple enough to implement that you save so much time and can focus on other features of the game or even polish it even more to create more intelligent movement such as rotation, random movement between destinations etc. however on the other case, the only practical benefit to using waypoint graphs is where you want to restrict movement to exact lines rather than certain areas like nav mesh meaning that it is moderately cheaper to operate. 

References

[1] https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html
[2] https://www.youtube.com/watch?v=4Kj6YUPLWCw
[3] https://docs.unity3d.com/ScriptReference/Physics.Raycast.html

