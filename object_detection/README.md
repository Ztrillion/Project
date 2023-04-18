# object_ detection

## 4월 3일 1차 이관 데이터 Preprocessing

| EPOCH | ORIGINAL (mAP) | PREPROCESSING (mAP) |
| :---: | :------------: | :-----------------: |
| BEST  |     0.299      |        0.675        |

### ORIGINAL DATA

- Class num -> 117EA

- Class count min -> 1

- Class count max -> 13,000

    ![original_class](https://github.com/Ztrillion/object_detection/blob/master/plots/original_class.png)

- Boxplot

  ![original_boxplot](https://github.com/Ztrillion/object_detection/blob/master/plots/original_boxplot.png)



## preprocessing data

- Class count min -> 1
- Class count max -> 3500

![prep_class](https://github.com/Ztrillion/object_detection/blob/master/plots/prep_class.png)

- Boxplot

![prep_boxplot](https://github.com/Ztrillion/object_detection/blob/master/plots/prep_boxplot.png)

---

- 데이터 맥스값을 조절하고 분포를 조금만 맞췄는데도 불구하고 성능지표 37프로 이상 상승
- CLASS가 117개 이지만 original data 자체가 클래스 편향이 심하고 밀도가 낮아 모델 성능의 한계가 있음. 
- **<u>수집과 가공단에 class count 3,000개 미만인 class부터 모두 1,000개씩 수집 및 가공 요청</u>**
- 4월말 데이터 분포 확인 후 mAP지표 확인
