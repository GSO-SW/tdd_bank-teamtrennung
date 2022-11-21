# Bank
Beachten Sie den Reiter Issues in GitHub. Können Sie das Issue mit einem Pull-Request schließen?
 
 -1.1

Was sind User Stories:
User Stories sind einfach gesehen die Anforderungen der Kunden.

1.2
- Wer fordert etwas an? (Rolle)
    Der Anforderer. (meist der spätere Nutzer)
    
- Was wünscht sich der Anforderer (Funktion)
    Das Bestimmte, was passieren, muss.



- Warum ist das für den Geschäftsfall wichtig (Nutzen)
    Durch diese soll ein Ziel erreicht werden.



- Mit INVEST-Kriterien
    1. Independant
        - Jede User-Story soll unabhängig von einer anderen sein.
    2. Negotiable
        - Product Owner, Stakeholder und das Entwicklerteam diskutieren und präzisieren eine User Story gemeinsam.
    3. Valuable
        - Ergebnis muss sinnvoll sein
    4. Estimatable
        - Aufwände für die Realisierung muss abschätzbar
    5. Small
        - Umfang möglichst klein, präzise und leicht zum Verstehen
    6. Testable
        - Jede Story muss getestet werden. Mit dem Test wird die Umsetzung festgestellt.
1.3
-ist eine Checkliste mit Qualitätskriterien, die beschreibt, welche Aspekte erfüllt sein müssen, damit die Erstellung eines Backlog Items,
 eines Features oder einer User Story als abgeschlossen betrachtet werden kann

-2.1 Was sind UnitTests: Mit UnitTests checkt man ob der Code der geschrieben wurde funktoniert würd was er bestimmt wurde.

[10:51] Sagar Tambar
1.2
- Wer fordert etwas an? (Rolle)    Der Anforderer. (meist der spätere Nutzer)    
- Was wünscht sich der Anforderer (Funktion)    Das Bestimmte, was passieren, muss.

- Warum ist das für den Geschäftsfall wichtig (Nutzen)    Durch diese soll ein Ziel erreicht werden.

- Mit INVEST-Kriterien    1. Independant        - Jede User-Story soll unabhängig von einer anderen sein.    2. Negotiable        - Product Owner, Stakeholder und das Entwicklerteam diskutieren und präzisieren eine User Story gemeinsam.    3. Valuable        - Ergebnis muss sinnvoll sein    4. Estimatable        - Aufwände für die Realisierung muss abschätzbar    5. Small        - Umfang möglichst klein, präzise und leicht zum Verstehen    6. Testable        - Jede Story muss getestet werden. Mit dem Test wird die Umsetzung festgestellt.


2.2

- Schritt 1 (Zu testende Klasse als öffentlich deklarieren)    •    Projektmappen-Explorer: zu testende Klasse, z.B. Rechteck.cs öffnen

- Schritt 2 (Neues Komponententestprojekt zur Projektmappe hinzufügen)    •    Projektmappen-Explorer: Rechtsklick auf Projektmappe  Hinzufügen  Neues Projekt hinzufügen: Installiert > Visual C# > Test > Komponententestprojekt > Name: <zu testendes Projekt>Test

- Schritt 3 (Verweis auf zu testehendes Projekt hinzufügen)    •    Projektmappen-Explorer: Rechtsklick auf Komponententestprojekt  Verweis hinzufügen > Projektmappe > Projekte > zu testendes Projekt

- Schritt 4 (Using-Direktive für den Namensraum der zu testenden Klasse hinzufügen)    •    Projektmappen-Explorer: Rechtsklick auf UnitTest1.cs  Umbenennen    •    Name: <zu testende Klasse>Tests, also z.B. RechteckTests    •    Projektmappen-Explorer: Testklasse, z.B. RechteckTests.cs öffnen    •    Im Bereich der Using-Direktiven „using <Namensraum der zu testenden Klasse>;“ einfügen

- Schritt 5 (Testmethode implementieren)    •    Attribut [TestMethod] in eine eigene Zeile vor der Methodendeklaration schreiben    •    Testmethoden haben keine Übergabeparameter und keinen Rückgabewert    •    Name: <zu testende Methode>_Informationen_zum_erwarteten_Verhalten, z.B. Skalieren_AendertBreiteUndHoehe oder Skalieren_Faktor_Null_Schlaegt_Fehl    •    Muster Arrange – Act – Assert (AAA) verwenden

- Schritt 6 (Tests ausführen)    •    Menü: TEST  Fenster  Test-Explorer    •    Fenster Test-Explorer: Alle ausführen

