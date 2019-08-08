# 2019_openCV
 openCV 사용기

1. WindowsFormsApp1
    - openCVSharp
    - 기능
        1. 영상을 초당 n개의 이미지로 분할
        2. 이미지들을 FPS가 n인 영상으로 제작

            - program

        ![application1](./sample_image/application1.JPG)


2. image_processing
    - opencv-python
    - 기능
        1. 이미지들을 분할
        2. 분할된 이미지들을 새로운 색상으로 변환

    - C# form에 opencv-python을 얹으려 했으나 여러 문제로 python console로 진행..

        - image
            ![original_image](./sample_image/image_processing_origin.jpg)

        - clustering
            ![clustering](./sample_image/image_processing_cluster.jpg)

        - segmentatoin
            ![segmentation](./sample_image/image_processing_segmentation.JPG)

        - blur
            ![blur](./sample_image/image_processing_blur.jpg)

        - output
            ![output](./sample_image/image_processing_output.jpg)

        - program
            ![application3](./sample_image/application3.png)
