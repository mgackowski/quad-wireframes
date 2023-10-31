# Quad Wireframes for Unity

![Screenshot of a four cubes using the wireframe script.](/Images/cubes.jpg)

An approach to adding wireframes to your objects in Unity without the use of shaders. I wrote this specifically so that I could filter our the diagonal lines from quadrilateral surfaces. The implementation is pretty simple and uses GL.LINES and GL.QUADS for rendering.

## Usage

Only WireframeRenderer.cs is required, but the contents of the Assets/Editor folder are recommended for ease of use.
1. Attach the WireframeRenderer component to your GameObject(s). Note that a MeshFilter component is required.
2. Use the buttons in the inspector to prepare the wireframe. This generates a list of line segments that get serialised with the script.
3. The wireframes will be visible in Play Mode.

![Screenshot of the script's custom inspector.](/Images/inspector.jpg)

### Render mode

"Lines" uses GL.LINES, which limits this mode to single-pixel wide rendering. The width parameter has no effect.

"Quads" uses GL.QUADS, which do have a configurable width.

### Z-fighting

When using quads, the geometry of the wireframe will create visible artifacting if you're also using a mesh renderer. To avoid that, you can use the shader and material provided for the wireframe (see example scene). The shader simply forces an offset in the depth buffer.
