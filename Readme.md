# BallThrowAssignment

## Overview

This project implements a reusable VR throwing system using Unity XR Interaction Toolkit.

The system allows any Rigidbody object to become throwable using a single reusable Throwable component.

Implemented objects:

- Ball
- Cube
- Dart

All objects share the same throw system without any object-specific throw logic.

---

## Features

### Reusable Throw System

A single Throwable component can be attached to any Rigidbody object.

### Velocity Smoothing

Throw velocity is calculated using a buffered history of controller positions.

This avoids controller jitter and produces realistic throws.

### Physics Interaction

Objects interact using Unity Rigidbody physics.

Features include:

- Gravity
- Collisions
- Environmental interaction
- Continuous collision detection

### Target Feedback

Target board provides:

- Visual feedback
- Audio feedback

when successfully hit.

### Spawn System

Each throwable type has its own spawn point.

Features:

- One object per spawn point
- Prevents duplicate spawning
- Reusable design

---

## Project Structure

Assets

- Scenes
    - BallThrowAssignment.unity

- Scripts
    - Core
        - Throwable.cs
        - VelocityTracker.cs
        - ThrowSample.cs

    - Targets
        - TargetHit.cs

    - Spawn
        - ThrowableSpawner.cs
        - SpawnButtonHandler.cs
        - SpawnedThrowable.cs

- Prefabs
    - Ball.prefab
    - Cube.prefab
    - Dart.prefab
    - Target.prefab

- AudioClip
   -Hitting.wav
   -hit.wav

---

## Required Packages

- XR Interaction Toolkit
- XR Plugin Management
- Input System
- OpenXR

---

## Scene Hierarchy

BallThrowAssignment

- XR Origin
- SpawnManager
- BallSpawnPoint
- CubeSpawnPoint
- DartSpawnPoint
- Targets
- Canvas

---

## Controls

### VR Controller

Trigger

- Grab Object

Release Trigger

- Throw Object

### UI Buttons

- Spawn Ball
- Spawn Cube
- Spawn Dart

---

## Throwable Objects

### Ball

Mass: 1

Linear Drag: 0.5

### Cube

Mass: 2

Linear Drag: 1

### Dart

Mass: 0.5

Linear Drag: 0.2

---

## Architecture

### VelocityTracker

Collects controller position samples.

### Throwable

Applies smoothed throw velocity on release.

### TargetHit

Handles target hit feedback.

### ThrowableSpawner

Controls object spawning and spawn point occupancy.

---

## Assignment Requirements Coverage

✅ Reusable Throwable Component

✅ Velocity Averaging Using Buffered Samples

✅ Three Throwable Object Types

✅ Physics-Based Interactions

✅ Target Hit Feedback

✅ Clean Architecture

✅ Reusable Spawn System

---

## How To Run

1. Open project in Unity.
2. Open Scene:
   Assets/Scenes/BallThrowAssignment.unity
3. Enter Play Mode.
4. Spawn an object using UI buttons.
5. Grab and throw using XR controllers.
6. Hit target board or knock down cans.

---


## Demo Video

🎥 Project Demo Video:

PASTE_YOUR_VIDEO_LINK_HERE

---

## Overview

This project implements a reusable VR throwing system using Unity XR Interaction Toolkit.

The system allows any Rigidbody object to become throwable using a single reusable Throwable component.

Implemented objects:
- Ball
- Cube
- Dart


## Author

Ravi Gautam