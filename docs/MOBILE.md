# Mobile + CrazyGames

## Controls (touch-ui)

| Control | Action |
|---------|--------|
| Left drag / joystick | Move |
| TEMBAK | Hold/release shot meter |
| OPER | Pass |
| SPRINT | Hold boost |
| GANTI | Cycle team A player |
| PIVOT | Hold pivot |
| PRESS | Auto-defend |

Keyboard: WASD, Space shoot, P pass, Shift sprint, Q switch.

## Detection

`pointer:coarse`, small viewport, or `ontouchstart` → `body.touch-ui` + lower particle/crowd budget.

## Left hand

`localStorage hoopsLeftHand=1` mirrors stick/buttons.

## Dynamic stick

Touch left ~48% of court repositions the stick under the finger.
