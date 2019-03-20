Physics-Interactions
====

Using the built-in physics engine to make reactive behaviours and environments. You must have some basic experience of Unity and Scripting.

# TODO
+ [ ] Breakdown scripts.
+ [ ] Add events slides.

# Overview

+ [Physics](#physics)
+ [Interactions](#interactions)
+ [Bonus](#bonus)

# Physics

![Physics](https://boostlog-public.s3.us-west-1.amazonaws.com/articles/5aeec61e47018500491f4421/MainTitle-1525597640234.gif)

## Language and Anatomy

+ [Colliders](https://docs.unity3d.com/2017.4/Documentation/Manual/CollidersOverview.html)
![collisionExample](https://i.imgur.com/gj2kGu0.gif)
+ [Rigidbodies](https://docs.unity3d.com/2017.4/Documentation/Manual/RigidbodiesOverview.html)
![RigidbodyExmaple](https://i.redd.it/41ll9162magy.gif)
+ [Joints](https://docs.unity3d.com/2017.4/Documentation/Manual/Joints.html)
![jointsExample](https://img.itch.zone/aW1nLzE2MzI1OTEuZ2lm/original/1FnkaC.gif)
+ [Physic Materials](https://docs.unity3d.com/2017.4/Documentation/Manual/class-PhysicMaterial.html)
![bouncy](https://cdn-images-1.medium.com/max/1600/1*sHNVumjYqoPIHmfU-jWApQ.gif)
+ [Collision Layers](https://docs.unity3d.com/2017.4/Documentation/Manual/LayerBasedCollision.html)
![collisionMatrix](https://docs.unity3d.com/uploads/Main/LayerBasedCollision.png)

## Details

In game engines, there is no assumption that an object should be affected by
physics — firstly because it requires a lot of processing power, and secondly because it simply doesn't make sense. For example, in a 3D driving game, it makes
sense for the cars to be under the influence of the physics engine, but not the track
or surrounding objects, such as trees, walls, and so on — they simply don't need to
be. For this reason, when making games, a Rigid Body component is given to any
object you want under the control of the physics engine.

Physics engines for games use the Rigid Body dynamics system of creating realistic
motion. This simply means that instead of objects being static in the 3D world, they
can have the following properties:

+ Mass
+ Gravity
+ Velocity
+ Friction

While more crucial in game engines than in 3D animation, collision detection is the
way we analyze our 3D world for inter-object collisions. By giving an object a **Collider** component, we are effectively placing an invisible net around it. This net mimics its shape and is in charge of reporting any collisions with other colliders, making the game engine respond accordingly. For example, in a ten-pin bowling game, a simple spherical collider will surround the ball, while the pins themselves will have either a simple capsule collider, or for a more realistic collision, employ a Mesh collider.
On impact, the colliders of any affected objects will report to the physics engine, which will dictate their reaction, based on the direction of impact, speed, and other factors.

## Practical

### Basics

+ Open `Assets/Scenes/BaseScene`.
+ Make a cube, add a `Rigidbody` component, press play. Watch it fall forever. This is the gravity simulation.
+ Add a Floor Prototype prefab. Make the coordinates (Position) x: 0 y: 0 z: 0.
+ Press play.

Also, if you change the `Physic Material` on the `Box Collider`, this will change how the box interacts with other surfaces.

+ Select a cube, select the bouncy material.
+ Press play. They should bounce.

### Using Colliders and Rigidbodies in the Editor

+ Open 1_Physics - Basics scene
+ Import funny shaped models
+ Add Colliders, Rigidbodies, check settings
+ Making composite shapes from Colliders for efficient collision checking
+ Add Physic Materials to make stuff bounce
+ Play around with mass and drag settings to understand the effects.

### Using OnTrigger or OnCollision

+ Open 2_Physics - Triggers scene
+ Make a transparent box, open the template script `PlaySoundOnTrigger`
+ You will have to fill in how it works. What it should do is play a sound whenever the player enters the collider volume.
+ For bonus points, how can you ensure that the collider will be a trigger?

### Add forces

+ Open the hover pad script and make it add a force if the player is staying in the trigger volume.

### Destroy OnCollision

+ If something gets hit, make it destroy it self and make an explosition using the particle systems in the standard assets.

### Make a banging door with Joints.

+ For the brave, make a door that makes a noise when it shuts.

## Useful links

+ [Best Practices](https://unity3d.com/learn/tutorials/topics/physics/physics-best-practices?playlist=30089&_ga=2.25017914.1256270532.1553102866-498088709.1552744322)
+ [Make a Pinball machine tutorial (2d)](https://www.raywenderlich.com/6184-unity-2017-2d-techniques-build-a-2d-pinball-game)
+ [Interesting things with math and physics e.g. Verlet Softbody, Rigidbody, and Chain](https://github.com/zalo/MathUtilities)
+ [Boids and Cloth](https://github.com/bennybroseph/Unity-Physics)

# Interactions

+ MouseDown, clicking things in the screen space
+ Raycasting, shooting lasers to hit things in space
+ HitEvent, moving the process of object effects on the objects themselves

## Events

TODO

## Raycasting

TODO

# Bonus

+ [Ragdoll Wizard](https://docs.unity3d.com/2017.4/Documentation/Manual/wizard-RagdollWizard.html)
  + Open Ragdoll scene, press play, watch for a change.
  + Try to bring it back to life by adding forces to the joints.
![ragdoll](http://blog.leapmotion.com/wp-content/uploads/2014/06/ragdoll-gif.gif)

+ Klak - creative coding kit for Unity that you can prototype things with then steal the code
