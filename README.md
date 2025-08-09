# Overlord-Knight---Unity-2D

## Overview

Survive waves of enemies and defeat powerful bosses in this action-packed 2D survival game developed with Unity. Face relentless hordes, collect bonuses to empower your character, and confront unique bosses at the end of each stage.

## Features

- Multiple waves of enemies with escalating difficulty.
- Boss fights with distinct attack patterns.
- Player and boss health bars designed for optimal UI clarity.
- NPC enemies powered by Unity's NavMesh for intelligent pathfinding.
- Variety of power-ups that upgrade speed, damage, and health.
- Immersive sound effects and responsive animations.
- Strategic gameplay that rewards adaptation and skill.

## Gameplay Details

- **Survival Rounds:** Progress through successive waves of enemies, each more challenging than the last.
- **Boss Battles:** Every stage ends with an epic boss encounter, each with unique mechanics.
- **Bonuses:** Power-ups drop throughout waves to improve movement speed, attack power, and overall survivability.
- **Controls & Mechanics:** Smooth 2D controls. Both melee and ranged combat; enemy AI adapts by type for a dynamic challenge.

## Visual Highlights

*The images below illustrate key aspects of gameplay and mechanics. Place your exported Unity screenshots in the `images/` folder and reference them as shown.*

### Ambient & Lighting Example

![Example of Environment and Lighting](images/ambient_lighting_example.png)  
*Example scene showing the game's atmospheric environment and lighting.*

### Enemy Movement via NavMesh

![Enemy Movement](images/enemy_navmesh.png)  
*Enemies use Unity’s NavMesh system for smart and dynamic pursuit of the player.*

### Health Bars

![Player Health Bar](images/health_bars_1.png)  
![Boss Health Bar](images/health_bars_2.png)  

*Distinct visual designs for player and boss health bars to enhance the user experience.*

### Combat and Attack Mechanics

#### Boss

Boss attack sequence:

![Boss Attack](images/bossAttack.png)

Boss Animator graph:

![Boss Animator Graph](images/combat_boss_mechanics.png)

#### Player

Melee attack:

![Player Melee Attack 1](images/MeleeAttack_1.png)  
![Player Melee Attack 2](images/MeleeAttack_2.png)

Ranged attack:

![Player Ranged Attack 1](images/Range1.png)  
![Player Ranged Attack 2](images/Range2.png)

Player Animator:

![Player Animator](images/combat_player_mechanics.png)

*These animations and mechanics showcase the range of both melee and ranged combat, adding depth to the gameplay.*

### Power-Ups System

Power-ups collected during gameplay:

![Power-Ups](images/powerUp.png)  
*Collectible bonuses enhance key player attributes, aiding survival and progression.*

Spawn chance of power-ups throughout waves:

![Power-Up Spawn Chance](images/powerUp2.png)  
*Visualizing the drop mechanics and probabilities for power-ups during waves.*

### Waves

Examples of enemy waves with progressive difficulty:

![Wave Example 1](images/waveExample1.png)  
![Wave Example 2](images/waveExample2.png)  
![Wave Example 3](images/waveExample3.png)

*Waves are designed to escalate in difficulty, preparing players for the next boss confrontation.*

---

## Controls

- Move: WASD or Arrow keys  
- Attack (Melee): Spacebar  
- Attack (Ranged): Left Mouse Button

## Future Improvements

- Add more enemy and boss types with diverse behaviors.  
- Implement multiplayer mode for cooperative survival.  
- Enhance UI with dynamic feedback and leaderboards.  
- Add background music and improve sound effects for greater immersion.

---

## Author

David Furtado

---

## License

This project is licensed under the MIT License.
