rgb_image = imread('C:\Users\user\Desktop\777-pic668-668x444-90692.jpg');
rgb_image = rgb2gray(rgb_image);
bw = imbinarize(rgb_image);
%marker = imerode(bw, strel('line', 10, 0));
%clean_image = imreconstruct(marker, bw);
clean_image = imcomplement(bw);
results = ocr(clean_image,'TextLayout', 'Block');
disp(results.Text);
imshow(clean_image);