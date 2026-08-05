# HOOPS PRO — Code structure (balanced layers)

Single-file index.html for CrazyGames. Logical modules must stay even.

0 PLATFORM · 1 DATA · 2 PERSISTENCE · 3 INPUT · 4 GAMEPLAY · 5 PRESENTATION · 6 META UI · 7 LIVE OPS

Dependency: DATA → PERSISTENCE → GAMEPLAY → PRESENTATION; META UI reads data, does not write physics.

Balance: menu = CTA only; split saves; curated events; no 100 dead feature buttons.
