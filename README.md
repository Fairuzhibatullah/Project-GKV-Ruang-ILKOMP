# Echoes of Ilkom IPB

## Overview
Echoes of Ilkom IPB is a VR Educational Exploration project developed using Unity 2022 LTS and VR Template. The project introduces the learning environment of IPB University Computer Science students through an interactive 360° virtual tour experience.

Users can explore several important locations such as:
- Komlong
- Fapet classrooms
- FMIPA practical laboratory
- LSI Library

using panorama 360° environments, hotspot interactions, and teleport-based navigation.

---

# Project Type
VR Interactive Virtual Tour

---

# Main Features
- 360° panorama exploration
- VR-based environment visualization
- Teleport / scene navigation
- Hotspot interaction system
- Educational popup information
- Linear progression exploration
- Simple immersive UI

---

# Target Platform
- Windows Desktop

---

# Unity Version
Unity 2022 LTS (VR Template)

Recommended version:
- Unity 2022.3.x LTS

---

# Technologies Used
- Unity Engine
- C#
- XR Interaction Toolkit
- Panorama 360° Environment
- GitHub Version Control

---

# Folder Structure

Assets/
├── Scenes  
├── Panorama  
├── Materials  
├── Scripts  
├── Audio  
├── UI  
├── Prefabs  
└── XR  

---

# Folder Description

## Scenes
Contains Unity scenes for each exploration location.

## Panorama
Stores 360° panorama images.

## Materials
Contains materials used for panorama sphere rendering.

## Scripts
Contains all C# scripts.

## Audio
Contains ambience music and sound effects.

## UI
Contains buttons, icons, popup UI, and menu assets.

## Prefabs
Reusable Unity prefabs.

## XR
XR / VR-related assets and settings.

---

# Main Exploration Flow

Main Menu (Komlong)  
↓  
Explore Komlong  
↓  
Fapet Building  
↓  
Classroom Exploration  
↓  
FMIPA Laboratory  
↓  
LSI Library  
↓  
Ending Scene  

---

# Gameplay Mechanics

## Exploration
Users can look around using VR camera controls.

## Hotspot Interaction
Interactive objects can display:
- room information
- faculty information
- activity descriptions

## Teleport Navigation
Users move between locations using:
- buttons
- teleport hotspots
- simple map navigation

## Progression
Some locations are locked until previous exploration is completed.

---

# Development Scope (MVP)

This project intentionally focuses on:
- simple VR interaction
- panorama exploration
- educational information delivery

The project DOES NOT include:
- multiplayer
- combat system
- complex AI
- open world movement
- advanced physics

---

# Panorama Requirements

Recommended format:
- JPG / PNG
- 2:1 aspect ratio preferred
- High resolution panorama

Example:
- 11904 x 5952
- 9008 x 2144

Panorama images are rendered using:
- inverted sphere mapping

---

# Development Roadmap

## Week 12
- Project planning revision
- Determine exploration flow
- Determine locations

## Week 13
- Setup Unity VR project
- Collect panorama assets
- Create basic VR scenes

## Week 14
- Implement panorama environment
- Create teleport navigation
- Add hotspot interaction

## Week 15
- UI implementation
- Add audio ambience
- Polish interaction system

## Week 16
- Testing and bug fixing
- Final build
- Presentation preparation

---

# Team
FairuzHebat Team

Members:
- Faisal Mumtaz Hidayat
- Fairuz Hibatullah
- Muh Arifaushan
- Muhammad Ammar Rizky

---

# Git Workflow

Recommended branch naming:
- feature/ui
- feature/navigation
- feature/hotspot
- fix/bugname

Commit example:
feat: add hotspot popup system  
fix: panorama material issue

---

# Additional Instructions for AI Assistant

This repository may include a learning module or tutorial file named:

- `projectunity.pdf`

This PDF contains:
- lecture materials
- Unity VR setup tutorial
- panorama implementation guidance
- workflow instructions provided by the lecturer

Before giving suggestions or generating code, please:
- read and understand the contents of `projectunity.pdf`
- follow the workflow and architecture explained in the module whenever possible
- prioritize approaches consistent with the lecturer's tutorial
- avoid conflicting implementations unless necessary

The project uses:
- Unity 2022 LTS
- VR Template
- Panorama 360° environment
- XR Interaction Toolkit

When helping develop this project:
- prioritize simplicity and MVP scope
- avoid overly complex VR systems
- use lightweight interactions
- maintain compatibility with Unity 2022 LTS
- focus on panorama-based VR exploration
- avoid unnecessary dependencies

Preferred systems:
- scene-to-scene navigation
- XR Interaction Toolkit
- simple popup UI
- teleport interaction
- modular scripts

Avoid:
- multiplayer systems
- heavy physics simulation
- procedural generation
- advanced networking
- unnecessary optimization complexity

Important:
This project is an educational VR virtual tour, not a complex VR game.

The primary focus is:
- panorama 360° visualization
- hotspot interaction
- teleport navigation
- educational information popup
- immersive exploration experience

Please explain implementations clearly and use beginner-friendly approaches suitable for university students and a 5-week MVP project.

---

# Credits
Developed as Final Project for:
Computer Graphics and Visualization Course  
IPB University