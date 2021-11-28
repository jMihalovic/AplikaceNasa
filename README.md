# Aplikace Nasa
## Specifikace požadavků
### Verze 1

Jakub Mihalovič <br/>
mihalovic.jakub.2018@skola.ssps.cz <br/>
28. 11. 2021

* Úvod
  * Tento dokument slouží k vytvoření aplikace zobrazující data o vesmírných tělesech v blízkosti Země.
  * Kontakt
    * Jakub Mihalovič 
    * mihalovic.jakub.2018@skola.ssps.cz
* Celkový popis
  * Cílem je vytvořit WPF aplikaci, která zobrazí informace o asteroidech poblíž Země pomocí dat z Nasa API.
  * Aplikace bude ukazovat výčet položek
  * Při rozkliknutí položky se zobrazí podrobnější informace
  * Tělesa si bude možné uložit do oblíbených
  * Oblíbená tělesa bude možné zobrazit i v offline režimu
* Uživatelské skupiny
  * Aplikace bude mít pouze jeden způsob užití.
* Omezení návrhu a implementace
  * Bez připojení k internetu se zobrazí pouze oblíbené položky 
* Požadavky na rozhraní
  * WPF
  * Windows
* Vlastnosti systému
  1. Načtení dat při zapnutí aplikace
    * Vstup : Zapnutí aplikace
    * Akce : Požadavek o data z Nasa API
    * Výstup 1: Vypsání vesmírných těles do seznamu
    * Výstup 2: Při offline režimu zobrazení oblíbených položek
  2. Obnovení dat
    * Vstup : Tlačítko pro obnovení
    * Akce : Požadavek o data z Nasa API
    * Výstup 1: Vypsání vesmírných těles do seznamu
    * Výstup 2: Hlášení při offline režimu
  3. Podrobné informace
    * Vstup : Kliknutí na těleso v seznamu
    * Akce : Otevření nového okna
    * Výstup : Podrobné informace o tělesu
  4. Přidání do oblíbených
    * Vstup : Zmáčnutí tlačítka na rozkliknutém tělesu
    * Akce : Uložení dat do zařízení
    * Výstup : Položku bude možné zobrazit i v offline režimu
