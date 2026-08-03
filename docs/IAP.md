# In-app purchases

## Policy

- **Cosmetics only** — no stat boosts / pay-to-win
- Real money only through **CrazyGames + Xsolla** (invite-only on their platform)
- Disabled inside CrazyGames **mobile app** (`applicationType` store) per CG docs

## Config

```html
<script>
window.HOOPS_XSOLLA_PROJECT_ID = "YOUR_ID_FROM_CRAZYGAMES";
</script>
```

## Flows

| Flow | When |
|------|------|
| Soft coins | Match rewards, daily login, coin shop prices |
| Rewarded ad | `SDK.ad.requestAd('rewarded')` → +coins |
| Premium | `SDK.user.getXsollaUserToken()` then Xsolla catalog/pay station |

## API used

- `getXsollaUserToken()`
- Inventory GET `store.xsolla.com/api/v2/project/{id}/user/inventory/items`
- Rewarded ads module

Full Pay Station UI is completed in CrazyGames/Xsolla portal after IAP approval.
