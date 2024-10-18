# Lern-Periode 1

23.4 bis 20.8.2024

## Grob-Planung

Ich möchte einen Kalender programmieren. In diesem Kalender trage ich meine Hausaufgaben und Termine ein. Der Kalender wird dann eine Meldung schicken  mit einer Liste die alle Aufgaben für den nächsten Tag anzeigt.

## Fertiges Projekt
Ich habe ein Prüfungskalender programmiert für die Schule. Man kann dann dort den Monat und das Jahr eingeben und das Programm gibt nur die Prüfungen von diesem Monat aus. Die Prüfungen muss man jedoch am Anfang in das Projekt reinschreiben. Am angfang musste ich lernen wie mit DateTime umzugehen ist. Da habe ich gelernt wie man Daten und Uhrzeiten ausgibt, oder auch wie man Wochentage ausgibt. Ich musste noch recherchieren wie man nur die Bestimmten Prüfungen in einem Zeitraum ausgeben kann. ich haben dann mit hilfe des Internets und herrn Colic eine einfache Version gefunden wie man das macht.
![Screenshot 2024-09-20 112059](https://github.com/user-attachments/assets/afd3ea17-c143-4b95-bc08-3c425d529e86)

Zuerst musste ich den ersten Tag des Monats und dann den letzten Tag des Monats rausfinden. Nämlich mit: `DateTime firstDayOfMonth = new DateTime(year, month, 1); und
DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);`
Danach habe ich eine Liste erstellt in den alle Daten gespeichert sind und dann mit foreach und if razsgefunden welche Prüfungen in diesen bestimmten Monaten sind:

//die Daten in einer Liste speichern

DateTime[] Prüfungen = { Prüfung1, Prüfung2, Prüfung3, Prüfung4, Prüfung5, Prüfung6, Prüfung7, Prüfung8};

//Prüfungen in dem Gesuchten monat rausfinden

foreach (DateTime prüfung in Prüfungen)

Am schluss habe ich noch ein übersichtliches Layout gemacht.
![Screenshot 2024-09-20 112130](https://github.com/user-attachments/assets/f78a3829-2e87-42da-bc61-3bba7c922876)


## 23.4.2024

✍️ Heute habe ich... (50-100 Wörter)

## 30.4.2024

- [x] Recherche wie man einen Kalender Programmiert/ mit welchem Programm?
- [ ] Ein Kalenderjahr eintragen, so das die Daten und Wochentage zu diesem Jahr passen.
- [x] Hersausfinden wie man das Design eines Kalenders programmiern kann.
- [ ] Die Eingabe für Hausaufgaben und Termine machen.

✍️ Heute habe ich... (50-100 Wörter)
Heute habe ich recherchiert wie man ein Kalender programmiert und habe dazu eineige gute Quellen gefunden. Das Video hat mir gezeigt das ich den kalender auf Windows Form benuzen soll. Ich habe dann aber gemerkt das es noch viel gibt wo ich nicht kannte. Mit Herr Colic habe ich eine einfache Version vom Kalender angefangen. Dort lerne ich DateTime besser kennen. Dieser Kalender heisst jetzt meinPrüfungskalender. Er wird mir alle Prüfungen die ich dort eintragen als Liste mit datum Ausgeben.
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen


## 06.09.2024

- [x] Alle Prüfungsdaten einschreiben
- [x] Prüfungsdaten mit Console.WriteLine wieder ausgeben lassen
- [x] Wochentage zu den Daten hinzufügen
- [ ] Progammieren das man den Monat eingibt und nur die Prüfungen in diesem Monat werden angezeigt.


 Heute habe ich...
 Ich habe alle meine Prüfungsdaten von den nächsten paar Wochen eingetragen. Dann habe ich programmiert so dass der Tag das Datum und die Zeit dann ausgegeben wird. Danach war ich sehr lange dran herauszufinden wie man den Monat eingibt und nur die Prüfungen ausgibt die in diesem Monat sind. Ich habe ein paar sachen gefunden die ich aber noch gar nicht verstehe. Am schluss habe ich noch mit Herr Colic geredet und ich kann das erstmals nach diesem Prinzip machen: if (dateB < dateA && dateA < dateC).



 ## 13.09.2024


 - [x] Das Prinzip if (dateB < dateA && dateA < dateC) bei Prüfungsdaten ausprobieren
 - [ ] Das Layout übersichtlicher machen
 - [x] Das Programm nach dem neuen gelernten der Woche verbessern.
 - [ ] -

Heute habe ich..
Das Prinzip if (dateB < dateA && dateA < dateC) bei Prüfungsdaten ausprobiert. Dann hatte ich erstmals ein Problem mit Datetime und firstdayofthemonth. Aber dann konnte ich das problem erheben in dem ich den string in int convertet habe. Ich habe im internet raus gefunden wie man //Prüfungen in dem Gesuchten monat rausfinden kann mit weniger ifs. Nähmlich mit einer Liste -> foreach und dann if und else if.
 

## 20.09.2024

- [x] Herausfinden wie man die Daten in der Prüfungenliste sortiert.
- [ ] Eine Liste machen die nach Datum sortierte ausgabe macht.
- [x] Das Layout übersichtlicher machen.

Heute habe ich...
Mein Kalender fertig programmiert. Zuerst habe ich nachgeschaut wie man das layout übersichtlicher machen kann bei der Ausgabe. Man macht es mit Console.WriteLine("-----------"). So wurden alle daten schön von einander getrennt. Nachdem habe ich nachgeschaut wie man eine Datum sortierte ausgabe macht, ich habe da nicht viel gefunden aber auch weil ich mich später für ein besseres Ziel für mein Kalender interessiert habe. Nämlich wie man die Prüfungen mit einer eingabe für immer im Programm speichert, so das ich nicht immer die Test im Programm eingeben muss und alles dazu ändern muss. Es kam etwas mit System.IO;und file und so. Ich habe es ausprobiert und bin zum schluss gekommen das, dass vielleicht noch zu viel ist.
  

