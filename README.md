<<<<<<< HEAD
=======
# PCTO2025

This repository contains all of the code, examples and sketches used during our GameAbility Unity game project HNCR( Hololens Cell Nerve Recovery).

## TEAM

Our team is composed of 4 ITIS students from Cuneo, Italy.

## FENOGLIO SAMUELE

Fenoglio Samuele is the group leader and manager, he developed part of the code in c# and contributed most to the installation of Unity, MRTK and managed the gitHub.

## DANNA MATTIA

Danna Mattia has helped to program in c# and contributed to the development of unity.

## MASOERO ANDREA

Masoero Andrea contributed to the installation and development of unity. he was the web developer creating the project website and the download of the MRTK and managed the gitHub.

## FINO ANDREA

Fino Andrea up has contributed to the creation of the C# code and the development of unity.



# INSTRUCTION MANUAL

● In settings, look for developer mode and activate it.

● Download and install Unity Hub on your PC

● Download the HoloTrainer folder on your machine,

● If the multiple files are not already in a folder, put them in one 

● THIS FOLDER BECOMES YOUR UNITY PROJECT

● Open Unity Hub

● On the left-hand side of the window, you will find the Projects tab

● Click Add

● Select the folder which contains the project

● The project will get added below the Add button

● Open the project

● Now it will ask you to download the right Unity version (2022.3.20f1 LTS)

● With Unity it will in the installs tab a menu with different options you can checkmark

● Checkmark Visual Studio Community 2022, Universal Windows Platform Build Support, Windows Build Support(IL2CPP)

● Click Install

● It will open the Visual Studio Installer window

● In this window checkmark ● .NET desktop development_

● Desktop development with C++

● Universal Windows Platform (UWP) development

● Game development with Unity, On the right-hand side of the screen click Universal Windows Platform (UWP) development
● checkmark 

● USB Device Connectivity (required to deploy/debug to HoloLens over USB)

● C++ (v143) Universal Windows Platform tools

● Click Install

# Now you want to build the project
In the menu bar, select File > Build Settings....

● In the Build Settings window, select Universal Windows Platform. If you see a message "No Universal Windows Platform module loaded.", select Install with Unity Hub.

● Make sure the following settings are active:

● Architecture: ARM 64-bit

● Build Type: D3D Project

● Target SDK Version: Latest Installed

● Minimum Platform Version: 10.0.10240.0

● Visual Studio Version: Latest installed

● Build and Run on: Local Machine

● Build configuration: Release (there are known performance issues with Debug)

● Select the Switch Platform button. Unity displays a progress bar while it switches platforms.

● After the switch platform process is finished, click on Build and select an empty directory.

● Open that same directory and open _HoloTrainer.sln

● Configure Visual Studio for Hololens by selecting the Release configuration and the ARM64 architecture enter image description here

### NOTE: If you don't see "Device" as a target option in Visual Studio, you may need to change the startup project for the solution from the IL2CPP project to the UWP project. To do this, in the Solution Explorer, right-click [your project name](Universal Windows) and then select Set as StartUp Project. Before building to your device, the device must be in Developer Mode and paired with your development computer. See the section named "Enabling Developer Mode" on this page.

● Select the deployment target drop-down and then do one of the following: If you're building and deploying via USB, select Device.

● Connect your HoloLens to your computer, and then in Visual Studio, do one of the following:
To deploy to your HoloLens and automatically start the app without the Visual Studio debugger attached, select Debug > Start Without Debugging.

enter image description here

To deploy to your HoloLens without having the app start automatically, select Build > Deploy Solution.

Pairing your device The first time you deploy an app to your HoloLens from your PC, you'll be prompted for a PIN. To create a PIN:
In your HoloLens and your machine, look for developer settings Select Pair. This displays the PIN in the HoloLens. Enter the PIN in the dialog in Visual Studio. After pairing is complete, in the HoloLens, select Done. Your PC is now paired with your HoloLens and you can deploy apps automatically. Repeat these steps for every PC that's used to deploy apps to your HoloLens.

Running your app on your HoloLens After your app finishes building, in the HoloLens Start menu, find your app, and then select it.
DO IT YOURSELF
If you want to make a Unity Hololens project yourself, follow this tutorial: https://learn.microsoft.com/en-us/training/paths/beginner-hololens-2-tutorials/

## NOTE: If you are following the Italian version of the tutorial: DO NOT SELECT "Mixed Reality Toolkit Foundation" in Mixed Reality Toolkit in Microsoft Mixed Reality Feature Tool
>>>>>>> 329b7056368695e43f1a847302797416e28e3908
