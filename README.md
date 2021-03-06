# Ordering Color

My senior capstone project demonstrating different algorithms 
and their uses in ordering color. 

## Project Description
Both RGB and HSV colorspaces can be understood as a three-dimensional plane with 
colors existing as points. Values r, g, b and h, s, v can be understood as x, y, z
coordinates. This opens up the possibility of using the nearest neighbor algorithm,
as well as using space-filling curves such as the z-order curve and Hilbert curve, 
to order color. These graph-based solutions can be compared to more naive 
implementations of color ordering, such as using quicksort to order on individual
values.

## Requirements
Visual Studio

The code is written in C# and is available to be download and run through the
Visual Studio IDE that it was written in.

## GUI Usage
After downloading, launch the application in Visual Studio, this will alow you to
select both the algorithm to run and the color space to use. Doing so will change
the visualization of the color list at the bottom of the application. 

## Author
Independantly written by Chantal Danyluk, many thanks to my professor Bayazit Karaman
for his aid in understanding the Hilbert Curve.
