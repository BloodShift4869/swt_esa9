# swt_esa9
Unity DVC test for SWT

## Bearbeitung
1. Zunächst habe ich auf GitHub dieses Repository erstellt und eine *gitignore*-Datei für Unity hinzugefügt.
2. Danach habe ich das Repo auf meinen PC mit GitHub Desktop geklont und in Unity ein neues Projekt erzeugt (inital commit)
3. Anschließend habe ich eine Plane und einen Cube (das soll der Player sein) hinzugefügt
    1. Der erste Branch war **Player-Movement**: Hiermit kann der Würfel in alle vier Himmelsrichtungen bewegt werden
    2. Nach der Implementierung wurde der Branch in den **main** gemergt
4. Der Head wurde im **main** auf das Level-Setup verlegt ("Zeitreise")
5. Von dort wurde der Branch **Camera-Controller** erstellt
    1. Die initiale Position der Kamera stellt das Offset zu dem Spieler dar und wird laufend aktualisiert. Somit folgt die Kamera dem Spieler
    2. Die Änderungen wurden committed, gepusht und anschließend mit dem **main** gemergt
6. Dieses Markdown wurde erweitert und committed
7. Der Pull Request "PR test #513" wurde in Ihrem [Repo](https://github.com/edlich/education) eingestellt