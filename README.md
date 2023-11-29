# CloneGather

## 제작 : 송하겸
> Unity를 이용해 Gather의 클론코딩을 진행한 프로젝트입니다.


## 주요 기능
 - 캐릭터 생성
 - 캐릭터 이동
 - 방 생성
 - 카메라 이동
 - 캐릭터 애니메이션

## 상세 설명
 - 캐릭터 생성
   - Player 오브젝트 하위에 Sprite를 받을 오브젝트를 만들어 이미지 추가
     
 - 캐릭터 이동
   - Unity InputSystem을 이용해 방향키 및 W,A,S,D 를 입력받아 움직이도록 작업
   - 마우스의 좌표를 InputSystem으로 받아서 현재위치와 각도계산을 통해
   
     캐릭터가 마우스를 바라보게 설정
 
 - 방 생성
   - 각 방마다 빈 오브젝트를 생성하고 Collider를 추가해 충돌감지가 가능하게 작업
   - 각 방마다 VirtualCamera를 설치해 방에 들어오면 카메라가 전환되도록 작업
     
 - 카메라 이동
   - Player가 방을 이동하면 각 방의 Collider가 tag => Plyaer를 감지
  
     카메라가 각 방의 카메라에 맞게 전환
   - VirtualCamera가 Player를 따라가도록 follow에 Player쥐어줌
   
 - 캐릭터 애니메이션
   - 캐릭터에 기본애니메이션과 움직이는 애니메이션 추가 (Idle, Move)
   - 애니메이션 작업에서 BlandTree를 생성해 float값 Speed에 따라 Idle, Move 전환되게 작업
