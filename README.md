# OceansElevenDVDDemo

I created the original Ocean's Eleven DVD menu demo in Silverlight back in 2010 to demonstrate that XAML could create layered, complex animations, and still run smoothly.  This is a UWP port of that project.  

Back then I used Microsoft Expression Studio to complete the project.  I used Expression Design to create all the bitmap assets and vector paths.  I used Expression Encoder to create the .wmv and .wma files and to grab the frame captures I used to fill the number assets.  Finally, I used Expression Blend to put it all together.

I paid very close attention to the details.  For example, the "1" assets are all slightly different from each other, just like in the real Ocean's Eleven DVD menu.  The timing of the animation with the music is also very close to the original (you may need to turn up your speakers to hear the music).  

When I couldn't find the same screen grabs the actual DVD menu used for the number fills (likely because they were from deleted scenes), I created my own from frame captures.

Unfortunately, I had to remove the video that plays within the "11" when the menu appears because UWP does not have the VideoBrush like Silverlight did to play a video in the path fill.  I'll keep my eyes out for a solution so I can complete the port.

The screenshot below doesn't do justice to the animation, so I suggest you play the DVDMenu.wmv in the files above and then build this project to see the comparison.  

![](OceansElevenDVDDemoScreenShot.png?raw=true)
