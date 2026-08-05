# Modular Architecture (MVC map)

Single-file HTML, logical modules: View (overlays+canvas) / Controller (input, show*, rules) / Model (match, career, manager, rpg, cards, settings).

Match loop: loop → update(dt) → render().

Motion: updateMotionBlend (loco states + mass).

Extension rule: one model slice + one overlay + thin controller.
