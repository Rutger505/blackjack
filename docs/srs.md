# Software Requirements Specification

<!-- @formatter:off -->
<!-- TOC -->
* [Software Requirements Specification](#software-requirements-specification)
  * [Termen](#termen)
  * [Introductie](#introductie)
    * [Overzicht een ronde](#overzicht-een-ronde)
  * [Systeem vereisten functionaliteiten](#systeem-vereisten-functionaliteiten)
  * [Vragen](#vragen)
<!-- TOC -->
<!-- @formatter:on -->

## Termen

| Termen        | Betekenis                                                                                                                                                                                             |
|---------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Suit          | De type van een kaart. Een van de volgende: Clubs, Spades, Hearts, Diamonds                                                                                                                           |
| Face          | De waarde van een kaart. Een van de volgende: 3, 6, Jack, Queen, King, Ace                                                                                                                            |
| Hit           | De speler krijgt een kaart                                                                                                                                                                            |
| Stand         | De speler endigt de beurt voor die hand                                                                                                                                                               |
| Blackjack     | De speler heeft 2 kaarten met een totale waarde van 21                                                                                                                                                |
| Burn          | Een kaart afleggen op de afleg stapel                                                                                                                                                                 |
| Double down   | De speler dubbelt zijn inzet en krijgt een kaart. Dan eindigt de beurt voor die hand                                                                                                                  |
| Split         | De speler kan bij een dubbele face zijn hand splitsen in tweeën. Dit betekend dat hij nu twee handen speelt.                                                                                          |
| Insurance bet | De speler kan bij een aas van de dealer de helft van zijn inzet geven. Als de dealer dan Blackjack heeft pakt de speler alle chips terug inclusief de insurance anders is de insurance voor de dealer |
|               |                                                                                                                                                                                                       |
|               |                                                                                                                                                                                                       |
|               |                                                                                                                                                                                                       |
|               |                                                                                                                                                                                                       |
|               |                                                                                                                                                                                                       |

## Introductie

Deze software word geschreven om nieuwe Blackjack dealers op te leiden.

Met deze software kunnen de Dealers in opleiding kunnen alle blackjack regels breken. Aan het einde van een ronde
krijgen ze een score van een 0 tot en met 10 met beschrijving wat ze fout hebben.

### Overzicht een ronde

1. De Spelers zitten aan tafel met inzet op tafel.
2. De dealer schudt de kaarten
3. De dealer burnt een kaart
4. De dealer deelt een kaart aan elke non dealer speler started van links naar rechts
5. De dealer deelt zichzelf een kaart ondersteboven ###########################################
6. De dealer deelt een kaart aan elke non dealer speler started van links naar rechts
7. De dealer deelt zichzelf een kaart met de face naarboven ######################################
    1. Als de dealer een Aas heeft dan vraagt hij of de spelers een Insurance bet willen
    2. Als de dealer een 10 of een Aas heeft dan kijkt hij of hij blackjack heeft
    3. Als de dealer blackjack heeft wint hij tenzij de speler ook blackjack heeft dan is het even en nemen zij hun geld
       terug.
8. De dealer kijkt of de spelers blackjack hebben.
    1. Als de dealer blackjack heeft verliezen de spelers hun inzet en heeft de dealer de ronden gewonnen tenzij een
       speler ook blackjack heeft dan is het even en
       neemt die speler zijn geld terug en is de ronde voor hen voorbij.
    2. Als een speler blackjack heeft krijgt hij 1.5 keer zijn inzet terug en is de ronde voor hem voorbij.
9. De dealer doet het volgende per non dealer speler's handen start van links en eidigd met de non dealer speler's
   handen rechts
    * Als de speler Split speelt hij twee handen. De dealer start dan opnieuw bij deze speler en behandeld zijn twee
      handen als normale handen.
    * Als de speler dubble down gaat deelt de dealer één kaart.
    * De speler kan geen speciale actie doen.
        1. De speler kan kiezen om te hitten dit betekend dat hij een kaart krijgt.
        2. De speler kan kiezen om te passen dit betekend dat hij geen kaart krijgt en de beurd van die hand beëidigt.
        3. Als de speler meer dan 21 heeft verliest hij. Dan pakt de dealer zijn kaarten en inzet.
10. De dealer gaat zijn eigen kaarten trekken. Herhaal dit todat hij niet meer wil hitten en hij meer dan 17 heeft.
    1. De dealer kiest om te hitten
    2. De dealer kiest om te standen
11. De dealer kijkt per hand of hij gewonnen heeft of niet.
    1. Als de speler meer heeft dan de dealer wint hij en krijgt hij 100%.
    2. Als de dealer meer dan 21 heeft wint de speler.
    3. Als de speler meer heeft dan de dealer wint hij.
    4. Als de speler even veel heeft als de dealer is het even en neemt hij zijn inzet terug.
    5. Als de speler minder heeft dan de dealer verliest hij.

## Systeem vereisten functionaliteiten

| Feature          | Prioriteit (MoSCoW) |
|------------------|---------------------|
| De software moet |                     |
|                  |                     |
|                  |                     |
|                  |                     |
|                  |                     |
|                  |                     |
|                  |                     |
|                  |                     |
|                  |                     |

## Vragen

Moet ik nog use cases schrijven naast dit bestand?

kunnen de use case/diagram in dit bestand?

Diagrams maken?