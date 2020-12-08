# Reactive Menu and Prefab Workflow Example

Standard prefab workflow doesn’t allow you to save references to scene managers or scene objects. 

<https://github.com/AdamRamberg/unity-atoms>

<https://bitbucket.org/UnityUIExtensions/unity-ui-extensions/>


An alternative “architecture” is to use Scriptable Objects to store global data which communicate their state changes using events. Scriptable Objects are static assets that live in the project not in individual scenes, they are similar to monobehaviors but don’t have the magic methods like Awake, Start, Update. Scriptable Objects are often used to store data, like inventory or player stats, they can also contain methods and  raise events, which can be subscribed to. By using them like that you can decouple a lot of your scripts, and use these Scriptable Object assets to replace the “master” singleton data manager setup which gets spaghetti-ish very quickly. 

I highly recommend Ryan Hipple’s talk on this at Unite in 2017 <https://www.youtube.com/watch?v=raQ3iHhE_Kk>
That talk has a ton of great ideas and ways to help team workflow. It also inspired a few projects to implement it. I’ve tried a couple and found Unity Atoms my favorite, it has a lot of additional functionality, I mainly just use the simplest implementation of it, just variables that raise events.

Unity Atoms is an implementation of this workflow.

Within Unity UI Extensions is a menu manager, which was taken from Adam Kapos - Yousician 2017 Unite talk - Building an easy to use menu system.
<https://www.youtube.com/watch?v=wbmjturGbAQ>

With a small adjustment to the scripts this can be repurposed as a generic prefab loader (I have submitted a pull request for the change so check the latest version at the repository).

Within the menu manager repo you can find a few examples, essentially its a prefab loader that handles canvas states really nicely and solves a lot of the usual manu and canvas issues when doing anything remotely complex with multiple UIs.

By using these two open source projects with Unity you can architect away from multiple game managers and singletons into a refined and event based reactive workflow.

This repository is a demo of using these 2 projects to handle game health and a shop UI to replenish the player health.


# Other Assets used in the example

### from:
Wrestler from Mixamo <https://www.mixamo.com/> (decimated in Blender <https://www.blender.org/> )

The shader is by Carlos Wilkes <http://carloswilkes.com/> from <https://assetstore.unity.com/packages/tools/animation/lean-transition-144107>

Standard Assets character controller and animations
<https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351>

Font: Luckiest Guy <https://fonts.google.com/specimen/Luckiest+Guy>

Flipbook images are cartoonified versions of flipbooks from Unity Labs
<https://blogs.unity3d.com/2016/11/28/free-vfx-image-sequences-flipbooks/>