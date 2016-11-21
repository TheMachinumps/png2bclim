png2bclim
=========

BCLIM Converter (to/from PNG)

![alt tag](http://i.cubeupload.com/5spMqp.png)

Drag & Drop (or via the Open Button) to convert a PNG to BCLIM.
Output format should be specified via the ComboBox dropdowns.
A new BCLIM file will be saved in the same directory as "new_[filename].bclim"

Drag & Drop (or via the Open Button) to convert a BCLIM to PNG.
Input format should be automatically detected.
This program currently does not support bclim creation for Ericsson Compressed BCLIMs (etc1/etc1A4) or HILO8.
A new PNG file will be saved in the same directory as "[filename].png"

This version was made to fix some conversion formats and make a nice looking GUI

Formats fixed:
  - RGB565;
  - A4;
  - L4;

It took me some time to figure out why they were converting things in a weird way, but I found out why after tonnes of experiments!

Example: Inserting an Image... (original image had bad transparency)

Input PNG - http://i.imgur.com/XQb95VT.png
Ingame - http://i.imgur.com/LLc0Quu.jpg
