# Project_README

2021 ~ 2022까지 프로젝트 진행과 노력들

## 2022년 3월 ADSP 합격
  - ![image-20220413165439250](https://github.com/zerosysk/Project/blob/master/image/ADsP.png)

    
## Tensorflow를 활용한 ObjectDetection_Modeling(ssd)

- 국책과제 수행(인공지능 학습데이터 구축사업_ 융합센서 도로데이터)

  - 3D Lidar 기반 데이터 정제, 가공, CUDA 연산을 위한 Linux 환경구축(CUDA) , Object Detection 모델링

    - 3D 데이터 정제 및 라벨링

    - 모델링을 위한 json파일 converting 
    
    - CUDA 연산을 위한 Linux 환경구축(CUDA)

    - 모델링(모델선정, 환경구축, 모델링, 모델평가 및 수정)

    - 모델을 활용한 모델 Object Detection 구현

    - 수집차량 GPS좌표를 통한 이동경로 시각화 

      

  - 모델학습을 위한 json_file merge및 구조 converting

    - File_Merge :  [jsonfile_merge.ipynb](https://github.com/zerosysk/Project/blob/master/ObjectDetection_Modeling(ssd)/jsonfile_merge.ipynb)

    - File_Converting : [json_xml_conversion.ipynb](https://github.com/zerosysk/Project/blob/master/ObjectDetection_Modeling(ssd)/json_xml_conversion.ipynb)

      

  - 모델 : SSD -> [saved_model.pb](https://github.com/zerosysk/SelfDrive_Project/blob/master/saved_model.pb)

    - saved_model.pb

      - image, json 1184EA Traning

      - epochs = 250EA
      - batch size = 8
      - batch_size=8 -> total_loss : 0.13
      - batch_size=4(기본) -> total_loss : 0.1716125 => 0.17

    

  - 학습모델을 활용한 object_detection 구현 -> [ssd_modeling.ipynb](https://github.com/zerosysk/SelfDrive_Project/blob/master/ssd_modeling.ipynb)

    ![image-20220413135815121](https://github.com/zerosysk/Project/blob/master/image/object_detection.png)

  - 수집차량 GPS좌표를 통한 이동경로 시각화 -> [folium_test.ipynb](https://github.com/zerosysk/Project/blob/master/ObjectDetection_Modeling(ssd)/folium_test.ipynb)

    ![image-20220413135639250](https://github.com/zerosysk/Project/blob/master/image/FOLIUM_TEST.png)

## Unity기반 AR 강의안 제작
  
  - AR초급과정 강의안 : 코딩없이 클릭만으로 AR을 제작할 수 있는 교육에 활용
    
    - 강의안PDF :  [Unity_AR초급강의안.pdf](https://github.com/zerosysk/Project/blob/master/Unity/Unity_AR초급강의안.pdf)


##  멀티캠퍼스(기관교육)

### - netflix_viewpoint

- netflix_viewpoint 디렉토리에서 code : [Netflix_project김영성_완성.ipynb](https://github.com/zerosysk/Project/blob/master/netflix_viewpoint/Netflix_project김영성_완성.ipynb)

  ppt : [6조_그알_넷플릭스분석_최종.pdf](https://github.com/zerosysk/Project/blob/master/netflix_viewpoint/6조_그알_넷플릭스분석_최종.pdf)

![image-20220413132956442](https://github.com/zerosysk/Project/blob/master/image/멀티캠퍼스_우수상.png)

- 데이터 수집,정제 및 전처리

- 넷플릭스 재무제표 가공

- 넷플릭스 출시 일자를 통해 변수간 관계 EDA / 년,월,일로 분할해 

  viewPoint간의 상관관계분석



### - telco_churn

- (telco_churn 디렉토리에서 [코드 : [4조_telco최종.ipynb](https://github.com/zerosysk/Project/blob/master/telco_churn/4조_telco최종.ipynb),  

  PPT : [4조 통신사이탈분석 프로젝트.pptx](https://github.com/zerosysk/Project/blob/master/telco_churn/4조_통신사이탈분석.pptx)

- 데이터 전처리 및 EDA
- 머신러닝 모델링
- 팀 코드 통합 및 수정
- 전 모델 최적의 하이퍼 파라미터 튜닝을 통한 모델개선

