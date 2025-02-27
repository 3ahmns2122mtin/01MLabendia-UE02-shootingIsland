
# UE02 Shooting Island 

### Projektbeschreibung: 
Wir haben ein 2D Game erstellt dessen Ziel es ist 10 targets zu treffen damit man im Spiel gewinnt.

### Entwicklungsplattform: 
Mac OS Big Sur, Unity 2020.3.18f1, Visual Studio Version 2019 Community

### Zielplattform: 
WebGL Referenzauflösung (960x600) 


### Visuelle Einblicke in das Projekt: 
![Screenshot shootingIsland](https://user-images.githubusercontent.com/90834283/144318825-4d17370b-fde2-4b1d-bfff-0982cb27648f.png)
https://3ahmns2122mtin.github.io/02MLabendia-UE02-shootingIsland/

### Drittmaterial: 

Sounds: 
EndSound: https://youtu.be/3BsBXp6VkvU

Font:
Galactic Font: https://www.dafont.com/galactic-2.font

Images:
Galactic Background: ![Galactic background](https://user-images.githubusercontent.com/90834283/144316682-dcebb5e4-ccac-4da4-9eb6-8618ff44acb4.jpeg)
Meteor (Photoshop bearbeitet):

![kisspng-meteor-crater-meteoroid-meteorite-outer-space-aste-meteor-5b337e1bd27941 4854539715301012758621](https://user-images.githubusercontent.com/90834283/144316870-2f20faeb-9e79-4610-a0e3-2d4af56506bf.png)






### Anforderungsliste:  
- [x] WebGL export/upload lauffähig/spielbar
- [x] 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen
- [x] In Assets Folder MyGame anlegen.
- [x] Den Ordner Scenes in Assets > MyGame ziehen
- [x] Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene
- [x] Ein Canvas GameObject anlegen.
- [x] Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, 
das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.
- [x] In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.
- [x] In Asstets > MyGame den Folder Sprites anlegen. 
- [x] Ein Hintergrund Sprite reinladen.
- [x] In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.
- [x] Das Image ggf. positionieren und größentechnisch anpassen.
- [x] Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen. 
- [x] Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag. 
- [x] Das empty GameObject umbenennen in ParentTargets.
- [x] in Assets > MyGame > Prefabs Folder anlegen.
- [x] Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.
- [x] Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen. 
- [x] Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die 
- [x] Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen. 
- [x] In Assets > MyGame einen neuen Ordner anlegen Scripts
- [x] In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit Doppelklick öffnen in Visual Studio.
- [x] Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop). 
- [x] Einen 2D Collider als Komponente dem Target hinzufügen. 
- [x] Dem Script Target eine Methode OnMouseDown() hinzufügen. 
- [x] In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen
- [x] Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen. 
- [x] In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen. 
- [x] Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.
- [x] Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.

- [x] Projekt etwas verschönern (EndSound, Extratext(Mission))


### Limitationen:


Copyright by Mlabendia
