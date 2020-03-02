# What is PureBitmap?

The main aim of this package is to provide a fully cross-platform way to generate images from code.
Unfortunately, most of libraries are overkilled with many unecessary functionality. Moreover, they are limited with own UI controls and/or supported only by limited number of platforms.

So, let's do it in another way ;)

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
