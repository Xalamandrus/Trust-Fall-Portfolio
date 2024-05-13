# Trust-Fall

Projekt "Trust Fall" to ciągle rozwijana gra, nad którą pracujemy w 4-osobowym zespole składającym się z 3 grafików, 2 designerów i 1 programisty. Głównym założeniem projektu jest stworzenie dynamicznej rozgrywki, w której gracz spada i pokonuje różne biomy z unikalnymi przeszkodami i mechanikami. Celem gry jest omijanie przeszkód i dotarcie jak najgłębiej do jaskini.

# Moja-Rola-W-Zespole

Moja główna rola w zespole obejmuje zarządzanie całym projektem gry, programowanie wszystkich mechanik, wymyślanie całego konceptu gry oraz dodatkowo tworzenie grafik interfejsu.

# W-Porftolio-Umieszczam

- Skrypty odpowiedzialne za tworzenie pól szablonów mapy oraz ich aktywowanie pod sobą.
  - [PoolingMapManager.cs](Scripts/ObjectPooling/PoolingMapManager.cs)
  - [PoolingScriptableObject.cs](Scripts/ObjectPooling/PoolingScriptableObject.cs)
 
- Skrypt odpowiedzialny za przesówanie obiektów w górę.
  - [VectorMoveY.cs](Scripts/VectorMoveY.cs)
 
- Skrypty odpowiedzialne za zarządzanie ruchem gracza oraz jego statystykami.
  - [PlayerManager.cs](Scripts/Player/PlayerManager.cs)
  - [PlayerMovement.cs](Scripts/Player/PlayerMovement.cs)
  - [PlayerHealth.cs](Scripts/Player/PlayerHealth.cs)
  - [StatisticComponent.cs](Scripts/Player/StatisticComponent.cs)

- Skrypty odpowiedzialne za eventy.
  - [Stalactite.cs](Scripts/Events/Stalactite/Stalactite.cs)
  - [StalactiteEvent.cs](Scripts/Events/Stalactite/StalactiteEvent.cs)
  - [StalactiteEventTrigger.cs](Scripts/Events/Stalactite/StalactiteEventTrigger.cs)
  - [DepthSystem.cs](Scripts/Events/DepthSystem.cs)

- Skrypty GameManagera.
    - [GameManager.cs](Scripts/Manager/GameManager.cs)
    - [MonoSingleton.cs](Scripts/Manager/MonoSingleton.cs)
