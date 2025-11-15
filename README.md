# Rapport du projet AR : Système Solaire Interactif

## Présentation

Ce projet consiste en un **système solaire interactif en réalité augmentée** utilisant **Vuforia** et **Unity**. Chaque planète est associée à une **image cible** (Image Target) que l'utilisateur peut scanner avec son appareil mobile ou webcam. Lorsqu'une planète est détectée, elle apparaît en 3D et certaines interactions sont disponibles pour rendre l'expérience plus immersive.

---

## Interactions implémentées

### 1. Affichage des informations
- **Touche `I`** : permet d'afficher ou de cacher le **panneau d'information** relatif à la planète scannée.  
- Le panneau contient des **faits essentiels** sur la planète (ex : Mars : plus grand volcan Olympus Mons, température moyenne -60°C ; Terre : 71% de la surface recouverte par l'eau, température moyenne 15°C, etc.).  

### 2. Contrôle de la rotation de la planète
- **Touche `S`** : augmente la **vitesse de rotation** de la planète sur elle-même.  
- **Touche `B`** : diminue la **vitesse de rotation**.  
- **Touche `O`** : **arrête complètement la rotation**.  

Ces interactions permettent à l'utilisateur de contrôler le comportement visuel de la planète en temps réel, rendant l'expérience plus interactive.

---

## Configuration technique

- **Unity** (version 2022.3 LTS ou supérieure)  
- **Vuforia Engine** activé avec clé de licence Vuforia  
- **Image Targets** pour chaque planète (Mars, Terre)  
- **Modèles 3D** attachés en tant qu'enfants des Image Targets  
- **UI Canvas en World Space** pour les panneaux d'information  

---

## Fonctionnement

1. L'utilisateur ouvre l'application sur son appareil.  
2. Il scanne l'image cible correspondant à la planète désirée.  
3. La planète apparaît en 3D et commence à tourner automatiquement.  
4. L'utilisateur peut interagir avec la planète via les touches :  
   - `I` → Affiche / cache les informations  
   - `S` → Augmente la vitesse de rotation  
   - `B` → Diminue la vitesse de rotation  
   - `O` → Arrête la rotation  

---

## Objectifs atteints

- Détection des **Image Targets** avec Vuforia  
- Affichage d'une **planète 3D interactive**  
- Rotation contrôlable via le clavier  
- Panneau d'informations interactif  
- Interface simple et intuitive  

---

## Perspectives d'amélioration

Pour aller plus loin, le projet pourrait être enrichi avec :

- Animations supplémentaires (pulsation, glow, apparition progressive)  
- Cycle de plusieurs panneaux d'information  
- Intégration de toutes les planètes restantes  
- Interaction mobile tactile (drag, pinch, etc.)  
- Effets visuels (particules, halo lumineux)  

---

## Conclusion

Ce projet illustre une **expérience AR simple et interactive**, montrant comment utiliser **Vuforia** pour détecter des images et faire apparaître des modèles 3D interactifs. Les contrôles clavier permettent une première approche de l'interactivité sans ajout d’objets supplémentaires.  

