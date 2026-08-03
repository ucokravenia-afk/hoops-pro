# Art system — logos & portraits

## Why procedural?

Generating hundreds of AI image files would bloat a single HTML build and risk real-person likeness issues. HOOPS uses **deterministic canvas art**:

- Same name → same face (hash-based skin, hair, style)
- Same club → same crest (primary/secondary colors + monogram)
- Original geometry — not scraped NBA / EA assets

## Club logos

`clubLogoDataUrl(club, size)` — shield crest, metallic ring, short monogram, star mark.
Shown on team select + manager pick cards.

## Player portraits

`playerAvatarDataUrl(name, number, jerseyColor, size)` — FC26-inspired card:
jersey shoulders, neck, head, hair variants, eyes, number badge, gold frame.

Used on-court discs and can be reused in menus/stats.

## FC26 feel

Visual language (card frame, shoulder crop, premium palette) — **not** licensed EA faces or kits.
