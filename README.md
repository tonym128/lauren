# lauren
Largely AUtomated REsiziNg app

## What is Lauren
It's a Windows C# application.

It's an automated image resizer with some configuration for allowing it to crop and resize files the way you want.

There's options for :
- Choosing a focus area
- 3 Profiles with settings
- Each setting defines 
  - Width and Height
  - Compression
  - Max size

With options set when you drag and drop a file in, it will create all the file sizes you've specified using the centre point to define the middle of the image as best it can.

Initially it will resize the image to match one axis in size, then after that it will crop and resize to achieve the resolution desired.

## Should it be more complicated ?
I looked at using Microsofts online service for determining the focal point of a picture, but the time and complexity it added was not worth it's ability to remove a single user click.

## What more should the app do ?
- Batch Resizing
- Clever'er algorithms
- More cusomtisation options
- Flexible profiles

## But will it do it ?
I will happily accept changes from any interested parties, but will probably not extend the app further unless I get some demand for it.
