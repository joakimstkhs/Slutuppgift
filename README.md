# ShortestRouteFinder

## Uppgift 3

**Mål**: 

Applikationen ska läsa in en lista över rutter från en JSON-fil, där varje rutt har en startpunkt, destination och avstånd. 
Den ska sortera listan efter avstånd (kortaste rutt först alt längsta först) med minst två olika sorteringsalgoritmer (t ex Bubble Sort och Quick Sort). 
Användaren ska kunna välja sorterings algoritm.

Resultatet visas sedan i GUI.

**Förbättringar (Nice to have)**:

Utvärdering: Utöka input data och visa beräkningstiden för varje vald algoritm.


**Komponenter**:

- **Model**: 

  Representerar en rutt och hanterar datan från JSON-filen.
  
- **ViewModel**: 

  Innehåller logiken för att sortera listan och uppdatera vyn.
  
- **View**: 

  WPF-gränssnittet som visar rutter i en lista och låter användaren välja en sorteringsmetod.
  
