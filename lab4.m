face_detector = vision.CascadeObjectDetector('FrontalFaceCART');
img = imread('C:\Users\user\Desktop\o1566729345746021.jpeg');
face = step(face_detector, img);
annotated_image = insertObjectAnnotation(img, 'rectangle', face,'Face');
imshow(annotated_image);
