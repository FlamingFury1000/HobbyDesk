# HobbyDesk

HobbyDesk je jednoduchá desktopová aplikace ve Windows Forms (C#), která slouží k evidenci hobby produktů (např. barvy, štětce, patinátory atd.).  
Aplikace umožňuje produkty přidávat, upravovat, mazat a filtrovat podle kategorií a výrobců.

Data se ukládají do JSON souboru, takže se dají snadno přenášet nebo zálohovat.

---

## Co aplikace umí

### Produkty
- přidávání nových produktů
- úprava produktů
- mazání produktů (s potvrzením)
- možnost odstranit všechny produkty najednou
- možnost přiřadit produktu obrázek

# <img width="885" height="532" alt="promo_produkty" src="https://github.com/user-attachments/assets/1d1ced53-d2b8-4978-ac40-7003cb6d7668" />

### Filtrování produktů
- vyhledávání podle názvu
- filtrování podle kategorie
- filtrování podle výrobce
- tlačítko pro reset filtrů

# <img width="885" height="532" alt="promo_filtrovani_produktu" src="https://github.com/user-attachments/assets/7a3d5f88-6668-465a-90c0-c8f2f0eb7b63" />

### Kategorie a výrobci
- správa kategorií (přidat / upravit / smazat)
- správa výrobců (přidat / upravit / smazat)
- filtr nelze smazat, pokud ho používá nějaký produkt

# <img width="298" height="448" alt="promo_sprava_filtru" src="https://github.com/user-attachments/assets/ae5c1bd6-46b1-42d1-a732-4bcfb3df055f" />

### Domovská stránka
- donut graf s rozdělením produktů podle kategorií
- donut graf s rozdělením produktů podle výrobců
- u výrobců se zobrazuje TOP 5 a zbytek je jako „Ostatní“
- zobrazení počtu produktů, kategorií a výrobců

# <img width="885" height="532" alt="promo_domovska_stranka" src="https://github.com/user-attachments/assets/7804f672-ccbf-4b74-b661-5ee3af81f11f" />

### Ukládání a načítání
- uložení dat do interního JSON souboru aplikace
- možnost uložit data kamkoliv přes "Uložit jako"
- možnost načíst data z libovolného JSON souboru přes "Načíst"

# <img width="883" height="530" alt="promo_ukladani" src="https://github.com/user-attachments/assets/7e5ce703-0e4a-43af-970b-c5fc4729fef8" />

### Ochrana proti neuloženým změnám
- aplikace hlídá neuložené změny
- při zavření aplikace nebo načtení nového souboru se zobrazí upozornění

# <img width="883" height="530" alt="promo_ochrana" src="https://github.com/user-attachments/assets/ab8d9f2e-a695-47eb-a9fd-de5203944ea1" />
---
