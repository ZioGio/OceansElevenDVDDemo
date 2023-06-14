# OceansElevenDVDDemo

I created the original Ocean's Eleven DVD menu demo in Silverlight back in 2010 to demonstrate that XAML could create layered, complex animations with parallax, and still run smoothly.  This is a UWP port of that project.  

Back then I used Microsoft Expression Studio to complete the project.  I used Expression Design to create all the bitmap assets and vector paths.  I used Expression Encoder to create the .wmv and .wma files and to grab the frame captures I used to fill the number assets.  Finally, I used Expression Blend to put it all together.

I paid close attention to the details.  For example, the "1" paths are all slightly different from each other, just like in the real Ocean's Eleven DVD menu.  The timing of the animation with the music is also close to the original (you may need to turn up your speakers to hear the music).  

Unfortunately, I had to remove the video that plays within the stationary "11" path because UWP does not have a VideoBrush like Silverlight did to use a video as a path fill.  I will keep my eyes out for a solution so I can complete the port.

The screenshot below does not do justice to the animation, so I suggest you play the DVDMenu.wmv in the files above and then build this project to see the comparison.  

![](OceansElevenDVDDemoScreenShot.png?raw=true)
