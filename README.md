# Forschungsprojekt Holographic Grisons

## Prototyp

Der vorliegende Protyp fürs Forschungsprojekt Holographic Grisons umfasst ein Terrain mit platzierbaren Annotationen und zeigt anhand eines angezeigten Weges wie Wegdaten (z.B. von OpenStreetMap) importiert und aufs Terrain gemappt werden können. Vorbeiziehende Wolken zeigen wie ein Modell durch eine Immersionsebene erweitert werden kann.

Das ausgewählte Terrain umfasst Arosa und Umgebung. Die Szene ist so aufgebaut, dass sie relativ einfach auf andere Gebiete angepasst werden kann. 

[Screen recording](https://drive.google.com/file/d/1bQkQS4UM795xcwBWdy0i45mah5A30EtM/view) vom laufenden Prototyp in HoloLens.

## Systemvoraussetzungen

- Windows 10 PC mit den richtigen Tools installiert:
  - [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
  - [Windows 10 SDK](https://developer.microsoft.com/en-US/windows/downloads/windows-10-sdk)
  - [Unity 2017.4.15f1](https://unity3d.com/unity/qa/lts-releases)
  - [Mixed Reality Toolkit](https://github.com/Microsoft/MixedRealityToolkit-Unity/blob/master/README.md)
  
[Detaillierte Installationsanleitung](https://docs.microsoft.com/en-us/windows/mixed-reality/install-the-tools)
- HoloLens device 

Dieses Repository nutzt Git Large File Storage (git-lfs) für grosse Dateien. Git-lfs muss lokal auf dem Computer installiert werden: [https://git-lfs.github.com](https://git-lfs.github.com)

## Installation

1) Clone Repository:

Command Line: 
```
git clone https://github.com/MartinVollenweider/holographic_grisons.git
```

Github Desktop:


![Open in GitHub Desktop](https://user-images.githubusercontent.com/6608578/51750981-f6997e00-20b3-11e9-8ae5-b138ca46a3b9.png)

2) Unity starten

3) Projekt in Unity öffnen


## Projekt von Unity nach Visual Studio exportieren

Build und Deployment erfolgen wie [hier](https://docs.microsoft.com/en-us/windows/mixed-reality/holograms-101) beschrieben. 
Die wichtigsten Schritte erfolgen wie folgt: 

- In Unity select File > Build Settings.
- Select Universal Windows Platform in the Platform list and click Switch Platform.
- Set SDK to Universal 10 and Build Type to D3D.
- Check Unity C# Projects.
- Click Add Open Scenes to add the scene.

![Build Settings](https://user-images.githubusercontent.com/6608578/51751697-c652df00-20b5-11e9-8e6d-076ddb9967e2.jpg)

- Click Build.
- In the file explorer window that appears, create a New Folder named "App".
- Single click the App Folder.
- Press Select Folder.
- When Unity is done, a File Explorer window will appear.
- Open the App folder.
- Open (double click) _HolographicGrisons.sln_.
- Using the top toolbar in Visual Studio, change the target from Debug to Release and from ARM to X86.
- Click on the arrow next to the Device button, and select Remote Machine to deploy over Wi-Fi.
- Set the Address to the name or IP address of your HoloLens. If you do not know your device IP address, look in Settings > - - Network & Internet > Advanced Options or ask Cortana "Hey Cortana, What's my IP address?"
- If the HoloLens is attached over USB, you may instead select Device to deploy over USB.
- Leave the Authentication Mode set to Universal.
- Click Select
- Click Debug > Start Without debugging or press Ctrl + F5. If this is the first time deploying to your device, you will need to pair it with Visual Studio.
- The HolographicGrisons project will now build, deploy to your HoloLens, and then run.
- Put on your HoloLens and look around to see your new holograms.

## Bedienung

Die Annotationen, der angezeigte Weg und die Wolken können via Speech Commands ein und ausgeschaltet werden: 

- _"Labels on"_: Einblenden der Annotationen
- _"Labels off"_: Ausblenden der Annotationen
- _"Trails on"_: Einblenden des Weges
- _"Trails off"_: Ausblenden des Weges
- _"Weather on"_: Einblenden der Wolken
- _"Weather off"_: Ausblenden der Wolken



## Benutzte Assets

### Real World Terrain

Für bequemes importieren und konfigurieren von Gelände inkl. Texturen wird das Asset [Real World Terrain](https://assetstore.unity.com/packages/tools/terrain/real-world-terrain-8752) benutzt. Das Asset ist schon bestandteil des Projektes und muss nicht mehr runtergeladen bzw. gekauft werden. 

[Dokumentation](http://infinity-code.com/en/docs/real-world-terrain)

