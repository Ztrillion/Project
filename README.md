# Project_README

2021 ~ 프로젝트 진행

- 2022.08 ~ 
## Pytorch를 활용한 3D Sementic Segmentation

- 업무영억  
  - 학습모델의 원리를 통해 정제 및 라벨링 기준 수립
  
  - 데이터 전처리 
  - max_point 추출 [https://github.com/Ztrillion/advancement/tree/master/preprocessing](https://github.com/Ztrillion/advancement/blob/master/preprocessing/01.calculate_max_point.py)
  - preprocessing [https://github.com/Ztrillion/advancement/blob/master/preprocessing/02.preprocessing.py](https://github.com/Ztrillion/advancement/blob/master/preprocessing/02.preprocessing.py)
    
    
    - pcd 파일과 json파일 매핑에러 해결
    - jsno파일 구문 정정을 통해 구문정확성 100%달성
  
  - GUI 프로그래밍 - https://github.com/Ztrillion/advancement/blob/master/9Boon%20Tool%20User%20Guide/9BooN%20User%20Guide_.pdf
    - 네이밍 변경 및 리턴 기능, 확장자별 네이밍 자동 체크 -> 정제
    - JSON 구문정확성 점검 및 오류 수정 기능 -> 전처리
    - 기능별 로그파일 생성 및 기록을 통해 유저 행동 추적
  
  - 유효성 검증 모델
    - 사용자 환경구축 편의제공 -> requirements.txt 제작 
      - [requirements.txt](https://github.com/Ztrillion/advancement/blob/master/requirements.txt)
    - 모델 환경 구축 및 CUSTOM MODEL학습 및 테스트
    - 검증 지표 mIoU 92%로 목표수치 과달성

## 2022년 3월 ADSP 합격
  - ![image-20220413165439250](https://github.com/zerosysk/Project/blob/master/image/ADsP.png)

    
## Tensorflow를 활용한 2D IMAGE ObjectDetection_Modeling(ssd)

- 국책과제 수행(인공지능 학습데이터 구축사업_ 융합센서 도로데이터)

    - 데이터 정제 및 라벨링 기준 수립

    - 데이터 전처리 : json파일 핸들링

    - object detection 모델 학습 및 학습모델의 활용한 Detect 시각화

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
  
  - AR초급과정 _ 지형인식을 통한 객체생성 : 코딩없이 클릭만으로 AR을 제작할 수 있는 교육에 활용
    
    - 강의안PDF :  [Unity_AR초급강의안.pdf](https://github.com/zerosysk/Project/blob/master/Unity/Unity_AR초급강의안.pdf)
 
  - AR중급과정 _ 이미지인식을 통한 캐릭터 커스터마이징
    
    - 강의안PDF :  [Unity_AR중급강의안.pdf](https://github.com/zerosysk/Project/blob/master/Unity/Unity_AR중급강의안.pdf)

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

