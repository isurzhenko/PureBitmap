# What is PureBitmap?

The main aim of this package is to provide a fully cross-platform way to generate images from code.
Unfortunately, most of libraries are overkilled with many unecessary functionality. Moreover, they are limited with own UI controls and/or supported only by limited number of platforms.

So, let's do it in another way ;)

# Current limitations

1. Supports only generation of the bitmap (no plans in discoverable future).
2. Supports only ARGB32 colorspace (probably, new colorspaces will appear soon)
3. Supports only `PutPixel` operation (absolutely, it will support most common standard drawing things like `DrawRect`, `DrawLine`, etc)
4. Supports plain old Win3.1 bitmap output (probably, will be gained later)

# Sample
```
var bmp = new ARGB32WinBitmap(2, 2);
bmp.PutPixel(1, 1, ARGB32.Black);
bmp.PutPixel(0, 0, ARGB32.White);
using (var stream = bmp.OutputStream())
{
  ... use stream for output ...
}
```
