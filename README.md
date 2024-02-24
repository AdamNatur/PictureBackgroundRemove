# PictureBackgroundRemove

This application is designed to separate the object and the background in the picture and remove it from the picture. 

The interface below:
![image](https://github.com/AdamNatur/PictureBackgroundRemove/assets/92713694/4c3fa912-9d34-4909-9683-86fa66bef456)


The detection algorithm consists of passing through the image by pixels and comparing two neighboring pixels. With a sudden change in RGB formulas system detects that and defines the next pixel as bound of the object in the picture. After the detection further pixel will be defined as object pixel, while RGB formulas will not be high enough (it controls with specific value parameter), and the further pixels will be defined as background pixels respectively. The main concepts is like aerodynamic flow, which flows around the object, just touching its bound surfaces. 

The application opportunities:
1) Detecting backgound and main object;
2) Coloring background and main object;
3) Deleting background and main object;
4) Detecting a contour of object

The example of working process is shown below:
Before finding the backgroung
![image](https://github.com/AdamNatur/PictureBackgroundRemove/assets/92713694/8b73114c-1f7b-469d-97ee-71e227f1755f)

After detecting the background ( it is colored in red)

![image](https://github.com/AdamNatur/PictureBackgroundRemove/assets/92713694/9f2e53e0-cea2-4d41-8310-f87f3981055f)




