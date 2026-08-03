# CrazyGames / embed / 4K notes

## Hosting

1. Upload single file `HOOPS_PRO_PREMIUM.html` (or packed loader + parts).
2. Game detects iframe (`IS_EMBED`) and lowers particle/crowd budget.
3. Canvas scales with viewport; DPR capped with pixel budget (~8MP) for 4K stability.
4. `localStorage` wrapped in try/catch for private/iframe restrictions.

## QA checklist

- [ ] Loads inside iframe without console errors
- [ ] First click unlocks audio
- [ ] Resize / orientation keeps canvas visible
- [ ] Manager save survives refresh when storage allowed
- [ ] Putback does not fire after match end

## Limits

Still HTML5 2D canvas — not native 4K PBR. "4K ready" means sharp scaling + stable FPS, not console-grade graphics.
